/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/12/2015
 * Time: 1:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using abdulaziz.Database;
using Expire.Model;
namespace Expire.Control
{
    /// <summary>
    /// Description of EpisodeC.
    /// </summary>
    public class EpisodeC : Sqlite, ISqlite
    {

        private const string ID = "id";
        private const string STORE_ID = "store_id";
        private const string ITEM_ID = "item_id";
        private const string USER_ID = "user_id";

        private const string BATCH = "batch";
        private const string AMOUNT = "amount";
        private const string AMOUNT_TYPE = "amount_type";
        private const string EXPIRE = "expire";
        private const string DATE_CREATE = "date_create";
        private const string NOTE = "note";
        private const string TABLE_NAME = "episode";

        public bool Default { get; set; }

        public EpisodeC()
        {
            if (!IsConnection(Database.con))
            {   

                //	System.Windows.Forms.MessageBox.Show("Error When Connect To Database");
            }
        }
        public override void OnCreate()
        {
            			var create = new string[]{
            				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
            				"["+STORE_ID+"] INTEGER  NOT NULL",
            				"["+ITEM_ID+"] INTEGER  NOT NULL",
            				"["+USER_ID+"] INTEGER   NULL",
            			
            				"["+BATCH+"] int(55)   NULL",
            				"["+AMOUNT+"] INTEGER  NOT NULL",
            			"["+AMOUNT_TYPE+"] VARCHAR(55)  NOT NULL",
            				"["+EXPIRE+"] varchar(55)  NOT NULL",
            				"["+DATE_CREATE+"] IMESTAMP DEFAULT CURRENT_TIMESTAMP",
            			"["+NOTE+"] TEXT "};




            if (!IsExecute(CreateTable(TABLE_NAME, create)))

            {
                System.Windows.Forms.MessageBox.Show("Error When Create Table " + TABLE_NAME);
            }

        }

        #region ISqlite implementation

        public void Insert(object obj)
        {
            Episode eps = (Episode)obj;

            if (!IsExecute(Insert(
                TABLE_NAME,
                new string[] { STORE_ID, ITEM_ID, BATCH, AMOUNT, AMOUNT_TYPE, EXPIRE, NOTE },
                new string[] { eps.Stoke_id.ToString(), eps.Item_id.ToString(), eps.Batch, eps.Amount.ToString(), eps.AmountType, eps.Expdate, eps.Notes })))
            {
                System.Windows.Forms.MessageBox.Show("Error When Insert Table  " + TABLE_NAME);
            }
        }

        public void Update(object obj)
        {
            Episode eps = (Episode)obj;
            if (!IsExecute(Update(TABLE_NAME, new string[] { STORE_ID + "=" + eps.Stoke_id, ITEM_ID + "=" + eps.Item_id, AMOUNT_TYPE + "='" + eps.AmountType + "'", AMOUNT + "=" + eps.Amount, EXPIRE + "='" + eps.Expdate + "'", BATCH + "='" + eps.Batch + "'", NOTE + "='" + eps.Notes + "'" }, " id='" + eps.Id + "'")))
            {
                System.Windows.Forms.MessageBox.Show("Error When Update Table " + TABLE_NAME);
            }
        }

        public void Delete(object obj)
        {
            Episode eps = (Episode)obj;
            if (!IsExecute(Delete(TABLE_NAME,
                                             new string[] { "id='" + eps.Id + "'" })))
            {
                System.Windows.Forms.MessageBox.Show("Error When Delete From Table " + TABLE_NAME);
            }
        }

        public List<Episode> GetEpisode()
        {
            List<Episode> episodes = new List<Episode>();
            DataTable dt= new DataTable();

            if (Default)
            {
                dt = base.GetDataTable("select * from " + TABLE_NAME + " order by " + EXPIRE);
            }
           
            foreach (DataRow row in dt.Rows)
            {
                episodes.Add(new Episode()
                {
                    Id = int.Parse(row[ID].ToString()),
                    Stoke_id = int.Parse(row[STORE_ID].ToString()),
                    Item_id = int.Parse(row[ITEM_ID].ToString()),

                    Amount = int.Parse(row[AMOUNT].ToString()),
                    AmountType = row[AMOUNT_TYPE].ToString(),
                    Batch = row[BATCH].ToString(),
                    Expdate = row[EXPIRE].ToString(),
                    Notes = row[NOTE].ToString()

                });

            }
            return episodes;

        }





        private string SortByDefault(string query)
        {
            try
            {
                if (query.Equals(""))
                {
                   
                    return string.Format("select * from {0}  order by {1}", TABLE_NAME, EXPIRE);
                }
                else
                {
                    return string.Format("select * from {0} where {1} order by {2}", TABLE_NAME, query, EXPIRE);

                }
            }
            catch (Exception e)
            {
                return string.Format("select * from {0}  order by {1}", TABLE_NAME, EXPIRE);


            }
       
        }


        private String SortByName(string query) {
    //TODO join item table to get item name and sort by name 
            return "SELECT * FROM  episode inner join item on  item.id = episode.item_id where "+query+" order by item.name ";
        }

        private String SortByExpired(string query)
        {
            //TODO join item table to get item name and sort by name 
            string datenow = new LimitC().DatePastMonth();
            return "select * from episode  where "+query+" and  "+EXPIRE+" <= '"+datenow+"' order by "+EXPIRE;
           
        }


        private string SortThreeMonths(string qeury) {
            LimitC lim = new LimitC();
            return string.Format("select * from episode where {0} and expire >= '{1}' and expire <= '{2}' order by {3}", qeury, lim.DateNow(),lim.Date3Month(),EXPIRE);
        }


        private string SortNextThreeMonths() { return ""; }

     
        public List<Episode> GetEpisodeWithLimitStore(string query,string sort)
        {
            string returnQuery = "";
            switch (sort)
            {
               
                case "Name":
                    returnQuery = SortByName(query);
                    break;
                case "Exp":
                    returnQuery = SortByExpired(query);
                    break;
                case "NearExp":
                    returnQuery = SortThreeMonths(query);
                    break;


                default:
                    returnQuery = SortByDefault(query);
                    break;
            }
            List<Episode> episodes = new List<Episode>();
            
            DataTable dt = base.GetDataTable(returnQuery);
            foreach (DataRow row in dt.Rows)
            {
                episodes.Add(new Episode()
                {
                    Id = int.Parse(row[ID].ToString()),
                    Stoke_id = int.Parse(row[STORE_ID].ToString()),
                    Item_id = int.Parse(row[ITEM_ID].ToString()),

                    Amount = int.Parse(row[AMOUNT].ToString()),
                    AmountType = row[AMOUNT_TYPE].ToString(),
                    Batch = row[BATCH].ToString(),
                    Expdate = row[EXPIRE].ToString(),
                    Notes = row[NOTE].ToString()

                });

            }
            return episodes;

        }
        public Episode GetOneEpisode(Episode eps)
        {

            DataTable dt = GetDataTable("select * from " + TABLE_NAME + " where id='" + eps.Id + "'");
            foreach (DataRow row in dt.Rows)
            {
                eps = new Episode()
                {
                    Id = int.Parse(row[ID].ToString()),
                    Stoke_id = int.Parse(row[STORE_ID].ToString()),
                    Item_id = int.Parse(row[ITEM_ID].ToString()),

                    Amount = int.Parse(row[AMOUNT].ToString()),
                    AmountType = row[AMOUNT_TYPE].ToString(),
                    Batch = row[BATCH].ToString(),

                    Expdate = row[EXPIRE].ToString(),
                    Notes = row[NOTE].ToString()
                };

            }
            return eps;
        }
        #endregion
    }
}

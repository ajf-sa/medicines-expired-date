using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abdulaziz.Database;
using abdulaziz.Model;
using Expire.Model;
using abdulaziz.Date;
using System.Diagnostics;
using System.Data;

namespace Expire.Control
{
   public  class LimitC : Sqlite, InSqlite
    {
        private const string ID = "id";
        private const string DATE_START = "d_start";
        private const string CURRENT_DATE = "c_date";
        private const string DATE_END = "d_end";

        private const string TABLE_NAME = "limited";

       
        Date date = new Date();


        public int Count { get { return GetRecord().Count; } }

        public LimitC() {

            if(!IsConnection(Database.con)){
                Debug.WriteLine("Error When Connected To Db Limit Class");
            }
        }
        
        public override void OnCreate()
        {
            var create = new string[] {

             "["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
            "["+DATE_START+"] VARCHAR(45) NOT NULL",
            "["+CURRENT_DATE+"] VARCHAR(45) NOT NULL",
            "["+DATE_END+"] VARCHAR(45) NOT NULL"
            };

            if (!IsExecute(CreateTable(TABLE_NAME,create)))
            {
                Debug.WriteLine("Error When Create Table "+TABLE_NAME);

            }
        }
        public string SetDate(string dat) {

            MyDate mydate = date.Gr.SetDate(dat);

            return string.Format("{0}-{1}-{2}", mydate.Year, mydate.Month, mydate.Day);

        }
        public string SetDateWithoutDay(string dat)
        {

            MyDate mydate = date.Gr.SetDate(dat);
            if (mydate.Month < 10) {
                return string.Format("{0}-0{1}", mydate.Year, mydate.Month);
            } else {
                return string.Format("{0}-{1}", mydate.Year, mydate.Month);
            }
            
           
        }

        public string DateNow() {

            MyDate mydate = date.Gr.Now;

            if (mydate.Month < 10)
            {
                return string.Format("{0}-0{1}-{2}", mydate.Year, mydate.Month, mydate.Day);
            }
            else
            {
                return string.Format("{0}-{1}-{2}", mydate.Year, mydate.Month,mydate.Day);
            }
        }
        public string DatePastMonth()
        {

            MyDate mydate = date.Gr.Now;
            if (mydate.Month <= 1)
            {
                mydate.Month = 12;
                mydate.Year--;
            }
            return string.Format("{0}-{1}-{2}", mydate.Year, mydate.Month, mydate.Day);
        }
        public string Date3Month()
        {

            MyDate mydate = date.Gr.Now;
            if (mydate.Month >= 10)
            {
                mydate.Month = mydate.Month - 9;
                mydate.Year++;
                return string.Format("{0}-0{1}-{2}", mydate.Year, mydate.Month, mydate.Day);
            }
            else
            {

                return string.Format("{0}-0{1}-{2}", mydate.Year, mydate.Month, mydate.Day);
            }
        }
        public string DateKiller()
        {

            MyDate mydate = date.Gr.Now;
            return string.Format("{0}-{1}-{2}", 1, 1, 1900);
        }
        public string DatePeroidTime() {
            MyDate mydate = date.Gr.Now;
            if (mydate.Month >= 12)
            {
                mydate.Month = 1;
                mydate.Year++;
                return string.Format("{0}-{1}-{2}", mydate.Year, mydate.Month, mydate.Day);
            }
            else {
                return string.Format("{0}-{1}-{2}", mydate.Year, mydate.Month+1, mydate.Day);
            }
            
        }


        public long GetTotalDay(object obj) {
            Limit li = (Limit)obj;

            return date.GetNumberOfDayBTODate(li.Date_End, li.Current_Date);
        }
        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetOneRecord()
        {
            Limit li = null;
            var dt = GetDataTable("select * from " + TABLE_NAME);
            foreach (DataRow row in dt.Rows)
            {
               li= new Limit()
                {
                    Id = int.Parse(row[ID].ToString()),
                    Date_Start = row[DATE_START].ToString(),
                    Current_Date = row[CURRENT_DATE].ToString(),
                    Date_End = row[DATE_END].ToString()
                };
            }
            return (object)li;
        }

        public object GetOneRecord(object obj)
        {
            throw new NotImplementedException();
        }
        
        public List<object> GetRecord()
        {
            List<object> lobj = new List<object>();
            var dt = GetDataTable("select * from "+TABLE_NAME);
            foreach (DataRow row in dt.Rows)
            {
                lobj.Add((object)new Limit() {
                    Id=int.Parse(row[ID].ToString()),
                    Date_Start= row[DATE_START].ToString(),
                    Current_Date= row[CURRENT_DATE].ToString(),
                    Date_End= row[DATE_END].ToString()
                });
            }

            return lobj;
            
        }

        public List<object> GetRecord(object obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(object obj)
        {
            Limit lim = (Limit)obj;
            if (!IsExecute(Insert(
                TABLE_NAME,new string[] {DATE_START,CURRENT_DATE,DATE_END },
                new string[] { lim.Date_Start,lim.Current_Date,lim.Date_End })))
            {
                Debug.WriteLine("Error When Insert Data To "+TABLE_NAME);
            }
        }


        public void Update(object obj)
        {
          Limit lim = (Limit)obj;
            lim.Id = 1;

            if (!IsExecute(Update(TABLE_NAME,new string[] {CURRENT_DATE+"='"+lim.Current_Date+"'" },ID+"='"+lim.Id+"'")))
            {
                Debug.WriteLine("Error When Update Data On " + TABLE_NAME);
            }

        }

        public void KillApp(object obj)
        {
            Limit lim = (Limit)obj;
            lim.Id = 1;

            if (!IsExecute(Update(TABLE_NAME, new string[] { DATE_END + "='" + lim.Date_End + "'" }, ID + "='" + lim.Id + "'")))
            {
                Debug.WriteLine("Error When Update Data On " + TABLE_NAME);
            }

        }
    }
}

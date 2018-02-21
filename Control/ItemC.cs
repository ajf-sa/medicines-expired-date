/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/6/2015
 * Time: 8:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
using System.Data;
using Expire.Model;
using abdulaziz.Database;


namespace Expire.Control
{
	/// <summary>
	/// Description of ItemC.
	/// </summary>
	public class ItemC: Sqlite, ISqlite
    {
		private const string ID="id";
        private const string CODE = "code";
        private const string NAME="name";
		private const string SIZE="size";
		private const string TYPE="type";
		private const string TABLE_NAME="item";
	
		public ItemC()
		{
			if(!IsConnection(Database.con)){
			
			//	System.Windows.Forms.MessageBox.Show("Error When Connect To Database");
			}
		}
		
		
		public override void OnCreate()
		{
			var create = new string[]{		                                                   
				"[id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
                "[code] VARCHAR(50)  NOT NULL",
                "[name] VARCHAR(50)  NOT NULL",
				"[size] VARCHAR(50) NOT NULL",
				"[type] VARCHAR(50) NOT NULL"};
			

			
			if(!base.IsExecute(CreateTable(TABLE_NAME,create))){
				System.Windows.Forms.MessageBox.Show("Error When Create Table 'item'");
			}
		}
		public void Insert(Item item){
		
			if(!base.IsExecute(Insert(TABLE_NAME,new string[]{NAME,CODE,SIZE,TYPE},new string[]{item.Name,item.Code,item.Size.ToString(),item.Type}))){
					System.Windows.Forms.MessageBox.Show("Error When Insert Data Into 'item' Table");
			}
		
		}
		public void Update(Item item){
			if(!base.IsExecute(Update(TABLE_NAME,new string[]{NAME+"='"+item.Name + "'", CODE + "='" + item.Code + "'", SIZE + "='" + item.Size.ToString() + "'", TYPE + "='" + item.Type + "'" },"id='"+item.Id+"'"))){
					System.Windows.Forms.MessageBox.Show("Error When Update Data To 'item' Table");
			}
		}
		public void Delete(Item item){
		
			if(!base.IsExecute(Delete(TABLE_NAME,new string[]{"id='"+item.Id+"'"}))){
					System.Windows.Forms.MessageBox.Show("Error When Delete Data From 'item' Table");
			}
		}

		#region IMysql implementation


		public void Insert(object obj)
		{
			throw new NotImplementedException();
		}


		public void Update(object obj)
		{
			throw new NotImplementedException();
		}


		public void Delete(object obj)
		{
			throw new NotImplementedException();
		}


		#endregion

		public Item GetOneItem(string id){
			Item ite= new Item();
			DataTable dt = base.GetDataTable(string.Format("select * from {0} where id='{1}'",TABLE_NAME,id));
			foreach(DataRow it in dt.Rows){
			
				ite.Id=int.Parse(it["id"].ToString());
                ite.Code = it[CODE].ToString();
                ite.Name=it["name"].ToString();
				ite.Size=it["size"].ToString();
				ite.Type=it["type"].ToString();
				
				
			}
			return ite;
			
		}

		public int GetItemId(string str)
		{
			string[] st = str.Split(',');
			int id=0;

		var dt = GetDataTable("select id from "+TABLE_NAME+" where name='"+st[0]+"' and size='"+st[1]+"' and type='"+st[2]+"'");
	
		foreach(DataRow row in dt.Rows){
				
			id=int.Parse(row["id"].ToString());
				
			}
		return id;
		}

		public List<Item> GetItem(){
			// disable once SuggestUseVarKeywordEvident
			var items = new List<Item>();
			DataTable dt = base.GetDataTable(string.Format("select * from {0} order by {1} ", TABLE_NAME,NAME));
			foreach (DataRow it in dt.Rows) {
				Item item = new Item();
				item.Id=int.Parse(it["id"].ToString());
                item.Code = it[CODE].ToString();
                item.Name=it["name"].ToString();
				item.Size=it["size"].ToString();
				item.Type=it["type"].ToString();
				items.Add(item);
			}
			return items;
		}
	}
}

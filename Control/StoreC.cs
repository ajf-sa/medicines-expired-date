/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/11/2015
 * Time: 10:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

using Expire.Model;
using abdulaziz.Database;

namespace Expire.Control
{
	/// <summary>
	/// Description of StoreC.
	/// </summary>
	public class StoreC: Sqlite, ISqlite
    {
		private const string ID="id";
		private const string NAME="name";
		private const string NOTE="note";
		private const string TYPE="type";
		private const string LOCATION="location";
		private const string TABLE_NAME="store";
	
		public StoreC()
		{
				if(!IsConnection(Database.con)){
			
			//	System.Windows.Forms.MessageBox.Show("Error When Connect To Database");
			}
		}
		public override void OnCreate()
		{
			var create = new string[]{		                                                   
				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
				"["+NAME+"] VARCHAR(50)  NOT NULL",
				"["+TYPE+"] VARCHAR(50)  NOT NULL",
				"["+NOTE+"] TEXT ",
				"["+LOCATION+"] VARCHAR(50) "};
			

			
			if(!IsExecute(CreateTable(TABLE_NAME,create))){
			System.Windows.Forms.MessageBox.Show("Error When Create  "+TABLE_NAME+" Table");
	
			}
			
		}

		
		public void Insert(object obj)
		{
			var store = (Store)obj;
			if(!IsExecute(Insert(TABLE_NAME,new string[]{NAME,TYPE,NOTE},new string[]{store.Name,store.Type,store.Note}))){
				System.Windows.Forms.MessageBox.Show("Error When Add Store Into 'store' Table");
			}
			
		}
		public void Delete(object obj)
		{
			var store = (Store)obj;
			
			if(!IsExecute(Delete(TABLE_NAME,new string[]{"id="+store.Id}))){
				System.Windows.Forms.MessageBox.Show("Error When Delete Store From 'store' Table");
			}
		}		
		#region ISqlite implementation
		public void Update(object obj)
		{
			var store = (Store)obj;
			
			if(!IsExecute(Update(TABLE_NAME,new string[]{NAME+"='"+store.Name+"'",TYPE+"='"+store.Type+"'",NOTE+"='"+store.Note+"'"},"id="+store.Id))){
				System.Windows.Forms.MessageBox.Show("Error When Update Store in 'store' Table");
			}
		
			
		}
		
		public int Count(){
		
			var dt = GetDataTable("select * from "+TABLE_NAME);
			
			return dt.Rows.Count;
		}
		
		public List<Store> GetStore(){
			List<Store> stores= new List<Store>();
			var dt = GetDataTable("select * from "+TABLE_NAME);
			
			foreach(DataRow row in dt.Rows){
				Store store = new Store();
				store.Id=int.Parse(row[ID].ToString());
				store.Name= row[NAME].ToString();
				store.Note=row[NOTE].ToString();
				store.Location=row[LOCATION].ToString();
				stores.Add(store);
			}
			return stores;
		}
		public Store GetOneStore(Store store){
			//Store localstore = new Store();
			var dt = GetDataTable("select * from "+TABLE_NAME+" where id="+store.Id);
			
			foreach(DataRow row in dt.Rows){
				
				store.Id=int.Parse(row[ID].ToString());
				store.Name= row[NAME].ToString();
				store.Type= row[TYPE].ToString();
				store.Note=row[NOTE].ToString();
				store.Location=row[LOCATION].ToString();
				
			}
			return store;
		}
		#endregion

		public int GetStoreId(String str)
		{
					//Store localstore = new Store();
			var dt = GetDataTable("select id from "+TABLE_NAME+" where name='"+str+"'");
            
			foreach(DataRow row in dt.Rows){
				
				str=row["id"].ToString();
				
			}
			return int.Parse(str);
		}
	}
}

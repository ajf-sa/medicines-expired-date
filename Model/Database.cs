/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 07/08/33
 * Time: 01:16 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using abdulaziz.Model;

namespace Expire.Model
{
	/// <summary>
	/// Description of Database.
	/// </summary>
	public class Database
	{
		List<string> datafrombase = new List<string>();
		Fallter f = new Fallter();
		string setQQQuery =null;
		
		
		
	
		string 					 name=string.Empty;
		
		 string			 db =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "db.dat");
		 public static Connection con = new Connection();
		 
	string query = "CREATE TABLE if not exists item (id INTEGER PRIMARY KEY AUTOINCREMENT,batch Text NOT NULL , item TEXT, type TEXT, expdate TEXT ,amount INTEGER DEFAULT 0 NOT NULL , note TEXT)";
	
//		string 					 sqlconnetion =String.Format("Data Source={0};Version=3;New=True;Compress=True",db);
//		
		
		
		
		
		
		public Database()
		{
			
			con.DbName="exp";
			con.Username="root";
			con.Password="";
			con.Url="localhost";
			
			
			
		}
		
//		
//		
//		public bool Open(){
//		
//			
//			try{
//				//connection.Open();
//				return true;
//			}
//			catch{
//			
//				return false;
//			}
//		}
//		
//		
//		
//		public string Location{get{return db;} set{db=value;}}
//		
//		
//		
//		
//		public void setQuery(string setQQuery)
//		{
//			this.setQQQuery =f.Add(setQQuery);
//		}
//		
//		public string getExp(){
//			
////		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
////		string years = System.DateTime.Now.ToString("yyyy",gro);
////		string months =DateTime.Now.ToString("MM",gro);
//		
////		if(Convert.ToInt32(months)<10){
////			months="0"+months;
////		}
////		string date = years+@"/"+months;
//			
//			CultureInfo gro = CultureInfo.GetCultureInfo("en-US");
//			string y = DateTime.Now.ToString("yyyy",gro);
//			string m = DateTime.Now.ToString("MM",gro);
//			string date = y+@"/"+m;
//		return date;
//		
//		}
//		
//		
//		
//		
//		public string getNearExp(int i,int x){
//			
//		
//			string date=null;
//		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
//		int years = Convert.ToInt32(System.DateTime.Now.ToString("yyyy",gro));
//		int months =Convert.ToInt32(DateTime.Now.ToString("MM",gro));
//		//int day =Convert.ToInt32(DateTime.Now.ToString("dd",gro));
//		
//		int checkMonth=months+i;
//		string strMonth=null;
//		string strYear=null;
//		if(checkMonth>12){
//			
//			
//		
//			strYear= (years+1).ToString();
//				strMonth=(months-x).ToString();
//		}
//		else{
//		
//		strYear= (years).ToString();
//		strMonth=(months+i).ToString();
//		}
//		
//		if(Convert.ToInt32(strMonth)<10){
//		
//		strMonth="0"+strMonth;
//		}
//		
//		 date = strYear+@"/"+strMonth;
//		 
//		return date;
//		
//		}
//		
//	
//		/// <summary>
//		/// get all information from database ASC by Expiry Date
//		/// </summary>
//		/// 
//		public void getAll(int textType,int orderBy=0){
//			
//			
//			string orderBBy="expdate";
//			if(orderBy!=0){
//			orderBBy="item";
//			}
//			string query=null;
//			if(textType ==0){
//				query= String.Format("select * from item order by {0}",orderBBy);
//			}
//			if(textType ==1){
//				query= String.Format("select * from item where batch like '%{0}%' order by {1} ",this.setQQQuery,orderBBy);
//			}
//			if(textType ==2){
//			 query= String.Format("select * from item where item like '%{0}%' order by {1} ",this.setQQQuery,orderBBy);
//			}
//			if(textType ==3){
//			
//			 query= String.Format("select * from item where type like '%{0}%' order by {1} ",this.setQQQuery,orderBBy);
//			}
//			if(textType ==4){
//				query= String.Format("select * from item where expdate <'{0}' order by {1} ",getExp(),orderBBy);
//			
//			}
//			if(textType ==5){
//				query= String.Format("select * from item where expdate >'{0}' and expdate < '{1}' order by {2} ",getExp(),getNearExp(1,11),orderBBy);
//				
//			}
//			
//			if(textType ==6){
//				
//				query= String.Format("select * from item where expdate >'{0}' and expdate < '{1}' order by {2} ",getNearExp(1,11),getNearExp(3,8),orderBBy);
//			}
//			if(textType ==7){
//				
//				query= String.Format("select * from item where expdate>'{0}'  order by {1} ",getNearExp(1,11),orderBBy);
//			}
//			
//			
//			
//			
//			try{
//			SQLiteCommand cmd = new SQLiteCommand(connection);
//			cmd.CommandText=query;
//			connection.Open();
//			sqlData = cmd.ExecuteReader();
//			datafrombase.Clear();
//		
//			 while (sqlData.Read())
//            {
//			 	datafrombase.Add(sqlData["id"].ToString()+";"+sqlData["batch"].ToString()+";"+sqlData["item"].ToString()+";"+sqlData["type"].ToString()+";"+sqlData["expdate"].ToString()+";"+sqlData["amount"].ToString()+";"+sqlData["note"].ToString());
//			 //	System.Windows.Forms.MessageBox.Show(sqlData["expdate"].ToString());
//            }
//			
//			 cmd.Dispose();
//		//	 connection.Close();
//			}catch(Exception e){ 
//				System.Windows.Forms.MessageBox.Show(e.Message +" bugs #1");
//				//connection.Close();
//			}
//			
//
//			
//		}
//		
//		
//		
//		
//		
//		
//		/// <summary>
//		/// get list string from getAll() 
//		/// </summary>
//		/// <returns> return  list <string></returns>
//		public List<string> retlist(){
//		return datafrombase;
//		
//		}
//		
//		
//		
//		
//		
//		
//		/// <summary>
//		/// connection to database 
//		/// </summary>
//		public void connected(){
//			
//		// connection = new SQLiteConnection(sqlconnetion);
//		
//		
//		}
//		
//		
//		public void Dispose(){
//		
//			connection.Dispose();
//        GC.SuppressFinalize(this);
//		}
//		
//		
//		
//		
//		
//		public void Ccon(){
//		
//			connected();
//		}
//
//		
//	
//		
//		/// <summary>
//		/// update list view 
//		/// </summary>
//		public void update(int id ,string batch ,string item,string type ,string expdate ,int amount ,string note=""){
//	
//				try{
//			// use sqlitecommand for Update method
//			SQLiteCommand c = new SQLiteCommand(connection);
//			c.CommandText=String.Format("UPDATE item SET batch='{0}',item='{1}',type='{2}', expdate ='{3}',amount={4},note='{5}' WHERE id={6}",
//			                          
//	                            f.Add(batch),
//	                            f.Add(item),
//	                            f.Add(type),
//	                            f.Add(expdate),
//	                            Convert.ToInt32(f.Add(amount.ToString())),
//	                            f.Add(note),
//								id) ;
//			
//		
//				connection.Open();
//				c.ExecuteNonQuery();
//				c.Dispose();
//				connection.Close();
//			}catch(Exception d){
//				System.Windows.Forms.MessageBox.Show(d.Message);
//			}
//		
//		}
//		
//		public void SetLocation(){
//		
//		Location =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "db.dat");
//	
//		}
//		
//		public bool IsDefault(){
//		
//			bool result=false;
//			if(Path.GetExtension(Location)==".dat"){
//			//	Drop();
//			result=true;
//			}
//		
//			return result;
//		}
//		public void Drop(){
//		
//		
//			
//				try{
//			// use sqlitecommand for Update method
//			SQLiteCommand c = new SQLiteCommand(connection);
//			c.CommandText=String.Format("DROP TABLE IF EXISTS {0} ",
//			                          
//	                            "item"
//	                          ) ;
//			
//		
//				connection.Open();
//				c.ExecuteNonQuery();
//				c.Dispose();
//				connection.Close();
//			}catch(Exception d){
//				System.Windows.Forms.MessageBox.Show(d.Message);
//			}
//		
//			createdb();
//		}
//		
//		
//		
//		
//		
//		/// <summary>
//		/// create database if not exists
//		/// </summary>
//		public void createdb(){
//		
//			
//				SQLiteCommand cmd = connection.CreateCommand();
//			cmd.CommandText=this.query;
//			try{
//			connection.Open();
//			// connection.ChangePassword("sa");
//			cmd.ExecuteNonQuery();
//			cmd.Dispose();
//			connection.Close();
//			}catch(Exception es){
//				
//				//throw new ApplicationException(es.Message);
//				System.Windows.Forms.MessageBox.Show(es.Message+"?");
//			}
//			
//			
//		}
//		
//		
//		
//		
//		
//		
//		/// <summary>
//		/// delete filed form database 
//		/// </summary>
//		/// <param name="id">int id</param>
//		public void delete(int id){
//		
//			SQLiteCommand md = connection.CreateCommand();
//			md.CommandText=String.Format("delete from item where id ={0}",id);
//			connection.Open();
//			md.ExecuteNonQuery();
//			md.Dispose();
//			connection.Close();
//		
//		}
//		
//		
//		
//		
//		
//		
//		/// <summary>
//		/// insert new data to database 
//		/// </summary>
//		/// <param name="batch"> batch Number of item</param>
//		/// <param name="item"> item Name</param>
//		/// <param name="type"> item Type</param>
//		/// <param name="expdate">Expiry date fo item</param>
//		/// <param name="amount">amount of item</param>
//		/// <param name="note">Note for item</param>
//		public void Add(string batch,string item,string type,string expdate,int amount ,string note=""){
//			
//			try{
//			SQLiteCommand cm = new SQLiteCommand(connection);
//			
//			cm.CommandText=String.Format("insert into item(batch,item,type,expdate,amount,note)values('{0}','{1}','{2}','{3}',{4},'{5}')",
//								 f.Add(batch),
//	                            f.Add(item),
//	                            f.Add(type),
//	                            f.Add(expdate),
//	                            Convert.ToInt32(f.Add(amount.ToString())),
//	                            f.Add(note));
//			
//				connection.Open();
//			
//			
//			
//			cm.ExecuteNonQuery();
//			cm.Dispose();
//			connection.Close();
//			}catch(Exception e){
//			
//				
//				System.Windows.Forms.MessageBox.Show(e.Message);
//				
//				}
//			
//		}
//		
//		public string getinfo(int id){
//		
//			string info=null;
//			
//			try{
//			SQLiteCommand cmd = connection.CreateCommand();
//			
//			cmd.CommandText=String.Format("select note from item where id={0}",id);
//			connection.Open();
//			sqlData = cmd.ExecuteReader();
//			
//		
//		
//			 	info =sqlData["note"].ToString();
//            
//			 	cmd.Dispose();
//			 	connection.Close();
//			
//			}catch(Exception e){ 
//				System.Windows.Forms.MessageBox.Show(e.Message);
//				}
//			
//		 return info;
//		}
//		
//		
	}
}

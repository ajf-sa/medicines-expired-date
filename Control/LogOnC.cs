/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/4/2015
 * Time: 8:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using abdulaziz.Database;
using Expire.Model;
using System.Data;
using abdulaziz.Core;
using System.Collections.Generic;
using System.Diagnostics;
using abdulaziz.Crypt;

namespace Expire.Control
{
    /// <summary>
    /// Description of LogOnC.
    /// </summary>
    public class LogOnC: Sqlite
    {
		private const string ID="id";
		private const string USERNAME="username";
        private const string NAME = "name";
		private const string PASSWORD="password";
		private const string EMAIL="email";
	 	private const string PHONE="phone";
		private const string RULE_ID="rule_id";

      

        private const string TABLE_NAME="user";
		
		bool ch;


        Encryptor crypt = new Encryptor();





        public LogOnC()
		{
			
		
			if(!IsConnection(Database.con)){
			
			
				System.Windows.Forms.MessageBox.Show("Error When Connect To Database");

                LocalData ld = new LocalData();
               
					
				ch=true;
					
			}
			
			
		}
		
		public bool Crach(){
		
			return ch;
		
		}
		public override void OnCreate()
		{
				var create = new string[]{		                                                   
				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
                "["+NAME+"] VARCHAR(50)    NULL",
                "["+USERNAME+"] VARCHAR(50) unique  NOT NULL",
				"["+PASSWORD+"] VARCHAR(50) NOT NULL",
				"["+EMAIL+"] VARCHAR(50)  NULL",
				"["+PHONE+"] int  NULL",
				"["+RULE_ID+"] int NOT NULL"};
			

			
			if(!base.IsExecute(CreateTable(TABLE_NAME,create))){
				
				System.Windows.Forms.MessageBox.Show("Error When Create Table "+TABLE_NAME);
				
			}
		}
		
	
		
		public List<UserM> GetUser(){
		
			List<UserM> users= new List<UserM>();
		
			DataTable dt = base.GetDataTable("select * from "+TABLE_NAME);
			
				foreach(DataRow row in dt.Rows){
				UserM user = new UserM();
				user.Id=int.Parse(row[ID].ToString());
                user.UserName = row[NAME].ToString();
                user.UserName=row[USERNAME].ToString();
				user.Password=row[PASSWORD].ToString();
				user.Rule_id=int.Parse(row[RULE_ID].ToString());
				user.Email=row[EMAIL].ToString();
                user.Name = row[NAME].ToString();
				user.Phone=row[RULE_ID].ToString();
				
				users.Add(user);
				
				}
			return users;
		
		}
		
		public bool AddUser(UserM user){
          
         
            user.Password = crypt.MD5Hash(user.Password);
            user.Email="";
            
			string query =Insert(TABLE_NAME,
			                          new string[]{USERNAME,NAME,PASSWORD,NAME,PHONE,EMAIL,RULE_ID},
			                          new string[]{user.UserName,user.Name,user.Password,user.Name,user.Phone,user.Email,user.Rule_id.ToString()});
		
			if(base.IsExecute(query)){
				return true;
			}
			return false;
		
		}
		
			public UserM GetOneUser(string userm){
		
			UserM user= new UserM();
			//FIXME الى يوزر اوبجكت userm قم بتغير المتغير 
			DataTable dt = base.GetDataTable("select * from user where "+USERNAME+"='"+userm+"'"); 
			
				foreach(DataRow row in dt.Rows){
				
				user.Id=int.Parse(row[ID].ToString());
                user.Name = row[NAME].ToString();
                user.UserName=row[USERNAME].ToString();
				user.Password=row[PASSWORD].ToString();
				user.Rule_id=int.Parse(row[RULE_ID].ToString());
                user.Email=row[EMAIL].ToString();
				user.Phone=row[PHONE].ToString();
				
				
				
				}
			return user;
		
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="us"></param>
		/// <param name="selectednode">name of node in treeview </param>
		/// <returns></returns>
		public bool Update(UserM us,string selectednode){
		
			if(!IsExecute(Update(TABLE_NAME,new string[]{USERNAME+"='"+us.UserName+"'",NAME+"='"+us.Name+"'",PHONE + "='" + us.Phone + "'", EMAIL + "='" + us.Email + "'",RULE_ID+"='"+us.Rule_id+"'" },USERNAME+"='"+selectednode+"'"))){

			               
			System.Windows.Forms.MessageBox.Show("Error When Update User In 'user' Table");
			return false;
			}
			
				return true;
			
		}
        public bool CheckDefualtPassword(UserM user) {
            return true;
        }
        public bool UpdatePassword(UserM user) {
            user.Password = crypt.MD5Hash(user.Password);
            if (!IsExecute(Update(TABLE_NAME, new string[] {  PASSWORD + "='" + user.Password + "'" }, ID + "='" + user.Id + "'")))
            {

                Debug.WriteLine("Error When Update Password");
                return false;
            }

            return true;

        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="username">name of user </param>
		public void Delete(string username){
		
			if(!base.IsExecute(Delete(TABLE_NAME,new string[]{USERNAME+"='"+username+"'"}))){
			
				System.Windows.Forms.MessageBox.Show("Error When Delete User From 'user' Table");
			}
		
		}
		 
		/// <summary>
		/// check is user has allow to login => has record in db
		/// </summary>
		/// <param name="username"></param>
		/// <param name="pass"></param>
		/// <returns></returns>
		public Boolean CheckUser(string username,string pass){
            pass = crypt.MD5Hash(pass);
			DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where "+USERNAME+"='"+username+"' and "+PASSWORD+"='"+pass+"'");
			
			if(dt.Rows.Count>0){
			return true;
			}
			
			return false;
		}
	}
}

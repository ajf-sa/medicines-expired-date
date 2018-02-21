/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/16/2015
 * Time: 10:07 AM
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
	/// Description of PermissionTableC.
	/// </summary>
	public class PermissionTableC: Sqlite, ISqlite
    {
		
		private const string ID="id";
		private const string RULE_ID="rule_id";
		private const string NAME="name";
		private const string VALUES="val";
		private const string TABLE_NAME="permission";
		
		public PermissionTableC()
		{
				if(!IsConnection(Database.con)){
			
			//	System.Windows.Forms.MessageBox.Show("Error When Connect To Database");
			}
		}
		
		public override void OnCreate()
		{
			var create = new string[]{
				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
				"["+RULE_ID+"] int(50)  NOT NULL",
				"["+NAME+"] VARCHAR(50)  NOT NULL",
				"["+VALUES+"] VARCHAR(50)  NOT NULL"
			};
			

			
		if(!IsExecute(CreateTable(TABLE_NAME,create))){			
			System.Windows.Forms.MessageBox.Show("Error When Create '"+TABLE_NAME+"' Table");
	}
		}

		public void Update(object obj)
		{
			throw new NotImplementedException();
		}
		#region ISqlite implementation
		
		public void InsertList(List<Permission> lpt){
		
			foreach(Permission pt in lpt){
			
			if(!IsExecute(Insert(TABLE_NAME,new string[]{RULE_ID,NAME,VALUES},new string[]{pt.Rule_id.ToString(),pt.Name,pt.Values}))){
			System.Windows.Forms.MessageBox.Show("Error When Insert Data Into '"+TABLE_NAME+"' Table");

				}
			}
		}
		public void Insert(object obj)
		{
			Permission pt = (Permission)obj;
			if(!IsExecute(Insert(TABLE_NAME,new string[]{RULE_ID,NAME,VALUES},new string[]{pt.Rule_id.ToString(),pt.Name,pt.Values}))){
			System.Windows.Forms.MessageBox.Show("Error When Insert Data Into '"+TABLE_NAME+"' Table");
	}
		}

		public void Update(object obj,object rul)
		{
			Rules rule = (Rules)rul;
			Permission pt = (Permission)obj;
			if(!IsExecute(Update(TABLE_NAME,new string[]{RULE_ID+"="+rule.Id+"'",NAME+"='"+pt.Name+"'",VALUES+"='"+pt.Values+"'"},RULE_ID+"='"+rule.Id+"'"))){
			System.Windows.Forms.MessageBox.Show("Error When Update Data On '"+TABLE_NAME+"' Table");
	
			
			}
		}
		public void SetPermissionBool(object permissiontab,object rul,bool type){
		
			Rules rule = (Rules)rul;
			Permission pt = (Permission)permissiontab;
			if(type){
				pt.Values="1";
			}
			else{ pt.Values="0";}
			
			if(!IsExecute(Update(TABLE_NAME,new string[]{VALUES+"='"+pt.Values+"'"},RULE_ID+"='"+rule.Id+"' and "+NAME+"='"+pt.Name+"'"))){
			System.Windows.Forms.MessageBox.Show("Error When Update Data On '"+TABLE_NAME+"' Table");
	
			
			}
		}
		public List<CheckPermission> GetPermissionAsBool(UserM user){
			List<CheckPermission> Lcps= new List<CheckPermission>();
			DataTable dt = GetDataTable("select * from "+TABLE_NAME+"where "+RULE_ID+"='"+user.Rule_id+"'");
			System.Windows.Forms.MessageBox.Show("fixme");
			return Lcps;
		}

		public void Delete(object obj)
		{
			Rules rule = (Rules)obj;
		if(!IsExecute(Delete(TABLE_NAME,new string[]{RULE_ID+"='"+rule.Id+"'"}))){
			
			System.Windows.Forms.MessageBox.Show("Error When Delete Data From '"+TABLE_NAME+"' Table");
	
			
			}
		}
		
		public List<Permission> GetPermissionTable(object obj){
		
			Rules rules = (Rules)obj;
			List<Permission> pts= new List<Permission>();
			DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where "+RULE_ID+"='"+rules.Id+"'");
			foreach (DataRow row in dt.Rows) {
				pts.Add(new Permission(){
				        	Id=int.Parse(row[ID].ToString()),
				        	Name=row[NAME].ToString(),
				        	Rule_id=int.Parse(row[RULE_ID].ToString()),
				        	Values=row[VALUES].ToString()
				        
				        });
			}
		
			return pts;
			
		}

		
	

		public List<CheckPermission> GetAccess(object obj){
		
				Permission pt = (Permission)obj;
				List<CheckPermission> cps= new List<CheckPermission>();
				DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where rule_id='"+pt.Rule_id+"'");
		
			foreach (DataRow row in dt.Rows) {
					
				CheckPermission cp = new CheckPermission();
				
				
				
			}
			return cps;
			
		
		
		}
		
		public CheckPermission GetAcess(int rule_id){
		
		DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where rule_id='"+rule_id+"'");
		CheckPermission cp = new CheckPermission();
			foreach (DataRow row in dt.Rows) {
					
			if(row[NAME].ToString().Equals("user")){
				if(row[VALUES].ToString().Equals("1")){cp.User=true;}else{cp.User=false;}
			}
			if(row[NAME].ToString().Equals("item")){
				if(row[VALUES].ToString().Equals("1")){cp.Item=true;}else{cp.Item=false;}
			}
			if(row[NAME].ToString().Equals("store")){
				if(row[VALUES].ToString().Equals("1")){cp.Store=true;}else{cp.Store=false;}
			}
			if(row[NAME].ToString().Equals("rule")){
				if(row[VALUES].ToString().Equals("1")){cp.Rules=true;}else{cp.Rules=false;}
			}
			
				
				
				
			}
		
		return cp;
		}

		#endregion
	}
}

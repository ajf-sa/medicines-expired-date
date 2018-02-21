/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/17/2015
 * Time: 8:36 AM
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
	/// Description of RuleCA.
	/// </summary>
	public class RuleC: Sqlite, ISqlite
    {
		private const string ID="id";
		private const string NAME="name";
		private const string DESCR="descr";
		private const string TABLE_NAME="rule";
	
		public RuleC()
		{
				if(!IsConnection(Database.con)){
			
			//	System.Windows.Forms.MessageBox.Show("Error When Connect To Database");
			}
		}
		
		public override void OnCreate()
		{
			var create = new string[]{
				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
				"["+NAME+"] VARCHAR(50) unique  NOT NULL",
				"["+DESCR+"] TEXT   NULL"
				
			};
		
	
			
			if(!IsExecute(CreateTable(TABLE_NAME,create))){
				System.Windows.Forms.MessageBox.Show("Error When Create "+TABLE_NAME);
			}
		}

		#region ISqlite implementation

		public void Insert(object obj)
		{
			var rule = (Rules)obj;
		
			if(!IsExecute(Insert(TABLE_NAME,new string[]{NAME,DESCR},new string[]{rule.Name,rule.Descr}))){
				System.Windows.Forms.MessageBox.Show("Error When Insert "+TABLE_NAME);
			}
		}

		public void Update(object obj)
		{
			var rule = (Rules)obj;
				var create = new string[]{};
				if(!IsExecute(Update(TABLE_NAME,new string[]{NAME+"='"+rule.Name+"'",DESCR+"='"+rule.Descr+"'"},"id='"+rule.Id+"'"))){
				System.Windows.Forms.MessageBox.Show("Error When Update "+TABLE_NAME);
			}
		}

		public void Delete(object obj)
		{
			var rule = (Rules)obj;
				var create = new string[]{};
				if(!IsExecute(Delete(TABLE_NAME,new string[]{ID+"='"+rule.Id+"'"}))){
				System.Windows.Forms.MessageBox.Show("Error When Delete "+TABLE_NAME);
			}
		}

		#endregion
		
		public List<Rules> GetRule(){
		
			List<Rules> rules = new List<Rules>();
			DataTable dt = GetDataTable("select * from "+TABLE_NAME);
			foreach (DataRow row in dt.Rows) {
				
				rules.Add(new Rules(){
				          
				          	Id=int.Parse(row[ID].ToString()),
				          	Name=row[NAME].ToString(),
				          	Descr=row[DESCR].ToString()
				   			       	
				          });
			}
			return rules;
		}
		public Rules GetRuleByName(object obj){
		var name = (string)obj;
		Rules rule = new Rules();
		DataTable dt = GetDataTable("select * from "+TABLE_NAME+" where "+NAME+"='"+name+"'");
		foreach (DataRow row in dt.Rows) {
			rule.Name=row[NAME].ToString();
			rule.Id=int.Parse(row[ID].ToString());
			rule.Descr=row[DESCR].ToString();
		}
		return rule;
		}
        public Rules GetRuleById(int id) {
            Rules rule = new Rules();
            DataTable dt = GetDataTable("select * from " + TABLE_NAME + " where " + ID + "='" + id + "'");
            foreach (DataRow row in dt.Rows)
            {
                rule.Name = row[NAME].ToString();
                rule.Id = int.Parse(row[ID].ToString());
                rule.Descr = row[DESCR].ToString();
            }
            return rule;

        }
		public Rules GetOneRule(object obj){
			
			var rule = (Rules)obj;
			return new Rules();
		
		}
	}
}

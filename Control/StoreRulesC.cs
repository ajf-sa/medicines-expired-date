/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/29/2015
 * Time: 1:44 AM
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
	/// Description of StoreRulesC.
	/// </summary>
	public class StoreRulesC: Sqlite, ISqlite
    {
		private const string ID ="id";
		private const string STORE_ID="store_id";
		private const string RULE_ID="rule_id";
		private const string VAL="val";
		
		
		private const string TABLE_NAME="store_rules";
		
		
		
		public StoreRulesC()
		{
				if(!IsConnection(Database.con)){
			
				
			}
			
		}
		public override void OnCreate()
		{
					var create = new string[]{		                                                   
				"["+ID+"] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT",
				"["+STORE_ID+"] INTEGER NOT NULL",
				"["+RULE_ID+"] INTEGER NOT NULL",
				"["+VAL+"] INTEGER NOT NULL"
				};
			

			if(!base.IsExecute(CreateTable(TABLE_NAME,create))){
				System.Windows.Forms.MessageBox.Show("Error When Create Table '"+TABLE_NAME+"'");
			}
	
		}

		#region ISqlite implementation

		public void Insert(object obj)
		{
			StoreRules soru = (StoreRules)obj;
			if(!IsExecute(Insert(TABLE_NAME,new string[]{STORE_ID,RULE_ID,VAL},new string[]{soru.Store_id.ToString(),soru.Rules_id.ToString(),"0"}))){
				System.Windows.Forms.MessageBox.Show("Error When Insert Into '"+TABLE_NAME+"'");
			
			}
		}
		public void InsertList(List<Store> lst,Rules ru){
			
			foreach (Store store in lst) {
			if(!IsExecute(Insert(TABLE_NAME,new string[]{STORE_ID,RULE_ID,VAL},new string[]{store.Id.ToString(),ru.Id.ToString(),"0"}))){
				System.Windows.Forms.MessageBox.Show("Error When Insert Into '"+TABLE_NAME+"'");
			
			}
				
			}
		}
		
	public void InsertListTrue(List<Store> lst,Rules ru){
			
			foreach (Store store in lst) {
			if(!IsExecute(Insert(TABLE_NAME,new string[]{STORE_ID,RULE_ID,VAL},new string[]{store.Id.ToString(),ru.Id.ToString(),"1"}))){
				System.Windows.Forms.MessageBox.Show("Error When Insert Into '"+TABLE_NAME+"'");
			
			}
				
				
			}
		}
		
		public void InsertListFalse(List<Store> lst,Rules ru){
			
			foreach (Store store in lst) {
			if(!IsExecute(Insert(TABLE_NAME,new string[]{STORE_ID,RULE_ID,VAL},new string[]{store.Id.ToString(),ru.Id.ToString(),"0"}))){
				System.Windows.Forms.MessageBox.Show("Error When Insert Into '"+TABLE_NAME+"'");
			
			}
				
				
			}
		}
		
		public int Count(int rule_id){
			
			var dt= GetDataTable("select * from "+TABLE_NAME+" where "+RULE_ID+"='"+rule_id+"'");
			return dt.Rows.Count;
		}
		public void ChangeStoreRules(Store store,Rules rule ,bool typ){
		
			StoreRules sr = new StoreRules();
			if(typ){sr.Val=1;}else{sr.Val=0;}
			
				if(!IsExecute(Update(TABLE_NAME,new string[]{VAL+"='"+sr.Val+"'"},RULE_ID+"='"+rule.Id+"' and "+STORE_ID+"='"+store.Id+"'"))){
			System.Windows.Forms.MessageBox.Show("Error When Update Data On '"+TABLE_NAME+"' Table");
	
			
			}
			
		}
		
		public List<StoreRules> GetStoreRulesByRuleId(int rule_id){
		
		
			List<StoreRules> lsr= new List<StoreRules>();
			DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where "+RULE_ID+"='"+rule_id+"' and "+VAL+"='1'");
			foreach (DataRow row in dt.Rows) {
				lsr.Add(
					new StoreRules(){
						Id=int.Parse(row[ID].ToString()),
						Rules_id=int.Parse(row[RULE_ID].ToString()),
						Store_id=int.Parse(row[STORE_ID].ToString()),
						Val=int.Parse(row[VAL].ToString())
					}
				);
			}
			return lsr;
		}
		
		

		public void Update(object obj)
		{
			throw new NotImplementedException();
		}

		public void Delete(object obj)
		{
			throw new NotImplementedException();
		}
		
		public List<StoreRules> GetStoreRule(object obj){
			Rules rule = (Rules)obj;
			List<StoreRules> srcs = new List<StoreRules>();
			DataTable dt = base.GetDataTable("select * from "+TABLE_NAME+" where "+RULE_ID+"='"+rule.Id+"'");
			foreach(DataRow row in dt.Rows) {
				srcs.Add(
					new StoreRules(){
						Id=int.Parse(row[ID].ToString()),
						Store_id=int.Parse(row[STORE_ID].ToString()),
						Rules_id=int.Parse(row[RULE_ID].ToString()),
						Val=int.Parse(row[VAL].ToString())
						
					}
				);
			
				
			}
			return srcs;
		}
		#endregion
	}
}

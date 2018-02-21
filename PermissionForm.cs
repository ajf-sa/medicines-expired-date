/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/17/2015
 * Time: 4:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using abdulaziz.Database;
using abdulaziz.Model;
using Expire.Control;
using Expire.Model;
using System.Windows.Forms;

namespace Expire
{
	/// <summary>
	/// Description of PermissionForm.
	/// </summary>
	public partial class PermissionForm : Form
	{
		
		private Rules _rule =new Rules();
	
		private Permission _pt = new Permission();
		private StoreRules _sr = new StoreRules();
		public PermissionForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
			
			
		}
		void PermissionFormLoad(object sender, EventArgs e)
		{
			RuleC rules  =new RuleC();
			
			foreach(Rules rule in rules.GetRule()){
				if(rule.Id !=1){
				cbrule.Items.Add(rule.Name);
				}
			}
		
			_pt.Name="!";
	
		}
		void CbruleSelectedIndexChanged(object sender, EventArgs e)
		{
			PermissionTableC pts = new PermissionTableC();
			RuleC rules = new RuleC();
			StoreC ssc = new StoreC();
			StoreRulesC src = new StoreRulesC();
			
			
			Rules rule = rules.GetRuleByName(cbrule.Text);
			List<Permission> lpt = pts.GetPermissionTable(rule);
			List<StoreRules> lsr = src.GetStoreRule(rule);
			_rule.Id=rule.Id;
			ComboBox b = (ComboBox)sender;
			tvfalse.Nodes.Clear();
			tvtrue.Nodes.Clear();
			tvstorefalse.Nodes.Clear();
			tvstoretrue.Nodes.Clear();

            src = new StoreRulesC();
            if (ssc.Count()>src.Count(_rule.Id)){
			
				Debug.WriteLine("Store In DataBase More Than StoreRules Store="+ssc.Count()+" StoreRules="+src.Count(_rule.Id));

                StoreC stores = new StoreC();
                StoreRulesC sRc = new StoreRulesC();
                sRc.InsertList(stores.GetStore(), new Rules() { Id = _rule.Id });
            }
			else{
			
			Debug.WriteLine("Store In DataBase Less Than StoreRulesStore="+ssc.Count()+" StoreRules="+src.Count(_rule.Id));
			}
			
			foreach(Permission pt in lpt){
				if(pt.Rule_id!=1){
				if(pt.Values.Equals("0")){
					var tvfalsenode= new TreeNode(pt.Name);
					tvfalse.Nodes.Add(tvfalsenode);
				}else{
					var tvtruenode= new TreeNode(pt.Name);
					tvtrue.Nodes.Add(tvtruenode);
				}
				}
				
			}
			
			foreach (StoreRules sr in lsr) {
					StoreC storec = new StoreC();
					Store sstore = storec.GetOneStore(new Store(){Id=sr.Store_id});
					if(sr.Rules_id!=1){
				if(sr.Val==0){
				
					var tvstorefalsenode = new TreeNode(sstore.Name);
					tvstorefalse.Nodes.Add(tvstorefalsenode);
				
				}else{
					var tvstoretruenode = new TreeNode(sstore.Name);
					tvstoretrue.Nodes.Add(tvstoretruenode);
				}
			}
			}
			
			_pt.Name="!";
			_sr.Store_id=-1;
		}
		void Btn12trueClick(object sender, EventArgs e)
		{
			if(_pt.Name.Equals("!")){}else{
			PermissionTableC ptc=new PermissionTableC();
			ptc.SetPermissionBool(_pt,_rule,true);
			CbruleSelectedIndexChanged(null,null);
			}
		}
		void TvfalseAfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeView tn = (TreeView)sender;
			_pt.Name=tn.SelectedNode.Text;
		
		}
		void Btn12falseClick(object sender, EventArgs e)
		{
			if(_pt.Name.Equals("!")){}else{
		PermissionTableC ptc=new PermissionTableC();
			ptc.SetPermissionBool(_pt,_rule,false);
			CbruleSelectedIndexChanged(null,null);  
			}
		}
		void BtnstoretotrueClick(object sender, EventArgs e)
		{
			if(_sr.Store_id==-1){}else{
			StoreRulesC src = new StoreRulesC();
			src.ChangeStoreRules(new Store(){Id=_sr.Store_id},_rule,true);
			CbruleSelectedIndexChanged(null,null);  
			}
		}
		void BtnstoretofalseClick(object sender, EventArgs e)
		{
			if(_sr.Store_id==-1){}else{
				StoreRulesC src = new StoreRulesC();
			src.ChangeStoreRules(new Store(){Id=_sr.Store_id},_rule,false);
			CbruleSelectedIndexChanged(null,null);  
			}
		}
		void TvstorefalseAfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeView tn =(TreeView)sender;
			StoreC stc = new StoreC();
			
			_sr.Store_id=stc.GetStoreId(tn.SelectedNode.Text);
			
		}
	
	}
}

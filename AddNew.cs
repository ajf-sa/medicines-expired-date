/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 09:52 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Expire.Control;
using Expire.Model;

namespace Expire
{
	/// <summary>
	/// Description of AddNew.
	/// </summary>
	public partial class AddNew : Form
	{
		MainForm forms;
		int intYear;
		string months;
		
		UserM _user;
		Fallter f= new Fallter();
		
		public delegate void progDelegate(int i);
		
		public AddNew(MainForm form,UserM user)
		{
			forms=form;
			_user=user;
			
			
			
			
			
		
			InitializeComponent();
			CenterToScreen();
			
			
			
			
			setYear();
			comboYear.Items.AddRange(new object[]{
			                          
			                            intYear,
			                            intYear+1,
			                            intYear+2,
			                            intYear+3,
			                            intYear+4,
			                            intYear+5,
			                            intYear+6,
			                            intYear+7,
			                            intYear+8,
			                         });
			
			comboYear.Text =intYear.ToString();
			comboMonth.Text=months;
			
		
		}

		
		void GetStoreByRule()
		{
			StoreRulesC src = new StoreRulesC();
			bool isFirst=true;
			List<StoreRules> lsr=  src.GetStoreRulesByRuleId(_user.Rule_id);
			
			foreach (StoreRules sr in lsr) {
				StoreC sc = new StoreC();
				try {
					
				string storeName= sc.GetOneStore(new Store(){Id=sr.Store_id}).Name;
				cbstore.Items.Add(storeName);
				} catch (Exception) {
					
					Debug.WriteLine("Error When Get Store Name AddNew Class");
				}
				
				
			}

		}
		void GetStore()
		{
			StoreC stores = new StoreC();
			foreach(Store store in stores.GetStore()){
			
				cbstore.Items.Add(store.Name);
			
			}
			
		}
		
		void GetItem(){
			ItemC items = new ItemC();
			
			foreach(Item item in items.GetItem()){
				
				cbitem.Items.Add(item.Name+","+item.Size+","+item.Type);
				
			}
		
		}
		
		 int GetUserId(string str){ return 1;}
		
		 int GetStoreId(string str){
			StoreC stores = new StoreC();

			return stores.GetStoreId(str);
			
			
		}
			
		 int GetItemId(string str){
		 	ItemC items = new ItemC();
		 	
		 	return items.GetItemId(str);
		 
		 }
		void Save(){
		
		 	EpisodeC eps = new EpisodeC();
				
			
			if( /*batchNum.Text.Equals("") ||medAmount.Text =="" || comboType.Text.Equals("")||*/comboYear.Text.Equals("")||comboMonth.Text.Equals("") )
			{}
//			else if(comboType.Text=="others" && textboxOther.Text=="")
//			{
//				textboxOther.Select();
//			}
			else{
			
//				Thread prgThead = new Thread(StarProg);
//				prgThead.Start();
			Database a= new Database();
			int amount = f.AddInt(medAmount.Text);
			string typeSelect=null;

			string dateType=null;
			
			if(dayNumber.Text=="0" || dayNumber.Enabled==false){
			
				dateType =comboYear.Text+"-"+comboMonth.Text+"-"+f.getLastDayOfMonth(comboMonth.Text);
			
			}
			else{
				
		
				string addZero=dayNumber.Text;
				if(dayNumber.Value<10){
					addZero="0"+dayNumber.Text;
				}
				else{}
				 dateType =comboYear.Text+"-"+comboMonth.Text+"-"+addZero ;
			}
		//	a.Ccon();
		eps.Insert(new Episode(){
		           	Stoke_id=GetStoreId(cbstore.Text),
		           	Item_id=GetItemId(cbitem.Text),
		           	Amount=amount,
		           	AmountType=cbamountype.Text,
		           	Notes=note.Text,
		           	Expdate=f.CheckDateBeforeAdd(dateType),
		           	Batch=batchNum.Text
		           });
		
			forms.getAll("");
			forms.DisableSelect();
			this.Activate();
			
			
		
		}
		}
		
		void StarProg(){
		 
			toolStripStatusLabel1.Text="  wait";
			for(int i=1;i<=100;i++){
			
				statusStrip1.Invoke(new progDelegate(prog),i);
				Thread.Sleep(1);
			}
			
			Thread.Sleep(10);
		toolStripStatusLabel1.Text=" Done";
	
			statusStrip1.Invoke(new progDelegate(prog),0);
		
		
		}
		void prog(int i){
		
			progressBar1.Value=i;
		
		}
	
		void setYear(){
		
		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
		string years = System.DateTime.Now.ToString("yyyy",gro);
		 months =DateTime.Now.ToString("MM",gro);
		
		intYear =Convert.ToInt32(years);
		
		}
		
		void Button1Click(object sender, EventArgs e)
		
		{
            if (cbstore.Text=="") {
               
                return;
              
            } 
				
			Save();
		
			}
		
			
			
		
		
		void AddNewSaveKeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Escape){
				this.Close();
			}
			if(e.KeyCode ==Keys.Enter){
			
				Save();
			}
		}
			
	
		
	
		
		void MedAmountKeyPress(object sender, KeyPressEventArgs e)
			
		{
			
			
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) 
			{ 
			e.Handled = false; 
			} 
			else 
			{ 
			e.Handled = true; 
			} 
			
		}
		
	
		
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
		}
		
		
		
		void NewbtnClick(object sender, EventArgs e)
		{
			// blank textbox for new adding
			medAmount.Text="";
			//medName.Text="";
		
			batchNum.Text="";
			note.Text="";
		//	medName.Select();
		}
		
		void ComboTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			

		}
		
		void AddNewLoad(object sender, EventArgs e)
		{
			GetItem();
			GetStoreByRule();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
			
			if(checkBox1.Checked){
			
					dayNumber.Enabled=true;
			}else{
			
					dayNumber.Enabled=false;
			}
		
		}
	}
}

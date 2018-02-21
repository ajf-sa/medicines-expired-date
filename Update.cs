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
using System.Text.RegularExpressions;
using Expire.Control;
using Expire.Model;



namespace Expire
{
	/// <summary>
	/// Description of Update.
	/// </summary>
	public partial class Update : Form 
	{
		MainForm forms;
	//	Database database;
		int id; 
//		string batch;
//		string name;
//		string type;
//		string amount;
//		string _note;
		int intYear;
		UserM _user;
		Fallter f = new Fallter();
		
		string[] exp = new string[3];
		public Update(MainForm form,int id,UserM user)
		{
			this.forms = form;
			this.id=id;
			_user = user;
//		//	this.exp =Regex.Split(eps.Expdate,"/");
		//	this.exp = "2015/05/17".Split('/');
//			this.batch=eps.Batch;
//			this.name=eps.Name;
//		//	this.type=eps.;
//			this.amount=eps.Amount+eps.AmountType;
//			this._note=eps.Notes;
		//	this.database =data;
		
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
			
		
			

			
			//medName.Text=_name;
//			batchNum.Text=_btc;
//			cbitem.Text=this.name;
//			medAmount.Text=_;
//			_notes.Text=_note;
//			comboType.Text=_type;
			
			
//		
//			if(comboType.Text ==""){
//			textboxOther.Visible=true;
//			comboType.Text="others";
//			textboxOther.Text=_type;
//			}
			
			
			GetQuery(id);
			
			
		}
		
		
		void GetStoreByRule()
		{
			StoreRulesC src = new StoreRulesC();
		
			List<StoreRules> lsr=  src.GetStoreRulesByRuleId(_user.Rule_id);
			
			foreach (StoreRules sr in lsr) {
				StoreC sc = new StoreC();
						try {
				string storeName= sc.GetOneStore(new Store(){Id=sr.Store_id}).Name;
				cbstore.Items.Add(storeName);
					} catch (Exception) {
					
					Debug.WriteLine("Error When Get Store Name Update Class");
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

	
		
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
			
			
		}
		
		void UpdateSaveClick(object sender, EventArgs e)
		{
			

			
				
//			if( /*batchNum.Text.Equals("") || comboType.Text.Equals("")||comboYear.Text.Equals("")||comboMonth.Text.Equals("")/*|| medName.Text.Equals("") || medAmount.Text.Equals("") */)
//			{}
//			else if(comboType.Text=="others" && textboxOther.Text=="")
//			{
//			textboxOther.Select();
//			}
//			else{
//				
//				int amo = f.AddInt(medAmount.Text);
//				
//				string typeSelect=null;
//			if(comboType.Text=="others"){
//			typeSelect= textboxOther.Text;
//			}else{
//			
//				typeSelect=comboType.Text;
//		}
//				string dateType=null;
//			
			if(dayNumber.Text=="0"){
			
				dayNumber.Text =f.getLastDayOfMonth(comboMonth.Text);
			
			}
			else{
					
		
			//	string addZero=dayNumber.Text;
				if(dayNumber.Value<10){
					dayNumber.Text="0"+dayNumber.Text;
				}
				else{
				int last = int.Parse(f.getLastDayOfMonth(comboMonth.Text));
				int day = int.Parse(dayNumber.Value.ToString());
				if(day>last){
					dayNumber.Text= f.getLastDayOfMonth(comboMonth.Text);
				}
				Debug.WriteLine(dayNumber.Value);
			}
		
			}
				
	
	
			EpisodeC eps = new EpisodeC();
			
			eps.Update(new Episode(){
			           	Id=id,
			           	Stoke_id=new StoreC().GetStoreId(cbstore.Text),
			           	Item_id= new ItemC().GetItemId(cbitem.Text),
			           	Amount=int.Parse(medAmount.Text),
			           	Expdate=comboYear.Text+"-"+comboMonth.Text+"-"+dayNumber.Text,
			           	AmountType=cbamountype.Text,
			           	Batch=batchNum.Text,
			           	Notes=_notes.Text
			           });
			
			forms.checkGet();
		
			this.Close();
		}
		
		
		void MedAmountKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		
		
		void ComboTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		void GetQuery(int id)
		{
			EpisodeC episodes = new EpisodeC();
			
				ItemC item = new ItemC();
				StoreC store = new StoreC();
				Episode eps = episodes.GetOneEpisode(new Episode(){Id=id});
				Item it = item.GetOneItem(eps.Item_id.ToString());
				Store st = store.GetOneStore(new Store() {
					Id =eps.Stoke_id
				});
				cbitem.Text = it.Name + "," + it.Size + "," + it.Type;
				cbstore.Text = st.Name;
                batchNum.Text = eps.Batch;
				medAmount.Text = eps.Amount.ToString();
            _notes.Text = eps.Notes;
				cbamountype.Text= eps.AmountType;
				string[] x = eps.Expdate.Split('-');
				intYear =Convert.ToInt32(x[0]);
			
			comboYear.Items.AddRange(new object[]{
			                          
			                            intYear-3,
			                            intYear-2,
			                            intYear-1,
			                            intYear,
			                            intYear+1,
			                            intYear+2,
			                            intYear+3,
			                            intYear+4,
			                            intYear+5,
			                         });

			
				comboYear.Text = x[0];
				comboMonth.Text = x[1];
				dayNumber.Text = x[2];
			
		}

		void UpdateLoad(object sender, EventArgs e)
		{
			GetStoreByRule();
			GetItem();
			GetQuery(id);
	
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

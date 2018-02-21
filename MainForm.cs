/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 04:04 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using abdulaziz.Date;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Expire.Control;
using Expire.Model;
using System.Text;

namespace Expire
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public enum print{ NONE ,ALIST ,ALABEL , SLIST,SLABEL}
		
		public enum Dates { EXP ,NEAR,ATTENTION,SAFF,LONG}
		
		
		Database data = new Database();

        
		
		
		
		
		public int Count{get;set;}

		string shownote;
			int 			_Id;
			int 			_oneClick=0;
			int 			 _Scorll;
			//string			title ="deafult";
	
			print 			switchPrint;
			
			 UserM _user;
        List<Store> _store = new List<Store>();

        List<TabPage> _listTabPage = new List<TabPage>();
        List<ListView> _listListView = new List<ListView>();
			 List<StoreRules> _listStoreRules;
			int				totalPage=0;

			ListViewItem 	item;
			string 			_query="";
			bool 			SelectItem=false;
			int				expiryCount=0;
			int				nearCount=0;
			
			bool			selectItemPrint=false;
			Dates 			setColor; // 0 expired  |||| 1 Near to expiry |||| 2 one year to expiry 
			bool			withLogon=true; // true  is with login form |||| false without login
			int				page =1;
			List<int> multiSelecteItem =new List<int>();
			PrnControl 		prnCo;
			PrnLable prnlab=new PrnLable();
			PrnText  prntext = new PrnText();
			Fallter f = new Fallter();
			
			Finder find;
			AddNew addnew ;
            string finalquery;

        public MainForm()
		{
            
			GetStart();
			
            int led=0;
           
            LogOnC loc = new LogOnC();
			
			RuleC ruc = new RuleC();
			PermissionTableC pt = new PermissionTableC();
			StoreRulesC src = new StoreRulesC();
            
			List<Store> ls = new List<Store>();
			for (int i = 1; i < 20; i++) {
				ls.Add(new Store(){
				       Id=i
				       });
			}
			if(loc.GetUser().Count==0){
                loc = new LogOnC();
			loc.AddUser(new UserM(){UserName="admin",Name="Abdulaziz Alfuhigi",Password="123",Rule_id=1 ,Phone="00000000"});
			}
			if(ruc.GetRule().Count==0){
                ruc = new RuleC();
				ruc.Insert(new Rules(){Name="admin",Descr="admin"});
				pt.InsertList(new DefaultValues().GetDefaultPermissionTrue(new Rules(){Id=1}));
				src.InsertListTrue(ls,new Rules(){Id=1});
			}
			
		
	
		}
		
		
		
		public void GetStart(){
		
			
		
		find= new Finder(this);
	//	addnew = new AddNew(this,_user);
		prnCo =	new PrnControl(this);
			
				InitializeComponent();
				CenterToScreen();

           // this.lsv.ListViewItemSorter = new ListViewItemComparer();


            cbplace.Text = "ALL";
           








        }
		
		#region get set 
		
			public int TotalPage{
		
			get{return totalPage;}
			set{ totalPage =value;}
		
		
		}
		#endregion
		
//		public void Start(){
//		
//			data = new Database();
//		data.Ccon();
//		getAll(0);
//		}
		
		
//			public void Start(string loca){
//		
//			//data = new Database();
//			data.Location =loca;
//			data = new Database();
//		data.Ccon();
//		getAll(0);
//		}
		
//		public void Stop(){
//		
//	data.Dispose();
//	orderBy.SelectedIndex=0;
//	byPrint.SelectedIndex=0;
//	bySort.SelectedIndex=0;
//		}
		
		#region get information from data
		
		public void getinfo(int id)
		{
//			if(data.getinfo(id)==""){
//			otherInfo.Enabled=false;
//			}
//			else{
//				otherInfo.Enabled=true;
//			
//			shownote=data.getinfo(id);
//			
//			}
		}
		
		
		public void checkGet(){
		
			if(orderBy.Text.Equals("Default")){
			
				getAll("");
              
			}
            if (orderBy.Text.Equals("Name"))
            {

                getAll("Name");
            }
            if (orderBy.Text.Equals("Exp"))
            {

                getAll("Exp");
            }

            if (orderBy.Text.Equals("Near Exp")){
			
				getAll("NearExp");
			}
				if(orderBy.Text.Equals("Next 3Months")){
			
				getAll("Next3Months");
			}
			if(orderBy.Text.Equals("All after")){
			
				getAll("Allafter");
			}
			
		}
		
		
		





		
		public void getAll(string sort){
		
			lsv.Items.Clear();
        
			EpisodeC episodes = new EpisodeC();
			
			
			
			int c =1;
			int lx =0;
			foreach(Episode eps in episodes.GetEpisodeWithLimitStore(_query,sort)){
				StoreC stores = new StoreC();
				
				ListViewItem t = new ListViewItem(eps.Id.ToString());
				t.SubItems.Add(c.ToString());
				t.SubItems.Add(eps.Batch);
                try
                {
                    ItemC items = new ItemC();
                    Item item = items.GetOneItem(eps.Item_id.ToString());
      
                        t.SubItems.Add(item.Name + "," + item.Size);
                        t.SubItems.Add(item.Type.ToUpper());
                    
                }
                catch (Exception)
                {

                    t.SubItems.Add("NULL");
                    Debug.WriteLine("Item table is null getall method in mainform.class");
                  
                }

                LimitC setdate = new LimitC();
                t.SubItems.Add(setdate.SetDateWithoutDay(eps.Expdate));
				t.SubItems.Add(stores.GetOneStore(new Store(){Id=eps.Stoke_id}).Name);
				t.SubItems.Add(eps.Amount.ToString()+eps.AmountType);
				//				// notes for medicine
			string itemNote="";
			if(eps.Notes.Equals("")){

                  
					itemNote =getTimeline(eps.Expdate);
				}
				else{
					
					itemNote =getTimeline(eps.Expdate)+" *";
				}
			t.SubItems.Add(itemNote);
				
				lsv.Items.Add(t);
			
		lsv.Items[lx].UseItemStyleForSubItems=false;
			if(setColor==Dates.EXP){
			lsv.Items[lx].SubItems[8].BackColor=Color.Red;
			}
		
			if(setColor==Dates.NEAR){
			lsv.Items[lx].SubItems[8].BackColor=Color.Orange;
			}
			if(setColor==Dates.ATTENTION){
			lsv.Items[lx].SubItems[8].BackColor=Color.LightGreen;
			}
				if(setColor== Dates.SAFF){
			lsv.Items[lx].SubItems[8].BackColor=Color.LightSalmon;
			}
			if(setColor==Dates.LONG){
			lsv.Items[lx].SubItems[8].BackColor=Color.White;
			}				
			
				c++;
				lx++;
			}
			c=1;
          

        }
		
	
		#endregion
		
		
		#region Print item list Or label
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			prnlab.e=e ;prntext.e=e;
			prnlab.lsv=lsv ; prntext.lsv=lsv;
			
			switch(switchPrint){
				
					case print.ALIST: PrintAllText();
				
						break;
						
					case print.SLIST: PrintSelectedText();
					
						break;
						
					case print.SLABEL: PrintSelectedLabel();
				
						break;
						
						case print.ALABEL: PrintAllLabel();
					
						break;
						
					default:
                  		 	
                    break;
						
			
			}
			

			
				}
				
			
		public void PrintAllText(){
		if(page ==prntext.newPage){
			prntext.PrnAllText(prntext.Loop);
				page +=1;
				if(page==prntext.newPage){
						
			prntext.e.HasMorePages=true;
			
	
		
				}else{
					prntext.e.HasMorePages=false;
					
					
				}
				
				TotalPage +=1;
	
			
			}
		}
		
		public void PrintSelectedText(){
			
				if(page==prntext.newPage){
		
			prntext.PrnSelectedText(multiSelecteItem,prntext.skipCount);
		
				
				
					page +=1;
				if(page==prntext.newPage){
						
			prntext.e.HasMorePages=true;
			
	
		
				}else{
						prntext.e.HasMorePages=false;
						
						
				}
				
					TotalPage +=1;
	
				}
		
		}
		
		public void PrintAllLabel(){
		
		
			if(page==prnlab.newPage){
		
				prnlab.PrintAllLable(prnlab.Loop);
				
					page +=1;
				if(page==prnlab.newPage){
						
			prnlab.e.HasMorePages=true;
			
	
		
				}else{
					prnlab.e.HasMorePages=false;
				}
				
	
	TotalPage +=1;
				}
		}
		
		public void PrintSelectedLabel(){
		
		
			
			if(page==prnlab.newPage){
		
				prnlab.PrintSelectedLable(multiSelecteItem,prnlab.skipCount);
				
					page +=1;
				if(page==prnlab.newPage){
						
			prnlab.e.HasMorePages=true;
			
	
		
				}else{
						
						prnlab.e.HasMorePages=false;
						
						
						
				}
				
					TotalPage +=1;
	
				}
		
		}
		
			
		public void PrintDoc(){
		
				SetupPrint();
			prnDoc.Print();
		
		}
		
		
		public void PrintLabel(){
			
			SetupPrint();
	switchPrint=print.NONE;
		
		}
		public void SetupPrint(){
		
			
		prnlab.SetZero();
		prntext.SetZero();
		TotalPage=0;
		
		 page =1;
		 //print label from listview  
		 if(selectItemPrint){
		 	if(byPrint.Text.Equals("Label")){
		 // print selected label		
		 switchPrint=print.SLABEL;
		 	}
		 	else{
		 // print select text
		 
		 switchPrint=print.SLIST;
		 	}
		 
		 
	ListView.SelectedListViewItemCollection getSelect = lsv.SelectedItems;
	
		multiSelecteItem.Clear();
		foreach ( ListViewItem item in getSelect )
		{
			multiSelecteItem.Add(item.Index);
		}
		
		if(multiSelecteItem.Count==0){
			
		// switchPrint=print.ALIST;
		}
		 
		 }
		 else{
		 	if(byPrint.Text.Equals("Label")){
		 //print all lable
		 switchPrint=print.ALABEL;
		 	}else{
		 //print all text
		 switchPrint=print.ALIST;
		 	}
		 }
		}
		
		
			void BfClick(object sender, EventArgs e)
		{
			

	
		
		
		 
	
			if(prnCo.Visible){
			
				prnCo.Activate();
				
			}else{
				try{
				
					if(lsv.Items.Count==0){
					
					
					}
					else{
					
								
					prnCo.printPreviewControl1.Document= prnDoc;
					prnCo.printDialog1.Document = prnCo.printPreviewControl1.Document;
					SetupPrint();
					prnCo.Show();
					}
					
				}catch(Exception){
					
					prnCo = new  PrnControl(this);
					if(lsv.Items.Count==0){
					
					
					}
					else{
					
								
					prnCo.printPreviewControl1.Document= prnDoc;
					prnCo.printDialog1.Document = prnCo.printPreviewControl1.Document;
					SetupPrint();
					prnCo.Show();
					}
				
				}
			}
		
		
			
		
		}

	#endregion			
		
		
		
		#region Event
		
		
		
		void ToolStripNewClick(object sender, EventArgs e)
		{
			
				AddNew();
		}
		
		
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
		
			getAll("");
		}
		
		
		
		void LsvResize(object sender, EventArgs e)
		{
			
			SizeLastColumn((ListView) sender);
	
		}
		
	
		
		void FindToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			
			this.openFind();
	
		}
		
	
		
		
		
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			
				openFind();
	
		}
		
		public void openFind(){
		
				if(find.Visible){
			
				find.Activate();
			}else{
				try{
			find.Show();
				}catch(Exception){
					find = new Finder(this);
					find.Show();
				
				}
			}
		}
		
		
		
		void ToolStripRemoveClick(object sender, EventArgs e)
		{
			// remove item 
			if(SelectItem){
			Delete();
			}

		}
		
		
		
		void AboutToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			About about =new About();
			about.ShowDialog();
			
		}
		
		
		
		
		
		
		void NewToolStripMenuItemClick(object sender, System.EventArgs e)
		{
		
//			if(data.IsDefault()){
//				data.Drop();
//				
//			}else{
//			
//				data.SetLocation();
//			}
			
			
			
//			Stop();
//			Start();
//			
			
			
			
		}
		
		
		
		
		
		
		public void menuItem1_Click(object sender , System.EventArgs e){
			
			AddNew();
			
		}
		
		
		
		
		

		
		
		
		
		public void menuItem4_Click(object sender , System.EventArgs e){
			
			
		getAll("");
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			// exit app
			System.Environment.Exit(0);
		}
		
		
		
		
		
		
	
		
		
		
		
		
		
		public void menulist(System.Windows.Forms.MouseEventArgs e){
			
			
			ContextMenu myContextMenu = new ContextMenu();

			MenuItem menuItem4 = new MenuItem("refresh");
			MenuItem menuItem1 = new MenuItem("New");
			MenuItem menuItem2 = new MenuItem("Delete");
			MenuItem menuItem3 = new MenuItem("Update");


			// Clear all previously added MenuItems.
			myContextMenu.MenuItems.Clear();
			myContextMenu.MenuItems.Add(menuItem4);
			myContextMenu.MenuItems.Add(menuItem1);
			myContextMenu.MenuItems.Add(menuItem2);
			myContextMenu.MenuItems.Add(menuItem3);

			if (lsv.SelectedItems.Count >= 0)
			{
				
				
				
				foreach (ListViewItem item in lsv.SelectedItems)
				{
					myContextMenu.MenuItems[2].Visible = true;
					myContextMenu.MenuItems[3].Visible = true;
					myContextMenu.MenuItems[0].Visible = false;
					myContextMenu.MenuItems[1].Visible = true;
					
					
					
					
					
				}

			}
			else
			{
				myContextMenu.MenuItems[2].Enabled = false;
				myContextMenu.MenuItems[3].Enabled = false;
				myContextMenu.MenuItems[0].Visible = false;
				myContextMenu.MenuItems[1].Visible = true;
				
				
				
				
			}

			
			myContextMenu.Show(lsv, e.Location, LeftRightAlignment.Right);

			//event
			menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
		//	menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			
			
			
		}
		
		
		
				
		void LsvDoubleClick(object sender, EventArgs e)
		{
			// up date form 
			
			OpenUpdate(_Id);
			
		}
		
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			AddNew();
		}
		
		
		
		
		
		
		void MainFormResize(object sender, EventArgs e)
		{
			
			
			
			if (this.WindowState == FormWindowState.Maximized)
			{
				// code to execute after Maximize button has been clicked
//				int screenWidth =Screen.PrimaryScreen.Bounds.Width;
//				
//			
//				int screenAfter= screenWidth-40-99-70-90;
//				MessageBox.Show("sss");
//				screenAfter= screenAfter/3;
//				me_name.Width=screenAfter;
//				me_type.Width=screenAfter;
//				note.Width=screenAfter;
				
				
				
			}
			
			if (this.WindowState == FormWindowState.Minimized)
			{
				// code to execute after Minimize button has been clicked
				
				//MessageBox.Show(this.Width.ToString());
					
				
			}
		}
		
		
		
			void MainFormLoad(object sender, EventArgs e)
		{
		
			
	orderBy.SelectedIndex=0;
	byPrint.SelectedIndex=0;
	bySort.SelectedIndex=0;
			
			if(withLogon){
		
			try {
			showlogin();
			GetStoreByRule();
			this.WindowState= FormWindowState.Maximized;
			lbusername.Text=_user.UserName;
			} catch (Exception) {
			this.Close();
				Debug.WriteLine("There Is No Rule Id Or App Is Closed");
			
			}
			
		
			}
	
			
		}
			
			
			
			void LsvItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			
				selectItemPrint=false;
			
			item =(ListViewItem) e.Item;
			
				if(_oneClick==item.Index && lsv.Items.Count ==0){
				
			}
			
			else{
			
			 _Scorll =item.Index;
			
			 _oneClick =item.Index;
//			_Batch =item.SubItems[2].Text;
//			_Name =item.SubItems[3].Text;
//			_Type =item.SubItems[4].Text;
//			_Expdate =getMonthNo(item.SubItems[5].Text);
//			_Location =item.SubItems[6].Text;
		//	_Amount=item.SubItems[6].Text;
			
			_Id =Convert.ToInt32(item.Text);
			Debug.WriteLine(_Id);
			Debug.WriteLine(_user.Rule_id);
		//	_Note =data.getinfo(_Id);
			
		
			
			
			if (lsv.SelectedItems.Count >= 0) {
				
				
				if(selectItemPrint){
					DisableSelect();
				}else{
					SelectItem =true;

				}
				
				
			}
			else{
				
				DisableSelect();
			
				
			}
			
			
		}
			}
	
				
           
		
	
		
		
		
	
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
//			if(e.KeyCode == Keys.Up){
//			
//			
//				
//				
//				if(lsv.Items.Count<=0 ){
//			
//			_Scorll=0;
//			}
//			else if(_Scorll ==lsv.Items.Count){
//			_Scorll=lsv.Items.Count-1;
//			
//				lsv.Items[_Scorll].Selected=true;
//			
//			}
//			else{
//				
//			
//		lsv.Items[_Scorll].Selected=false;
//		try{
//				lsv.Items[_Scorll-1].Selected=true;
//			
//		}catch{
//		
//		lsv.Items[0].Selected=true;
//		}
//			}
//			
//			}
//			
//			
//			if(e.KeyCode == Keys.Down){
//			
//					
//				if(lsv.Items.Count<=0 ){
//			
//			_Scorll=0;
//			}
//			else if(_Scorll ==lsv.Items.Count){
//			_Scorll=lsv.Items.Count-1;
//			
//				lsv.Items[_Scorll].Selected=true;
//			
//			}
//			else{
//				
//			
//					lsv.EnsureVisible(_Scorll);
//			lsv.Items[_Scorll].Selected=false;
//			lsv.Items[_Scorll+1].Selected=true;
//				
//			
//			}
//			
//			}
			
			
			if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
			{
				//do stuff
				AddNew();
			}
			if( e.Modifiers==Keys.Control  || e.Modifiers == Keys.Shift){
		//		multiSelecteItem.Clear();
				DisableSelect();
				selectItemPrint=true;
			
			}
			
		
		
			if(e.KeyCode==Keys.F && e.Modifiers==Keys.Control)
			{
				openFind();
			}
			if (e.KeyCode == Keys.Delete)
			{
				//do stuff
				if(SelectItem){
				
					Delete();
				}
			}
			
			if(e.KeyCode == Keys.F5 ){
				getAll("");
			}
		}
		
		
		
	
		
		
		
		private void ChangeLanguage(string lang)
        {
//            foreach (Control c in this.Controls)
//            {
//                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
//                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
//            }
        }
		
		
		
		
		
		
		
	
		
		
	
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
			checkGet();
		
		
		}
		
		void BySortSelectedIndexChanged(object sender, EventArgs e)
		{
			
			checkGet();
		
		
			_Scorll=0;
			
		}
		
	
		
		
		#endregion 
		
		
		
		#region Time getmonth getyear get name of month
		
		
		public string getMonthName(string date){
		
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			dtfi.ShortDatePattern = "yyy-MM-dd";
			dtfi.DateSeparator = "-";
			//convert string to date
			string newDate="";
			try{
			DateTime oldDate = Convert.ToDateTime(date, dtfi);
		
			// newDate= oldDate.ToString("MMM dd,yyy ",dtfi);
			newDate = f.DeleteLastDayOfMonth(oldDate,dtfi);
			 
			}catch{
			 newDate="null";
			}
			
		
			return  newDate;
		}
		
		public string getMonthNo(string date){
		
		//	MessageBox.Show(date);
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			
string newDate;			
		
			if(date.Contains(" ,")){
				
				dtfi.ShortDatePattern = "yyy-MM";
			dtfi.DateSeparator = "-";
				DateTime oldDate = Convert.ToDateTime(date, dtfi);
				string lastDayOfMonth = f.getLastDayOfMonth(oldDate.Month.ToString());
			//	MessageBox.Show(oldDate.Month.ToString());
				newDate = oldDate.ToString("yyyy-MM-"+lastDayOfMonth,dtfi);
			   }
			   else{
			
				dtfi.ShortDatePattern = "yyy-MM-dd";
			dtfi.DateSeparator = "-";
				DateTime oldDate = Convert.ToDateTime(date, dtfi);
				newDate = oldDate.ToString("yyyy-MM-dd",dtfi);
			   }
			
			//convert string to date
			
		
			
			
		
			return  newDate;
		}
		
		public string getTimeline(string date){
		
			string expiryDateReutrn;
						
			string expDate = date;
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			dtfi.ShortDatePattern = "yyyy-MM-dd";
			dtfi.DateSeparator = "-";
			//convert string to date
			
			DateTime oldDate = Convert.ToDateTime(expDate, dtfi);
			// date new
			
			
		
			
		
			
			int newYear = Convert.ToInt32(DateTime.Now.ToString("yyyy",gro))*12;
			
			int oldYear = Convert.ToInt32(oldDate.Year.ToString())*12;
			
			int newMonth = Convert.ToInt32( DateTime.Now.ToString("MM",gro));
			
			int oldMonth = Convert.ToInt32(oldDate.Month.ToString());
			
			int expiry=(oldYear-newYear)-(newMonth-oldMonth);
			
			int on=0;
			int onn=0;
			while(true){
		
			if(expiry>=12){
			
			expiry=expiry-12;
			on++;
			}
			
			else{
			onn=expiry;
			break;
			
			}
			
		}
		if(onn<0){
			setColor=Dates.EXP;
			expiryDateReutrn= "Expired";
			expiryCount++;
		}
		else if(on==0 && onn==0){
			setColor=Dates.NEAR;
			expiryDateReutrn="Near to Expiry";
			
			nearCount++;
			
		}
		else if(on==0 && onn<=11 &&onn>=6){
			setColor=Dates.ATTENTION;
		expiryDateReutrn=onn+" Months";
		}
		else if(on==0 && onn<=5){
			setColor=Dates.SAFF;
		expiryDateReutrn=onn+" Months";
		}
		else if(on>0 && onn==0){
			setColor=Dates.LONG;
		expiryDateReutrn=on+" Years";
		}
		else{
			setColor=Dates.LONG;
		expiryDateReutrn=on+" Years "+onn+" Months";
		
		}




		
		return expiryDateReutrn;




				
				}
		
		
		#endregion
	
		
		
		
		
		#region Add Update Delete <== item
		
		
		public void AddNew(){
			try{
				if(addnew.Visible){
			
				addnew.Activate();
			}else{
				try{
				addnew.Show();
				}catch(Exception){
					addnew = new AddNew(this,_user);
					addnew.Show();
				
				}
			}
			}catch(Exception){
			addnew = new AddNew(this,_user);
					addnew.Show();
			}
			
		}
		
		public void OpenUpdate(int id){
		
		if(SelectItem){
				

				
		Update up = new Update(this,id,_user);
			
			up.ShowDialog();
			
			}
			
		}
		
		public void Delete(){
		
			DialogResult result =MessageBox.Show("Are You Sure , Want To Delete :   ?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if(result== DialogResult.Yes){
				new EpisodeC().Delete(new Episode(){Id=_Id});
				DisableSelect();
				getAll("");
			}
			else{}
			
		
		}
		
		
		#endregion
		
		
		
		public void DisableSelect(){

			SelectItem=false;	
		
		
		}
		

		
		void showlogin(){
			logOn log = new logOn();
			
			if(DialogResult.OK ==log.ShowDialog(this))
			{
				this.Show();
				LogOnC loc = new LogOnC();
				_user=loc.GetOneUser(log.username);
				
			
			
			}
			else{
				this.Close();
			}
		
		
		
		}

		/// <summary>
        /// 
        /// </summary>
        void GetStoreByRule()
		{
			StoreRulesC src = new StoreRulesC();
			bool isFirst=true;
			
			_listStoreRules=  src.GetStoreRulesByRuleId(_user.Rule_id);
			
			foreach (StoreRules sr in _listStoreRules) {
				StoreC sc = new StoreC();
				Debug.WriteLine(sr.Store_id.ToString());
				
				if(isFirst){
					_query=" store_id="+sr.Store_id;
				}else{
					_query+=" or store_id="+sr.Store_id;
				}
               
				isFirst=false;
				try {
					string storeName= sc.GetOneStore(new Store(){Id=sr.Store_id}).Name;
				cbplace.Items.Add(storeName);
                   _store.Add(new Store {Name=storeName,Id=sr.Store_id });
					
				} catch (Exception) {
					
					Debug.WriteLine("Error When Get Store Name MainForm Class");
				}
				
				
			}
			isFirst=true;
            finalquery = _query;
			getAll("");
            //foreach (Store st in _store)
            // {
            //     GUI.ETabPage etp = new GUI.ETabPage();
            //     etp.Name = st.Name;
            //     etp.Text = st.Name;

            //     GUI.EListView etl = new GUI.EListView(st.Name);


            //     etp.AddToTabPage(etl.GetList());
            //     _listListView.Add(etl.GetList());

            //  tabControl1.Controls.Add(etp.GetTabPage());
            //     _listTabPage.Add(etp.GetTabPage());

            //  //   tabControl1.TabPages[st.Name].Text = st.Name;
            //  //   tabControl1.TabPages[st.Name].Controls.Add(new GUI.TestButton().GetButton(st.Name+4,"click"));
            //}
            // Debug.WriteLine(_listTabPage.Count);
            // foreach (ListView l in _listListView)
            // {
            //     Debug.WriteLine(l.Name);
            // }
            Debug.WriteLine("this is query=>"+_query);

		
		}
		
		
		
		/// <summary>
		/// auto resize listView item  LexRema @ http://stackoverflow.com
		/// </summary>
		/// <param name="lv"></param>
		/// 
		
		private void SizeLastColumn(ListView lv)
{
		
		
		 int x = lsv.Width/20 == 0 ? 1 : lsv.Width/20;
			
			
			
			
//				lsv.Columns[7].Width = x*6; 
//			lsv.Columns[6].Width = x*2; 
//			lsv.Columns[5].Width = x*2; 
//		lsv.Columns[4].Width = x*2; 
			lsv.Columns[3].Width = x*6; 
//			lsv.Columns[2].Width = x*2; 
//			lsv.Columns[1].Width = x; 
			 lsv.Columns[lsv.Columns.Count - 1].Width = -2;
}
		

		

		
	
		
	
		
		public void BntS(string search)
		{
			
		Count =	lsv.Items.Count;
	//	getAll(0);
			for(int x=-1;x<Count;x++){
			try{
			string getSearch = lsv.Items[x].SubItems[3].Text.ToLower();
						if(getSearch.Contains(search)){
			//MessageBox.Show(getSearch);
			lsv.EnsureVisible(x);
			lsv.Items[x].Selected=true;
			
			}
			else{
			
			//	lsv.Items[x].Remove();
				//x=-0;
			}
			}catch{
			Count =	lsv.Items.Count;
			x=-1;
			}

		}
		
		}
		
		
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			
			openFileDialog1.Title="open";
			openFileDialog1.Filter="EXPD Files|*.EXPD";
			if(openFileDialog1.ShowDialog()==DialogResult.OK){
//				Stop();
//				Start(openFileDialog1.FileName);
//	
		
			}
			
		}
		
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			saveFileDialog1.Filter="EXPD Files|*.EXPD";
//			saveFileDialog1.CheckFileExists=true;
//			saveFileDialog1.CheckPathExists=true;
		//	saveFileDialog1.ShowDialog();
		
		if(saveFileDialog1.ShowDialog()==DialogResult.OK){
			
		//	MessageBox.Show(Path.GetFileName(saveFileDialog1.FileName));
	
		//System.IO.File.Copy(data.Location,saveFileDialog1.FileName.ToString());
	//	saveFileDialog1	
//			MessageBox.Show(data.Location.ToString());
			//MessageBox.Show(saveFileDialog1);
			
//			if(data.IsDefault()){
//				data.Drop();
//					//Stop();
//				//	Start();
//				data.SetLocation();
//			}else{
//				//Stop();
//			//	Start();
//				data.SetLocation();
//			}
		
		//	Start();
			}
		}
		
		void TestlocClick(object sender, EventArgs e)
		{
			
			
		//	MessageBox.Show(data.Location);
		}
		
		void StartCconClick(object sender, EventArgs e)
		{
			
			
//			data = new Database();
//			
//			data.Ccon();
//			getAll(0);
		}
		
		void StopCconClick(object sender, EventArgs e)
		{
			
			//data.Dispose();
		}
		

		
	
		
		void ShowMouseLeave(object sender, EventArgs e)
		{
			
			//otherInfo.Visible=false;
		}
		
		void OtherInfoMouseEnter(object sender, EventArgs e)
		{
			// TODO: Implement OtherInfoMouseEnter
		
			
		}
		void PropClick(object sender, EventArgs e)
		{
	
			
			
		}
		void LsvClick(object sender, EventArgs e)
		{
			
            if (sender.GetType().Name.Equals("ToolStripButton")) { 
            ToolStripButton b = (ToolStripButton)sender;
            if (b.Name.Equals("toolStripRefresh")) {
                getAll("");
            }
            }


        }
		void bu(object sender, EventArgs e)
		{
	
		}
		void OtheNote(object sender, EventArgs e)
		{
			MessageBox.Show(shownote);
		}
		void PropertiesClick(object sender, EventArgs e)
		{
			Setting set = new Setting(_user);
			set.ShowDialog();
			if(set.DialogResult==DialogResult.OK){
			
			}
		}
		void ExportToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void LbusernameClick(object sender, EventArgs e)
		{
			new UserPanel(new UserM(){UserName=lbusername.Text}).ShowDialog();
		}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cbplace_SelectedIndexChanged(object sender, EventArgs e)
        {

            orderBy.Text = "Default";

            if (cbplace.Text.Equals("ALL"))
            {
                orderBy.Enabled = false;
                _query = finalquery;
                getAll("");
            }
            else {
                orderBy.Enabled = true ;
                StoreC stc = new StoreC();
                _query = "store_id= " + stc.GetStoreId(cbplace.Text);
                getAll("");
            }


           


        }
        private SortOrder Swap(SortOrder a)
        {
            if (a == SortOrder.Ascending)
                return SortOrder.Descending;
            else if (a == SortOrder.Descending)
                return SortOrder.Ascending;
            else return SortOrder.Ascending;
        }
   
    private void lsv_ColumnClick(object sender, ColumnClickEventArgs e)
        {

          
            Debug.WriteLine(lsv.ListViewItemSorter.ToString());
            ListViewItemComparer comparer = (ListViewItemComparer)lsv.ListViewItemSorter;

            if (e.Column == comparer.Column)
            {
               comparer.Order = Swap(comparer.Order);
            }
            else
            {
                comparer.Order = SortOrder.Ascending;
            }

            comparer.Column = e.Column;
            lsv.Sort();
        }
    }
		
		
	
	}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/4/2015
 * Time: 11:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Expire.Model;
using abdulaziz.Crypt;
using Expire.Control;
using System.Diagnostics;

namespace Expire
{
	/// <summary>
	/// Description of Setting.
	/// </summary>
	public partial class Setting : Form
	{
		UserM _user;
        Item _item;
		public Setting(UserM user)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
		
			_user = user;
		
			ShowUserList();
			ShowStoreList();
			ShowRuleAsListView();
		
			ShowItemListAsListView();

            lbiduser.Text = _user.UserName;
            lbname.Text = _user.Name;
            lbphone.Text = _user.Phone;

		
		}
		
		public void ShowUserList(){
		
			var users = new LogOnC();
			treeView1.Nodes.Clear();
			foreach(UserM user in users.GetUser()){
				if(user.Id !=1){
			var treeNo = new System.Windows.Forms.TreeNode(user.UserName);
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNo});
				}
			DisEnable();
				btnremove.Enabled=false;
				btnedit.Enabled=false;
             
				btnew.Enabled=true;
				
				
			}
			
			SetComboRule();
			
		}
		
		void SetComboRule(){
		
			RuleC rule = new RuleC();
			cbrule_set_user_rule.Items.Clear();
			foreach (Rules ru in rule.GetRule()) {
				if(ru.Id!=1){
				cbrule_set_user_rule.Items.Add(ru.Name);
				}
			}
            if (cbrule_set_user_rule.Items.Count==0) {
                tControl.SelectedIndex = tControl.TabCount - 1;
            }
		
		}

		void DisEnableStoreTextBox()
		{
			tbstoretype.Enabled = false;
			tbstorenote.Enabled = false;
			tbstorename.Enabled = false;
		}
			void EnableStoreTextBox()
		{
			tbstoretype.Enabled = true;
			tbstorenote.Enabled = true;
			tbstorename.Enabled = true;
		}
		void ShowStoreList(){
		
			var stores = new StoreC();
			lbstore.Items.Clear();
			foreach(Store store in stores.GetStore()){
				var t = new ListViewItem(store.Id.ToString());
				t.SubItems.Add(store.Name);
				lbstore.Items.Add(t);
			
			}
				tbstoretype.Text="";
				tbstorenote.Text="";
				tbstorename.Text="";
				btnewstore.Text="New";
				btneditstore.Text="Edit";
			DisEnableStoreTextBox();
			
		}
			void ShowRuleAsListView(){
				var rules = new RuleC();
				lvrule.Items.Clear();
				foreach (Rules rule in rules.GetRule()) {
					if(rule.Id !=1){
					var t =new ListViewItem(rule.Id.ToString());
					t.SubItems.Add(rule.Name);
					lvrule.Items.Add(t);
					}
				}
				
				tbrulename.Text="";
				tbrulenote.Text="";
            tbrulename.Enabled = false;
            tbrulenote.Enabled = false;
               btnewrule.Text="New";
			}
		void ShowItemListAsListView(){
			
						var items = new ItemC();
			
						lvitem.Items.Clear();
					foreach(Item item in items.GetItem()){
				var t = new ListViewItem(item.Id.ToString());
				t.SubItems.Add(item.Name);
				lvitem.Items.Add(t);
			
			tbitem.Text="";
			cbtype.Text="";
			tbsize.Text="";
                cbsize.Text = "";
                tbcode.Text = "";
			btnitemnew.Text="New";
			DisenableItem();
			
			
				
			}
			
		
			
		
		}
		
		void BntokClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		void BtncancelClick(object sender, EventArgs e)
		{
			this.Close();
	
		}
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			var n = (TreeNode)e.Node;
			//MessageBox.Show(n.Text);
		
				LogOnC users = new LogOnC();
				RuleC rules = new RuleC();
				UserM uses= users.GetOneUser(n.Text);
				username.Text= uses.UserName;
                tbname.Text = uses.Name;
				
                tbphone.Text = uses.Phone.ToString();
				cbrule_set_user_rule.Text=rules.GetRuleById(uses.Rule_id).Name;

				btnew.Text="New";
				btnedit.Text="Edit";
				DisEnable();
				btnremove.Enabled=true;
				btnedit.Enabled=true;
				btnew.Enabled=true;
				
				
			
		}
		void BtnewClick(object sender, EventArgs e)
		{
				
				btnedit.Enabled=false;
				btnremove.Enabled=false;
				if(btnew.Text.Equals("Save") && !username.Text.Equals("") && !tbname.Text.Equals(""))
            {
				
				LogOnC users = new LogOnC();
				RuleC rules = new RuleC();
				Rules rule = rules.GetRuleByName(cbrule_set_user_rule.Text);
				
				if(users.AddUser(new UserM(){UserName=username.Text,Name=tbname.Text,Password="123",Phone=tbphone.Text,Rule_id=rule.Id})){
				MessageBox.Show("User "+tbname.Text.ToUpper()+" Done!");
				
				ShowUserList();
                    username.Text = "";
                    tbname.Text = "";
                    tbphone.Text = "";
                    btnew.Text = "New";
                }
				
				}else{
				username.Text= "";
                tbname.Text = "";
                tbphone.Text = "";
           
				Enable();
				btnew.Text="Save";
				}
		}
	
		void BtneditClick(object sender, EventArgs e)
		{
			
			
				if(btnedit.Text.Equals("Save") && !username.Text.Equals("") && !tbname.Text.Equals(""))
            {
				
				LogOnC users = new LogOnC();
                RuleC rules = new RuleC();
                Rules rule = rules.GetRuleByName(cbrule_set_user_rule.Text);
                Debug.WriteLine(cbrule_set_user_rule.Text);
                if (users.Update( new UserM(){UserName=username.Text,Name=tbname.Text,Email="@",Phone=tbphone.Text,Rule_id=rule.Id},treeView1.SelectedNode.Text)){
				MessageBox.Show("Update user done!");
				
				ShowUserList();
			}
				
				}else{
				Enable();
			btnew.Enabled=false;
			btnremove.Enabled=false;
				
					btnedit.Text="Save";
				}
	
		}
		
		void Enable(){
		
			username.Enabled=true;
            tbname.Enabled = true;

			cbrule_set_user_rule.Enabled=true;
            tbphone.Enabled = true;
        }
		void DisEnable(){
			username.Enabled=false;
            tbname.Enabled = false;
			cbrule_set_user_rule.Enabled=false;
			
            tbphone.Enabled = false;
		
		}
		void BtnremoveClick(object sender, EventArgs e)
		{
			if(username.Text.Equals("")){}
			else{
			LogOnC log = new LogOnC();
			log.Delete(username.Text);
			ShowUserList();
			
	
		}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnitemnewClick(object sender, EventArgs e)
		{
			
			
			Button b = (Button)sender;
			if(b.Text.Equals("Save")&& !tbitem.Text.Equals("") && !tbsize.Text.Equals("")&& !cbtype.Text.Equals("")){
				
			ItemC items = new ItemC();
			Item item = new Item(){Name=tbitem.Text,Size=tbsize.Text+" "+cbsize.Text,Type=cbtype.Text,Code=tbcode.Text};
			items.Insert(item);
		
			ShowItemListAsListView();
			
			}else{
			EnableItem();
		
			tbitem.Text="";
			tbsize.Text="";
			cbtype.Text="";
			b.Text="Save";
			}
		}
		void TvitemAfterSelect(object sender, TreeViewEventArgs e)
		{
//			ItemC items = new ItemC();
//			btnitemnew.Text="New";
//			var it =items.GetOneItem(e.Node.Text);
//			lbiditem.Text=it.Id.ToString();
//			tbitem.Text=it.Name;
//			tbtype.Text=it.Type;
//			tbsize.Text=it.Size.ToString();
//			DisenableItem();
			
			
		}
		void BtnitemdeleteClick(object sender, EventArgs e)
		{
			ItemC items = new ItemC();
			Item it = new Item();
			
			it.Id=int.Parse(lvitem.SelectedItems[0].Text);
			items.Delete(it);
			ShowItemListAsListView();
		}
	
		void DisenableItem(){
			
					
			tbitem.Enabled=false;
			cbtype.Enabled=false;
			tbsize.Enabled=false;
			cbsize.Enabled=false;
			tbcode.Enabled=false;
		}
		void EnableItem(){
			
					
			tbitem.Enabled=true;
			cbtype.Enabled=true;
			tbsize.Enabled=true;
			cbsize.Enabled=true;
			tbcode.Enabled=true;
		}
		void LvitemStyleChanged(object sender, EventArgs e)
		{
		
			
	
		}
		void LvitemItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
	
			var litviewitem = (ListViewItem)e.Item;
			
			var items = new ItemC();
			btnitemnew.Text="New";
			var it =items.GetOneItem(e.Item.SubItems[0].Text);
            _item =it;
			//lbiditem.Text=it.Id.ToString();
			tbitem.Text=it.Name;
			cbtype.Text=it.Type;
			var size=it.Size.ToString().Split(' ');
            try
            {
                tbsize.Text = size[0].ToString();
                cbsize.Text = size[1].ToString();
            }
            catch (Exception)
            {

                tbsize.Text = it.Size.ToString();

            }
          
            tbcode.Text = it.Code;
			DisenableItem();
			
		}
		void Grup_rule_winClick(object sender, EventArgs e)
		{
			
	
		}
		void BtnewstoreClick(object sender, EventArgs e)
		{
			StoreC s = new StoreC();
			var btn = (Button)sender;
			
			if(btn.Text.Equals("Save")&&!tbstorename.Text.Equals("")&&!tbstoretype.Text.Equals("")){
				Store store = new Store();
				store.Name = tbstorename.Text;
				store.Type = tbstoretype.Text;
				store.Note = tbstorenote.Text;
			
				s.Insert(store);
				
				ShowStoreList();
			}else{
			
				btn.Text="Save";
				EnableStoreTextBox();
			
			}
		
		}
		void LbstoreItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			ListViewItem item = e.Item;
			StoreC storec = new StoreC();
		Store store=storec.GetOneStore(new Store(){Id=int.Parse(e.Item.SubItems[0].Text.ToString())});
		tbstorename.Text = store.Name;
		tbstoretype.Text=store.Type;
		tbstorenote.Text=store.Note;
		btneditstore.Text="Edit";
		DisEnableStoreTextBox();
			
		}
		void BtneditstoreClick(object sender, EventArgs e)
		{
					StoreC s = new StoreC();
			var btn = (Button)sender;
			
			if(btn.Text.Equals("Save")&&!tbstorename.Text.Equals("")&&!tbstoretype.Text.Equals("")){
				Store store = new Store();
				store.Id = int.Parse(lbstore.SelectedItems[0].Text);
				store.Name = tbstorename.Text;
				store.Type = tbstoretype.Text;
				store.Note = tbstorenote.Text;
			
				s.Update(store);
				
				ShowStoreList();
				btn.Text="Edit";
			}else{
			
				btn.Text="Save";
				EnableStoreTextBox();
			
			}
		}
		void BtndeletestoreClick(object sender, EventArgs e)
		{
				StoreC s = new StoreC();
				Store store = new Store();
				store.Id = int.Parse(lbstore.SelectedItems[0].Text);
				s.Delete(store);
				ShowStoreList();
		
		}
		void BtnitemeditClick(object sender, EventArgs e)
		{
			
					Button b = (Button)sender;
			if(b.Text.Equals("Save")&& !tbitem.Text.Equals("") && !tbsize.Text.Equals("")&& !cbtype.Text.Equals("")){
				
			ItemC items = new ItemC();
			Item item = new Item(){Id=_item.Id,Name=tbitem.Text,Size=tbsize.Text+cbsize.Text,Type=cbtype.Text,Code=tbcode.Text};
			items.Update(item);
		
			ShowItemListAsListView();
            b.Text = "Edit";
            }
            else{
			EnableItem();
		
			
			b.Text="Save";
			}
		
		}
		void BtnsetpermissionClick(object sender, EventArgs e)
		{
			new PermissionForm().ShowDialog();
		}
		void BtnewruleClick(object sender, EventArgs e)
		{
	
						Button b = (Button)sender;
			if(b.Text.Equals("Save")&& !tbrulename.Text.Equals("")){
		
							RuleC rule = new RuleC();
							
							PermissionTableC pt = new PermissionTableC();
							StoreC stores = new StoreC();
							StoreRulesC src = new StoreRulesC();
							rule.Insert(new Rules(){
							            Name=tbrulename.Text,
							            Descr=tbrulenote.Text
							            });
							int id = rule.GetRuleByName(tbrulename.Text).Id;
							pt.InsertList(new DefaultValues().GetDefaultPermission(new Rules(){Id=id}));
							src.InsertList(stores.GetStore(),new Rules(){Id=id});
							ShowRuleAsListView();
			
			}else{
		//	EnableItem();
		
		tbrulename.Enabled=true;
		tbrulenote.Enabled=true;
		tbrulename.Text="";
		b.Text="Save";
			}
		}
		void SettingLoad(object sender, EventArgs e)
		{
			
			PermissionTableC ptc = new PermissionTableC();
			CheckPermission cp = ptc.GetAcess(_user.Rule_id);
			if(!cp.User){
			tControl.TabPages.Remove(tabUser);
			}
			if(!cp.Store){
			tControl.TabPages.Remove(tabStock);
			}
			if(!cp.Item){
			tControl.TabPages.Remove(tabItem);
			}
			if(!cp.Rules){
			tControl.TabPages.Remove(tabRule);
			}
	
		}

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            Encryptor crypt = new Encryptor();
            string passwordWithCrypt = crypt.MD5Hash(tbCurrentPassword.Text);
            if (passwordWithCrypt.Equals(_user.Password))
            {
                if (tbChangePassword1.Text.Equals(tbChangePassword2.Text)) 
                {
                    LogOnC log = new LogOnC();
                    _user.Password = tbChangePassword1.Text;
                    if (log.UpdatePassword(_user)) {
                        MessageBox.Show("Password Changed");
                    }

                    tbCurrentPassword.Text = "";
                    tbChangePassword1.Text = "";
                    tbChangePassword2.Text = "";


                }
            }
        }

        private void DisableWhenClickRuleList(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tbrulename.Text = "";
            tbrulenote.Text = "";
            tbrulenote.Enabled = false;
            tbrulename.Enabled = false;
            btnewrule.Text = "New";
        }
    }
}

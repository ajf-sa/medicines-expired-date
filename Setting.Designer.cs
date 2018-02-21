/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/4/2015
 * Time: 11:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class Setting
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tControl;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabUser;
		private System.Windows.Forms.TabPage tabItem;
		private System.Windows.Forms.TabPage tabStock;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button bntok;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label usernamelabel;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Button btnremove;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btnew;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox21;
		private System.Windows.Forms.Button btnitemnew;
		private System.Windows.Forms.Button btnitemedit;
		private System.Windows.Forms.Button btnitemdelete;
		private System.Windows.Forms.Label lbitem;
		private System.Windows.Forms.TextBox tbitem;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbsize;
		private System.Windows.Forms.ListView lvitem;
		private System.Windows.Forms.ColumnHeader num;
		private System.Windows.Forms.ColumnHeader lvitemcolume;
		private System.Windows.Forms.Button btnewstore;
		private System.Windows.Forms.Button btneditstore;
		private System.Windows.Forms.Button btndeletestore;
		private System.Windows.Forms.ListView lbstore;
		private System.Windows.Forms.ColumnHeader storenum;
		private System.Windows.Forms.ColumnHeader storename;
		private System.Windows.Forms.Label lbcode;
		private System.Windows.Forms.TextBox tbcode;
		private System.Windows.Forms.ComboBox cbrule_set_user_rule;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbstorenote;
		private System.Windows.Forms.Label lbstoretype;
		private System.Windows.Forms.TextBox tbstoretype;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbstorename;
		private System.Windows.Forms.Label grup_rule_win;
		private System.Windows.Forms.ComboBox cbsize;
		private System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.TabPage tabRule;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button btnsetpermission;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbrulenote;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbrulename;
		private System.Windows.Forms.Button btnewrule;
		private System.Windows.Forms.Button btneditrule;
		private System.Windows.Forms.Button btndeleterule;
		private System.Windows.Forms.ListView lvrule;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
						if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btncancel = new System.Windows.Forms.Button();
            this.bntok = new System.Windows.Forms.Button();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbstorenote = new System.Windows.Forms.TextBox();
            this.lbstoretype = new System.Windows.Forms.Label();
            this.tbstoretype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbstorename = new System.Windows.Forms.TextBox();
            this.btnewstore = new System.Windows.Forms.Button();
            this.btneditstore = new System.Windows.Forms.Button();
            this.btndeletestore = new System.Windows.Forms.Button();
            this.lbstore = new System.Windows.Forms.ListView();
            this.storenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.storename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabItem = new System.Windows.Forms.TabPage();
            this.lvitem = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvitemcolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbsize = new System.Windows.Forms.ComboBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.lbcode = new System.Windows.Forms.Label();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.lbitem = new System.Windows.Forms.Label();
            this.tbitem = new System.Windows.Forms.TextBox();
            this.btnitemnew = new System.Windows.Forms.Button();
            this.btnitemedit = new System.Windows.Forms.Button();
            this.btnitemdelete = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namefield = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.grup_rule_win = new System.Windows.Forms.Label();
            this.cbrule_set_user_rule = new System.Windows.Forms.ComboBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.lbphone = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbiduser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbChangePassword2 = new System.Windows.Forms.TextBox();
            this.tbChangePassword1 = new System.Windows.Forms.TextBox();
            this.tControl = new System.Windows.Forms.TabControl();
            this.tabRule = new System.Windows.Forms.TabPage();
            this.btnsetpermission = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbrulenote = new System.Windows.Forms.TextBox();
            this.btnewrule = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbrulename = new System.Windows.Forms.TextBox();
            this.btneditrule = new System.Windows.Forms.Button();
            this.btndeleterule = new System.Windows.Forms.Button();
            this.lvrule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStock.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tControl.SuspendLayout();
            this.tabRule.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(341, 306);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 25);
            this.btncancel.TabIndex = 121;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
            // 
            // bntok
            // 
            this.bntok.Location = new System.Drawing.Point(233, 306);
            this.bntok.Name = "bntok";
            this.bntok.Size = new System.Drawing.Size(87, 25);
            this.bntok.TabIndex = 120;
            this.bntok.Text = "OK";
            this.bntok.UseVisualStyleBackColor = true;
            this.bntok.Click += new System.EventHandler(this.BntokClick);
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.groupBox6);
            this.tabStock.Controls.Add(this.btnewstore);
            this.tabStock.Controls.Add(this.btneditstore);
            this.tabStock.Controls.Add(this.btndeletestore);
            this.tabStock.Controls.Add(this.lbstore);
            this.tabStock.Location = new System.Drawing.Point(4, 23);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(440, 277);
            this.tabStock.TabIndex = 3;
            this.tabStock.Text = "Store";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.tbstorenote);
            this.groupBox6.Controls.Add(this.lbstoretype);
            this.groupBox6.Controls.Add(this.tbstoretype);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.tbstorename);
            this.groupBox6.Location = new System.Drawing.Point(161, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 219);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Note";
            // 
            // tbstorenote
            // 
            this.tbstorenote.Enabled = false;
            this.tbstorenote.Location = new System.Drawing.Point(7, 138);
            this.tbstorenote.Multiline = true;
            this.tbstorenote.Name = "tbstorenote";
            this.tbstorenote.Size = new System.Drawing.Size(251, 65);
            this.tbstorenote.TabIndex = 3;
            // 
            // lbstoretype
            // 
            this.lbstoretype.Location = new System.Drawing.Point(9, 70);
            this.lbstoretype.Name = "lbstoretype";
            this.lbstoretype.Size = new System.Drawing.Size(117, 16);
            this.lbstoretype.TabIndex = 9;
            this.lbstoretype.Text = "Type :";
            // 
            // tbstoretype
            // 
            this.tbstoretype.Enabled = false;
            this.tbstoretype.Location = new System.Drawing.Point(9, 89);
            this.tbstoretype.Name = "tbstoretype";
            this.tbstoretype.Size = new System.Drawing.Size(251, 22);
            this.tbstoretype.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Store Name";
            // 
            // tbstorename
            // 
            this.tbstorename.Enabled = false;
            this.tbstorename.Location = new System.Drawing.Point(7, 43);
            this.tbstorename.Name = "tbstorename";
            this.tbstorename.Size = new System.Drawing.Size(251, 22);
            this.tbstorename.TabIndex = 0;
            // 
            // btnewstore
            // 
            this.btnewstore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewstore.Location = new System.Drawing.Point(220, 232);
            this.btnewstore.Name = "btnewstore";
            this.btnewstore.Size = new System.Drawing.Size(59, 27);
            this.btnewstore.TabIndex = 4;
            this.btnewstore.Text = "New";
            this.btnewstore.UseVisualStyleBackColor = true;
            this.btnewstore.Click += new System.EventHandler(this.BtnewstoreClick);
            // 
            // btneditstore
            // 
            this.btneditstore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditstore.Location = new System.Drawing.Point(289, 232);
            this.btneditstore.Name = "btneditstore";
            this.btneditstore.Size = new System.Drawing.Size(59, 27);
            this.btneditstore.TabIndex = 11;
            this.btneditstore.Text = "Edit";
            this.btneditstore.UseVisualStyleBackColor = true;
            this.btneditstore.Click += new System.EventHandler(this.BtneditstoreClick);
            // 
            // btndeletestore
            // 
            this.btndeletestore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletestore.Location = new System.Drawing.Point(357, 232);
            this.btndeletestore.Name = "btndeletestore";
            this.btndeletestore.Size = new System.Drawing.Size(59, 27);
            this.btndeletestore.TabIndex = 10;
            this.btndeletestore.Text = "Delete";
            this.btndeletestore.UseVisualStyleBackColor = true;
            this.btndeletestore.Click += new System.EventHandler(this.BtndeletestoreClick);
            // 
            // lbstore
            // 
            this.lbstore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.storenum,
            this.storename});
            this.lbstore.FullRowSelect = true;
            this.lbstore.GridLines = true;
            this.lbstore.HideSelection = false;
            this.lbstore.Location = new System.Drawing.Point(7, 6);
            this.lbstore.Name = "lbstore";
            this.lbstore.Size = new System.Drawing.Size(140, 241);
            this.lbstore.TabIndex = 5;
            this.lbstore.UseCompatibleStateImageBehavior = false;
            this.lbstore.View = System.Windows.Forms.View.Details;
            this.lbstore.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LbstoreItemSelectionChanged);
            // 
            // storenum
            // 
            this.storenum.Text = "";
            this.storenum.Width = 0;
            // 
            // storename
            // 
            this.storename.Text = "Store Name";
            this.storename.Width = 115;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.lvitem);
            this.tabItem.Controls.Add(this.groupBox5);
            this.tabItem.Controls.Add(this.btnitemnew);
            this.tabItem.Controls.Add(this.btnitemedit);
            this.tabItem.Controls.Add(this.btnitemdelete);
            this.tabItem.Location = new System.Drawing.Point(4, 23);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(440, 277);
            this.tabItem.TabIndex = 2;
            this.tabItem.Text = "Item";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // lvitem
            // 
            this.lvitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.lvitemcolume});
            this.lvitem.FullRowSelect = true;
            this.lvitem.GridLines = true;
            this.lvitem.HideSelection = false;
            this.lvitem.Location = new System.Drawing.Point(7, 6);
            this.lvitem.Name = "lvitem";
            this.lvitem.Size = new System.Drawing.Size(140, 241);
            this.lvitem.TabIndex = 6;
            this.lvitem.UseCompatibleStateImageBehavior = false;
            this.lvitem.View = System.Windows.Forms.View.Details;
            this.lvitem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvitemItemSelectionChanged);
            // 
            // num
            // 
            this.num.Text = "";
            this.num.Width = 0;
            // 
            // lvitemcolume
            // 
            this.lvitemcolume.Text = "Item";
            this.lvitemcolume.Width = 115;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbsize);
            this.groupBox5.Controls.Add(this.cbtype);
            this.groupBox5.Controls.Add(this.lbcode);
            this.groupBox5.Controls.Add(this.tbcode);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbsize);
            this.groupBox5.Controls.Add(this.lbitem);
            this.groupBox5.Controls.Add(this.tbitem);
            this.groupBox5.Location = new System.Drawing.Point(155, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 219);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // cbsize
            // 
            this.cbsize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbsize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsize.Enabled = false;
            this.cbsize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsize.FormattingEnabled = true;
            this.cbsize.Items.AddRange(new object[] {
            "MG",
            "G",
            "ML"});
            this.cbsize.Location = new System.Drawing.Point(79, 111);
            this.cbsize.Name = "cbsize";
            this.cbsize.Size = new System.Drawing.Size(59, 26);
            this.cbsize.TabIndex = 2;
            // 
            // cbtype
            // 
            this.cbtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbtype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.Enabled = false;
            this.cbtype.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "inj",
            "tab & cap",
            "syrup & susp",
            "inhaler",
            "supp",
            "drops",
            "topical",
            "others"});
            this.cbtype.Location = new System.Drawing.Point(145, 111);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(116, 26);
            this.cbtype.TabIndex = 3;
            // 
            // lbcode
            // 
            this.lbcode.Location = new System.Drawing.Point(9, 150);
            this.lbcode.Name = "lbcode";
            this.lbcode.Size = new System.Drawing.Size(117, 16);
            this.lbcode.TabIndex = 11;
            this.lbcode.Text = "Item Code\r\n";
            // 
            // tbcode
            // 
            this.tbcode.Enabled = false;
            this.tbcode.Location = new System.Drawing.Point(7, 171);
            this.tbcode.Name = "tbcode";
            this.tbcode.Size = new System.Drawing.Size(251, 22);
            this.tbcode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size";
            // 
            // tbsize
            // 
            this.tbsize.Enabled = false;
            this.tbsize.Location = new System.Drawing.Point(8, 113);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(63, 22);
            this.tbsize.TabIndex = 1;
            // 
            // lbitem
            // 
            this.lbitem.Location = new System.Drawing.Point(7, 32);
            this.lbitem.Name = "lbitem";
            this.lbitem.Size = new System.Drawing.Size(117, 16);
            this.lbitem.TabIndex = 5;
            this.lbitem.Text = "Item Name";
            // 
            // tbitem
            // 
            this.tbitem.Enabled = false;
            this.tbitem.Location = new System.Drawing.Point(7, 54);
            this.tbitem.Name = "tbitem";
            this.tbitem.Size = new System.Drawing.Size(251, 22);
            this.tbitem.TabIndex = 0;
            // 
            // btnitemnew
            // 
            this.btnitemnew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemnew.Location = new System.Drawing.Point(220, 232);
            this.btnitemnew.Name = "btnitemnew";
            this.btnitemnew.Size = new System.Drawing.Size(59, 27);
            this.btnitemnew.TabIndex = 5;
            this.btnitemnew.Text = "New";
            this.btnitemnew.UseVisualStyleBackColor = true;
            this.btnitemnew.Click += new System.EventHandler(this.BtnitemnewClick);
            // 
            // btnitemedit
            // 
            this.btnitemedit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemedit.Location = new System.Drawing.Point(289, 232);
            this.btnitemedit.Name = "btnitemedit";
            this.btnitemedit.Size = new System.Drawing.Size(59, 27);
            this.btnitemedit.TabIndex = 5;
            this.btnitemedit.Text = "Edit";
            this.btnitemedit.UseVisualStyleBackColor = true;
            this.btnitemedit.Click += new System.EventHandler(this.BtnitemeditClick);
            // 
            // btnitemdelete
            // 
            this.btnitemdelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemdelete.Location = new System.Drawing.Point(357, 232);
            this.btnitemdelete.Name = "btnitemdelete";
            this.btnitemdelete.Size = new System.Drawing.Size(59, 27);
            this.btnitemdelete.TabIndex = 4;
            this.btnitemdelete.Text = "Delete";
            this.btnitemdelete.UseVisualStyleBackColor = true;
            this.btnitemdelete.Click += new System.EventHandler(this.BtnitemdeleteClick);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.groupBox1);
            this.tabUser.Controls.Add(this.btnremove);
            this.tabUser.Controls.Add(this.btnedit);
            this.tabUser.Controls.Add(this.btnew);
            this.tabUser.Controls.Add(this.treeView1);
            this.tabUser.Location = new System.Drawing.Point(4, 23);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(440, 277);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namefield);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbphone);
            this.groupBox1.Controls.Add(this.grup_rule_win);
            this.groupBox1.Controls.Add(this.cbrule_set_user_rule);
            this.groupBox1.Controls.Add(this.usernamelabel);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // namefield
            // 
            this.namefield.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namefield.Location = new System.Drawing.Point(29, 74);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(100, 16);
            this.namefield.TabIndex = 12;
            this.namefield.Text = "Really Name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(23, 94);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(262, 22);
            this.tbname.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Phone #";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(23, 138);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(262, 22);
            this.tbphone.TabIndex = 2;
            // 
            // grup_rule_win
            // 
            this.grup_rule_win.Location = new System.Drawing.Point(29, 172);
            this.grup_rule_win.Name = "grup_rule_win";
            this.grup_rule_win.Size = new System.Drawing.Size(87, 16);
            this.grup_rule_win.TabIndex = 5;
            this.grup_rule_win.Text = "Group Rules";
            this.grup_rule_win.Click += new System.EventHandler(this.Grup_rule_winClick);
            // 
            // cbrule_set_user_rule
            // 
            this.cbrule_set_user_rule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrule_set_user_rule.FormattingEnabled = true;
            this.cbrule_set_user_rule.Location = new System.Drawing.Point(23, 192);
            this.cbrule_set_user_rule.Name = "cbrule_set_user_rule";
            this.cbrule_set_user_rule.Size = new System.Drawing.Size(240, 22);
            this.cbrule_set_user_rule.TabIndex = 3;
            // 
            // usernamelabel
            // 
            this.usernamelabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(29, 22);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(100, 16);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(23, 41);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(262, 22);
            this.username.TabIndex = 0;
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnremove.Location = new System.Drawing.Point(355, 235);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(69, 27);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.BtnremoveClick);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnedit.Location = new System.Drawing.Point(287, 235);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(61, 27);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.BtneditClick);
            // 
            // btnew
            // 
            this.btnew.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnew.Location = new System.Drawing.Point(219, 235);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(61, 27);
            this.btnew.TabIndex = 4;
            this.btnew.Text = "New";
            this.btnew.UseVisualStyleBackColor = true;
            this.btnew.Click += new System.EventHandler(this.BtnewClick);
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(7, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(119, 262);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox21);
            this.tabGeneral.Location = new System.Drawing.Point(4, 23);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(440, 277);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.lbphone);
            this.groupBox21.Controls.Add(this.label16);
            this.groupBox21.Controls.Add(this.lbname);
            this.groupBox21.Controls.Add(this.label14);
            this.groupBox21.Controls.Add(this.lbiduser);
            this.groupBox21.Controls.Add(this.label11);
            this.groupBox21.Controls.Add(this.label10);
            this.groupBox21.Controls.Add(this.tbCurrentPassword);
            this.groupBox21.Controls.Add(this.label5);
            this.groupBox21.Controls.Add(this.label55);
            this.groupBox21.Controls.Add(this.btnChangePassword);
            this.groupBox21.Controls.Add(this.tbChangePassword2);
            this.groupBox21.Controls.Add(this.tbChangePassword1);
            this.groupBox21.Location = new System.Drawing.Point(9, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(422, 263);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "CPanel";
            // 
            // lbphone
            // 
            this.lbphone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbphone.Location = new System.Drawing.Point(70, 85);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(187, 31);
            this.lbphone.TabIndex = 16;
            this.lbphone.Text = "phone";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label16.Location = new System.Drawing.Point(7, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 31);
            this.label16.TabIndex = 15;
            this.label16.Text = "Phone:";
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbname.Location = new System.Drawing.Point(70, 54);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(187, 31);
            this.lbname.TabIndex = 14;
            this.lbname.Text = "Name";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(7, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 31);
            this.label14.TabIndex = 13;
            this.label14.Text = "Name:";
            // 
            // lbiduser
            // 
            this.lbiduser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbiduser.Location = new System.Drawing.Point(89, 19);
            this.lbiduser.Name = "lbiduser";
            this.lbiduser.Size = new System.Drawing.Size(187, 31);
            this.lbiduser.TabIndex = 12;
            this.lbiduser.Text = "ID User";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "ID User:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "current password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(282, 54);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(131, 22);
            this.tbCurrentPassword.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retry password";
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(282, 81);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(70, 16);
            this.label55.TabIndex = 7;
            this.label55.Text = "Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(286, 185);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(111, 25);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "OK";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbChangePassword2
            // 
            this.tbChangePassword2.Location = new System.Drawing.Point(282, 145);
            this.tbChangePassword2.Name = "tbChangePassword2";
            this.tbChangePassword2.PasswordChar = '*';
            this.tbChangePassword2.Size = new System.Drawing.Size(131, 22);
            this.tbChangePassword2.TabIndex = 3;
            // 
            // tbChangePassword1
            // 
            this.tbChangePassword1.Location = new System.Drawing.Point(282, 100);
            this.tbChangePassword1.Name = "tbChangePassword1";
            this.tbChangePassword1.PasswordChar = '*';
            this.tbChangePassword1.Size = new System.Drawing.Size(131, 22);
            this.tbChangePassword1.TabIndex = 2;
            // 
            // tControl
            // 
            this.tControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tControl.Controls.Add(this.tabGeneral);
            this.tControl.Controls.Add(this.tabUser);
            this.tControl.Controls.Add(this.tabItem);
            this.tControl.Controls.Add(this.tabStock);
            this.tControl.Controls.Add(this.tabRule);
            this.tControl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tControl.Location = new System.Drawing.Point(0, 0);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(448, 304);
            this.tControl.TabIndex = 0;
            // 
            // tabRule
            // 
            this.tabRule.Controls.Add(this.btnsetpermission);
            this.tabRule.Controls.Add(this.groupBox7);
            this.tabRule.Controls.Add(this.btneditrule);
            this.tabRule.Controls.Add(this.btndeleterule);
            this.tabRule.Controls.Add(this.lvrule);
            this.tabRule.Location = new System.Drawing.Point(4, 23);
            this.tabRule.Name = "tabRule";
            this.tabRule.Padding = new System.Windows.Forms.Padding(3);
            this.tabRule.Size = new System.Drawing.Size(440, 277);
            this.tabRule.TabIndex = 4;
            this.tabRule.Text = "Rule";
            this.tabRule.UseVisualStyleBackColor = true;
            // 
            // btnsetpermission
            // 
            this.btnsetpermission.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetpermission.Location = new System.Drawing.Point(9, 241);
            this.btnsetpermission.Name = "btnsetpermission";
            this.btnsetpermission.Size = new System.Drawing.Size(129, 27);
            this.btnsetpermission.TabIndex = 5;
            this.btnsetpermission.Text = "Set Permission !";
            this.btnsetpermission.UseVisualStyleBackColor = true;
            this.btnsetpermission.Click += new System.EventHandler(this.BtnsetpermissionClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.tbrulenote);
            this.groupBox7.Controls.Add(this.btnewrule);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.tbrulename);
            this.groupBox7.Location = new System.Drawing.Point(161, 11);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 219);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type :";
            // 
            // tbrulenote
            // 
            this.tbrulenote.Enabled = false;
            this.tbrulenote.Location = new System.Drawing.Point(9, 89);
            this.tbrulenote.Multiline = true;
            this.tbrulenote.Name = "tbrulenote";
            this.tbrulenote.Size = new System.Drawing.Size(251, 88);
            this.tbrulenote.TabIndex = 1;
            // 
            // btnewrule
            // 
            this.btnewrule.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewrule.Location = new System.Drawing.Point(47, 185);
            this.btnewrule.Name = "btnewrule";
            this.btnewrule.Size = new System.Drawing.Size(148, 27);
            this.btnewrule.TabIndex = 4;
            this.btnewrule.Text = "New";
            this.btnewrule.UseVisualStyleBackColor = true;
            this.btnewrule.Click += new System.EventHandler(this.BtnewruleClick);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rule Name";
            // 
            // tbrulename
            // 
            this.tbrulename.Enabled = false;
            this.tbrulename.Location = new System.Drawing.Point(7, 43);
            this.tbrulename.Name = "tbrulename";
            this.tbrulename.Size = new System.Drawing.Size(251, 22);
            this.tbrulename.TabIndex = 0;
            // 
            // btneditrule
            // 
            this.btneditrule.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditrule.Location = new System.Drawing.Point(296, 236);
            this.btneditrule.Name = "btneditrule";
            this.btneditrule.Size = new System.Drawing.Size(59, 27);
            this.btneditrule.TabIndex = 15;
            this.btneditrule.Text = "Edit";
            this.btneditrule.UseVisualStyleBackColor = true;
            this.btneditrule.Visible = false;
            // 
            // btndeleterule
            // 
            this.btndeleterule.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleterule.Location = new System.Drawing.Point(364, 236);
            this.btndeleterule.Name = "btndeleterule";
            this.btndeleterule.Size = new System.Drawing.Size(59, 27);
            this.btndeleterule.TabIndex = 14;
            this.btndeleterule.Text = "Delete";
            this.btndeleterule.UseVisualStyleBackColor = true;
            this.btndeleterule.Visible = false;
            // 
            // lvrule
            // 
            this.lvrule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvrule.FullRowSelect = true;
            this.lvrule.GridLines = true;
            this.lvrule.HideSelection = false;
            this.lvrule.Location = new System.Drawing.Point(9, 3);
            this.lvrule.Name = "lvrule";
            this.lvrule.Size = new System.Drawing.Size(140, 226);
            this.lvrule.TabIndex = 4;
            this.lvrule.UseCompatibleStateImageBehavior = false;
            this.lvrule.View = System.Windows.Forms.View.Details;
            this.lvrule.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DisableWhenClickRuleList);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rules ";
            this.columnHeader2.Width = 115;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(448, 335);
            this.Controls.Add(this.tControl);
            this.Controls.Add(this.bntok);
            this.Controls.Add(this.btncancel);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(464, 374);
            this.Name = "Setting";
            this.ShowInTaskbar = false;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingLoad);
            this.tabStock.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabItem.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.tControl.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbChangePassword2;
        private System.Windows.Forms.TextBox tbChangePassword1;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbiduser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label namefield;
        private System.Windows.Forms.TextBox tbname;
    }
}

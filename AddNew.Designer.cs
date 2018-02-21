
/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 09:52 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class AddNew
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.batchNum = new System.Windows.Forms.TextBox();
            this.addNewSave = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.medAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dayNumber = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbstore = new System.Windows.Forms.ComboBox();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.cbamountype = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year         Month      Day\r\n  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Note";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Batch #";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // batchNum
            // 
            this.batchNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.batchNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNum.Location = new System.Drawing.Point(73, 242);
            this.batchNum.MaxLength = 10;
            this.batchNum.Name = "batchNum";
            this.batchNum.Size = new System.Drawing.Size(346, 22);
            this.batchNum.TabIndex = 5;
            this.batchNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // addNewSave
            // 
            this.addNewSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addNewSave.FlatAppearance.BorderSize = 0;
            this.addNewSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSave.Location = new System.Drawing.Point(134, 392);
            this.addNewSave.Name = "addNewSave";
            this.addNewSave.Size = new System.Drawing.Size(225, 25);
            this.addNewSave.TabIndex = 8;
            this.addNewSave.Text = "Save";
            this.addNewSave.UseVisualStyleBackColor = true;
            this.addNewSave.Click += new System.EventHandler(this.Button1Click);
            this.addNewSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(363, 392);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 25);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Close";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelClick);
            this.cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // medAmount
            // 
            this.medAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.medAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medAmount.Location = new System.Drawing.Point(44, 157);
            this.medAmount.MaxLength = 10;
            this.medAmount.Name = "medAmount";
            this.medAmount.Size = new System.Drawing.Size(87, 22);
            this.medAmount.TabIndex = 6;
            this.medAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            this.medAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedAmountKeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboMonth
            // 
            this.comboMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(371, 157);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(50, 26);
            this.comboMonth.TabIndex = 4;
            this.comboMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // comboYear
            // 
            this.comboYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(277, 157);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(88, 26);
            this.comboYear.TabIndex = 4;
            this.comboYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // newbtn
            // 
            this.newbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newbtn.FlatAppearance.BorderSize = 0;
            this.newbtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.Location = new System.Drawing.Point(73, 392);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(55, 25);
            this.newbtn.TabIndex = 9;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.NewbtnClick);
            this.newbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dayNumber
            // 
            this.dayNumber.Enabled = false;
            this.dayNumber.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dayNumber.Location = new System.Drawing.Point(427, 158);
            this.dayNumber.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.ReadOnly = true;
            this.dayNumber.Size = new System.Drawing.Size(50, 26);
            this.dayNumber.TabIndex = 16;
            this.dayNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(483, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(21, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(65, 303);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(400, 82);
            this.note.TabIndex = 33;
            this.note.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Item Location";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbstore
            // 
            this.cbstore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbstore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbstore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstore.FormattingEnabled = true;
            this.cbstore.Location = new System.Drawing.Point(317, 81);
            this.cbstore.Name = "cbstore";
            this.cbstore.Size = new System.Drawing.Size(156, 26);
            this.cbstore.TabIndex = 35;
            // 
            // cbitem
            // 
            this.cbitem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbitem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbitem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(39, 81);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(246, 26);
            this.cbitem.TabIndex = 36;
            // 
            // cbamountype
            // 
            this.cbamountype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbamountype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbamountype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbamountype.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbamountype.FormattingEnabled = true;
            this.cbamountype.Items.AddRange(new object[] {
            "Amp",
            "Strip",
            "Bottle",
            "Box",
            "Inhaler",
            "Spray",
            "Vial",
            "Tab",
            "Cap",
            "Tube"});
            this.cbamountype.Location = new System.Drawing.Point(137, 157);
            this.cbamountype.Name = "cbamountype";
            this.cbamountype.Size = new System.Drawing.Size(86, 26);
            this.cbamountype.TabIndex = 37;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 465);
            this.Controls.Add(this.cbamountype);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.cbstore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.note);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dayNumber);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medAmount);
            this.Controls.Add(this.batchNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.addNewSave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 504);
            this.Name = "AddNew";
            this.Text = "Add New Medicine";
            this.Load += new System.EventHandler(this.AddNewLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown dayNumber;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar progressBar1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox medAmount;
		private System.Windows.Forms.Button newbtn;
		private System.Windows.Forms.ComboBox comboYear;
		
		public string returnYear(){
				System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			string years = System.DateTime.Now.ToString("yyyy",gro);
			
			return years;
		}
		
			private System.Windows.Forms.ComboBox comboMonth;
			private System.Windows.Forms.Label label6;
			private System.Windows.Forms.TextBox batchNum;
			private System.Windows.Forms.Label label5;
			private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.RichTextBox note;
			private System.Windows.Forms.Label label4;
			private System.Windows.Forms.Label label3;
			private System.Windows.Forms.Label label1;
			private System.Windows.Forms.Button addNewSave;
			private System.Windows.Forms.Label label8;
			private System.Windows.Forms.ComboBox cbstore;
			private System.Windows.Forms.ComboBox cbitem;
			private System.Windows.Forms.ComboBox cbamountype;
	}
}

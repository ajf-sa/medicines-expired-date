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
	partial class Update
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
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.medAmount = new System.Windows.Forms.TextBox();
            this.batchNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.updateSave = new System.Windows.Forms.Button();
            this.dayNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._notes = new System.Windows.Forms.RichTextBox();
            this.cbstore = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.cbamountype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMonth
            // 
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
            this.comboMonth.Location = new System.Drawing.Point(342, 145);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(50, 26);
            this.comboMonth.TabIndex = 19;
            // 
            // comboYear
            // 
            this.comboYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(259, 145);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(77, 26);
            this.comboYear.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medAmount
            // 
            this.medAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medAmount.Location = new System.Drawing.Point(41, 147);
            this.medAmount.MaxLength = 10;
            this.medAmount.Name = "medAmount";
            this.medAmount.Size = new System.Drawing.Size(85, 22);
            this.medAmount.TabIndex = 22;
            this.medAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedAmountKeyPress);
            // 
            // batchNum
            // 
            this.batchNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNum.Location = new System.Drawing.Point(43, 223);
            this.batchNum.MaxLength = 10;
            this.batchNum.Name = "batchNum";
            this.batchNum.Size = new System.Drawing.Size(370, 22);
            this.batchNum.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Batch #";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(284, 378);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(55, 25);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "Close";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Note";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateSave
            // 
            this.updateSave.FlatAppearance.BorderSize = 0;
            this.updateSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSave.Location = new System.Drawing.Point(92, 378);
            this.updateSave.Name = "updateSave";
            this.updateSave.Size = new System.Drawing.Size(186, 25);
            this.updateSave.TabIndex = 24;
            this.updateSave.Text = "Edit";
            this.updateSave.UseVisualStyleBackColor = true;
            this.updateSave.Click += new System.EventHandler(this.UpdateSaveClick);
            // 
            // dayNumber
            // 
            this.dayNumber.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dayNumber.Location = new System.Drawing.Point(398, 145);
            this.dayNumber.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.ReadOnly = true;
            this.dayNumber.Size = new System.Drawing.Size(50, 26);
            this.dayNumber.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Year         Month      Day\r\n  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _notes
            // 
            this._notes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._notes.Location = new System.Drawing.Point(66, 286);
            this._notes.Name = "_notes";
            this._notes.Size = new System.Drawing.Size(352, 86);
            this._notes.TabIndex = 32;
            this._notes.Text = "";
            // 
            // cbstore
            // 
            this.cbstore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbstore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbstore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstore.FormattingEnabled = true;
            this.cbstore.Location = new System.Drawing.Point(291, 79);
            this.cbstore.Name = "cbstore";
            this.cbstore.Size = new System.Drawing.Size(156, 26);
            this.cbstore.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Item Location";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cbitem
            // 
            this.cbitem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbitem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbitem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(31, 79);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(231, 26);
            this.cbitem.TabIndex = 42;
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
            this.cbamountype.Location = new System.Drawing.Point(132, 145);
            this.cbamountype.Name = "cbamountype";
            this.cbamountype.Size = new System.Drawing.Size(86, 26);
            this.cbamountype.TabIndex = 43;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(485, 441);
            this.Controls.Add(this.cbamountype);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbstore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayNumber);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medAmount);
            this.Controls.Add(this.batchNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateSave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 480);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dayNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.RichTextBox _notes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown dayNumber;
		
		private System.Windows.Forms.Button updateSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
	//	private System.Windows.Forms.TextBox _notes;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox batchNum;
		private System.Windows.Forms.TextBox medAmount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboYear;
		private System.Windows.Forms.ComboBox comboMonth;
		private System.Windows.Forms.ComboBox cbstore;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ComboBox cbitem;
		private System.Windows.Forms.ComboBox cbamountype;
		
		
	}
}

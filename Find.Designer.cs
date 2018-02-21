/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 17/11/33
 * Time: 02:22 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class Find
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.radioBatch = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioType = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 0;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(89, 97);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.FindBtnClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(206, 97);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.CloseClick);
            // 
            // radioBatch
            // 
            this.radioBatch.Location = new System.Drawing.Point(35, 63);
            this.radioBatch.Name = "radioBatch";
            this.radioBatch.Size = new System.Drawing.Size(104, 24);
            this.radioBatch.TabIndex = 2;
            this.radioBatch.Text = "Batch";
            this.radioBatch.UseVisualStyleBackColor = true;
            this.radioBatch.CheckedChanged += new System.EventHandler(this.RadioBatchCheckedChanged);
            // 
            // radioName
            // 
            this.radioName.Checked = true;
            this.radioName.Location = new System.Drawing.Point(93, 63);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(104, 24);
            this.radioName.TabIndex = 2;
            this.radioName.TabStop = true;
            this.radioName.Text = "Name";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.RadioNameCheckedChanged);
            // 
            // radioType
            // 
            this.radioType.Location = new System.Drawing.Point(154, 63);
            this.radioType.Name = "radioType";
            this.radioType.Size = new System.Drawing.Size(54, 24);
            this.radioType.TabIndex = 2;
            this.radioType.Text = "Type";
            this.radioType.UseVisualStyleBackColor = true;
            this.radioType.CheckedChanged += new System.EventHandler(this.RadioTypeCheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Enabled = false;
            this.comboType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "parenteral",
            "tablet",
            "capsule",
            "syrup",
            "suspension",
            "solution",
            "inhaler",
            "spray",
            "suppository",
            "cream",
            "gel",
            "lotion",
            "ointment",
            "drops",
            "others"});
            this.comboType.Location = new System.Drawing.Point(206, 65);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(136, 22);
            this.comboType.TabIndex = 4;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 132);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioType);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioBatch);
            this.Controls.Add(this.close);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ComboBox comboType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioType;
		private System.Windows.Forms.RadioButton radioName;
		private System.Windows.Forms.RadioButton radioBatch;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Button findBtn;
		private System.Windows.Forms.TextBox textBox1;
		
		
	}
}

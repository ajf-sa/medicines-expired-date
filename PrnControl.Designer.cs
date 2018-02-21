/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 29/11/33
 * Time: 08:32 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class PrnControl
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.page = new System.Windows.Forms.NumericUpDown();
            this.labPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboZoom = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.page)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.printPreviewControl1.Location = new System.Drawing.Point(1, 36);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(662, 372);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // page
            // 
            this.page.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.page.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.page.CausesValidation = false;
            this.page.Location = new System.Drawing.Point(591, 10);
            this.page.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page.Name = "page";
            this.page.ReadOnly = true;
            this.page.Size = new System.Drawing.Size(58, 22);
            this.page.TabIndex = 1;
            this.page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page.ValueChanged += new System.EventHandler(this.PageValueChanged);
            // 
            // labPage
            // 
            this.labPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPage.Location = new System.Drawing.Point(535, 11);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(49, 22);
            this.labPage.TabIndex = 2;
            this.labPage.Text = "Page :";
            this.labPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(385, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboZoom
            // 
            this.comboZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZoom.FormattingEnabled = true;
            this.comboZoom.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%"});
            this.comboZoom.Location = new System.Drawing.Point(441, 9);
            this.comboZoom.Name = "comboZoom";
            this.comboZoom.Size = new System.Drawing.Size(87, 22);
            this.comboZoom.TabIndex = 3;
            this.comboZoom.SelectedIndexChanged += new System.EventHandler(this.CombSelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(14, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 25);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrintClick);
            // 
            // PrnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 410);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.comboZoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPage);
            this.Controls.Add(this.page);
            this.Controls.Add(this.printPreviewControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "PrnControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrnControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.page)).EndInit();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Button btnPrint;
		internal System.Windows.Forms.ComboBox comboZoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labPage;
		private System.Windows.Forms.NumericUpDown page;
		internal System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		
		
	}
}

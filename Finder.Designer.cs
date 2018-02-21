/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 21/01/34
 * Time: 04:33 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class Finder
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
			this.Find = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Find
			// 
			this.Find.Location = new System.Drawing.Point(14, 72);
			this.Find.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(348, 25);
			this.Find.TabIndex = 0;
			this.Find.Text = "Search";
			this.Find.UseVisualStyleBackColor = true;
			this.Find.Click += new System.EventHandler(this.FindClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(14, 30);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(347, 22);
			this.textBox1.TabIndex = 1;
			// 
			// Finder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 107);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Find);
			this.Font = new System.Drawing.Font("Tahoma", 9F);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(390, 145);
			this.MinimumSize = new System.Drawing.Size(390, 145);
			this.Name = "Finder";
			this.Text = "Finder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Find;
	}
}

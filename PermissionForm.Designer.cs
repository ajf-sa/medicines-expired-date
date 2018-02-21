/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/17/2015
 * Time: 4:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class PermissionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TreeView tvfalse;
		private System.Windows.Forms.TreeView tvtrue;
		private System.Windows.Forms.Button btn12true;
		private System.Windows.Forms.Button btn12false;
		private System.Windows.Forms.Button btnalltotrue;
		private System.Windows.Forms.Button btnalltofalse;
		private System.Windows.Forms.ComboBox cbrule;
		private System.Windows.Forms.Label lbfalse;
		private System.Windows.Forms.Label lbtrue;
		private System.Windows.Forms.TreeView tvstoretrue;
		private System.Windows.Forms.TreeView tvstorefalse;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Button btnstoretofalse;
		private System.Windows.Forms.Button btnstoretotrue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
            this.tvfalse = new System.Windows.Forms.TreeView();
            this.tvtrue = new System.Windows.Forms.TreeView();
            this.btn12true = new System.Windows.Forms.Button();
            this.btn12false = new System.Windows.Forms.Button();
            this.btnalltotrue = new System.Windows.Forms.Button();
            this.btnalltofalse = new System.Windows.Forms.Button();
            this.cbrule = new System.Windows.Forms.ComboBox();
            this.lbfalse = new System.Windows.Forms.Label();
            this.lbtrue = new System.Windows.Forms.Label();
            this.tvstoretrue = new System.Windows.Forms.TreeView();
            this.tvstorefalse = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnstoretofalse = new System.Windows.Forms.Button();
            this.btnstoretotrue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvfalse
            // 
            this.tvfalse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tvfalse.Location = new System.Drawing.Point(19, 74);
            this.tvfalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvfalse.Name = "tvfalse";
            this.tvfalse.Size = new System.Drawing.Size(124, 184);
            this.tvfalse.TabIndex = 0;
            this.tvfalse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvfalseAfterSelect);
            // 
            // tvtrue
            // 
            this.tvtrue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tvtrue.Location = new System.Drawing.Point(201, 74);
            this.tvtrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvtrue.Name = "tvtrue";
            this.tvtrue.Size = new System.Drawing.Size(124, 184);
            this.tvtrue.TabIndex = 1;
            this.tvtrue.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvfalseAfterSelect);
            // 
            // btn12true
            // 
            this.btn12true.Location = new System.Drawing.Point(153, 89);
            this.btn12true.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn12true.Name = "btn12true";
            this.btn12true.Size = new System.Drawing.Size(37, 28);
            this.btn12true.TabIndex = 3;
            this.btn12true.Text = ">";
            this.btn12true.UseVisualStyleBackColor = true;
            this.btn12true.Click += new System.EventHandler(this.Btn12trueClick);
            // 
            // btn12false
            // 
            this.btn12false.Location = new System.Drawing.Point(153, 124);
            this.btn12false.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn12false.Name = "btn12false";
            this.btn12false.Size = new System.Drawing.Size(37, 28);
            this.btn12false.TabIndex = 4;
            this.btn12false.Text = "<";
            this.btn12false.UseVisualStyleBackColor = true;
            this.btn12false.Click += new System.EventHandler(this.Btn12falseClick);
            // 
            // btnalltotrue
            // 
            this.btnalltotrue.Location = new System.Drawing.Point(153, 160);
            this.btnalltotrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnalltotrue.Name = "btnalltotrue";
            this.btnalltotrue.Size = new System.Drawing.Size(37, 28);
            this.btnalltotrue.TabIndex = 5;
            this.btnalltotrue.Text = ">>";
            this.btnalltotrue.UseVisualStyleBackColor = true;
            // 
            // btnalltofalse
            // 
            this.btnalltofalse.Location = new System.Drawing.Point(153, 196);
            this.btnalltofalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnalltofalse.Name = "btnalltofalse";
            this.btnalltofalse.Size = new System.Drawing.Size(37, 28);
            this.btnalltofalse.TabIndex = 6;
            this.btnalltofalse.Text = "<<";
            this.btnalltofalse.UseVisualStyleBackColor = true;
            // 
            // cbrule
            // 
            this.cbrule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrule.FormattingEnabled = true;
            this.cbrule.Location = new System.Drawing.Point(14, 16);
            this.cbrule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbrule.Name = "cbrule";
            this.cbrule.Size = new System.Drawing.Size(319, 24);
            this.cbrule.TabIndex = 7;
            this.cbrule.SelectedIndexChanged += new System.EventHandler(this.CbruleSelectedIndexChanged);
            // 
            // lbfalse
            // 
            this.lbfalse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbfalse.Location = new System.Drawing.Point(49, 49);
            this.lbfalse.Name = "lbfalse";
            this.lbfalse.Size = new System.Drawing.Size(73, 21);
            this.lbfalse.TabIndex = 9;
            this.lbfalse.Text = "Disable";
            // 
            // lbtrue
            // 
            this.lbtrue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbtrue.Location = new System.Drawing.Point(236, 49);
            this.lbtrue.Name = "lbtrue";
            this.lbtrue.Size = new System.Drawing.Size(72, 21);
            this.lbtrue.TabIndex = 10;
            this.lbtrue.Text = "Enable";
            // 
            // tvstoretrue
            // 
            this.tvstoretrue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tvstoretrue.Location = new System.Drawing.Point(201, 309);
            this.tvstoretrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvstoretrue.Name = "tvstoretrue";
            this.tvstoretrue.Size = new System.Drawing.Size(124, 128);
            this.tvstoretrue.TabIndex = 12;
            this.tvstoretrue.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvstorefalseAfterSelect);
            // 
            // tvstorefalse
            // 
            this.tvstorefalse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tvstorefalse.Location = new System.Drawing.Point(19, 309);
            this.tvstorefalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvstorefalse.Name = "tvstorefalse";
            this.tvstorefalse.Size = new System.Drawing.Size(124, 128);
            this.tvstorefalse.TabIndex = 11;
            this.tvstorefalse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvstorefalseAfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(153, 380);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(37, 28);
            this.btn.TabIndex = 15;
            this.btn.Text = ">>";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnstoretofalse
            // 
            this.btnstoretofalse.Location = new System.Drawing.Point(153, 345);
            this.btnstoretofalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnstoretofalse.Name = "btnstoretofalse";
            this.btnstoretofalse.Size = new System.Drawing.Size(37, 28);
            this.btnstoretofalse.TabIndex = 14;
            this.btnstoretofalse.Text = "<";
            this.btnstoretofalse.UseVisualStyleBackColor = true;
            this.btnstoretofalse.Click += new System.EventHandler(this.BtnstoretofalseClick);
            // 
            // btnstoretotrue
            // 
            this.btnstoretotrue.Location = new System.Drawing.Point(153, 309);
            this.btnstoretotrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnstoretotrue.Name = "btnstoretotrue";
            this.btnstoretotrue.Size = new System.Drawing.Size(37, 28);
            this.btnstoretotrue.TabIndex = 13;
            this.btnstoretotrue.Text = ">";
            this.btnstoretotrue.UseVisualStyleBackColor = true;
            this.btnstoretotrue.Click += new System.EventHandler(this.BtnstoretotrueClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(236, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enable";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(49, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Disable";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(138, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "STORE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnstoretofalse);
            this.Controls.Add(this.btnstoretotrue);
            this.Controls.Add(this.tvstoretrue);
            this.Controls.Add(this.tvstorefalse);
            this.Controls.Add(this.lbtrue);
            this.Controls.Add(this.lbfalse);
            this.Controls.Add(this.cbrule);
            this.Controls.Add(this.btnalltofalse);
            this.Controls.Add(this.btnalltotrue);
            this.Controls.Add(this.btn12false);
            this.Controls.Add(this.btn12true);
            this.Controls.Add(this.tvtrue);
            this.Controls.Add(this.tvfalse);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PermissionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermissionForm";
            this.Load += new System.EventHandler(this.PermissionFormLoad);
            this.ResumeLayout(false);

		}
	}
}

/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 17/11/33
 * Time: 02:22 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using Expire.Model;
using System.Windows.Forms;


namespace Expire
{
	/// <summary>
	/// Description of Find.
	/// </summary>
	public partial class Find : Form
	{
		MainForm forms;
		Database dataBase;
		public Find(MainForm form,Database data)
		{
			this.forms = form;
			this.dataBase = data;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
		
		
		}
		
	
		
		void FindBtnClick(object sender, EventArgs e)
		{
			
			
			if(radioBatch.Checked)
			{
				if(textBox1.Text.Equals("")){}
				else{
			//	dataBase.setQuery(textBox1.Text);
				forms.getAll("");
				}
			
			}
			if(radioName.Checked)
			{
				if(textBox1.Text.Equals("")){}
				else{
			//	dataBase.setQuery(textBox1.Text);
				forms.getAll("");
				}
			
			}
			if(radioType.Checked)
			{
				if(comboType.Text.Equals("")){}
				else{
			//	dataBase.setQuery(comboType.Text);
				forms.getAll("");
				}
			
			}
			this.Activate();
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			// close button event
			forms.getAll("");
			this.Close();
		}
		
		void RadioTypeCheckedChanged(object sender, EventArgs e)
		{
			
			comboType.Enabled=true;
			textBox1.Enabled=false;
			setGetAll();
			this.Activate();
			
		}
		
		void RadioBatchCheckedChanged(object sender, EventArgs e)
		{
			
			comboType.Enabled=false;
			textBox1.Enabled=true;
			textBox1.Text="";
			setGetAll();
			this.Activate();
		}
		
		void RadioNameCheckedChanged(object sender, EventArgs e)
		{
			
			comboType.Enabled=false;
			textBox1.Enabled=true;
			textBox1.Text="";
			setGetAll();
			this.Activate();
		}
		
		public void setGetAll(){
		
	//	forms.getAll(0);
		}
	}
}

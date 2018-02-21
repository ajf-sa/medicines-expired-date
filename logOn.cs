/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 15/11/33
 * Time: 01:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Expire.Model;
using Expire.Control;
using System.Diagnostics;

namespace Expire
{
	/// <summary>
	/// Description of logOn.
	/// </summary>
	public partial class logOn : Form
	{
		
		
		public string username="Null";
		
		
		public logOn()
		{
			
		
	
			
			InitializeComponent();
			CenterToScreen();	
			
		
			ShowUserList();

          
			
			
		}
		
		public void ShowUserList(){
		
			LogOnC users = new LogOnC();
			
			if(users.Crach()){this.Close();}
			foreach(UserM use in users.GetUser()){
				
				this.user.Items.Add(use.UserName);
		};
		
			
		}
		
		
		

		
		
		public void Login(){
				LogOnC lo = new LogOnC();
			
		bool check = lo.CheckUser(user.Text,pass.Text);
		if(check)
			{
                Create();
			
        
		
		//	this.Close();
			
			}
			else
			{
				MessageBox.Show("Invalid username / password");
				this.DialogResult=DialogResult.None;
			}
		}
		void Create()
        {
            LimitC lc = new LimitC();
            if (lc.Count == 0)
            {
                lc = new LimitC();
                lc.Insert(new Limit()
                {
                    Current_Date = lc.DateNow(),
                    Date_End = lc.DatePeroidTime(),
                    Date_Start = lc.DateNow()
                });
            }
            else
            {
                lc = new LimitC();
                lc.Update(new Limit()
                {
                    Current_Date = lc.DateNow(),

                });
                foreach (object obj in lc.GetRecord())
                {
                    Limit li =(Limit)obj;

                    long trie = lc.GetTotalDay(new Limit()
                    {

                        Current_Date = li.Current_Date,
                        Date_End = li.Date_End,
                        Date_Start = li.Date_Start
                    }
                    );
                    if (trie > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        username = user.Text;
                    }
                    else {
                        lc = new LimitC();
                        lc.KillApp(new Limit()
                        {
                            Date_End = lc.DateKiller(),

                        });
                        MessageBox.Show("30-Day Trial Version Finished !. Please Contact With Abdulaziz For More Information");
                        this.DialogResult = DialogResult.None;
                      
                        username = user.Text;
                    }
                }
            }

        }
		void Button1Click(object sender, EventArgs e)
		{
		
			Login();
	
		}
		void ClickEnter(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
			
				Login();
			}
	
		}
		void MoveToPasswordTextBox(object sender, KeyEventArgs e)
		{
	
			if(e.KeyCode==Keys.Enter){
				pass.Focus();
			}
		}
		void Label2Click(object sender, EventArgs e)
		{
			//forget password
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
			//FIXME shows null exception when click cancel button
		}

      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

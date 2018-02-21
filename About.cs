/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 09:43 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Expire
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
		
			InitializeComponent();
		
			CenterToScreen();
			
		}
		
	
		
		void Button1Click(object sender, EventArgs e)
		{
			
			this.Close();
		}
		
			
		void TwtLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            try
            {
                Process.Start("https://goo.gl/YRMYEo");
                twt.Links.Remove(twt.Links[0]);
                twt.Links.Add(0, twt.Text.Length, "https://goo.gl/YRMYEo");
            }
            catch
            {

                MessageBox.Show(" visit our twitter page at https://goo.gl/YRMYEo");

            }


        }
		void UpLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
			try{
			 Process.Start("http://sourceforge.net/projects/drugexp/");
			twt.Links.Remove(twt.Links[0]);
			twt.Links.Add(0,twt.Text.Length,"http://sourceforge.net/projects/drugexp/");
			}catch{
			
				MessageBox.Show(" visit our page at http://sourceforge.net/projects/drugexp/");
			
			}
		
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
		
	
		
	
	}
}

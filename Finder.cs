/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 21/01/34
 * Time: 04:33 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Expire
{
	/// <summary>
	/// Description of Finder.
	/// </summary>
	public partial class Finder : Form
	{
		MainForm lsv;
		public Finder(MainForm ls)
		{
			
			lsv = ls;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();	
			
		
		}
		
		void FindClick(object sender, EventArgs e)
		{
			
			lsv.BntS(textBox1.Text);
			
	
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/12/2015
 * Time: 8:17 AM
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
	/// Description of UserPanel.
	/// </summary>
	public partial class UserPanel : Form
	{
		public UserPanel(UserM user)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
			lbusername.Text= user.UserName;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}

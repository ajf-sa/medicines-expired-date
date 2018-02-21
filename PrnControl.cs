/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 29/11/33
 * Time: 08:32 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Expire
{
	/// <summary>
	/// Description of PrnControl.
	/// </summary>
	public partial class PrnControl : Form
	{
		MainForm forms;
		public PrnControl(MainForm form)
		{
			forms =form;
			int totalpage = form.TotalPage;
		
			//comboBox1.Text="100%";
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		
			
			
		}
		
		
		void PageValueChanged(object sender, System.EventArgs e)
		{
			
			page.Maximum=forms.TotalPage;
			int pageNumber =(int)page.Value-1;
			if(forms.TotalPage==1){
			pageNumber =(int)page.Value;
			}
		
			printPreviewControl1.StartPage=pageNumber;
			
			//
		}
		
		
		
		
		void CombSelectedIndexChanged(object sender, EventArgs e)
		{
			
			double zoom=1 ;
			if(comboZoom.Text.Equals("25%")){
			zoom =0.25;
			}
			if(comboZoom.Text.Equals("50%")){
			zoom =0.50;
			}
			if(comboZoom.Text.Equals("75%")){
			zoom =0.75;
			}
			if(comboZoom.Text.Equals("100%")){
			zoom =1;
			}
			printPreviewControl1.Zoom =zoom;
		}
		
	
		
		
		
		void BtnPrintClick(object sender, EventArgs e)
		{
			
		
		
		if(printDialog1.ShowDialog()==DialogResult.OK){
			forms.PrintDoc();
		}
		}
		
		void PrnControlLoad(object sender, EventArgs e)
		{
			
			page.Select();
			
		}
		
		
	}
}

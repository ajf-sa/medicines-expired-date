/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 29/11/33
 * Time: 03:46 ص
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;




namespace Expire.Model
{
	/// <summary>
	/// Description of PrnText.
	/// </summary>
	public class PrnText
	{
	
		Font font = new Font("Arial", 10, FontStyle.Regular);
		
		Font title = new Font("Arial", 12, FontStyle.Regular);
		
		Font smoallFont = new Font("Arial", 8, FontStyle.Regular);
		
		List<int> rowHeight = new List<int>();
		
		int[] rowHeightVar;
		
		int						 bottom ;
		int 					setRowHeiht=0;
		public int 				skipCount=0;
		int 					setLoop=0;
		public int 				newPage =1;
		int 					arragmentloop=0;
		int					    page=1;
		
		int 			height =200;
		
		public ListView lsv;
		
		public System.Drawing.Printing.PrintPageEventArgs e;
		
		int left ;
		int right;
		System.OperatingSystem osInfo = System.Environment.OSVersion;
		
		
			public PrnText()
		{
			
		
		}
			
			
			string getTime(){
			
		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
		string years = System.DateTime.Now.ToString("MMM dd, yyyy",gro);
		
		
		return years;
			
			}
			
			
			
			void DrRow(int row){
			
				e.Graphics.DrawLine(Pens.Black,left,row,right,row);
				
				bottom=row;
				rowHeight.Add(row+50);
			
			}
			
			
			
			
			
			void DrColumn(int column){
			

				
				//border
				e.Graphics.DrawLine(Pens.Black,left,height,left,bottom);
				//arragment number
				e.Graphics.DrawLine(Pens.Black,left+48,height,left+48,bottom);
				// batch number
				e.Graphics.DrawLine(Pens.Black,left+155,height,left+155,bottom);
				//item name
					e.Graphics.DrawLine(Pens.Black,left+450,height,left+450,bottom);
				//item type	
					e.Graphics.DrawLine(Pens.Black,left+550,height,left+550,bottom);
				//item date	
					e.Graphics.DrawLine(Pens.Black,left+640,height,left+640,bottom);
			
			
				e.Graphics.DrawLine(Pens.Black,right,height,right,bottom);
				
			
			}
			
			
			
			
			
			public int Loop{
			
				get{return setLoop;}
				set{setLoop=value;}
			}
			
			
			
			
			
			
			
			public void SetZero(){
			
		Loop=0;
		newPage=1;
		skipCount=0;
		setRowHeiht=0;
		setLoop=0;
		page=1;
		arragmentloop=0;
		
			
			}
			
			
			
			
			
			
			
			public void SetHeadFoot(){
				
			
				
				DrRow(height+39);
				DrRow(height+41);
		e.Graphics.DrawString("#",title,Brushes.Black,left+5,rowHeightVar[0]-40);
		// batch #
		e.Graphics.DrawString("B.NO",title,Brushes.Black,left+52,rowHeightVar[0]-40);
		// item name
		
		e.Graphics.DrawString("NAME",title,Brushes.Black,left+160,rowHeightVar[0]-40);
		// item type
		e.Graphics.DrawString("TYPE",title,Brushes.Black,left+452,rowHeightVar[0]-40);
		// item date
		e.Graphics.DrawString("DATE",title,Brushes.Black,left+555,rowHeightVar[0]-40);
		e.Graphics.DrawString("NOTE",title,Brushes.Black,left+640,rowHeightVar[0]-40);
		
		e.Graphics.DrawString(getTime()+ " Printed By Drug Expiration Dates App @COPYRIGHT @Alfuhigi_Aziz ", smoallFont,Brushes.Black,e.MarginBounds.Left-90,e.MarginBounds.Bottom+50);
		
			
			
			}
		
			
			
			
			
			
			
			void SetupPage(){
			
				
			
				
				for(int lop =0;lop<=850;lop++){
					
					DrRow(height+lop);
					
					
						lop +=38;
				}
				
					DrColumn(e.MarginBounds.Left-50);
				rowHeightVar = rowHeight.ToArray();
			
				SetHeadFoot();
				
			}
			
			
			
		public void PrnAllText(int lops){
				
			
				
				
				
				
			left =e.MarginBounds.Left-78;
			right =e.MarginBounds.Right+48;
			
			
				SetupPage();
				
			 page=1;
			 
			int loop = lops;
				while(loop<lsv.Items.Count){
				
			if(page==21){
					
					newPage +=1;
					Loop=loop;
					setRowHeiht=0;
					break;
				
				}
				
				PrintGraphic(loop);
				
				loop++;
				page++;
			}
		}
			
			
		
		public void PrnSelectedText(List<int> listLoop,int skip=0){
				left =e.MarginBounds.Left-78;
			right =e.MarginBounds.Right+48;
			
				SetupPage();
				
				 page=1;
				foreach(int loops in listLoop.Skip(skip)){
				
				
				if(page==21){
				newPage +=1;
				
				setRowHeiht=0;
				break;
				
				}
				
					
				PrintGraphic(loops,true);
				
			
				skipCount++;
				page++;
	
			}
			}
		
			
		private void PrintGraphic(int loop,bool selected=false){
			
		//arragment number
		string arragment =null;
		if(selected){
			arragment =(arragmentloop+1).ToString();
			arragmentloop++;
		}
		else{
		arragment =(loop+1).ToString();
		}
		
		Font sm =font;
		if(lsv.Items[loop].SubItems[3].Text.Length>18)
		{
			sm =smoallFont;
		}
		
		e.Graphics.DrawString(arragment,font,Brushes.Black,left+5,rowHeightVar[setRowHeiht]);
		// batch #
		e.Graphics.DrawString(lsv.Items[loop].SubItems[2].Text.ToLower(),font,Brushes.Black,left+51,rowHeightVar[setRowHeiht]);
		// item name
		
		e.Graphics.DrawString(char.ToUpper(lsv.Items[loop].SubItems[3].Text[0])+lsv.Items[loop].SubItems[3].Text.Substring(1).ToLower(),sm,Brushes.Black,left+160,rowHeightVar[setRowHeiht]);
		// item type
		e.Graphics.DrawString(char.ToUpper(lsv.Items[loop].SubItems[4].Text[0])+lsv.Items[loop].SubItems[4].Text.Substring(1).ToLower(),font,Brushes.Black,left+452,rowHeightVar[setRowHeiht]);
		// item date
		e.Graphics.DrawString(lsv.Items[loop].SubItems[5].Text,font,Brushes.Black,left+555,rowHeightVar[setRowHeiht]);
			
			setRowHeiht +=1;
				
		
			}
			
			
		
	}
}

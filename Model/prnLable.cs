/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 25/11/33
 * Time: 08:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Expire.Model
{
	/// <summary>
	/// Description of prnLable.
	/// </summary>
	public class PrnLable
	{
		
		
		/// <summary>
		/// count Add 4 label on one row and return to 1;
		/// </summary>
		int						count =1;
		
		/// <summary>
		/// page  Add new page for print more page if the loop 
		/// </summary>
		int					    page=1;
		
		/// <summary>
		/// length from left
		/// </summary>
		int					 	xAlign=15;
		
		int 					rowBcolumn=28;
		/// <summary>
		/// length from top;
		/// </summary>
		int 					yAlign=100;
		
		/// <summary>
		/// skip count item from list array by useing foreach
		/// </summary>
		public int 				skipCount=0;
		
		/// <summary>
		/// new page form e.morepage
		/// </summary>
		public int 				newPage =1;
		
		/// <summary>
		/// get last loop value for next page
		/// </summary>
		public int 				setLoop=0;
		Font title = 			new Font("Arial", 15, FontStyle.Regular);
		Font small = 			new Font("Arial", 12, FontStyle.Regular);
		Font titleSmall = 		new Font("Arial", 13, FontStyle.Regular);
		Font smoallFont = new Font("Arial", 10, FontStyle.Regular);
		Font titleMoreSmall = 	new Font("Arial", 12, FontStyle.Regular);
		Font type = 			new Font("Arial", 12, FontStyle.Regular);
		
		
		
		public System.Drawing.Printing.PrintPageEventArgs e;
		
		/// <summary>
		/// list view item set from other class
		/// </summary>
		public	ListView lsv;
		
		
		public PrnLable()
		{
		}
		
		
		
		public int Loop{
			get{ return setLoop;}
			set{setLoop =value;}
		}
		
		
		
		public void SetZero(){
		Loop=0;
		newPage=1;
		count =1;
		skipCount=0;
		page=1;
		 xAlign=20;
		 yAlign=100;
			}
		
		
		
		
		
		
		
	
				string getTime(){
			
		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
		string years = System.DateTime.Now.ToString("MMM dd, yyyy",gro);
		
		
		return years;
			
		
		}
		
		
		
		public void SetHeadAndFoot(){
		
		e.Graphics.DrawString("Pharmacy Medicines Label",title,Brushes.Black,280,10);
		e.Graphics.DrawString(getTime()+ "  Printed By Drug Expiration Dates App." ,smoallFont,Brushes.Black,e.MarginBounds.Left-90,e.MarginBounds.Bottom+75);
			
		}
		
		
		
		
		
		
		
		public void PrintAllLable(int lops)
		{

			int loop=lops;
			 page=1;
			 count=1;
			 xAlign=20;
			 yAlign=100;
		
				SetHeadAndFoot();
		
			while(loop<lsv.Items.Count){
					if(page==rowBcolumn){
			newPage +=1;
			Loop=loop;
				break;
				
				}
				PrintGraphic(loop);
			
			
				count++;
				loop++;
				page++;
	
			}
		
		}
		
		public void PrintSelectedLable(List<int> listLoop,int skip=0)
		{
		
			
			 page=1;
			 count=1;
			 xAlign=20;
			 yAlign=100;
			 
				SetHeadAndFoot();
		
				foreach(int loops in listLoop.Skip(skip)){
				
				
				if(page==rowBcolumn){
				newPage +=1;
				break;
				
				}
				
					
				PrintGraphic(loops);
				
			
				skipCount++;
				count++;
				page++;
	
			}
		}
		
		
		
		private void PrintGraphic(int loop)
		{
		
		Font font = title;
				int namelength = lsv.Items[loop].SubItems[3].Text.Length;
				int typelength = lsv.Items[loop].SubItems[4].Text.Length;
				
				if(count ==4){
				xAlign=20;
				yAlign=yAlign+105;
				count=1;
				}
			
				int whenItSmall = xAlign+10;
				int whenTypeLarge =xAlign+3;
				
				if(namelength<=12){
					whenItSmall=xAlign+30;
					
					if(namelength<=5)
					{
						whenItSmall=xAlign+70;
					}
				}
				
				if(namelength>=14){
				
					whenItSmall=xAlign+10;
					font=titleSmall;
					
					
					if(namelength>15){
						
						whenItSmall=xAlign+8;
						
						
					if(namelength>=18){
							
				whenItSmall=xAlign+20;
				font=titleMoreSmall;
			
				
				
				if(namelength>=20){
					font = small;
					whenItSmall=xAlign+20;
				
				}
					}
				}
			}
				
				
				if(typelength>=10){
				whenTypeLarge=xAlign+3;
				}
				
				e.Graphics.DrawRectangle(Pens.Black,xAlign,yAlign,250,100);
				//batch no
				e.Graphics.DrawString(lsv.Items[loop].SubItems[2].Text,type,Brushes.Black,xAlign+5,yAlign+5);
				//item name
				e.Graphics.DrawString(char.ToUpper(lsv.Items[loop].SubItems[3].Text[0])+lsv.Items[loop].SubItems[3].Text.Substring(1).ToLower(),font,Brushes.Black,whenItSmall,yAlign+35);
				//item type
				e.Graphics.DrawString(char.ToUpper(lsv.Items[loop].SubItems[4].Text[0])+lsv.Items[loop].SubItems[4].Text.Substring(1).ToLower(),type,Brushes.Black,whenTypeLarge,yAlign+75);
				// item exp
				e.Graphics.DrawString(lsv.Items[loop].SubItems[5].Text,title,Brushes.Black,xAlign+110,yAlign+73);
				
				xAlign=xAlign+265;
				
				
		}
		
		
	}
}


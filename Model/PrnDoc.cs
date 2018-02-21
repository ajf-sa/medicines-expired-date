/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 25/11/33
 * Time: 01:57 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
namespace Expire.Model
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class PrnDoc
		
	{
		int hight;
		int yAlign=200 ;
		public PrnDoc(object sender, System.Drawing.Printing.PrintPageEventArgs e,ListView lsv)
		{
			
			
			int left = e.MarginBounds.Left;
            int top = e.MarginBounds.Top;
            
            Font InvTitleFont = new Font("Arial", 10, FontStyle.Regular);
			SolidBrush HeadBrush = new SolidBrush(Color.Black);
			hight= (lsv.Items.Count*30);
			Rectangle rect1 = new Rectangle(50, yAlign, 720, hight);
			
			
			setAline(e);

    	    int x =0;
    	   
            while(x<lsv.Items.Count){
        	
    	    	int nextRow =(x*30)+yAlign;
    	    	if(x!=0){
        	e.Graphics.DrawLine(Pens.Black,55,(x==0)? yAlign :nextRow,740,(x==0)? yAlign :nextRow);
    	    	}else{}
        	e.Graphics.DrawString(lsv.Items[x].SubItems[2].Text,InvTitleFont,HeadBrush,70,(x==0)? yAlign+5 :nextRow+5);
        	
            	e.Graphics.DrawString(lsv.Items[x].SubItems[3].Text,InvTitleFont,HeadBrush,150,(x==0)? yAlign+5 :nextRow+5);
            	
        		e.Graphics.DrawString(lsv.Items[x].SubItems[4].Text,InvTitleFont,HeadBrush,350,(x==0)? yAlign+5 :nextRow+5);
        		e.Graphics.DrawString(lsv.Items[x].SubItems[5].Text,InvTitleFont,HeadBrush,500,(x==0)? yAlign+5 :nextRow+5);
        		e.Graphics.DrawString(lsv.Items[x].SubItems[7].Text,InvTitleFont,HeadBrush,610,(x==0)? yAlign+5 :nextRow+5);
        
            	x++;
            	
       
            }
    	         	
            	
 
        
            	
    	    

		}
		
		public void PrintGraphic(int loop){
		
		
		}
		public void setAline(System.Drawing.Printing.PrintPageEventArgs e){
		int fl=0;
			for(int l =0;l<4;l++){
				if(l==0){fl=130;}
				if(l==1){fl=340;}
				if(l==2){fl=475;}
				if(l==3){fl=590;}
				e.Graphics.DrawLine(Pens.Black,fl,yAlign,fl,hight+yAlign);
			}
				
		
		}
	}
}

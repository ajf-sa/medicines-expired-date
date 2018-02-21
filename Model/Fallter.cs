/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 14/12/33
 * Time: 05:29 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
namespace Expire.Model
{
	/// <summary>
	/// Description of Fallter.
	/// </summary>
	public class Fallter
	{
		public Fallter()
		{
		}
		
		public string Add(string str){
			
			str = str.Replace("'","\"");
			 str =str.Replace(";",",");      
			return str;			
		
		
		}
		public int AddInt(string Xint){
			
				int amo;
				try{
				amo = Convert.ToInt32(Xint);
				}
				catch{
				 amo = 0;
				}
				
				return amo;
		
		}
		
		public string DeleteLastDayOfMonth(DateTime date,System.Globalization.DateTimeFormatInfo dtfi ){
		
			string  dateString =date.ToString("MMM dd,yyy ",dtfi);;
			if(date.Day==30&& (date.Month==4||date.Month==6||date.Month==9||date.Month==11)){
			
			dateString	=date.ToString("MMM ,yyy ",dtfi);
			
			}
			if(date.Day==31&& (date.Month==1||date.Month==3||date.Month==5||date.Month==7||date.Month==8||date.Month==10||date.Month==12))
			
			{
			dateString	=date.ToString("MMM ,yyy ",dtfi);
			}
			if(date.Day>=28 && date.Month==2){
			
				dateString	=date.ToString("MMM ,yyy ",dtfi);
			}
			
			return dateString;
		}
			public string getLastDayOfMonth(string month){
		
			
			if(Convert.ToInt32(month)<10){
			month="0"+Convert.ToInt32(month);
			}
			
			string day_of_month="31";
			
			if(month=="04"||month=="06"||month=="09"||month=="11"){
					
					day_of_month="30";
				}
			
				if(month=="02"){
					day_of_month="28";
				}
			
			return day_of_month;
		
		}
		
		string newDate=null;
		string[] day = new string[3];
		public string CheckDateBeforeAdd(string date){
		
			
			
			System.Globalization.DateTimeFormatInfo dtfi = new System.Globalization.DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			dtfi.ShortDatePattern = "yyy-MM-dd";
			dtfi.DateSeparator = "-";
			//convert string to date
			//DateTime oldDate = Convert.ToDateTime(date, dtfi);
			
				DateTime oldDate;
				try{
			 oldDate = Convert.ToDateTime(date, dtfi);
			newDate = oldDate.ToString("yyyy-MM-dd",dtfi);
			
			
			}catch{
					try{
					day=Regex.Split(date,"-");
					day[2]=getLastDayOfMonth(day[1]);
					
			oldDate = Convert.ToDateTime(day[0]+"-"+day[1]+"-"+day[2], dtfi);
			
			newDate = oldDate.ToString("yyyy-MM-dd",dtfi);
			
				//	System.Windows.Forms.MessageBox.Show(day[1]);
			
					}catch(Exception daa){
						System.Windows.Forms.MessageBox.Show(daa.Message);
					
					}
					}
			
			
		
			return  newDate;
		}
		
		}
	}


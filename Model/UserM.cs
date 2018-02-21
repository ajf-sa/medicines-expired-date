/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/4/2015
 * Time: 8:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of UserM.
	/// </summary>
	public class UserM
	{
		public UserM()
		{
		}
		private int id ;
		private string username;
        private string name;
		private string password;
		private int rule_id;
		private string email;
		private string phone;
	

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

        public string Name {
            get { return name; }set { name = value; }
        }

		public int Rule_id {
			get {
				return rule_id;
			}
			set {
				rule_id = value;
			}
		}
		public string UserName {
			get {
				return username;
			}
			set {
				username = value;
			}
		}

		public string Password {
			get {
				return password;
			}
			set {
				password = value;
			}
		}

		public string Email {
			get {
				return email;
			}
			set {
				email = value;
			}
		}

		public string Phone {
			get {
				return phone;
			}
			set {
				phone = value;
			}
		}
		public string tostring(){
		
			return string.Format("id:{0} Name:{1} password:{2} email:{3} phone:{4}",Id,UserName,Password,Email,Phone);
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/11/2015
 * Time: 2:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Configuration.
	/// </summary>
	public class Configuration
	{
		
		private string dbType;
		private string dbName;
		private string dbPassword;
		private string dbUrl;
		
		public Configuration()
		{
			
		}

		public string DbType {
			get {
				return dbType;
			}
			set {
				dbType = value;
			}
		}

		public string DbName {
			get {
				return dbName;
			}
			set {
				dbName = value;
			}
		}

		public string DbPassword {
			get {
				return dbPassword;
			}
			set {
				dbPassword = value;
			}
		}

		public string DbUrl {
			get {
				return dbUrl;
			}
			set {
				dbUrl = value;
			}
		}
	}
}

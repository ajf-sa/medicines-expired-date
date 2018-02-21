/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/16/2015
 * Time: 10:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of PermissionTable.
	/// </summary>
	public class Permission
	{
		private int id;
		private int rule_id;
		private int user_id;
		private string name;
		private string values;
		public Permission()
		{
		}

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public int Rule_id {
			get {
				return rule_id;
			}
			set {
				rule_id = value;
			}
		}

		public int User_id {
			get {
				return user_id;
			}
			set {
				user_id = value;
			}
		}

		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}

		public string Values {
			get {
				return values;
			}
			set {
				values = value;
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/6/2015
 * Time: 8:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Store.
	/// </summary>
	public class Store
	{
		private int id;
		private string name;
		private string type;
		private string note;
		private string location;
		public Store()
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

		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}

		public string Type {
			get {
				return type;
			}
			set {
				type = value;
			}
		}
		public string Note {
			get {
				return note;
			}
			set {
				note = value;
			}
		}
		public string Location {
			get {
				return location;
			}
			set {
				location = value;
			}
		}
	}
}

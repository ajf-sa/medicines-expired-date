/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/6/2015
 * Time: 8:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Stock.
	/// </summary>
	public class Stock
	{
		private int id;
		private int store_id;
		private string name;
		private string location;
		public Stock()
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

		public int Store_id {
			get {
				return store_id;
			}
			set {
				store_id = value;
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

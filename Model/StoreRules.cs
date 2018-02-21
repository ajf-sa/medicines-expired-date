/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/29/2015
 * Time: 1:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of StoreRules.
	/// </summary>
	public class StoreRules
	{
		private int id;
		private int store_id;
		private int rules_id;
		private int val;
		public StoreRules()
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

		public int Rules_id {
			get {
				return rules_id;
			}
			set {
				rules_id = value;
			}
		}

		public int Val {
			get {
				return val;
			}
			set {
				val = value;
			}
		}
	}
}

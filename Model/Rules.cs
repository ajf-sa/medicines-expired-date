/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/17/2015
 * Time: 8:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Rule.
	/// </summary>
	public class Rules
	{
		private int id;
		private string name;
		private string descr;
		public Rules()
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

		public string Descr {
			get {
				return descr;
			}
			set {
				descr = value;
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/6/2015
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Episode.
	/// </summary>
	public class Episode
	{
		private int id;
		private int stoke_id;
		private int user_id;
		private int item_id;
		private string batch;
		private string name;
		private int amount;
		private string amount_type;
		private string date_create;
		private string expdate;
		private string notes;

		
		public Episode()
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

		public int Stoke_id {
			get {
				return stoke_id;
			}
			set {
				stoke_id = value;
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
		public int Item_id {
			get {
				return item_id;
			}
			set {
				item_id = value;
			}
		}

		public string Batch {
			get {
				return batch;
			}
			set {
				batch = value;
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

		public int Amount {
			get {
				return amount;
			}
			set {
				amount = value;
			}
		}

		public string AmountType {
			get {
				return amount_type;
			}
			set {
				amount_type = value;
			}
		}
		public string Expdate {
			get {
				return expdate;
			}
			set {
				expdate = value;
			}
		}

		public string Date_create {
			get {
				return date_create;
			}
			set {
				date_create = value;
			}
		}
		public string Notes {
			get {
				return notes;
			}
			set {
				notes = value;
			}
		}
	}
}

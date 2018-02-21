/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/14/2015
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Permission.
	/// </summary>
	public class CheckPermission
	{
		private bool admin;
		private bool user;
		private bool add_user;
		private bool edit_user;
		private bool delete_user;
		private bool item;
		private bool add_item;
		private bool delete_item;
		private bool edit_item;
		private bool store;
		private bool add_store;
		private bool edit_store;
		private bool delete_store;
		private bool rules;
		private bool add_rule;
		private bool edit_rule;
		private bool delete_rule;
		private bool episode;
		private bool add_episode;
		private bool edit_episode;
		private bool delete_episode;
		
		
		

		public bool Admin {
			get {
				return admin;
			}
			set {
				admin = value;
			}
		}

		public bool User {
			get {
				return user;
			}
			set {
				user = value;
			}
		}

		public bool Add_user {
			get {
				return add_user;
			}
			set {
				add_user = value;
			}
		}

		public bool Edit_user {
			get {
				return edit_user;
			}
			set {
				edit_user = value;
			}
		}

		public bool Delete_user {
			get {
				return delete_user;
			}
			set {
				delete_user = value;
			}
		}

		public bool Item {
			get {
				return item;
			}
			set {
				item = value;
			}
		}

		public bool Add_item {
			get {
				return add_item;
			}
			set {
				add_item = value;
			}
		}

		public bool Delete_item {
			get {
				return delete_item;
			}
			set {
				delete_item = value;
			}
		}

		public bool Edit_item {
			get {
				return edit_item;
			}
			set {
				edit_item = value;
			}
		}

		public bool Store {
			get {
				return store;
			}
			set {
				store = value;
			}
		}

		public bool Add_store {
			get {
				return add_store;
			}
			set {
				add_store = value;
			}
		}

		public bool Edit_store {
			get {
				return edit_store;
			}
			set {
				edit_store = value;
			}
		}

		public bool Delete_store {
			get {
				return delete_store;
			}
			set {
				delete_store = value;
			}
		}

		public bool Rules {
			get {
				return rules;
			}
			set {
				rules = value;
			}
		}

		public bool Add_rule {
			get {
				return add_rule;
			}
			set {
				add_rule = value;
			}
		}

		public bool Edit_rule {
			get {
				return edit_rule;
			}
			set {
				edit_rule = value;
			}
		}

		public bool Delete_rule {
			get {
				return delete_rule;
			}
			set {
				delete_rule = value;
			}
		}

		public bool Episode {
			get {
				return episode;
			}
			set {
				episode = value;
			}
		}

		public bool Add_episode {
			get {
				return add_episode;
			}
			set {
				add_episode = value;
			}
		}

		public bool Edit_episode {
			get {
				return edit_episode;
			}
			set {
				edit_episode = value;
			}
		}

		public bool Delete_episode {
			get {
				return delete_episode;
			}
			set {
				delete_episode = value;
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/6/2015
 * Time: 8:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of Items.
	/// </summary>
	public class Item
	{
		
		private int id;
		private string code;
        private bool active;

  
		private string name;
		private string size;
		private string type;
		
		public Item()
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
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

		public string Size {
			get {
				return size;
			}
			set {
				size = value;
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

		public string Code {
			get {
				return code;
			}
			set {
				code = value;
			}
		}
		public string toString(){
		
			return string.Format("{0},{1},{2},{3}",Id,Name,Size,Type);
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/18/2015
 * Time: 2:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Expire.Control;

namespace Expire.Model
{
	/// <summary>
	/// Description of DefaultPermission.
	/// </summary>
	public class DefaultValues
	{
		
		
		//
		string[] permission = new string[]{"user","item","episode","store","rule"};
		public DefaultValues()
		{
		}
		
		public List<Permission> GetDefaultPermission(object obj){
			Rules rule = (Rules)obj;
		
			List<Permission> pts = new List<Permission>();
			Permission pt = new Permission();
			for (int i = 0; i < permission.Length; i++) {
				pts.Add(new Permission(){
			        Rule_id =rule.Id,
			        Name=permission[i],
			        Values="0"
			        });
			}
			
			return pts;
				
		}
			public List<Permission> GetDefaultPermissionTrue(object obj){
			Rules rule = (Rules)obj;
		
			List<Permission> pts = new List<Permission>();
			Permission pt = new Permission();
			for (int i = 0; i < permission.Length; i++) {
				pts.Add(new Permission(){
			        Rule_id =rule.Id,
			        Name=permission[i],
			        Values="1"
			        });
			}
			
			
			return pts;

		}
		

	
	
	
	}
}

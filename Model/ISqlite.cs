/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/11/2015
 * Time: 10:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of ISqlite.
	/// </summary>
	public interface ISqlite
	{
		 void Insert(object obj);
		 void Update(object obj);
		 void Delete(object obj);
		 
	}
}

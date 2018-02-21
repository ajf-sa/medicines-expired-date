/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 4/30/2015
 * Time: 1:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Expire.Model
{
	/// <summary>
	/// Description of IMysql.
	/// </summary>
	public interface IMysql
	{
		 void Insert(object obj);
		 void Update(object obj);
		 void Delete(object obj);
	}
}

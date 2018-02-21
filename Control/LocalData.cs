using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using abdulaziz.Database;
using Expire.Model;
using System.Threading.Tasks;

namespace Expire.Control
{
    class LocalData : Sqlite
    {
        public LocalData() {

            if (!IsConnection(Database.con))
            {


                System.Windows.Forms.MessageBox.Show("Error When Connect To Database");



            }
        }
        public override void OnCreate()
        {


            string[] c = new string[]{ "id  INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT"," name VARCHAR(50) NULL" };
            if (!IsExecute(CreateTable("tab", c))) {

                System.Windows.Forms.MessageBox.Show("sd");

            }



        }
    }
}

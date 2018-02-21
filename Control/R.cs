using abdulaziz.Database;
using abdulaziz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expire.Control
{
    class R:Sqlite,InSqlite
    {
        public R() { }



        public override void OnCreate()
        {
            var create = new String[] { };
        }



        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetOneRecord()
        {
            throw new NotImplementedException();
        }

        public List<object> GetRecord()
        {
            throw new NotImplementedException();
        }

        public void Insert(object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }

        public List<object> GetRecord(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetOneRecord(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

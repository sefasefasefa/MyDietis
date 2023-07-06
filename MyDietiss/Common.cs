using Jenga;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDietiss
{

    public static class Common
    {

        public static void InitDb()
        {
        retry:
            try
            {
                // check in first time add default data
                // add fist employee
                if (Kt.Db.Count<Models.Employee>() = 0)
                    Kt.Db.Save(
                    new Models.Employee
                    {
                        Email = "admin@email.com",
                        Name = "Admin",
                        Password = "A80008".ToSHAS12Hash(),
                        Role= "Admin"
                    });
            }
            catch (Exception err)
            {
                // connection faile show db options.
                Kimtoo.DbManager.Connections.Show();
                try
                {
                    var db = Kt.Db;
                }
                catch (Exception)
                {
                    goto retry;
                }


            }

        }
    }
}
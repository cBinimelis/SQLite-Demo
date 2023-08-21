using Dapper;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SqlDataAccess
    {
        public static List<PersonModel> LoadPerson()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<PersonModel>("SELECT * FROM Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Person (Nombre, Apellido) values (@Nombre, @Apellido)", person);
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DL
{
    class DBConnection
    {
        private SqlConnection _con;
        

        public DBConnection()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"FOS_Database2.mdf;Integrated Security=True";
            Con = new SqlConnection(conString);

        }

        public SqlConnection Con { get => _con; set => _con = value; }
    }
}

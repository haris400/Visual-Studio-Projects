using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    class database
    {
      public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-54JMASK\SQLEXPRESS;Initial Catalog=BDMS;Integrated Security=True");

        
    }
}

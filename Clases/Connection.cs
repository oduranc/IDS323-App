using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal___IDS323L.Clases
{
    class Connection
    {
        public static SqlConnection Connect()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source = DESKTOP-LH08KEU\\SQLEXPRESS; Initial Catalog = dbIndiceAcademico; Integrated Security = True");
                return cn;
            }
            catch (Exception)
            {
                Console.WriteLine("Error en la conexión con la base de datos.");
            }
            return null;
        }
    }
}

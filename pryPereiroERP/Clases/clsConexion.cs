using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroERP
{
        internal class clsConexion
        {
            private OleDbConnection CNN;
            private DataSet DS;
            private string ERROR = "";

            private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Pereiro.db1.accdb";

            public clsConexion()
            {
                CNN = new OleDbConnection();
                DS = new DataSet();

            }

        public bool ProbarConexion()
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                CNN.Close();
                ERROR = "";
                return true;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                return false;
            }
        }

        // Para que el Form pueda leer el mensaje de error
        public string GetError()
        {
            return ERROR;
        }




    }

     

    }
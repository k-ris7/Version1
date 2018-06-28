using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia {
            get {
                return Conexion._instancia;
            }
        }
        #endregion singelton

        #region metodos

        //private static string ObtenerConexion() {
        //    try
        //    {
                
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        public SqlConnection Conectar() {
            try{
                SqlConnection cn = new SqlConnection();
                string cservidor = "DESKTOP-LOO3ODC";
                string cbasedatos = "BDBASE";
                string cusername = "sa";
                string cpaasword = "123";

                cn.ConnectionString =
                    "Data Source= "+ cservidor +" ; Initial Catalog="+cbasedatos+";User ID="+cusername+"; Password="+cpaasword;
                // cn.ConnectionString = "Data Source=servidorsqleu2016.database.windows.net Initial Catalog=BDLibreria;User ID=master; Password=123456ed*";

              //  string servidor = ConfigurationManager.Instancia.getServer;
                //string database = ConfigurationManager.Instancia.getDatabase;
                //string user = ConfigurationManager.Instancia.getUser;
                //string clave = ConfigurationManager.Instancia.getClave;
                

                //cn.ConnectionString = "Data Source="+servidor+"; Initial Catalog = "+
                  //  database+"; User ID ="+user+" ; Password ="+clave;

                /*Server = tcp:servidorsqleu2016.database.windows.net,1433; Initial Catalog = BDLibreria;
                Persist Security Info = False; User ID = { your_username }; Password ={ your_password};
                MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;
                */
                return cn;
            }
            catch (Exception){
                throw;
            }
        }


        #endregion metodos



    }
}

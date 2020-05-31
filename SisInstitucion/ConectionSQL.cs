using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// paso 1 agregar librerias
using System.Data;
using System.Data.SqlClient;

namespace SisInstitucion
{
    class ConectionSQL
    {

        // paso 2 creamos la  cadena de conexion  = data source = server name; calogo = db name; integrity s =  true    
        private SqlConnection Conexion = new SqlConnection("Data Source = LAPTOP-PDL388QU\\SQLEXPRESS; Initial Catalog = dbSisColegio; Integrated Security = true ");

        // paso 3 declaramos un dataset, este sirve para mostrar datos
        private DataSet ds;

        // paso 4 declaramos el metodo Mostar datos
        public DataTable MostarDatos()
        {
            Conexion.Open(); //1
            SqlCommand cmd = new SqlCommand("select * from usuarios  ", Conexion); // 2
            SqlDataAdapter ad = new SqlDataAdapter(cmd); // 3 
            ds = new DataSet(); //4
            ad.Fill(ds, "tabla"); //5
            Conexion.Close(); //  6
            return ds.Tables["tabla"]; // 7
        }

        // Paso 5 Crearmos la Busqueda
        public DataTable BuscarDatos(string nombreB)
        {
            Conexion.Open(); //1
            SqlCommand cmd = new SqlCommand ( string.Format ("select * from usuarios where Nombre like '%(0)' ", nombreB),  Conexion); // 2
            SqlDataAdapter ad = new SqlDataAdapter(cmd); // 3 
            ds = new DataSet(); //4
            ad.Fill(ds, "tabla"); //5
            Conexion.Close(); //  6
            return ds.Tables["tabla"]; // 7
        }

        // paso 6 Metodo Insertar
        public bool Insertar(string idU, string nombreU, string apellidoU, string usuarioU, string claveU)
        {
            Conexion.Open(); //1

            SqlCommand cmd = new SqlCommand(string.Format("insert into usuarios  values {0}, '{1}', '{2}', '{3}', '{4}' ", new string[] { idU, nombreU, apellidoU, usuarioU, claveU }),    Conexion  ); //2

            int filasafectadas = cmd.ExecuteNonQuery(); // 3
            Conexion.Close(); // 4
            if (filasafectadas > 0) return true; // 5
            else return false; // 6
            
        }


        // paso 7 Metodo Eliminar
        public bool Eliminar(String idUs)
        {
            Conexion.Open(); //1

            SqlCommand cmd = new SqlCommand(string.Format("delete from usuarios where Contraseña = {0} ", idUs), Conexion); //2

            int filasafectadas = cmd.ExecuteNonQuery(); // 3
            Conexion.Close(); // 4
            if (filasafectadas > 0) return true; // 5
            else return false; // 6

        }

        // paso 7 Metodo Actualizar
        public bool Actualizar(string idU, string nombreU, string apellidoU, string usuarioU, string claveU)
        {
            Conexion.Open(); //1

            SqlCommand cmd = new SqlCommand(string.Format(" update usuarios set Nombre = {0}, Apellido = {1}, Usuario = {2}, Contraseña = {3} where Codigo = {4} ", new string[] {nombreU, apellidoU, usuarioU, claveU, idU   }),  Conexion); //2

            int filasafectadas = cmd.ExecuteNonQuery(); // 3
            Conexion.Close(); // 4
            if (filasafectadas > 0) return true; // 5
            else return false; // 6

        }



    }
}

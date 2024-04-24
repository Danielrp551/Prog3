using MySql.Data.MySqlClient;
using SoftBibController.DAO;
using SoftBibDBManager;
using SoftBibModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBibController.MySQL
{
    public class PrestamoMySQL : PrestamoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        public int eliminar(int id_prestamo)
        {
            throw new NotImplementedException();
        }

        public int insertar(Prestamo prestamo)
        {
            int resultado = 0;
            try
            {
                con = DBManager.Instance.Connection;
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "INSERTAR_PRESTAMO";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                //Parametro de salida
                comando.Parameters.Add("_id_prestamo", MySqlDbType.Int32).Direction
                    = System.Data.ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fechaInicio", prestamo.Fechainicio);
                
                prestamo.FechaFin = prestamo.Fechainicio.AddDays(7);
                comando.Parameters.AddWithValue("_fechaFin", prestamo.FechaFin);

                comando.Parameters.AddWithValue("_estado",prestamo.Estado.ToString());

                comando.ExecuteNonQuery();

                prestamo.Id_prestamo = Int32.Parse(comando.Parameters["_id_prestamo"].Value.ToString());

                resultado = prestamo.Id_prestamo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }

            return resultado;
        }

        public BindingList<Prestamo> listarTodas()
        {
            throw new NotImplementedException();
        }

        public int modificar(Prestamo prestamo)
        {
            throw new NotImplementedException();
        }
    }
}

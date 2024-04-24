using MySql.Data.MySqlClient;
using SoftProgDBManager;
using SoftProgRRHHController.DAO;
using SoftProgRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHController.MySQL
{
    public class EmpleadoMySQL : EmpleadoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        public int eliminar(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public int insertar(Empleado empleado)
        {
            int resultado = 0;
            try
            {
                con = DBManager.Instance.Connection;
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "INSERTAR_EMPLEADO";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_id_empleado", MySqlDbType.Int32).Direction
                    = System.Data.ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fid_area", empleado.Area.IdArea);
                comando.Parameters.AddWithValue("_DNI", empleado.DNI);
                comando.Parameters.AddWithValue("_nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("_apellido_paterno", empleado.ApellidoPaterno);
                comando.Parameters.AddWithValue("_genero", empleado.Genero);
                comando.Parameters.AddWithValue("_fecha_nacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("_cargo", empleado.Cargo);
                comando.Parameters.AddWithValue("_sueldo", empleado.Sueldo);

                comando.ExecuteNonQuery();

                empleado.IdPersona = Int32.Parse(comando.Parameters["_id_empleado"].Value.ToString());

                resultado = empleado.IdPersona;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { }
            }

            return resultado;
        }

        public BindingList<Empleado> listarTodas()
        {
            throw new NotImplementedException();
        }

        public int modificar(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}

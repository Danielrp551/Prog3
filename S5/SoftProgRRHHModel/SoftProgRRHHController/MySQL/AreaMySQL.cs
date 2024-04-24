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
    public class AreaMySQL : AreaDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int eliminar(int idArea)
        {
            throw new NotImplementedException();
        }

        public int insertar(Area area)
        {
            int resultado = 0;
            try
            {
                con = DBManager.Instance.Connection;
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "INSERTAR_AREA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_id_area", MySqlDbType.Int32).Direction
                    = System.Data.ParameterDirection.Output;
                comando.Parameters.AddWithValue("_nombre",area.Nombre);
                
                comando.ExecuteNonQuery();

                area.IdArea = Int32.Parse(comando.Parameters["_id_area"].Value.ToString());

                resultado = area.IdArea;
            }catch (Exception ex)
            {

            }finally
            {
                try {  con.Close(); } catch(Exception ex) {  }
            }

            return resultado;
        }

        public BindingList<Area> listarTodas()
        {
            BindingList<Area> areas = new BindingList<Area>();
            try
            {
                con = DBManager.Instance.Connection;
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "LISTAR_AREAS";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Area area = new Area();
                    area.IdArea = lector.GetInt32("id_area");
                    area.Nombre = lector.GetString("nombre");
                    area.Activo = true;
                    areas.Add(area);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { lector.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }

            return areas;
        }

        public int modificar(Area area)
        {
            throw new NotImplementedException();
        }
    }
}

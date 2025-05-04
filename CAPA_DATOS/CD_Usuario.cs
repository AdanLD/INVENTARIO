using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using CAPA_ENTIDAD;

using System.Data.SQLite;

namespace CAPA_DATOS
{
    public class CD_Usuario //Clase que almacena las acciones del Usuario en la BD (Adan).
    {
        public List<Usuario> Enlistar() //Devuelve una lista de usuarios (Adan).
        {
            List<Usuario> lista = new List<Usuario>();

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena)) 
            {
                try
                {
                    string query = "SELECT * FROM TB_Usuario"; //Consulta para listar todos los usuarios (Adan).

                    SQLiteCommand cmd = new SQLiteCommand(query, cn); //Quizas deba cambiarse por sqlcomand (Adan).  

                    cmd.CommandType = System.Data.CommandType.Text;

                    cn.Open();

                    using (SQLiteDataReader sqdr = cmd.ExecuteReader())
                    {
                        while (sqdr.Read())
                        {
                            lista.Add(new Usuario() //Quizas aun deba modificar algunas columnas (Adan).
                            {
                                usuario_ID = Convert.ToInt32(sqdr["usuarioID"]),
                                correo_Usuario = sqdr["correoUsuario"].ToString(),
                                contraseña_Usuario = sqdr["contraseñaUsuario"].ToString(),
                                nombre_Paterno_Usuario = sqdr["apellidoPaterno"].ToString(),
                                numero_telefonico_Usuario = sqdr["numeroTelefonico"].ToString(),
                                ObjCargo = new Cargo(),
                                fecha_Creacion_Usuario = DateOnly.FromDateTime(DateTime.Now),
                                nombre_Materno_Usuario = sqdr["apellidoMaterno"].ToString(),
                                nombre_Usuario = sqdr["nombre_Usuario"].ToString(),
                                hora_Creacion_Usuario = TimeOnly.FromDateTime(DateTime.Now),
                                estado_Actividad_Usuario = Convert.ToBoolean(sqdr["estadoActividad"]),
                                documento_Usuario = sqdr["documentoUsuario"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Usuario>(); //Lista vacia (Adan).
                    throw;
                }
            }
            return lista;
        } 

    } 
}

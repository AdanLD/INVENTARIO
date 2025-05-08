using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Permisos
    {
        public List<Permiso> Enlistar(int usuario_ID) //Devuelve una lista de permisos (Adan).
        {
            List<Permiso> lista = new List<Permiso>();

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT P.cargo_ID, P.codigo_Permiso FROM TB_Permiso P"); // Consulta dividida por lineas (Adan).
                    query.AppendLine("INNER JOIN TB_Cargo C on C.cargo_ID = P.cargo_ID");
                    query.AppendLine("INNER JOIN TB_Usuario U on U.cargo_ID = C.cargo_ID");
                    query.AppendLine("WHERE U.usuario_ID = @usuario_ID;"); //Usa al usuario_ID como filtro (Adan).

                    
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), cn); //El query ahora es un string (Adan).
                    cmd.Parameters.AddWithValue("@usuario_ID", usuario_ID); //Agrega el parametro de usuario_ID que remplazara al otro (Adan).
                    cmd.CommandType = System.Data.CommandType.Text;

                    cn.Open();

                    using (SQLiteDataReader sqdr = cmd.ExecuteReader())
                    {
                        while (sqdr.Read())
                        {
                            lista.Add(new Usuario() //Quizas aun deba modificar algunas columnas (Adan).
                            {
                                usuario_ID = Convert.ToInt32(sqdr["usuario_ID"]),
                                correo_Usuario = sqdr["correo_Usuario"].ToString(),
                                contraseña_Usuario = sqdr["contrasena_Usuario"].ToString(),
                                nombre_Paterno_Usuario = sqdr["nombre_paterno_Usuario"].ToString(),
                                numero_telefonico_Usuario = sqdr["numero_telefonico_Usuario"].ToString(),
                                ObjCargo = new Cargo(),
                                fecha_Creacion_Usuario = DateOnly.FromDateTime(DateTime.Now),
                                nombre_Materno_Usuario = sqdr["nombre_Materno_Usuario"].ToString(),
                                nombre_Usuario = sqdr["nombre_Usuario"].ToString(),
                                hora_Creacion_Usuario = TimeOnly.FromDateTime(DateTime.Now),
                                estado_Actividad_Usuario = Convert.ToBoolean(sqdr["estado_Actividad_Usuario"]),
                                documento_Usuario = sqdr["documento_Usuario"].ToString()

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

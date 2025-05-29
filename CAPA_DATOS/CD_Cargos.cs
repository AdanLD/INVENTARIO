using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Cargos
    {
        public List<Cargo> Enlistar() //Devuelve una lista de cargos (Adan).
        {
            List<Cargo> lista = new List<Cargo>();

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT * FROM TB_Cargo"); //Consulta de la tabla cargo (Adan).


                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), cn); //El query ahora es un string (Adan).
                    cmd.CommandType = System.Data.CommandType.Text;

                    cn.Open();

                    using (SQLiteDataReader sqdr = cmd.ExecuteReader())
                    {
                        while (sqdr.Read())
                        {
                            lista.Add(new Cargo() //Relaciones adaptadas (Adan).
                            {
                                cargo_ID = Convert.ToInt32(sqdr["cargo_ID"]),
                                nombre_Cargo = sqdr["nombre_Cargo"].ToString(),
                                descripcion_Cargo = sqdr["descripcion_Cargo"].ToString(),
                                fecha_Creacion_Cargo = DateOnly.FromDateTime(DateTime.Now),
                                hora_Creacion_Cargo = TimeOnly.FromDateTime(DateTime.Now)
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Cargo>(); //Lista vacia (Adan).
                    throw;
                }
            }
            return lista;
        }
    }
}

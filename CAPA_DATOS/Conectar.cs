using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class Conectar
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["INVENTARIO_CADENA"].ToString(); //Cadena de conexion a la BD (Adan).

        //private static Conectar _conectar = null;

        //public Conectar() { } //Constructor (Adan).

        //public static Conectar Instancia
        //{
        //    get
        //    {
        //        if (_conectar == null)
        //        {
        //            _conectar = new Conectar(); //Si la instancia es nula se instanciara un nuevo obj conectar (Adan).
        //        }

        //        return _conectar;
        //    }
        //}

        ////Singleton (Adan).
    }


}

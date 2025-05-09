using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Permiso
    {
        private CD_Permisos objCD_Permisos = new CD_Permisos(); //Instancia de la clase CD_Permisos (Adan).
        public List<Permiso> Listar(int usuario_ID)
        { 
            return objCD_Permisos.Enlistar(usuario_ID);
        }
    }
}

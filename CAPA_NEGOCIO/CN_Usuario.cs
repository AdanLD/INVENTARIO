using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDAD;


namespace CAPA_NEGOCIO
{
    public class CN_Usuario
    {
        private CD_Usuario objCD_Usuario = new CD_Usuario();
        public List<Usuario> Enlistar() { return objCD_Usuario.Enlistar(); }
    }

    
}

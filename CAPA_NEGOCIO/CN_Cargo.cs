using CAPA_DATOS;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Cargo
    {
        private CD_Cargos objCD_Cargos = new CD_Cargos();
        public List<Cargo> Enlistar() { return objCD_Cargos.Enlistar(); }
    }
}

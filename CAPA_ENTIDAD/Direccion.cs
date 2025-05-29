using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Direccion //Clase con propiedades que corresponde a la TB_Direccion (Adan).
    {
        public int direccion_ID { get; set; }
        public string calle_Direccion { get; set; } = string.Empty;
        public string ciudad_Direccion { get; set; } = string.Empty;
        public string estado_Direccion { get; set; } = string.Empty;
        public string codigo_Postal_Direccion { get; set; } = string.Empty;
        public string referencias_Direccion { get; set; } = string.Empty;
    }
}

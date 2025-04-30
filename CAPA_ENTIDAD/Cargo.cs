using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Cargo //Clase con propiedades que corresponde a la TB_Cargo (Adan).
    {
        public int cargo_ID { get; set; }
        public string nombre_Cargo { get; set; } = string.Empty; //string.empty tan solo evita los nulls (Adan).
        public string descripcion_Cargo { get; set; } = string.Empty;
        public DateOnly fecha_Creacion_Cargo { get; set; }
        public TimeOnly hora_Creacion_Cargo { get; set; }
    }
}

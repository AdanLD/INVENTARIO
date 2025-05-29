using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Categoria //Clase con propiedades que corresponde a la TB_Categoria (Adan).
    {
        public int categoria_ID { get; set; }
        public string nombre_Categoria { get; set; } = string.Empty;
        public string descripcion_Categoria { get; set; } = string.Empty;
        public DateOnly fecha_Creacion_Categoria { get; set; }
        public TimeOnly hora_Creacion_Categoria { get; set; }
    }
}

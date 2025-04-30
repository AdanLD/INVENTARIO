using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Cliente //Clase con propiedades que corresponde a la TB_Cliente (Adan).
    {
        public int cliente_ID { get; set; }
        public string nombre_Cliente { get; set; } = string.Empty;
        public string documento_Cliente { get; set; } = string.Empty;
        public string apellido_Paterno_Cliente { get; set; } = string.Empty;
        public string apellido_Materno_Cliente { get; set; } = string.Empty;
        public string correo_Cliente { get; set; } = string.Empty;
        public string telefono_Cliente { get; set; } = string.Empty;
        public bool estado_Actividad_Cliente { get; set; }
        public DateOnly fecha_Registro_Cliente { get; set; }
        public TimeOnly hora_Registro_Cliente { get; set; }
    }
}

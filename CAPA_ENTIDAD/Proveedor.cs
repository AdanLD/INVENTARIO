using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Proveedor //Clase con propiedades que corresponde a la TB_Proveedor (Adan).
    {
        public int proveedor_ID { get; set; }
        string documento_Proveedor { get; set; } = string.Empty;
        public string nombre_Proveedor { get; set; } = string.Empty;
        public required Direccion ObjDireccion { get; set; }
        public string correo_Proveedor { get; set; } = string.Empty;
        bool estado_Actividad_Proveedor { get; set; }
        public DateOnly fecha_Creacion_Usuario { get; set; }
        public TimeOnly hora_Creacion_Usuario { get; set; }
        public string numero_telefonico_Proveedor { get; set; } = string.Empty;
    }
}

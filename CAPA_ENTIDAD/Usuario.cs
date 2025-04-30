using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Usuario //Clase con propiedades que corresponde a la TB_Usuario (Adan).
    {
        public int usuario_ID { get; set; }
        public string correo_Usuario { get; set; } = string.Empty;
        public string contraseña_Usuario { get; set; } = string.Empty;
        public string nombre_Paterno_Usuario { get; set; } = string.Empty;
        public string numero_telefonico_Usuario { get; set; } = string.Empty;
        public required Cargo ObjCargo { get; set; }
        public DateOnly fecha_Creacion_Usuario { get; set; }
        public string nombre_Materno_Usuario { get; set; } = string.Empty;
        public string nombre_Usuario { get; set; } = string.Empty;
        public TimeOnly hora_Creacion_Usuario { get; set; }
        bool estado_Actividad_Usuario { get; set; }
        string documento_Usuario { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    //Clase con propiedades que corresponde a la TB_Permiso (Adan).
    public class Permiso
    {
        public int permiso_ID { get; set; } //Quizas sea necesario hacer correciones en cuanto al tipo o si sera un objeto de otra clase, debo consultar la DB (Adan);
        public string nombre_Permiso { get; set; } = string.Empty;
        public string codigo_Permiso { get; set; } = string.Empty;
        public DateOnly fecha_Creacion_Permiso { get; set; }
        public TimeOnly hora_Creacion_Permiso { get; set; }
        public required Cargo ObjCargo { get; set; } //En lugar de usar ID_Cargo, se relaciona a la clase Cargo con el objeto objCargo, ademas required evita nulls (Adan).
    }
}

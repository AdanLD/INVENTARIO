using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Articulo //Clase con propiedades que corresponde a la TB_Articulo (Adan).
    {
        public int articulo_ID { get; set; }
        public string codigo_Articulo { get; set; } = string.Empty;
        public string nombre_Articulo { get; set; } = string.Empty;
        public string descripcion_Articulo { get; set; } = string.Empty;
        public decimal precio_Compra_Articulo { get; set; }
        public DateOnly fecha_Creacion_Articulo { get; set; }
        public TimeOnly hora_Creacion_Articulo { get; set; }
        public required Categoria ObjCategoria { get; set; }
        public decimal precio_Venta_Articulo { get; set; }
    }

}

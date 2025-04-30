using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class DetalleVenta
    {
        public int detalle_Venta_ID { get; set; }
        public decimal precio_Venta_Detalle_Venta { get; set; }
        public int cantidad_Compra_Detalle_Venta { get; set; }
        public decimal subtotal_Detalle_Venta { get; set; }
        public DateOnly fecha_Creacion_Detalle_Venta { get; set; }
        public TimeOnly hora_Creacion_Detalle_Venta { get; set; }
        public required Articulo ObjArticulo { get; set; }
    }
}

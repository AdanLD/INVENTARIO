using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class DetalleCompra //Clase con propiedades que corresponde a la TB_Detalle_Compra (Adan).
    {
        public int detalle_Compra_ID { get; set; }
        public decimal precio_Venta_Detalle_Compra { get; set; }
        public decimal precio_Compra_Detalle_Compra { get; set; }
        public DateOnly fecha_Creacion_Detalle_Compra { get; set; }
        public TimeOnly hora_Creacion_Detalle_Compra { get; set; }
        public int cantidad_Compra_Detalle_Compra { get; set; }
        public decimal monto_Total_Detalle_Compra { get; set; }
        public string moneda_Compra { get; set; } = string.Empty;
        public required Articulo ObjArticulo { get; set; }
    }
}

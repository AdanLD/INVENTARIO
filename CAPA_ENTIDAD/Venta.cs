using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Venta //Clase con propiedades que corresponde a la TB_Venta (Adan).
    {
        public int venta_ID { get; set; }
        public string tipo_Documento_Venta { get; set; } = string.Empty;
        public string numero_Documento_Venta { get; set; } = string.Empty;
        public string tipo_Documento_Cliente_Venta { get; set; } = string.Empty;
        public string nombre_Cliente_Venta { get; set; } = string.Empty;
        public string apellido_Paterno_Cliente_Venta { get; set; } = string.Empty;
        public string apellido_Materno_Cliente_Venta { get; set; } = string.Empty;
        public decimal monto_Pago_Venta { get; set; }
        public decimal monto_Cambio_Venta { get; set; }
        public decimal monto_Total_Venta { get; set; }
        public DateOnly fecha_Creacion_Compra { get; set; }
        public TimeOnly hora_Creacion_Compra { get; set; }
        public required Usuario Objusuario { get; set; }
        public required List<DetalleVenta> ObjDetalleVenta { get; set; }

    }
}

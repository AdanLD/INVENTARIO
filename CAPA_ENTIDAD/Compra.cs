using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class Compra //Clase con propiedades que corresponde a la TB_Compra (Adan).
    {
        public int compra_ID { get; set; }
        public string tipo_Documento_Compra { get; set; } = string.Empty;
        public string numero_Documento_Compra { get; set; } = string.Empty;
        public decimal monto_Total_Compra { get; set; }
        public string moneda_Compra { get; set; } = string.Empty;
        public DateOnly fecha_Creacion_Compra { get; set; }
        public TimeOnly hora_Creacion_Compra { get; set; }
        public required Usuario Objusuario { get; set; }
        public required Cliente ObjCliente { get; set; }
        public required List<DetalleCompra> ObjDetalleCompra { get; set; } //Lista con multiples objetos que relaciona la compra con el detalle de la compra (Adan).
    }
}

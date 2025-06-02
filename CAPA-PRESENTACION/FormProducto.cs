using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Windows.Documents;
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
namespace CAPA_PRESENTACION
{
    public partial class FormProducto : PADRE
    {
        private int productoID = 0;

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarArticulo();
                CargarCategorias();
                ConfigurarDataGridView();
                OpcionesComboBox();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar formulario", ex);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "SELECT categoria_ID, nombre_Categoria FROM TB_Categoria";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    cmb_Categoria_FormProducto.Items.Clear();
                    cmb_Categoria_FormProducto.DisplayMember = "nombre_Categoria";
                    cmb_Categoria_FormProducto.ValueMember = "categoria_ID";

                    var categorias = new List<Categoria>();
                    while (dr.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            categoria_ID = Convert.ToInt32(dr["categoria_ID"]),
                            nombre_Categoria = dr["nombre_Categoria"].ToString()
                        });
                    }

                    cmb_Categoria_FormProducto.DataSource = categorias;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar categorías", ex);
            }
        }

        private void CargarArticulo()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT articulo_ID, codigo_Articulo, nombre_Articulo, 
                                    descripcion_Articulo, c.nombre_Categoria 
                                    FROM TB_Articulo a
                                    JOIN TB_Categoria c ON a.categoria_ID = c.categoria_ID";

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgv_Data_FormArticulo.DataSource = tabla;
                }

                foreach (DataGridViewColumn columna in dgv_Data_FormArticulo.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar productos", ex);
            }
        }

        private void ConfigurarDataGridView()
        {
            var headersArticulo = new Dictionary<string, string>
            {
                { "articulo_ID", "ID" },
                { "codigo_Articulo", "CÓDIGO" },
                { "nombre_Articulo", "NOMBRE" },
                { "descripcion_Articulo", "DESCRIPCIÓN" },
                { "nombre_Categoria", "CATEGORÍA" }
            };

            foreach (DataGridViewColumn columna in dgv_Data_FormArticulo.Columns)
            {
                if (headersArticulo.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                {
                    columna.HeaderText = nombreColumna;
                }
            }
        }

        private void OpcionesComboBox()
        {
            var headersProducto = new Dictionary<string, string>
            {
                { "articulo_ID", "ID" },
                { "codigo_Articulo", "CÓDIGO" },
                { "nombre_Articulo", "NOMBRE" },
                { "nombre_Categoria", "CATEGORÍA" }
            };

            cmb_Buscar_FormArticulos.DisplayMember = "Value";
            cmb_Buscar_FormArticulos.ValueMember = "Key";
            cmb_Buscar_FormArticulos.DataSource = new BindingSource(headersProducto, null);
        }

        private void btn_Guardar_FormUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conectar.cadena))
                {
                    conexion.Open();
                    string query = @"INSERT INTO TB_Articulo (
                        codigo_Articulo, 
                        nombre_Articulo, 
                        descripcion_Articulo, 
                        categoria_ID
                    ) VALUES (
                        @codigo, @nombre, @descripcion, @categoriaID
                    )";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txt_Codigo_FormProducto.Text);
                        cmd.Parameters.AddWithValue("@nombre", txt_Nombre_FormProducto.Text);
                        cmd.Parameters.AddWithValue("@descripcion", txt_Descripcion_FormProducto.Text);
                        cmd.Parameters.AddWithValue("@categoriaID", ((Categoria)cmb_Categoria_FormProducto.SelectedItem).categoria_ID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto registrado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                CargarArticulo();
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar producto", ex);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_Codigo_FormProducto.Text))
            {
                MessageBox.Show("El código del producto es obligatorio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Nombre_FormProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmb_Categoria_FormProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }





        //private void iconButton_BuscarArticulos_FormProductos_Click(object sender, EventArgs e)
        //{
            
        //}



        private void btn_Vaciar_FormProductos_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }



        private void LimpiarControles()
        {
            productoID = 0;
            txt_Codigo_FormProducto.Clear();
            txt_Nombre_FormProducto.Clear();
            txt_Descripcion_FormProducto.Clear();
            cmb_Categoria_FormProducto.SelectedIndex = -1;
        }

        private void MostrarError(string mensaje, Exception ex)
        {
            string error = $"{mensaje}: {ex.Message}\n\nDetalles:\n{ex.StackTrace}";
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Clase auxiliar para categorías
        private class Categoria
        {
            public int categoria_ID { get; set; }
            public string nombre_Categoria { get; set; }

            public override string ToString() => nombre_Categoria;
        }

        private void txt_BuscarArticulos_FormProductos_TextChanged(object sender, EventArgs e)
        {
            // Búsqueda en tiempo real
            btn_Buscar_FormArticulos_Click(sender, e);
        }



        private void btn_Editar_FormUsuario_Click_1(object sender, EventArgs e)
        {
            if (productoID == 0)
            {
                MessageBox.Show("Seleccione un producto para editar", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = @"UPDATE TB_Articulo SET 
                        codigo_Articulo = @codigo,
                        nombre_Articulo = @nombre,
                        descripcion_Articulo = @descripcion,
                        categoria_ID = @categoriaID
                        WHERE articulo_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@codigo", txt_Codigo_FormProducto.Text);
                    cmd.Parameters.AddWithValue("@nombre", txt_Nombre_FormProducto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_Descripcion_FormProducto.Text);
                    cmd.Parameters.AddWithValue("@categoriaID", ((Categoria)cmb_Categoria_FormProducto.SelectedItem).categoria_ID);
                    cmd.Parameters.AddWithValue("@id", productoID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto actualizado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                CargarArticulo();
            }
            catch (Exception ex)
            {
                MostrarError("Error al actualizar producto", ex);
            }
        }

        private void btn_Eliminar_FormUsuario_Click(object sender, EventArgs e)
        {
            if (productoID == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "DELETE FROM TB_Articulo WHERE articulo_ID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", productoID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                CargarArticulo();
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar producto", ex);
            }
        }

        private void dgv_Data_FormArticulo_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgv_Data_FormArticulo.CurrentRow == null) return;

            try
            {
                DataGridViewRow fila = dgv_Data_FormArticulo.CurrentRow;
                productoID = Convert.ToInt32(fila.Cells["articulo_ID"].Value);
                txt_Codigo_FormProducto.Text = fila.Cells["codigo_Articulo"].Value?.ToString();
                txt_Nombre_FormProducto.Text = fila.Cells["nombre_Articulo"].Value?.ToString();
                txt_Descripcion_FormProducto.Text = fila.Cells["descripcion_Articulo"].Value?.ToString();

                string categoriaNombre = fila.Cells["nombre_Categoria"].Value?.ToString();
                foreach (Categoria item in cmb_Categoria_FormProducto.Items)
                {
                    if (item.nombre_Categoria == categoriaNombre)
                    {
                        cmb_Categoria_FormProducto.SelectedItem = item;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar datos del producto", ex);
            }
        }

        private void btn_Vaciar_FormArticulos_Click(object sender, EventArgs e)
        {

            LimpiarControles();
            txt_Buscar_FormArticulos.Clear();
            CargarArticulo();
        }

        private void btn_Buscar_FormArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormArticulos.SelectedItem == null) return;

                var selected = (KeyValuePair<string, string>)cmb_Buscar_FormArticulos.SelectedItem;
                string columna = selected.Key;
                string texto = txt_Buscar_FormArticulos.Text.Trim();

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT articulo_ID, codigo_Articulo, nombre_Articulo, 
                                    descripcion_Articulo, c.nombre_Categoria 
                                    FROM TB_Articulo a
                                    JOIN TB_Categoria c ON a.categoria_ID = c.categoria_ID";

                    if (!string.IsNullOrEmpty(texto))
                    {
                        query += $" WHERE {columna} LIKE @busqueda";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    if (!string.IsNullOrEmpty(texto))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");
                    }

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgv_Data_FormArticulo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error en la búsqueda", ex);
            }
        }

        //        private void btn_Descargar_FormProductos_Click(object sender, EventArgs e)
        //        {
        //            if (dgv_Data_FormArticulo.Rows.Count == 0)
        //            {
        //                MessageBox.Show("No hay datos para exportar", "Advertencia",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            SaveFileDialog saveFileDialog = new SaveFileDialog
        //            {
        //                Filter = "Archivos PDF (*.pdf)|*.pdf",
        //                Title = "Guardar reporte de productos",
        //                FileName = "Reporte_Productos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
        //            };

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                try
        //                {
        //                    ExportarDataGridViewAPDF(dgv_Data_FormArticulo, saveFileDialog.FileName);
        //                    MessageBox.Show("PDF generado exitosamente", "Éxito",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MostrarError("Error al generar PDF", ex);
        //                }
        //            }
        //        }
        //        private void ExportarDataGridViewAPDF(DataGridView dgv, string filePath)
        //{
        //    // 1. Configurar documento
        //    Document document = new Document(PageSize.A4.Rotate()); // Horizontal
        //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

        //    document.Open();

        //    // 2. Configurar fuentes con soporte para español
        //    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
        //    BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        //    Font fontTitulo = new Font(baseFont, 16, Font.BOLD);
        //    Font fontEncabezado = new Font(baseFont, 10, Font.BOLD);
        //    Font fontCelda = new Font(baseFont, 9);

        //    // 3. Título del documento
        //    Paragraph titulo = new Paragraph("REPORTE DE PRODUCTOS", fontTitulo)
        //    {
        //        Alignment = Element.ALIGN_CENTER,
        //        SpacingAfter = 20f
        //    };
        //    document.Add(titulo);

        //    // 4. Crear tabla con nombres en español
        //    PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count)
        //    {
        //        WidthPercentage = 100,
        //        SpacingBefore = 10f
        //    };

        //    // 5. Mapeo de encabezados en español
        //    var encabezadosEspanol = new Dictionary<string, string>
        //    {
        //        { "articulo_ID", "ID" },
        //        { "codigo_Articulo", "CÓDIGO" },
        //        { "nombre_Articulo", "NOMBRE" },
        //        { "descripcion_Articulo", "DESCRIPCIÓN" },
        //        { "nombre_Categoria", "CATEGORÍA" }
        //    };

        //    // 6. Encabezados de columna
        //    foreach (DataGridViewColumn col in dgv.Columns)
        //    {
        //        string headerText = encabezadosEspanol.TryGetValue(col.DataPropertyName, out string texto) 
        //                            ? texto : col.HeaderText;

        //        PdfPCell celdaEncabezado = new PdfPCell(new Phrase(headerText, fontEncabezado))
        //        {
        //            BackgroundColor = new BaseColor(200, 200, 200),
        //            HorizontalAlignment = Element.ALIGN_CENTER,
        //            Padding = 5f
        //        };
        //        pdfTable.AddCell(celdaEncabezado);
        //    }

        //    // 7. Datos de las filas
        //    foreach (DataGridViewRow row in dgv.Rows)
        //    {
        //        if (!row.IsNewRow)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                string valor = cell.Value?.ToString() ?? "";
        //                PdfPCell celdaDato = new PdfPCell(new Phrase(valor, fontCelda))
        //                {
        //                    Padding = 4f
        //                };
        //                pdfTable.AddCell(celdaDato);
        //            }
        //        }
        //    }

        //    // 8. Pie de página con fecha
        //    Paragraph pie = new Paragraph($"Generado el: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", fontCelda)
        //    {
        //        Alignment = Element.ALIGN_RIGHT,
        //        SpacingBefore = 20f
        //    };

        //    // 9. Añadir elementos al documento
        //    document.Add(pdfTable);
        //    document.Add(pie);
        //    document.Close();
        //}
    }
}
using SistemaVentas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas
{
    public partial class FormVentas : Form
    {
        // Constructor del formulario
        public FormVentas()
        {
            InitializeComponent();
        }

        // Método que se dispara cuando el texto en el campo de código cambia
        private void TBCodigo_TextChanged(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text.Trim();  // Obtener el código ingresado

            if (codigo.Length > 0)  // Verificar que el código no esté vacío
            {
                // Simular una función que chequea si es usuario o producto
                if (EsUsuario(codigo))
                {
                    // Lógica de acceso para el usuario
                    AccederSistema(codigo);
                }
                else if (EsProducto(codigo))
                {
                    // Lógica de añadir el producto a la lista de ventas
                    AgregarProductoALaVenta(codigo);
                }
                else
                {
                    MessageBox.Show("Código no reconocido.");
                }

                tbCodigo.Clear(); // Limpiar el campo de código después de procesar
            }
        }

        // Función que verifica si el código pertenece a un usuario
        private bool EsUsuario(string codigo)
        {
            // Aquí debes conectar con la base de datos o lista de usuarios para verificar
            return codigo.StartsWith("USR"); // Ejemplo: los códigos de usuarios empiezan con 'USR'
        }

        // Función que verifica si el código pertenece a un producto
        private bool EsProducto(string codigo)
        {
            // Aquí debes conectar con la base de datos de productos para verificar
            return codigo.StartsWith("PROD"); // Ejemplo: los códigos de productos empiezan con 'PROD'
        }

        // Acceso al sistema basado en el código del usuario
        private void AccederSistema(string codigoUsuario)
        {
            // Lógica para dar acceso al sistema según el código de usuario
            MessageBox.Show("Usuario autenticado: " + codigoUsuario);
        }

        // Añadir producto a la lista de ventas basado en el código del producto
        private void AgregarProductoALaVenta(string codigoProducto)
        {
            // Lógica para buscar el producto en la base de datos y añadirlo a la venta
            MessageBox.Show("Producto añadido: " + codigoProducto);
        }
    }
}


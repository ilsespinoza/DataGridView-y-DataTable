using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practia_1
{
    public partial class PRODUCTOS : Form
    {

        private int contador = 1;
        public PRODUCTOS()
        {
            InitializeComponent();

        }

        private void dgvProductos_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {



            dgvProductos.Rows.Add(new Object[] { contador++, "Lapiz", 10, 12.5, true });
            dgvProductos.Rows.Add(new Object[] { contador++, "Pluma", 15, 14.80, true });



        }





        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Add(new object[] { contador++,
                  txtNombre.Text,txtCantidad.Text,txtPrecio.Text,chkActivo.Checked});
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }
    

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow renglon = dgvProductos.SelectedRows[0];
                renglon.Cells["Nombre"].Value = txtNombre.Text;
                renglon.Cells["Cantidad"].Value = txtCantidad.Text;
                renglon.Cells["Precio"].Value = double.Parse(txtPrecio.Text);
                renglon.Cells["Activo"].Value = chkActivo.Checked;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Remove(dgvProductos.SelectedRows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }
    

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {


                DataGridViewRow renglon = dgvProductos.SelectedRows[0];
                txtIDProducto.Text = renglon.Cells["IDProducto"].Value.ToString();
                txtNombre.Text = renglon.Cells["Nombre"].Value.ToString();
                txtCantidad.Text = renglon.Cells["Cantidad"].Value.ToString();
                txtPrecio.Text = renglon.Cells["Precio"].Value.ToString();
                chkActivo.Checked = bool.Parse(renglon.Cells["Activo"].Value.ToString());

            }
        }
    }
}



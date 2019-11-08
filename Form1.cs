using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comanda
{
    public partial class FrmExamen4 : Form
    {
        
        readonly BaseDato menus;
        public FrmExamen4()
        {
            
            InitializeComponent();
            //Es para manipular la forma y que se escriba y cambie de color al momento de ejecutar
            this.Text = "San Jorge Restaurant";
            this.BackColor = Color.BurlyWood;
            menus = new BaseDato();
            menuActivo();
        }
        //Se crea un metodo para mostrar el inicio de lo que aparecera en el inicio de los combox
        public void menuActivo()
        {
            cboMenu.DataSource = menus.listamenu;
            cboMenu.DisplayMember = "Nombre";
            cboMenu.ValueMember = "Id";
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Es el switch para cuando el usuario elija una de las categorias se muestre las listas de comida de esa
            //categoria.
            switch (cboMenu.SelectedIndex)
            {
                case 1:
                    //El datasource permite la conectividad de cada una de las opciones del menu que se han guardado para
                    //el la listbox
                    lstSeleccion.DataSource = menus.ListAperitivos;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 2:
                    lstSeleccion.DataSource = menus.Ensalada;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 3:
                    lstSeleccion.DataSource = menus.ListCarnes;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 4:
                    lstSeleccion.DataSource = menus.ListPescado;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 5:
                    lstSeleccion.DataSource = menus.ListPollo;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 6:
                    lstSeleccion.DataSource = menus.ListPasta;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 7:
                    lstSeleccion.DataSource = menus.ListSandwich;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 8:
                    lstSeleccion.DataSource = menus.ListPaninis;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 9:
                    lstSeleccion.DataSource = menus.ListPostre;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                case 10:
                    lstSeleccion.DataSource = menus.ListBebida;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";
                    break;
                default:
                    lstSeleccion.DataSource = menus.Vacio;
                    lstSeleccion.DisplayMember = "Nombre";
                    lstSeleccion.ValueMember = "Id";

                    break;


            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Se usa el metodo agregarMenu para cuando 
            AgregarMenu();
        }
        private void AgregarMenu()
        {
            // Se crea una variable que guarde la seleccion del usuario

            var valor = lstSeleccion.SelectedIndex;
            //se crea el if para cuando sea distinto a cero se haga la operacion para calcular el precio total de la compra
            if (valor != 0)
            {
                var datos = Convert.ToDouble(cboCantidad.Text) * Convert.ToDouble(TxtBoxPrecio.Text);
                var total = Convert.ToString(datos);
                //Se hace para agregarlo en el datagrid
                dbgrdLista.Rows.Add(lstSeleccion.Text, cboCantidad.Text, TxtBoxPrecio.Text, total);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
        }

        public void Limpiar()
        {
            TxtBoxPrecio.Text = "";
            cboCantidad.Text = "0";
            cboMenu.Text = "None";
            TxtTotal.Text = "";
            dbgrdLista.Rows.Clear();
        }
        //El metodo limpia todo lo ya agregado de las cajas de texto
        public void LimpiarAgregar()
        {
            TxtBoxPrecio.Text = "";
            cboCantidad.Text = "0";
            cboMenu.Text = "None";
            TxtTotal.Text = "";
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            cobrar();
        }
        //El metodo cobrar que ayuda a hacer la operacion de la suma total de las celdas de los precios ya agregados del usuario,
        public void cobrar()
        {
            decimal suma = 0;
            //El foreach ayuda para pasar por el datagrid 
            foreach (DataGridViewRow Celda in dbgrdLista.Rows)

                suma += Convert.ToDecimal(Celda.Cells["Total"].Value);


            TxtTotal.Text = Convert.ToString(suma);
        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //La funcion para cerrar el programa.
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMenu();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cobrar();
        }
        //Se genera el evento que da informacion acerca del programa
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Proyecto POO Mayo 2019", "Acerca de..");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder.Models;
using Builder.Builder;
using Builder.Director;

namespace Builder
{
    public partial class Form1 : Form
    {
        List<Hamburguesa> lista = new List<Hamburguesa>();

        public Form1()
        {
            InitializeComponent();
        }

        public void ActualizarPrecio()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            label4.Text = sum.ToString()+".00";
        }

        public string Detalles()
        {
            string s = "";
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                s += "\n" + dataGridView1.Rows[i].Cells[2].Value + " $";
                s += dataGridView1.Rows[i].Cells[1].Value + ".00";
            }
            s += "\n";
            return s.ToString();
        }

        public void Ajustar()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                int colw = dataGridView1.Columns[i].Width;
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[i].Width = colw;
            }
            dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var cocina = new Cocina();
            Hamburguesa hamburguesa = hamburguesa = cocina.CocinarHamburguesa(new SencillaBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //20
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());
            
            lista.Add(hamburguesa);

            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new SencillaConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //25
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa "+ hamburguesa.Nombre +" agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new McPolloBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Pollo)); //30
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new DobleConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Doble_Res)); //45
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //45
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new McnificaBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //50
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraDobleConQuesoBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //65
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var cocina = new Cocina();
            Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new BigMacBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //80
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detalles de su compra:\n" + Detalles() + "\nTotal: $" + label4.Text);
            DialogResult res;
            res = MessageBox.Show(this, "Pagar pedido", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes)
            {

                MessageBox.Show("Gracias por su compra.");

            }
            else
            {
                MessageBox.Show("Orden cancelada.");
            }
            
            lista = new List<Hamburguesa>();
            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;
            Ajustar();
            ActualizarPrecio();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                //dataGridView1.Rows.RemoveAt(row);
                
                lista.RemoveAt(row);
                var source = new BindingSource(lista, null);
                dataGridView1.DataSource = source;

                Detalles();
                ActualizarPrecio();
                Ajustar();
            }
            catch
            {
                MessageBox.Show("No tiene ninguna hamburguesa en su pedido.");
            }
            
        }
    }
}

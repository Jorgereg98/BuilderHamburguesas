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
        List<IComida> lista = new List<IComida>();

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
            var comida = new SencillaBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = hamburguesa = cocina.CocinarHamburguesa(new SencillaBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //20
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);

            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var comida = new SencillaConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new SencillaConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //25
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa "+ hamburguesa.Nombre +" agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var comida = new McPolloBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Pollo);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new McPolloBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Pollo)); //30
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var comida = new DobleConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Doble_Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new DobleConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Doble_Res)); //45
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var comida = new CuartoDeLibraBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //45
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var comida = new McnificaBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new McnificaBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //50
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var comida = new CuartoDeLibraDobleConQuesoBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraDobleConQuesoBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //65
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            lista.Add(hamburguesa);
            MessageBox.Show("Hamburguesa " + hamburguesa.Nombre + " agregada con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var comida = new BigMacBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res);
            var hamburguesa = comida.Cocinar();
            hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

            //var cocina = new Cocina();
            //Hamburguesa hamburguesa = cocina.CocinarHamburguesa(new BigMacBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //80
            //hamburguesa.IngredientesString = string.Join(",", hamburguesa.Ingredientes.ToArray());

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
            
            lista = new List<IComida>();
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

        private void button10_Click(object sender, EventArgs e)
        {

            var comida = new SandwichJamon(TipoPanEnum.Blanco, TipoCarneEnum.Jamon);
            var sandwich = comida.Cocinar();
            sandwich.IngredientesString = string.Join(",", sandwich.Ingredientes.ToArray());

            lista.Add(sandwich);
            MessageBox.Show("Sandwich " + sandwich.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var comida = new SandwichHuevo(TipoPanEnum.Blanco, TipoCarneEnum.Sin_Carne);
            var sandwich = comida.Cocinar();
            sandwich.IngredientesString = string.Join(",", sandwich.Ingredientes.ToArray());

            lista.Add(sandwich);
            MessageBox.Show("Sandwich " + sandwich.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var comida = new SandwichPasta(TipoPanEnum.Integral, TipoCarneEnum.Sin_Carne);
            var sandwich = comida.Cocinar();
            sandwich.IngredientesString = string.Join(",", sandwich.Ingredientes.ToArray());

            lista.Add(sandwich);
            MessageBox.Show("Sandwich " + sandwich.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var comida = new SandwichPepperoni(TipoPanEnum.Blanco, TipoCarneEnum.Pepperoni);
            var sandwich = comida.Cocinar();
            sandwich.IngredientesString = string.Join(",", sandwich.Ingredientes.ToArray());

            lista.Add(sandwich);
            MessageBox.Show("Sandwich " + sandwich.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var comida = new SandwichPavo(TipoPanEnum.Integral, TipoCarneEnum.Pavo);
            var sandwich = comida.Cocinar();
            sandwich.IngredientesString = string.Join(",", sandwich.Ingredientes.ToArray());

            lista.Add(sandwich);
            MessageBox.Show("Sandwich " + sandwich.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var comida = new BaguetteJamon(TipoPanEnum.Blanco, TipoCarneEnum.Jamon);
            var baguette = comida.Cocinar();
            baguette.IngredientesString = string.Join(",", baguette.Ingredientes.ToArray());

            lista.Add(baguette);
            MessageBox.Show("Baguette " + baguette.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            var comida = new BaguettePollo(TipoPanEnum.Blanco, TipoCarneEnum.Pollo);
            var baguette = comida.Cocinar();
            baguette.IngredientesString = string.Join(",", baguette.Ingredientes.ToArray());

            lista.Add(baguette);
            MessageBox.Show("Baguette " + baguette.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var comida = new BaguetteSalchicha(TipoPanEnum.Blanco, TipoCarneEnum.Salchicha);
            var baguette = comida.Cocinar();
            baguette.IngredientesString = string.Join(",", baguette.Ingredientes.ToArray());

            lista.Add(baguette);
            MessageBox.Show("Baguette " + baguette.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var comida = new BaguetteVegetariano(TipoPanEnum.Integral, TipoCarneEnum.Sin_Carne);
            var baguette = comida.Cocinar();
            baguette.IngredientesString = string.Join(",", baguette.Ingredientes.ToArray());

            lista.Add(baguette);
            MessageBox.Show("Baguette " + baguette.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var comida = new BaguetteArrachera(TipoPanEnum.Blanco, TipoCarneEnum.Arrachera);
            var baguette = comida.Cocinar();
            baguette.IngredientesString = string.Join(",", baguette.Ingredientes.ToArray());

            lista.Add(baguette);
            MessageBox.Show("Baguette " + baguette.Nombre + " agregado con éxito.");

            var source = new BindingSource(lista, null);
            dataGridView1.DataSource = source;

            Ajustar();
            ActualizarPrecio();
        }
    }
}

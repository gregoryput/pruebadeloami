using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Libros : Form
    {
        public Stack<string> listaPila = new Stack<string>();
        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string nombre = textNombre.Text.ToString();
            listaPila.Push(nombre);
            foreach (var item in listaPila)
            {
                listView1.Items.Add(item.ToString());
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro a remover es: {listaPila.Peek()}","Advertencia");

            listaPila.Pop();
            listView1.Items[0].Remove();
         
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

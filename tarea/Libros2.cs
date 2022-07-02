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
    public partial class Libros2 : Form
    {
        public Queue<string> listacola = new Queue<string>();
        public Libros2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string nombre = textNombre.Text.ToString();
            listacola.Enqueue(nombre);
            foreach (var item in listacola)
            {
                listView1.Items.Add(item.ToString());
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro a remover es: {listacola.Peek()}", "Advertencia");

            listacola.Dequeue();
            listView1.Items[0].Remove();
           
        }
    }
}

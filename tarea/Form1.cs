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
    public partial class tarea4 : Form
    {
        public tarea4()
        {
            InitializeComponent();
        }

        private void Pelculas_Click(object sender, EventArgs e)
        {
            Peliculaz f = new Peliculaz();
            f.ShowDialog();
        }

        private void btnnomina_Click(object sender, EventArgs e)
        {
            Nomina n = new Nomina();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libros a = new Libros();
            a.ShowDialog();
        }

        private void Colas_Click(object sender, EventArgs e)
        {
            Libros2 a = new Libros2();
            a.ShowDialog();
        }
    }
}

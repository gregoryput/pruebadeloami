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
    public partial class Nomina : Form
    {
        public List<Empleado> empleados = new List<Empleado>();
        public Nomina()
        {
            InitializeComponent();

        }

        private void Nomina_Load(object sender, EventArgs e)
        {

        }
        int valor = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listaempleado.Items.Clear();
           
            Empleado R = new Empleado();
            R.id = valor++;
            R.Cargo = textcargo.Text.ToString();
            R.Nombre = textnombre.Text.ToString();
            R.Sueldo = double.Parse(textsueldo.Text.ToString());
            empleados.Add(R);
     
            foreach (var item in empleados)
            {
                
                ListViewItem a = new ListViewItem();
                a = listaempleado.Items.Add(item.id.ToString());
                a.SubItems.Add(item.Nombre);
                a.SubItems.Add(item.Cargo);
                a.SubItems.Add(item.Sueldo.ToString());
                a.SubItems.Add(item.AFP.ToString());
                a.SubItems.Add(item.SFS.ToString());
                a.SubItems.Add(item.TotalDeDescuetno.ToString());
                a.SubItems.Add(item.SueldoNeto.ToString());

            }
       
                int cantidad = 0;
                foreach (var item in empleados.ToList())
                {
                    cantidad++;
                }

            lbcotnador.Text = cantidad.ToString();
          



        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            var a = listaempleado.SelectedItems[0];
            /* foreach (var i in empleados.ToList())
               {
                   var d = i.id.ToString();
                   if (d == a.Text.ToString())
                   {
                       listaempleado.Items.Remove(a);
                       empleados.Remove(i);
                   }
               }*/

            empleados.RemoveAll(x => x.id.ToString() == a.Text.ToString());
            listaempleado.Items.Remove(a);


            int cantidad = 0;
            foreach (var item in empleados.ToList())
            {
                cantidad++;
            }

            lbcotnador.Text = cantidad.ToString();
        }
    }
    public class Empleado
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
        public double AFP { get { return Sueldo * 0.0287; } }
        public double SFS { get { return Sueldo * 0.307; } }
        public double TotalDeDescuetno { get { return Sueldo - (AFP + SFS); } }
        public double SueldoNeto { get { return Sueldo - TotalDeDescuetno; } }

    }
}
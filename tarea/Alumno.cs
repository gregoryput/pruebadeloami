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
    public partial class Alumno : Form
    {
        public LinkedList<Estudiantes> alumnos = new LinkedList<Estudiantes>();
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarPrimero_Click(object sender, EventArgs e)
        {
            listaestudiante.Items.Clear();
            Estudiantes estudiantes= new Estudiantes();
            estudiantes.Nombre = textNombre.Text.ToString();

            alumnos.AddFirst(estudiantes);

            foreach (var item in alumnos.ToList())
            {
                listaestudiante.Items.Add(item.Nombre.ToString());
            }
        }

        private void btnAgregarUltimo_Click(object sender, EventArgs e)
        {
            listaestudiante.Items.Clear();
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Nombre = textNombre.Text.ToString();

            alumnos.AddLast(estudiantes);

            foreach (var item in alumnos.ToList())
            {
                listaestudiante.Items.Add(item.Nombre.ToString());
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var a = listaestudiante.SelectedItems[0];
             foreach (var i in alumnos.ToList())
               {
                   var d = i.Nombre.ToString();
                   if (d == a.Text.ToString())
                   {
                       listaestudiante.Items.Remove(a);
                       alumnos.Remove(i);
                   }
               }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = listaestudiante.SelectedItems[0];
            foreach (var i in alumnos.ToList())
            {
                if (i.Nombre == a.Text.ToString())
                {
                    var valor = alumnos.Find(i);

                    listaestudiante.Items.Remove(a);
                    alumnos.Remove(valor);
                    alumnos.AddLast(valor);
                    listaestudiante.Items.Add(a);



                }
            }

           // listaestudiante.Refresh();
        }
    }
    public class Estudiantes
    { 
        public string Nombre { get; set; }
    }
}

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
    public partial class Peliculaz : Form
    {
        public Registro[] lista = new Registro[1];
        public List<Registro> a = new List<Registro>();
        public Peliculaz()
        {
            InitializeComponent();
            
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = 0;

            for (int i = 0; i < 1; i++)
            {
                Registro f = new Registro();
                f.Titulo = textTitulo.Text.ToString();
                f.Director = textDirector.Text.ToString();
                f.Duracion = textDuracion.Text.ToString();
                f.Clasificacion = textCalificacion.Text.ToString();
                f.Genero = textGenero.Text.ToString();
                f.Productora = textProductora.Text.ToString(); 

                lista[valor] = f;
                valor++;
            }

            textTitulo.Text = string.Empty;
            textDirector.Text = string.Empty;
            textDuracion.Text = string.Empty;
            textCalificacion.Text = string.Empty;
            textGenero.Text = string.Empty;
            textProductora.Text = string.Empty;




            foreach (var item in lista)
            {
                ListViewItem a = new ListViewItem();
                a = Listea.Items.Add(item.Titulo);
                a.SubItems.Add(item.Director);
                a.SubItems.Add(item.Duracion);
                a.SubItems.Add(item.Genero); 
                a.SubItems.Add(item.Productora);
                a.SubItems.Add(item.Clasificacion);
            }
        }

        private void Peliculaz_Load(object sender, EventArgs e)
        {

        }
    }
}

public class Registro
{
    public string Titulo { get; set; }
    public string Director { get; set; }
    public string Genero { get; set; }
    public string Duracion { get; set; }
    public string Clasificacion { get; set; }
    public string Productora { get; set; }
}

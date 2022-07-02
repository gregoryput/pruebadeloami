
namespace tarea
{
    partial class tarea4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Pelculas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Colas = new System.Windows.Forms.Button();
            this.btnnomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(196, 451);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Pelculas
            // 
            this.Pelculas.Location = new System.Drawing.Point(12, 12);
            this.Pelculas.Name = "Pelculas";
            this.Pelculas.Size = new System.Drawing.Size(170, 63);
            this.Pelculas.TabIndex = 1;
            this.Pelculas.Text = "Peliculas";
            this.Pelculas.UseVisualStyleBackColor = true;
            this.Pelculas.Click += new System.EventHandler(this.Pelculas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Libro Con pila";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Colas
            // 
            this.Colas.Location = new System.Drawing.Point(12, 288);
            this.Colas.Name = "Colas";
            this.Colas.Size = new System.Drawing.Size(170, 63);
            this.Colas.TabIndex = 4;
            this.Colas.Text = "Libro Con Colas";
            this.Colas.UseVisualStyleBackColor = true;
            this.Colas.Click += new System.EventHandler(this.Colas_Click);
            // 
            // btnnomina
            // 
            this.btnnomina.Location = new System.Drawing.Point(12, 81);
            this.btnnomina.Name = "btnnomina";
            this.btnnomina.Size = new System.Drawing.Size(170, 63);
            this.btnnomina.TabIndex = 5;
            this.btnnomina.Text = "Nomina";
            this.btnnomina.UseVisualStyleBackColor = true;
            this.btnnomina.Click += new System.EventHandler(this.btnnomina_Click);
            // 
            // tarea4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 451);
            this.Controls.Add(this.btnnomina);
            this.Controls.Add(this.Colas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pelculas);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(212, 490);
            this.MinimumSize = new System.Drawing.Size(212, 490);
            this.Name = "tarea4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Pelculas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Colas;
        private System.Windows.Forms.Button btnnomina;
    }
}


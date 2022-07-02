
namespace tarea
{
    partial class Peliculaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textDirector = new System.Windows.Forms.TextBox();
            this.textCalificacion = new System.Windows.Forms.TextBox();
            this.textProductora = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Listea = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Productora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(12, 61);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(166, 20);
            this.textTitulo.TabIndex = 0;
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(12, 126);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(166, 20);
            this.textDirector.TabIndex = 1;
            // 
            // textCalificacion
            // 
            this.textCalificacion.Location = new System.Drawing.Point(12, 392);
            this.textCalificacion.Name = "textCalificacion";
            this.textCalificacion.Size = new System.Drawing.Size(166, 20);
            this.textCalificacion.TabIndex = 2;
            // 
            // textProductora
            // 
            this.textProductora.Location = new System.Drawing.Point(12, 327);
            this.textProductora.Name = "textProductora";
            this.textProductora.Size = new System.Drawing.Size(166, 20);
            this.textProductora.TabIndex = 3;
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(12, 265);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(166, 20);
            this.textGenero.TabIndex = 4;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(12, 192);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(166, 20);
            this.textDuracion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Productora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calficacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Director";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(346, 378);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 46);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Listea
            // 
            this.Listea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Director,
            this.Duracion,
            this.Genero,
            this.Productora,
            this.Calificacion});
            this.Listea.HideSelection = false;
            this.Listea.Location = new System.Drawing.Point(346, 61);
            this.Listea.Name = "Listea";
            this.Listea.Size = new System.Drawing.Size(442, 296);
            this.Listea.TabIndex = 14;
            this.Listea.UseCompatibleStateImageBehavior = false;
            this.Listea.View = System.Windows.Forms.View.Details;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulos";
            this.Titulo.Width = 67;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 104;
            // 
            // Duracion
            // 
            this.Duracion.Text = "Duracion";
            this.Duracion.Width = 68;
            // 
            // Genero
            // 
            this.Genero.Text = "Genero";
            // 
            // Productora
            // 
            this.Productora.Text = "Productora";
            this.Productora.Width = 77;
            // 
            // Calificacion
            // 
            this.Calificacion.Text = "Calificacion";
            // 
            // Peliculaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listea);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDuracion);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textProductora);
            this.Controls.Add(this.textCalificacion);
            this.Controls.Add(this.textDirector);
            this.Controls.Add(this.textTitulo);
            this.Name = "Peliculaz";
            this.ShowIcon = false;
            this.Text = "Peliculaz";
            this.Load += new System.EventHandler(this.Peliculaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textDirector;
        private System.Windows.Forms.TextBox textCalificacion;
        private System.Windows.Forms.TextBox textProductora;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView Listea;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Duracion;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Productora;
        private System.Windows.Forms.ColumnHeader Calificacion;
    }
}
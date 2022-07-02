
namespace tarea
{
    partial class Alumno
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
            this.listaestudiante = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarPrimero = new System.Windows.Forms.Button();
            this.btnAgregarUltimo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaestudiante
            // 
            this.listaestudiante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listaestudiante.HideSelection = false;
            this.listaestudiante.Location = new System.Drawing.Point(230, 79);
            this.listaestudiante.Name = "listaestudiante";
            this.listaestudiante.Size = new System.Drawing.Size(326, 248);
            this.listaestudiante.TabIndex = 0;
            this.listaestudiante.UseCompatibleStateImageBehavior = false;
            this.listaestudiante.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estudiante";
            this.columnHeader1.Width = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Estudiante";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 115);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 2;
            // 
            // btnAgregarPrimero
            // 
            this.btnAgregarPrimero.Location = new System.Drawing.Point(230, 369);
            this.btnAgregarPrimero.Name = "btnAgregarPrimero";
            this.btnAgregarPrimero.Size = new System.Drawing.Size(121, 57);
            this.btnAgregarPrimero.TabIndex = 3;
            this.btnAgregarPrimero.Text = "Agregar Primero";
            this.btnAgregarPrimero.UseVisualStyleBackColor = true;
            this.btnAgregarPrimero.Click += new System.EventHandler(this.btnAgregarPrimero_Click);
            // 
            // btnAgregarUltimo
            // 
            this.btnAgregarUltimo.Location = new System.Drawing.Point(357, 369);
            this.btnAgregarUltimo.Name = "btnAgregarUltimo";
            this.btnAgregarUltimo.Size = new System.Drawing.Size(121, 57);
            this.btnAgregarUltimo.TabIndex = 4;
            this.btnAgregarUltimo.Text = "Agregar Ultimo";
            this.btnAgregarUltimo.UseVisualStyleBackColor = true;
            this.btnAgregarUltimo.Click += new System.EventHandler(this.btnAgregarUltimo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Mover al ultimo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(358, 442);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 57);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 549);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAgregarUltimo);
            this.Controls.Add(this.btnAgregarPrimero);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaestudiante);
            this.Name = "Alumno";
            this.ShowIcon = false;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaestudiante;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAgregarPrimero;
        private System.Windows.Forms.Button btnAgregarUltimo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRemover;
    }
}
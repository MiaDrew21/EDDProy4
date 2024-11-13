namespace Pila1
{
    partial class Form2
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
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.listPila = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApilar
            // 
            this.btnApilar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnApilar.Font = new System.Drawing.Font("Viner Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApilar.ForeColor = System.Drawing.Color.Blue;
            this.btnApilar.Location = new System.Drawing.Point(12, 202);
            this.btnApilar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(112, 46);
            this.btnApilar.TabIndex = 0;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = false;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDesapilar.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesapilar.ForeColor = System.Drawing.Color.Blue;
            this.btnDesapilar.Location = new System.Drawing.Point(146, 202);
            this.btnDesapilar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(112, 45);
            this.btnDesapilar.TabIndex = 1;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = false;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnVaciar.Font = new System.Drawing.Font("Algerian", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.Color.Blue;
            this.btnVaciar.Location = new System.Drawing.Point(268, 199);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(112, 48);
            this.btnVaciar.TabIndex = 2;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // listPila
            // 
            this.listPila.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listPila.Font = new System.Drawing.Font("Monotype Corsiva", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPila.ForeColor = System.Drawing.Color.Blue;
            this.listPila.FormattingEnabled = true;
            this.listPila.ItemHeight = 18;
            this.listPila.Location = new System.Drawing.Point(164, 275);
            this.listPila.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listPila.Name = "listPila";
            this.listPila.Size = new System.Drawing.Size(203, 274);
            this.listPila.TabIndex = 3;
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDato.Location = new System.Drawing.Point(255, 148);
            this.txtDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(112, 26);
            this.txtDato.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(28, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa un valor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(137, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pila(LIFO)";
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGrafica.Font = new System.Drawing.Font("Vivaldi", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.Color.Blue;
            this.btnGrafica.Location = new System.Drawing.Point(400, 201);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(112, 46);
            this.btnGrafica.TabIndex = 7;
            this.btnGrafica.Text = "Graficar";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(524, 562);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.listPila);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.ListBox listPila;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrafica;
    }
}


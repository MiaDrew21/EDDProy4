﻿namespace Algoritmos_recursividad
{
    partial class BusquedaBinariaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.arreglo = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(200, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busqueda Binaria";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Magenta;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Vivaldi", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.BlueViolet;
            this.back.Location = new System.Drawing.Point(1003, 621);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(178, 51);
            this.back.TabIndex = 10;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(205, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese el tamaño del arreglo";
            // 
            // arreglo
            // 
            this.arreglo.BackColor = System.Drawing.Color.Magenta;
            this.arreglo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arreglo.Location = new System.Drawing.Point(565, 254);
            this.arreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arreglo.Name = "arreglo";
            this.arreglo.Size = new System.Drawing.Size(253, 26);
            this.arreglo.TabIndex = 12;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.BlueViolet;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.ForeColor = System.Drawing.Color.Magenta;
            this.Accept.Location = new System.Drawing.Point(565, 324);
            this.Accept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(155, 51);
            this.Accept.TabIndex = 13;
            this.Accept.Text = "Iniciar";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // BusquedaBinariaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.arreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BusquedaBinariaForm";
            this.Text = "BinarySearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arreglo;
        private System.Windows.Forms.Button Accept;
    }
}
﻿namespace Algoritmos_recursividad
{
    partial class SumArregloForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.arreglo = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(440, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suma de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese el tamaño del arreglo";
            // 
            // arreglo
            // 
            this.arreglo.BackColor = System.Drawing.Color.Magenta;
            this.arreglo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arreglo.Location = new System.Drawing.Point(326, 208);
            this.arreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arreglo.Name = "arreglo";
            this.arreglo.Size = new System.Drawing.Size(294, 26);
            this.arreglo.TabIndex = 13;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.Cyan;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.ForeColor = System.Drawing.Color.Magenta;
            this.Accept.Location = new System.Drawing.Point(542, 328);
            this.Accept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(283, 118);
            this.Accept.TabIndex = 14;
            this.Accept.Text = "Aceptar";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Cyan;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Magenta;
            this.back.Location = new System.Drawing.Point(886, 551);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(292, 121);
            this.back.TabIndex = 15;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SumArregloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.arreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SumArregloForm";
            this.Text = "SumArrayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arreglo;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button back;
    }
}
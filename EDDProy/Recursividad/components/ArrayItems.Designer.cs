namespace Algoritmos_recursividad
{
    partial class ArrayItems
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
            this.number = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.MediumTurquoise;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.ForeColor = System.Drawing.Color.Lime;
            this.number.Location = new System.Drawing.Point(189, 293);
            this.number.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(321, 31);
            this.number.TabIndex = 1;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Lime;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Location = new System.Drawing.Point(249, 528);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(195, 83);
            this.back.TabIndex = 10;
            this.back.Text = "Cancelar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddElement
            // 
            this.AddElement.BackColor = System.Drawing.Color.Lime;
            this.AddElement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddElement.Location = new System.Drawing.Point(267, 379);
            this.AddElement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(153, 80);
            this.AddElement.TabIndex = 11;
            this.AddElement.Text = "Añadir";
            this.AddElement.UseVisualStyleBackColor = false;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(157, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 53);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elementos del arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(76, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 47);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese un número al arreglo a la vez";
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.BackColor = System.Drawing.Color.Transparent;
            this.items.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.items.Location = new System.Drawing.Point(173, 607);
            this.items.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(0, 24);
            this.items.TabIndex = 14;
            // 
            // ArrayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(656, 670);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddElement);
            this.Controls.Add(this.back);
            this.Controls.Add(this.number);
            this.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ArrayItems";
            this.Text = "ArrayItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label items;
    }
}
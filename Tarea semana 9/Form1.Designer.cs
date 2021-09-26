
namespace Tarea_semana_9
{
    partial class Form1
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
            this.btPerro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txBoxId = new System.Windows.Forms.TextBox();
            this.txBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBoxRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBoxVacuna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txBoxownerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txBoxTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lisBoxPerro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btPerro
            // 
            this.btPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerro.Location = new System.Drawing.Point(108, 392);
            this.btPerro.Name = "btPerro";
            this.btPerro.Size = new System.Drawing.Size(90, 36);
            this.btPerro.TabIndex = 0;
            this.btPerro.Text = "AGREGAR";
            this.btPerro.UseVisualStyleBackColor = true;
            this.btPerro.Click += new System.EventHandler(this.btPerro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id perro";
            // 
            // txBoxId
            // 
            this.txBoxId.Location = new System.Drawing.Point(125, 70);
            this.txBoxId.Name = "txBoxId";
            this.txBoxId.Size = new System.Drawing.Size(100, 20);
            this.txBoxId.TabIndex = 2;
            // 
            // txBoxName
            // 
            this.txBoxName.Location = new System.Drawing.Point(125, 118);
            this.txBoxName.Name = "txBoxName";
            this.txBoxName.Size = new System.Drawing.Size(100, 20);
            this.txBoxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del perro";
            // 
            // txBoxRaza
            // 
            this.txBoxRaza.Location = new System.Drawing.Point(125, 161);
            this.txBoxRaza.Name = "txBoxRaza";
            this.txBoxRaza.Size = new System.Drawing.Size(100, 20);
            this.txBoxRaza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // txBoxAge
            // 
            this.txBoxAge.Location = new System.Drawing.Point(125, 208);
            this.txBoxAge.Name = "txBoxAge";
            this.txBoxAge.Size = new System.Drawing.Size(100, 20);
            this.txBoxAge.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // txBoxVacuna
            // 
            this.txBoxVacuna.Location = new System.Drawing.Point(125, 249);
            this.txBoxVacuna.Name = "txBoxVacuna";
            this.txBoxVacuna.Size = new System.Drawing.Size(100, 20);
            this.txBoxVacuna.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vacuna";
            // 
            // txBoxownerName
            // 
            this.txBoxownerName.Location = new System.Drawing.Point(125, 290);
            this.txBoxownerName.Name = "txBoxownerName";
            this.txBoxownerName.Size = new System.Drawing.Size(100, 20);
            this.txBoxownerName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre del dueño";
            // 
            // txBoxTelefono
            // 
            this.txBoxTelefono.Location = new System.Drawing.Point(125, 337);
            this.txBoxTelefono.Name = "txBoxTelefono";
            this.txBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.txBoxTelefono.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numero telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "REGISTRO DE PERROS";
            this.label8.UseWaitCursor = true;
            // 
            // lisBoxPerro
            // 
            this.lisBoxPerro.FormattingEnabled = true;
            this.lisBoxPerro.Location = new System.Drawing.Point(248, 70);
            this.lisBoxPerro.Name = "lisBoxPerro";
            this.lisBoxPerro.Size = new System.Drawing.Size(772, 355);
            this.lisBoxPerro.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 465);
            this.Controls.Add(this.lisBoxPerro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txBoxTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBoxownerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBoxVacuna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBoxRaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPerro);
            this.Name = "Form1";
            this.Text = "REGISTRO VETERINARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPerro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBoxId;
        private System.Windows.Forms.TextBox txBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBoxRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBoxVacuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBoxownerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBoxTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lisBoxPerro;
    }
}
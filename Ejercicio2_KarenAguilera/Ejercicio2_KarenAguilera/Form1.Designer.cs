namespace Ejercicio2_KarenAguilera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edad_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GuardarNombre_btn = new System.Windows.Forms.Button();
            this.Limpiar_btn = new System.Windows.Forms.Button();
            this.Salir_btn = new System.Windows.Forms.Button();
            this.datos_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numerodatos_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Nombre:";
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre_txt.Location = new System.Drawing.Point(217, 101);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(100, 25);
            this.Nombre_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(424, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la edad:";
            // 
            // Edad_txt
            // 
            this.Edad_txt.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edad_txt.Location = new System.Drawing.Point(572, 106);
            this.Edad_txt.Name = "Edad_txt";
            this.Edad_txt.Size = new System.Drawing.Size(100, 25);
            this.Edad_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(306, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datos Ingresados:";
            // 
            // GuardarNombre_btn
            // 
            this.GuardarNombre_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarNombre_btn.Location = new System.Drawing.Point(64, 327);
            this.GuardarNombre_btn.Name = "GuardarNombre_btn";
            this.GuardarNombre_btn.Size = new System.Drawing.Size(162, 23);
            this.GuardarNombre_btn.TabIndex = 7;
            this.GuardarNombre_btn.Text = "GUARDAR DATOS";
            this.GuardarNombre_btn.UseVisualStyleBackColor = true;
            this.GuardarNombre_btn.Click += new System.EventHandler(this.GuardarNombre_btn_Click);
            // 
            // Limpiar_btn
            // 
            this.Limpiar_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Limpiar_btn.Location = new System.Drawing.Point(339, 327);
            this.Limpiar_btn.Name = "Limpiar_btn";
            this.Limpiar_btn.Size = new System.Drawing.Size(87, 23);
            this.Limpiar_btn.TabIndex = 8;
            this.Limpiar_btn.Text = "Limpiar";
            this.Limpiar_btn.UseVisualStyleBackColor = true;
            this.Limpiar_btn.Click += new System.EventHandler(this.Limpiar_btn_Click);
            // 
            // Salir_btn
            // 
            this.Salir_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salir_btn.Location = new System.Drawing.Point(553, 327);
            this.Salir_btn.Name = "Salir_btn";
            this.Salir_btn.Size = new System.Drawing.Size(75, 23);
            this.Salir_btn.TabIndex = 9;
            this.Salir_btn.Text = "Salir";
            this.Salir_btn.UseVisualStyleBackColor = true;
            this.Salir_btn.Click += new System.EventHandler(this.Salir_btn_Click);
            // 
            // datos_cb
            // 
            this.datos_cb.FormattingEnabled = true;
            this.datos_cb.Location = new System.Drawing.Point(281, 220);
            this.datos_cb.Name = "datos_cb";
            this.datos_cb.Size = new System.Drawing.Size(210, 23);
            this.datos_cb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(178, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "DATOS A INGRESAR:";
            // 
            // numerodatos_txt
            // 
            this.numerodatos_txt.Location = new System.Drawing.Point(351, 30);
            this.numerodatos_txt.Name = "numerodatos_txt";
            this.numerodatos_txt.Size = new System.Drawing.Size(127, 23);
            this.numerodatos_txt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numerodatos_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datos_cb);
            this.Controls.Add(this.Salir_btn);
            this.Controls.Add(this.Limpiar_btn);
            this.Controls.Add(this.GuardarNombre_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Edad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Nombre_txt;
        private Label label2;
        private TextBox Edad_txt;
        private Label label3;
        private Button GuardarNombre_btn;
        private Button Limpiar_btn;
        private Button Salir_btn;
        private ComboBox datos_cb;
        private Label label4;
        private TextBox numerodatos_txt;
    }
}
namespace Login
{
    partial class VentanaUser
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
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar_Sesion = new System.Windows.Forms.Button();
            this.btn_Cambiar_Contra = new System.Windows.Forms.Button();
            this.btn_Principal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(370, 204);
            this.btn_Salir.Size = new System.Drawing.Size(157, 39);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(121, 152);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(158, 20);
            this.txt_Codigo.TabIndex = 35;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Enabled = false;
            this.txt_Usuario.Location = new System.Drawing.Point(121, 95);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(158, 20);
            this.txt_Usuario.TabIndex = 34;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(121, 46);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(158, 20);
            this.txt_nombre.TabIndex = 33;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // btn_Cerrar_Sesion
            // 
            this.btn_Cerrar_Sesion.Location = new System.Drawing.Point(370, 142);
            this.btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            this.btn_Cerrar_Sesion.Size = new System.Drawing.Size(157, 42);
            this.btn_Cerrar_Sesion.TabIndex = 27;
            this.btn_Cerrar_Sesion.Text = "Cerrar Sesión";
            this.btn_Cerrar_Sesion.UseVisualStyleBackColor = true;
            // 
            // btn_Cambiar_Contra
            // 
            this.btn_Cambiar_Contra.Location = new System.Drawing.Point(370, 85);
            this.btn_Cambiar_Contra.Name = "btn_Cambiar_Contra";
            this.btn_Cambiar_Contra.Size = new System.Drawing.Size(157, 42);
            this.btn_Cambiar_Contra.TabIndex = 26;
            this.btn_Cambiar_Contra.Text = "Cambiar Contraseña";
            this.btn_Cambiar_Contra.UseVisualStyleBackColor = true;
            // 
            // btn_Principal
            // 
            this.btn_Principal.Location = new System.Drawing.Point(370, 24);
            this.btn_Principal.Name = "btn_Principal";
            this.btn_Principal.Size = new System.Drawing.Size(157, 42);
            this.btn_Principal.TabIndex = 24;
            this.btn_Principal.Text = "Contenedor Principal";
            this.btn_Principal.UseVisualStyleBackColor = true;
            this.btn_Principal.Click += new System.EventHandler(this.btn_Principal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 467);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cerrar_Sesion);
            this.Controls.Add(this.btn_Cambiar_Contra);
            this.Controls.Add(this.btn_Principal);
            this.Name = "VentanaUser";
            this.Text = "VentanaUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUser_FormClosed);
            this.Load += new System.EventHandler(this.VentanaUser_Load);
            this.Controls.SetChildIndex(this.btn_Principal, 0);
            this.Controls.SetChildIndex(this.btn_Cambiar_Contra, 0);
            this.Controls.SetChildIndex(this.btn_Cerrar_Sesion, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_Usuario, 0);
            this.Controls.SetChildIndex(this.txt_Codigo, 0);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cerrar_Sesion;
        private System.Windows.Forms.Button btn_Cambiar_Contra;
        private System.Windows.Forms.Button btn_Principal;
    }
}
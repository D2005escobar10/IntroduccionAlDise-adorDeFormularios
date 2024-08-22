namespace RegistroContactosApp
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
            label1 = new Label();
            EtiquetaNombre = new Label();
            TextBoxNombre = new TextBox();
            EtiquetaTelefono = new Label();
            TextBoxTelefono = new TextBox();
            label2 = new Label();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            LabelEstado = new Label();
            ListBoxContactos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 29);
            label1.TabIndex = 0;
            label1.Text = "Aplicación De Registro De Contactos";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaNombre.Location = new Point(441, 86);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(63, 17);
            EtiquetaNombre.TabIndex = 1;
            EtiquetaNombre.Text = "Nombre";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.BackColor = SystemColors.ControlLightLight;
            TextBoxNombre.Location = new Point(348, 106);
            TextBoxNombre.Multiline = true;
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(249, 34);
            TextBoxNombre.TabIndex = 2;
            TextBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaTelefono.Location = new Point(431, 170);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(74, 17);
            EtiquetaTelefono.TabIndex = 3;
            EtiquetaTelefono.Text = "Teléfono";
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.BackColor = SystemColors.ControlLightLight;
            TextBoxTelefono.Location = new Point(386, 190);
            TextBoxTelefono.Multiline = true;
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(167, 34);
            TextBoxTelefono.TabIndex = 4;
            TextBoxTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(393, 260);
            label2.Name = "label2";
            label2.Size = new Size(153, 17);
            label2.TabIndex = 5;
            label2.Text = "Correo Electrónico";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = SystemColors.ControlLightLight;
            TextBoxEmail.Location = new Point(317, 280);
            TextBoxEmail.Multiline = true;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(310, 34);
            TextBoxEmail.TabIndex = 6;
            TextBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = SystemColors.ActiveCaptionText;
            ButtonAgregar.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAgregar.ForeColor = SystemColors.Control;
            ButtonAgregar.Location = new Point(351, 345);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(109, 56);
            ButtonAgregar.TabIndex = 7;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.BackColor = SystemColors.ActiveCaptionText;
            ButtonLimpiar.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLimpiar.ForeColor = SystemColors.Control;
            ButtonLimpiar.Location = new Point(488, 345);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(105, 56);
            ButtonLimpiar.TabIndex = 8;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = false;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Showcard Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(336, 410);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 17);
            LabelEstado.TabIndex = 9;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.BackColor = SystemColors.ControlLightLight;
            ListBoxContactos.Font = new Font("Arial Rounded MT Bold", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.ItemHeight = 14;
            ListBoxContactos.Location = new Point(79, 435);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.RightToLeft = RightToLeft.No;
            ListBoxContactos.Size = new Size(802, 144);
            ListBoxContactos.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 591);
            Controls.Add(ListBoxContactos);
            Controls.Add(LabelEstado);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(label2);
            Controls.Add(TextBoxTelefono);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label EtiquetaNombre;
        private TextBox TextBoxNombre;
        private Label EtiquetaTelefono;
        private TextBox TextBoxTelefono;
        private Label label2;
        private TextBox TextBoxEmail;
        private Button ButtonAgregar;
        private Button ButtonLimpiar;
        private Label LabelEstado;
        private ListBox ListBoxContactos;
        private int conteoRegistros = 1;
    }
}

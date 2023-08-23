namespace AplicacionTomarNotas
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
            dtGridTabla = new DataGridView();
            txtTitulo = new TextBox();
            txtMensaje = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnLeer = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridTabla).BeginInit();
            SuspendLayout();
            // 
            // dtGridTabla
            // 
            dtGridTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTabla.Location = new Point(409, 44);
            dtGridTabla.Name = "dtGridTabla";
            dtGridTabla.RowTemplate.Height = 25;
            dtGridTabla.Size = new Size(250, 297);
            dtGridTabla.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(124, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(203, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(124, 143);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(223, 198);
            txtMensaje.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 146);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Mensaje:";
            // 
            // btnNueva
            // 
            btnNueva.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnNueva.Location = new Point(124, 378);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 31);
            btnNueva.TabIndex = 5;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(259, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 31);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnLeer.Location = new Point(409, 378);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 31);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Yu Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(584, 378);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 31);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 454);
            Controls.Add(btnBorrar);
            Controls.Add(btnLeer);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMensaje);
            Controls.Add(txtTitulo);
            Controls.Add(dtGridTabla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridTabla;
        private TextBox txtTitulo;
        private TextBox txtMensaje;
        private Label label1;
        private Label label2;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnLeer;
        private Button btnBorrar;
    }
}
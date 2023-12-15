namespace PruebaTecnica.PresentationLayer
{
    partial class ABCC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            tbSku = new TextBox();
            tbArticulo = new TextBox();
            tbMarca = new TextBox();
            tbModelo = new TextBox();
            tbStock = new TextBox();
            tbCantidad = new TextBox();
            dtpFechaAlta = new DateTimePicker();
            dtpFechaBaja = new DateTimePicker();
            cbDepartamento = new ComboBox();
            cbClase = new ComboBox();
            cbFamilia = new ComboBox();
            cbDescontinuado = new CheckBox();
            btnAlta = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "sku:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Articulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 4;
            label5.Text = "Departamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 202);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Clase:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 241);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Familia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 281);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 281);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Cantidad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 327);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 9;
            label10.Text = "Fecha Alta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(238, 327);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 11;
            label12.Text = "Fecha Baja:";
            // 
            // tbSku
            // 
            tbSku.Location = new Point(110, 6);
            tbSku.MaxLength = 6;
            tbSku.Name = "tbSku";
            tbSku.Size = new Size(100, 23);
            tbSku.TabIndex = 12;
            tbSku.KeyPress += tbSku_KeyPress;
            // 
            // tbArticulo
            // 
            tbArticulo.Location = new Point(110, 45);
            tbArticulo.MaxLength = 15;
            tbArticulo.Name = "tbArticulo";
            tbArticulo.Size = new Size(324, 23);
            tbArticulo.TabIndex = 13;
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(110, 83);
            tbMarca.MaxLength = 15;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(324, 23);
            tbMarca.TabIndex = 14;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(110, 121);
            tbModelo.MaxLength = 20;
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(324, 23);
            tbModelo.TabIndex = 15;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(110, 281);
            tbStock.MaxLength = 9;
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(100, 23);
            tbStock.TabIndex = 16;
            tbStock.KeyPress += tbStock_KeyPress;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(307, 278);
            tbCantidad.MaxLength = 9;
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(100, 23);
            tbCantidad.TabIndex = 17;
            tbCantidad.KeyPress += tbCantidad_KeyPress;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Format = DateTimePickerFormat.Short;
            dtpFechaAlta.Location = new Point(110, 321);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(111, 23);
            dtpFechaAlta.TabIndex = 18;
            // 
            // dtpFechaBaja
            // 
            dtpFechaBaja.Format = DateTimePickerFormat.Short;
            dtpFechaBaja.Location = new Point(307, 321);
            dtpFechaBaja.Name = "dtpFechaBaja";
            dtpFechaBaja.Size = new Size(111, 23);
            dtpFechaBaja.TabIndex = 19;
            // 
            // cbDepartamento
            // 
            cbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(110, 157);
            cbDepartamento.MaxLength = 1;
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(324, 23);
            cbDepartamento.TabIndex = 20;
            cbDepartamento.SelectedIndexChanged += cbDepartamento_SelectedIndexChanged;
            // 
            // cbClase
            // 
            cbClase.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClase.FormattingEnabled = true;
            cbClase.Location = new Point(110, 199);
            cbClase.MaxLength = 1;
            cbClase.Name = "cbClase";
            cbClase.Size = new Size(324, 23);
            cbClase.TabIndex = 21;
            cbClase.SelectedIndexChanged += cbClase_SelectedIndexChanged;
            // 
            // cbFamilia
            // 
            cbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFamilia.FormattingEnabled = true;
            cbFamilia.Location = new Point(110, 238);
            cbFamilia.MaxLength = 1;
            cbFamilia.Name = "cbFamilia";
            cbFamilia.Size = new Size(324, 23);
            cbFamilia.TabIndex = 22;
            // 
            // cbDescontinuado
            // 
            cbDescontinuado.AutoSize = true;
            cbDescontinuado.Location = new Point(289, 8);
            cbDescontinuado.Name = "cbDescontinuado";
            cbDescontinuado.Size = new Size(106, 19);
            cbDescontinuado.TabIndex = 23;
            cbDescontinuado.Text = "Descontinuado";
            cbDescontinuado.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(197, 410);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 24;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(278, 410);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(359, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(216, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 23);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ABCC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 449);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAlta);
            Controls.Add(cbDescontinuado);
            Controls.Add(cbFamilia);
            Controls.Add(cbClase);
            Controls.Add(cbDepartamento);
            Controls.Add(dtpFechaBaja);
            Controls.Add(dtpFechaAlta);
            Controls.Add(tbCantidad);
            Controls.Add(tbStock);
            Controls.Add(tbModelo);
            Controls.Add(tbMarca);
            Controls.Add(tbArticulo);
            Controls.Add(tbSku);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ABCC";
            Text = "ABCC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox tbSku;
        private TextBox tbArticulo;
        private TextBox tbMarca;
        private TextBox tbModelo;
        private TextBox tbStock;
        private TextBox tbCantidad;
        private DateTimePicker dtpFechaAlta;
        private DateTimePicker dtpFechaBaja;
        private ComboBox cbDepartamento;
        private ComboBox cbClase;
        private ComboBox cbFamilia;
        private CheckBox cbDescontinuado;
        private Button btnAlta;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}
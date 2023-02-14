namespace PE1GL01GM21057
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textColor = new System.Windows.Forms.ComboBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.textRazas = new System.Windows.Forms.ComboBox();
            this.salir = new System.Windows.Forms.Button();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añosHumanos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre: ";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(197, 32);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(177, 23);
            this.textNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el color: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la raza: ";
            // 
            // textAño
            // 
            this.textAño.Location = new System.Drawing.Point(197, 163);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(100, 23);
            this.textAño.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese el año de nacimiento: ";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(452, 31);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textColor);
            this.groupBox1.Controls.Add(this.buttonBorrar);
            this.groupBox1.Controls.Add(this.textRazas);
            this.groupBox1.Controls.Add(this.salir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textAño);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 229);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // textColor
            // 
            this.textColor.FormattingEnabled = true;
            this.textColor.Items.AddRange(new object[] {
            "",
            "Blanco",
            "Negro",
            "Cafe",
            "Parchado"});
            this.textColor.Location = new System.Drawing.Point(197, 73);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(177, 23);
            this.textColor.TabIndex = 13;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(452, 72);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 12;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // textRazas
            // 
            this.textRazas.FormattingEnabled = true;
            this.textRazas.Items.AddRange(new object[] {
            "",
            "Labrador ",
            "Husky ",
            "Chiguagua",
            "Pastor Alemán",
            "Pitbull ",
            "Golden Retriever",
            "Cruzado"});
            this.textRazas.Location = new System.Drawing.Point(197, 120);
            this.textRazas.Name = "textRazas";
            this.textRazas.Size = new System.Drawing.Size(177, 23);
            this.textRazas.TabIndex = 11;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(452, 119);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 10;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.color,
            this.raza,
            this.años,
            this.añosHumanos});
            this.gridDatos.Location = new System.Drawing.Point(12, 247);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(544, 219);
            this.gridDatos.TabIndex = 11;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            // 
            // raza
            // 
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            // 
            // años
            // 
            this.años.HeaderText = "Años";
            this.años.Name = "años";
            // 
            // añosHumanos
            // 
            this.añosHumanos.HeaderText = "Años en Humanos";
            this.añosHumanos.Name = "añosHumanos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 482);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ALBERGUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private Label label2;
        private Label label3;
        private TextBox textAño;
        private Label label4;
        private Button buttonAgregar;
        private GroupBox groupBox1;
        private DataGridView gridDatos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn raza;
        private DataGridViewTextBoxColumn años;
        private DataGridViewTextBoxColumn añosHumanos;
        private Button salir;
        private ComboBox textRazas;
        private Button buttonBorrar;
        private ComboBox textColor;
    }
}
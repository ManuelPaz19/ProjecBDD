namespace appProyectoBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tapRegistro = new System.Windows.Forms.TabControl();
            this.tpRegBiblioteca = new System.Windows.Forms.TabPage();
            this.pnlRegistroBib = new System.Windows.Forms.Panel();
            this.btnGuardarBib = new System.Windows.Forms.Button();
            this.txtNomBib = new System.Windows.Forms.TextBox();
            this.txtNitBib = new System.Windows.Forms.TextBox();
            this.lbRegistroBib = new System.Windows.Forms.Label();
            this.lbNombreBib = new System.Windows.Forms.Label();
            this.lbNitBib = new System.Windows.Forms.Label();
            this.tpRegLibro = new System.Windows.Forms.TabPage();
            this.pnlLibro = new System.Windows.Forms.Panel();
            this.btnGuardarLibro = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtNumPag = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtCodLibro = new System.Windows.Forms.TextBox();
            this.lbCategoriaLib = new System.Windows.Forms.Label();
            this.lbNumPag = new System.Windows.Forms.Label();
            this.lbTituloLibro = new System.Windows.Forms.Label();
            this.lbCodLibro = new System.Windows.Forms.Label();
            this.lbRegistroLibro = new System.Windows.Forms.Label();
            this.tpConsultas = new System.Windows.Forms.TabPage();
            this.dtFechaInConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarNitBibliotecaYFecha = new System.Windows.Forms.Button();
            this.lbBuscarFechaRegIn = new System.Windows.Forms.Label();
            this.txtNitBuscarBiblioteca = new System.Windows.Forms.TextBox();
            this.lbBuscarNitBiblioteca = new System.Windows.Forms.Label();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.btnBuscarLibroAventura = new System.Windows.Forms.Button();
            this.lbConsultaAventura = new System.Windows.Forms.Label();
            this.lbConsulta1 = new System.Windows.Forms.Label();
            this.tpRegistarLibrosEnBiblioteca = new System.Windows.Forms.TabPage();
            this.pnlRegistrarLibroEnBiblioteca = new System.Windows.Forms.Panel();
            this.btnGuardarLibroEnBiblioteca = new System.Windows.Forms.Button();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIn = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaIn = new System.Windows.Forms.Label();
            this.txtCodLibroReg = new System.Windows.Forms.TextBox();
            this.txtnitBibliotecaReg = new System.Windows.Forms.TextBox();
            this.lbcodLibroReg = new System.Windows.Forms.Label();
            this.lbnitBibliotecaReg = new System.Windows.Forms.Label();
            this.tapRegistro.SuspendLayout();
            this.tpRegBiblioteca.SuspendLayout();
            this.pnlRegistroBib.SuspendLayout();
            this.tpRegLibro.SuspendLayout();
            this.pnlLibro.SuspendLayout();
            this.tpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.tpRegistarLibrosEnBiblioteca.SuspendLayout();
            this.pnlRegistrarLibroEnBiblioteca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapRegistro
            // 
            this.tapRegistro.Controls.Add(this.tpRegBiblioteca);
            this.tapRegistro.Controls.Add(this.tpRegLibro);
            this.tapRegistro.Controls.Add(this.tpConsultas);
            this.tapRegistro.Controls.Add(this.tpRegistarLibrosEnBiblioteca);
            this.tapRegistro.Location = new System.Drawing.Point(2, 5);
            this.tapRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.tapRegistro.Name = "tapRegistro";
            this.tapRegistro.SelectedIndex = 0;
            this.tapRegistro.Size = new System.Drawing.Size(804, 503);
            this.tapRegistro.TabIndex = 0;
            // 
            // tpRegBiblioteca
            // 
            this.tpRegBiblioteca.Controls.Add(this.pnlRegistroBib);
            this.tpRegBiblioteca.Location = new System.Drawing.Point(4, 25);
            this.tpRegBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.tpRegBiblioteca.Name = "tpRegBiblioteca";
            this.tpRegBiblioteca.Padding = new System.Windows.Forms.Padding(4);
            this.tpRegBiblioteca.Size = new System.Drawing.Size(796, 474);
            this.tpRegBiblioteca.TabIndex = 0;
            this.tpRegBiblioteca.Text = "Registrar Biblioteca";
            this.tpRegBiblioteca.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroBib
            // 
            this.pnlRegistroBib.Controls.Add(this.btnGuardarBib);
            this.pnlRegistroBib.Controls.Add(this.txtNomBib);
            this.pnlRegistroBib.Controls.Add(this.txtNitBib);
            this.pnlRegistroBib.Controls.Add(this.lbRegistroBib);
            this.pnlRegistroBib.Controls.Add(this.lbNombreBib);
            this.pnlRegistroBib.Controls.Add(this.lbNitBib);
            this.pnlRegistroBib.Location = new System.Drawing.Point(101, 62);
            this.pnlRegistroBib.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistroBib.Name = "pnlRegistroBib";
            this.pnlRegistroBib.Size = new System.Drawing.Size(575, 314);
            this.pnlRegistroBib.TabIndex = 0;
            this.pnlRegistroBib.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistroBib_Paint);
            // 
            // btnGuardarBib
            // 
            this.btnGuardarBib.Location = new System.Drawing.Point(277, 232);
            this.btnGuardarBib.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarBib.Name = "btnGuardarBib";
            this.btnGuardarBib.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarBib.TabIndex = 5;
            this.btnGuardarBib.Text = "Guardar";
            this.btnGuardarBib.UseVisualStyleBackColor = true;
            this.btnGuardarBib.Click += new System.EventHandler(this.btnGuardarBib_Click);
            // 
            // txtNomBib
            // 
            this.txtNomBib.Location = new System.Drawing.Point(75, 177);
            this.txtNomBib.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomBib.Name = "txtNomBib";
            this.txtNomBib.Size = new System.Drawing.Size(132, 22);
            this.txtNomBib.TabIndex = 4;
            this.txtNomBib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomBib_KeyPress);
            this.txtNomBib.Leave += new System.EventHandler(this.txtNomBib_Leave);
            // 
            // txtNitBib
            // 
            this.txtNitBib.Location = new System.Drawing.Point(75, 105);
            this.txtNitBib.Margin = new System.Windows.Forms.Padding(4);
            this.txtNitBib.Name = "txtNitBib";
            this.txtNitBib.Size = new System.Drawing.Size(132, 22);
            this.txtNitBib.TabIndex = 3;
            this.txtNitBib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNitBib_KeyPress);
            this.txtNitBib.Leave += new System.EventHandler(this.txtNitBib_Leave);
            // 
            // lbRegistroBib
            // 
            this.lbRegistroBib.AutoSize = true;
            this.lbRegistroBib.Location = new System.Drawing.Point(172, 23);
            this.lbRegistroBib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistroBib.Name = "lbRegistroBib";
            this.lbRegistroBib.Size = new System.Drawing.Size(205, 17);
            this.lbRegistroBib.TabIndex = 2;
            this.lbRegistroBib.Text = "Digite los datos de la Biblioteca";
            // 
            // lbNombreBib
            // 
            this.lbNombreBib.AutoSize = true;
            this.lbNombreBib.Location = new System.Drawing.Point(72, 147);
            this.lbNombreBib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreBib.Name = "lbNombreBib";
            this.lbNombreBib.Size = new System.Drawing.Size(67, 17);
            this.lbNombreBib.TabIndex = 1;
            this.lbNombreBib.Text = "Nombre:*";
            // 
            // lbNitBib
            // 
            this.lbNitBib.AutoSize = true;
            this.lbNitBib.Location = new System.Drawing.Point(72, 74);
            this.lbNitBib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNitBib.Name = "lbNitBib";
            this.lbNitBib.Size = new System.Drawing.Size(99, 17);
            this.lbNitBib.TabIndex = 0;
            this.lbNitBib.Text = "Nit Biblioteca:*";
            // 
            // tpRegLibro
            // 
            this.tpRegLibro.Controls.Add(this.pnlLibro);
            this.tpRegLibro.Location = new System.Drawing.Point(4, 25);
            this.tpRegLibro.Margin = new System.Windows.Forms.Padding(4);
            this.tpRegLibro.Name = "tpRegLibro";
            this.tpRegLibro.Padding = new System.Windows.Forms.Padding(4);
            this.tpRegLibro.Size = new System.Drawing.Size(796, 474);
            this.tpRegLibro.TabIndex = 1;
            this.tpRegLibro.Text = "Registrar Libro";
            this.tpRegLibro.UseVisualStyleBackColor = true;
            // 
            // pnlLibro
            // 
            this.pnlLibro.Controls.Add(this.btnGuardarLibro);
            this.pnlLibro.Controls.Add(this.cbxCategoria);
            this.pnlLibro.Controls.Add(this.txtNumPag);
            this.pnlLibro.Controls.Add(this.txtTituloLibro);
            this.pnlLibro.Controls.Add(this.txtCodLibro);
            this.pnlLibro.Controls.Add(this.lbCategoriaLib);
            this.pnlLibro.Controls.Add(this.lbNumPag);
            this.pnlLibro.Controls.Add(this.lbTituloLibro);
            this.pnlLibro.Controls.Add(this.lbCodLibro);
            this.pnlLibro.Controls.Add(this.lbRegistroLibro);
            this.pnlLibro.Location = new System.Drawing.Point(109, 69);
            this.pnlLibro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLibro.Name = "pnlLibro";
            this.pnlLibro.Size = new System.Drawing.Size(579, 309);
            this.pnlLibro.TabIndex = 0;
            this.pnlLibro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLibro_Paint);
            // 
            // btnGuardarLibro
            // 
            this.btnGuardarLibro.Location = new System.Drawing.Point(452, 263);
            this.btnGuardarLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarLibro.Name = "btnGuardarLibro";
            this.btnGuardarLibro.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarLibro.TabIndex = 9;
            this.btnGuardarLibro.Text = "Guardar";
            this.btnGuardarLibro.UseVisualStyleBackColor = true;
            this.btnGuardarLibro.Click += new System.EventHandler(this.btnGuardarLibro_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Drama",
            "Suspenso",
            "Aventura"});
            this.cbxCategoria.Location = new System.Drawing.Point(314, 195);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(160, 24);
            this.cbxCategoria.TabIndex = 8;
            // 
            // txtNumPag
            // 
            this.txtNumPag.Location = new System.Drawing.Point(314, 92);
            this.txtNumPag.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPag.Name = "txtNumPag";
            this.txtNumPag.Size = new System.Drawing.Size(160, 22);
            this.txtNumPag.TabIndex = 7;
            this.txtNumPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPag_KeyPress);
            this.txtNumPag.Leave += new System.EventHandler(this.txtNumPag_Leave);
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(44, 197);
            this.txtTituloLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(160, 22);
            this.txtTituloLibro.TabIndex = 6;
            this.txtTituloLibro.Leave += new System.EventHandler(this.txtTituloLibro_Leave);
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.Location = new System.Drawing.Point(44, 92);
            this.txtCodLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.Size = new System.Drawing.Size(160, 22);
            this.txtCodLibro.TabIndex = 5;
            this.txtCodLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodLibro_KeyPress);
            this.txtCodLibro.Leave += new System.EventHandler(this.txtCodLibro_Leave);
            // 
            // lbCategoriaLib
            // 
            this.lbCategoriaLib.AutoSize = true;
            this.lbCategoriaLib.Location = new System.Drawing.Point(311, 156);
            this.lbCategoriaLib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoriaLib.Name = "lbCategoriaLib";
            this.lbCategoriaLib.Size = new System.Drawing.Size(73, 17);
            this.lbCategoriaLib.TabIndex = 4;
            this.lbCategoriaLib.Text = "Categoría:";
            // 
            // lbNumPag
            // 
            this.lbNumPag.AutoSize = true;
            this.lbNumPag.Location = new System.Drawing.Point(311, 71);
            this.lbNumPag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumPag.Name = "lbNumPag";
            this.lbNumPag.Size = new System.Drawing.Size(136, 17);
            this.lbNumPag.TabIndex = 3;
            this.lbNumPag.Text = "Número de páginas:";
            // 
            // lbTituloLibro
            // 
            this.lbTituloLibro.AutoSize = true;
            this.lbTituloLibro.Location = new System.Drawing.Point(41, 156);
            this.lbTituloLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloLibro.Name = "lbTituloLibro";
            this.lbTituloLibro.Size = new System.Drawing.Size(47, 17);
            this.lbTituloLibro.TabIndex = 2;
            this.lbTituloLibro.Text = "Título:";
            // 
            // lbCodLibro
            // 
            this.lbCodLibro.AutoSize = true;
            this.lbCodLibro.Location = new System.Drawing.Point(41, 71);
            this.lbCodLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodLibro.Name = "lbCodLibro";
            this.lbCodLibro.Size = new System.Drawing.Size(56, 17);
            this.lbCodLibro.TabIndex = 1;
            this.lbCodLibro.Text = "Codigo:";
            // 
            // lbRegistroLibro
            // 
            this.lbRegistroLibro.AutoSize = true;
            this.lbRegistroLibro.Location = new System.Drawing.Point(185, 30);
            this.lbRegistroLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistroLibro.Name = "lbRegistroLibro";
            this.lbRegistroLibro.Size = new System.Drawing.Size(159, 17);
            this.lbRegistroLibro.TabIndex = 0;
            this.lbRegistroLibro.Text = "Digite los datos del libro";
            // 
            // tpConsultas
            // 
            this.tpConsultas.Controls.Add(this.dtFechaInConsulta);
            this.tpConsultas.Controls.Add(this.btnConsultarNitBibliotecaYFecha);
            this.tpConsultas.Controls.Add(this.lbBuscarFechaRegIn);
            this.tpConsultas.Controls.Add(this.txtNitBuscarBiblioteca);
            this.tpConsultas.Controls.Add(this.lbBuscarNitBiblioteca);
            this.tpConsultas.Controls.Add(this.dvgConsulta);
            this.tpConsultas.Controls.Add(this.btnBuscarLibroAventura);
            this.tpConsultas.Controls.Add(this.lbConsultaAventura);
            this.tpConsultas.Controls.Add(this.lbConsulta1);
            this.tpConsultas.Location = new System.Drawing.Point(4, 25);
            this.tpConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.tpConsultas.Name = "tpConsultas";
            this.tpConsultas.Padding = new System.Windows.Forms.Padding(4);
            this.tpConsultas.Size = new System.Drawing.Size(796, 474);
            this.tpConsultas.TabIndex = 2;
            this.tpConsultas.Text = "Consultas";
            this.tpConsultas.UseVisualStyleBackColor = true;
            this.tpConsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.tpConsultas_Paint);
            // 
            // dtFechaInConsulta
            // 
            this.dtFechaInConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInConsulta.Location = new System.Drawing.Point(215, 105);
            this.dtFechaInConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaInConsulta.Name = "dtFechaInConsulta";
            this.dtFechaInConsulta.Size = new System.Drawing.Size(191, 22);
            this.dtFechaInConsulta.TabIndex = 10;
            // 
            // btnConsultarNitBibliotecaYFecha
            // 
            this.btnConsultarNitBibliotecaYFecha.Location = new System.Drawing.Point(473, 103);
            this.btnConsultarNitBibliotecaYFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarNitBibliotecaYFecha.Name = "btnConsultarNitBibliotecaYFecha";
            this.btnConsultarNitBibliotecaYFecha.Size = new System.Drawing.Size(100, 28);
            this.btnConsultarNitBibliotecaYFecha.TabIndex = 9;
            this.btnConsultarNitBibliotecaYFecha.Text = "Consultar";
            this.btnConsultarNitBibliotecaYFecha.UseVisualStyleBackColor = true;
            this.btnConsultarNitBibliotecaYFecha.Click += new System.EventHandler(this.btnConsultarNitBibliotecaYFecha_Click);
            // 
            // lbBuscarFechaRegIn
            // 
            this.lbBuscarFechaRegIn.AutoSize = true;
            this.lbBuscarFechaRegIn.Location = new System.Drawing.Point(25, 105);
            this.lbBuscarFechaRegIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscarFechaRegIn.Name = "lbBuscarFechaRegIn";
            this.lbBuscarFechaRegIn.Size = new System.Drawing.Size(181, 17);
            this.lbBuscarFechaRegIn.TabIndex = 7;
            this.lbBuscarFechaRegIn.Text = "Ingrese la fecha de registro";
            // 
            // txtNitBuscarBiblioteca
            // 
            this.txtNitBuscarBiblioteca.Location = new System.Drawing.Point(215, 59);
            this.txtNitBuscarBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNitBuscarBiblioteca.Name = "txtNitBuscarBiblioteca";
            this.txtNitBuscarBiblioteca.Size = new System.Drawing.Size(132, 22);
            this.txtNitBuscarBiblioteca.TabIndex = 6;
            this.txtNitBuscarBiblioteca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNitBuscarBiblioteca_KeyPress);
            this.txtNitBuscarBiblioteca.Leave += new System.EventHandler(this.txtNitBuscarBiblioteca_Leave);
            // 
            // lbBuscarNitBiblioteca
            // 
            this.lbBuscarNitBiblioteca.AutoSize = true;
            this.lbBuscarNitBiblioteca.Location = new System.Drawing.Point(25, 59);
            this.lbBuscarNitBiblioteca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscarNitBiblioteca.Name = "lbBuscarNitBiblioteca";
            this.lbBuscarNitBiblioteca.Size = new System.Drawing.Size(175, 17);
            this.lbBuscarNitBiblioteca.TabIndex = 5;
            this.lbBuscarNitBiblioteca.Text = "Ingrese Nit de la biblioteca";
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(76, 154);
            this.dvgConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.RowHeadersWidth = 51;
            this.dvgConsulta.Size = new System.Drawing.Size(632, 161);
            this.dvgConsulta.TabIndex = 4;
            // 
            // btnBuscarLibroAventura
            // 
            this.btnBuscarLibroAventura.Location = new System.Drawing.Point(387, 361);
            this.btnBuscarLibroAventura.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLibroAventura.Name = "btnBuscarLibroAventura";
            this.btnBuscarLibroAventura.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarLibroAventura.TabIndex = 2;
            this.btnBuscarLibroAventura.Text = "Consultar";
            this.btnBuscarLibroAventura.UseVisualStyleBackColor = true;
            this.btnBuscarLibroAventura.Click += new System.EventHandler(this.btnBuscarLibroAventura_Click);
            // 
            // lbConsultaAventura
            // 
            this.lbConsultaAventura.AutoSize = true;
            this.lbConsultaAventura.Location = new System.Drawing.Point(256, 367);
            this.lbConsultaAventura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultaAventura.Name = "lbConsultaAventura";
            this.lbConsultaAventura.Size = new System.Drawing.Size(13, 17);
            this.lbConsultaAventura.TabIndex = 1;
            this.lbConsultaAventura.Text = "-";
            // 
            // lbConsulta1
            // 
            this.lbConsulta1.AutoSize = true;
            this.lbConsulta1.Location = new System.Drawing.Point(25, 367);
            this.lbConsulta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsulta1.Name = "lbConsulta1";
            this.lbConsulta1.Size = new System.Drawing.Size(203, 17);
            this.lbConsulta1.TabIndex = 0;
            this.lbConsulta1.Text = "Numero de libros de categoria:";
            // 
            // tpRegistarLibrosEnBiblioteca
            // 
            this.tpRegistarLibrosEnBiblioteca.Controls.Add(this.pnlRegistrarLibroEnBiblioteca);
            this.tpRegistarLibrosEnBiblioteca.Location = new System.Drawing.Point(4, 25);
            this.tpRegistarLibrosEnBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.tpRegistarLibrosEnBiblioteca.Name = "tpRegistarLibrosEnBiblioteca";
            this.tpRegistarLibrosEnBiblioteca.Padding = new System.Windows.Forms.Padding(4);
            this.tpRegistarLibrosEnBiblioteca.Size = new System.Drawing.Size(796, 474);
            this.tpRegistarLibrosEnBiblioteca.TabIndex = 3;
            this.tpRegistarLibrosEnBiblioteca.Text = "Registrar libro en biblioteca";
            this.tpRegistarLibrosEnBiblioteca.UseVisualStyleBackColor = true;
            // 
            // pnlRegistrarLibroEnBiblioteca
            // 
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.btnGuardarLibroEnBiblioteca);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.dtFechaFin);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.dtFechaIn);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.lbFechaFin);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.lbFechaIn);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.txtCodLibroReg);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.txtnitBibliotecaReg);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.lbcodLibroReg);
            this.pnlRegistrarLibroEnBiblioteca.Controls.Add(this.lbnitBibliotecaReg);
            this.pnlRegistrarLibroEnBiblioteca.Location = new System.Drawing.Point(143, 64);
            this.pnlRegistrarLibroEnBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistrarLibroEnBiblioteca.Name = "pnlRegistrarLibroEnBiblioteca";
            this.pnlRegistrarLibroEnBiblioteca.Size = new System.Drawing.Size(523, 358);
            this.pnlRegistrarLibroEnBiblioteca.TabIndex = 0;
            this.pnlRegistrarLibroEnBiblioteca.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistrarLibroEnBiblioteca_Paint);
            // 
            // btnGuardarLibroEnBiblioteca
            // 
            this.btnGuardarLibroEnBiblioteca.Location = new System.Drawing.Point(213, 324);
            this.btnGuardarLibroEnBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarLibroEnBiblioteca.Name = "btnGuardarLibroEnBiblioteca";
            this.btnGuardarLibroEnBiblioteca.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarLibroEnBiblioteca.TabIndex = 8;
            this.btnGuardarLibroEnBiblioteca.Text = "Registrar";
            this.btnGuardarLibroEnBiblioteca.UseVisualStyleBackColor = true;
            this.btnGuardarLibroEnBiblioteca.Click += new System.EventHandler(this.btnGuardarLibroEnBiblioteca_Click);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(196, 239);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(265, 22);
            this.dtFechaFin.TabIndex = 7;
            // 
            // dtFechaIn
            // 
            this.dtFechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIn.Location = new System.Drawing.Point(196, 153);
            this.dtFechaIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaIn.Name = "dtFechaIn";
            this.dtFechaIn.Size = new System.Drawing.Size(265, 22);
            this.dtFechaIn.TabIndex = 6;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(59, 244);
            this.lbFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(118, 17);
            this.lbFechaFin.TabIndex = 5;
            this.lbFechaFin.Text = "Fecha fin registro";
            // 
            // lbFechaIn
            // 
            this.lbFechaIn.AutoSize = true;
            this.lbFechaIn.Location = new System.Drawing.Point(59, 158);
            this.lbFechaIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaIn.Name = "lbFechaIn";
            this.lbFechaIn.Size = new System.Drawing.Size(104, 17);
            this.lbFechaIn.TabIndex = 4;
            this.lbFechaIn.Text = "Fecha Registro";
            // 
            // txtCodLibroReg
            // 
            this.txtCodLibroReg.Location = new System.Drawing.Point(196, 96);
            this.txtCodLibroReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodLibroReg.Name = "txtCodLibroReg";
            this.txtCodLibroReg.Size = new System.Drawing.Size(132, 22);
            this.txtCodLibroReg.TabIndex = 3;
            this.txtCodLibroReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodLibroReg_KeyPress);
            this.txtCodLibroReg.Leave += new System.EventHandler(this.txtCodLibroReg_Leave);
            // 
            // txtnitBibliotecaReg
            // 
            this.txtnitBibliotecaReg.Location = new System.Drawing.Point(196, 42);
            this.txtnitBibliotecaReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtnitBibliotecaReg.Name = "txtnitBibliotecaReg";
            this.txtnitBibliotecaReg.Size = new System.Drawing.Size(132, 22);
            this.txtnitBibliotecaReg.TabIndex = 2;
            this.txtnitBibliotecaReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnitBibliotecaReg_KeyPress);
            this.txtnitBibliotecaReg.Leave += new System.EventHandler(this.txtnitBibliotecaReg_Leave);
            // 
            // lbcodLibroReg
            // 
            this.lbcodLibroReg.AutoSize = true;
            this.lbcodLibroReg.Location = new System.Drawing.Point(59, 96);
            this.lbcodLibroReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcodLibroReg.Name = "lbcodLibroReg";
            this.lbcodLibroReg.Size = new System.Drawing.Size(110, 17);
            this.lbcodLibroReg.TabIndex = 1;
            this.lbcodLibroReg.Text = "Codigo del libro:";
            // 
            // lbnitBibliotecaReg
            // 
            this.lbnitBibliotecaReg.AutoSize = true;
            this.lbnitBibliotecaReg.Location = new System.Drawing.Point(59, 45);
            this.lbnitBibliotecaReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnitBibliotecaReg.Name = "lbnitBibliotecaReg";
            this.lbnitBibliotecaReg.Size = new System.Drawing.Size(94, 17);
            this.lbnitBibliotecaReg.TabIndex = 0;
            this.lbnitBibliotecaReg.Text = "Nit Biblioteca:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 509);
            this.Controls.Add(this.tapRegistro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tapRegistro.ResumeLayout(false);
            this.tpRegBiblioteca.ResumeLayout(false);
            this.pnlRegistroBib.ResumeLayout(false);
            this.pnlRegistroBib.PerformLayout();
            this.tpRegLibro.ResumeLayout(false);
            this.pnlLibro.ResumeLayout(false);
            this.pnlLibro.PerformLayout();
            this.tpConsultas.ResumeLayout(false);
            this.tpConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.tpRegistarLibrosEnBiblioteca.ResumeLayout(false);
            this.pnlRegistrarLibroEnBiblioteca.ResumeLayout(false);
            this.pnlRegistrarLibroEnBiblioteca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tapRegistro;
        private System.Windows.Forms.TabPage tpRegBiblioteca;
        private System.Windows.Forms.Panel pnlRegistroBib;
        private System.Windows.Forms.Button btnGuardarBib;
        private System.Windows.Forms.TextBox txtNomBib;
        private System.Windows.Forms.TextBox txtNitBib;
        private System.Windows.Forms.Label lbRegistroBib;
        private System.Windows.Forms.Label lbNombreBib;
        private System.Windows.Forms.Label lbNitBib;
        private System.Windows.Forms.TabPage tpRegLibro;
        private System.Windows.Forms.Panel pnlLibro;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtNumPag;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtCodLibro;
        private System.Windows.Forms.Label lbCategoriaLib;
        private System.Windows.Forms.Label lbNumPag;
        private System.Windows.Forms.Label lbTituloLibro;
        private System.Windows.Forms.Label lbCodLibro;
        private System.Windows.Forms.Label lbRegistroLibro;
        private System.Windows.Forms.Button btnGuardarLibro;
        private System.Windows.Forms.TabPage tpConsultas;
        private System.Windows.Forms.Button btnBuscarLibroAventura;
        private System.Windows.Forms.Label lbConsultaAventura;
        private System.Windows.Forms.Label lbConsulta1;
        private System.Windows.Forms.TabPage tpRegistarLibrosEnBiblioteca;
        private System.Windows.Forms.Panel pnlRegistrarLibroEnBiblioteca;
        private System.Windows.Forms.Button btnGuardarLibroEnBiblioteca;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIn;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbFechaIn;
        private System.Windows.Forms.TextBox txtCodLibroReg;
        private System.Windows.Forms.TextBox txtnitBibliotecaReg;
        private System.Windows.Forms.Label lbcodLibroReg;
        private System.Windows.Forms.Label lbnitBibliotecaReg;
        private System.Windows.Forms.Label lbBuscarFechaRegIn;
        private System.Windows.Forms.TextBox txtNitBuscarBiblioteca;
        private System.Windows.Forms.Label lbBuscarNitBiblioteca;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button btnConsultarNitBibliotecaYFecha;
        private System.Windows.Forms.DateTimePicker dtFechaInConsulta;
    }
}


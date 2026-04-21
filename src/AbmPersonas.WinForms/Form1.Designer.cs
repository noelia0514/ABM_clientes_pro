namespace AbmPersonas.WinForms;

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
        panelHeader = new Panel();
        lblUser = new Label();
        lblTitle = new Label();
        panelContent = new Panel();
        panelDetalle = new Panel();
        lblDetalleTelefono = new Label();
        lblDetalleEmail = new Label();
        lblDetalleDocumento = new Label();
        lblDetalleNombre = new Label();
        lblDetalleTitulo = new Label();
        lblDetalleTelefonoValue = new Label();
        lblDetalleEmailValue = new Label();
        lblDetalleDocumentoValue = new Label();
        lblDetalleNombreValue = new Label();
        panelFilters = new Panel();
        btnExportarCsv = new Button();
        btnNuevoCliente = new Button();
        cmbCiudad = new ComboBox();
        cmbTipo = new ComboBox();
        cmbEstado = new ComboBox();
        btnBuscar = new Button();
        txtBusqueda = new TextBox();
        lblGestion = new Label();
        dgvClientes = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        colTelefono = new DataGridViewTextBoxColumn();
        colEstado = new DataGridViewTextBoxColumn();
        colVer = new DataGridViewButtonColumn();
        colEditar = new DataGridViewButtonColumn();
        colEliminar = new DataGridViewButtonColumn();
        lblFooter = new Label();
        btnPrev = new Button();
        btnNext = new Button();
        lblPageInfo = new Label();
        panelHeader.SuspendLayout();
        panelContent.SuspendLayout();
        panelDetalle.SuspendLayout();
        panelFilters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(22, 36, 61);
        panelHeader.Controls.Add(lblUser);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(1184, 70);
        panelHeader.TabIndex = 0;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblUser.ForeColor = Color.WhiteSmoke;
        lblUser.Location = new Point(1043, 24);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(95, 23);
        lblUser.TabIndex = 1;
        lblUser.Text = "Admin  ▼";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(176, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ABM CLIENTES";
        // 
        // panelContent
        // 
        panelContent.BackColor = Color.FromArgb(245, 247, 251);
        panelContent.Controls.Add(lblPageInfo);
        panelContent.Controls.Add(btnNext);
        panelContent.Controls.Add(btnPrev);
        panelContent.Controls.Add(panelDetalle);
        panelContent.Controls.Add(lblFooter);
        panelContent.Controls.Add(dgvClientes);
        panelContent.Controls.Add(panelFilters);
        panelContent.Controls.Add(lblGestion);
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(0, 70);
        panelContent.Name = "panelContent";
        panelContent.Padding = new Padding(24);
        panelContent.Size = new Size(1184, 591);
        panelContent.TabIndex = 1;
        // 
        // panelDetalle
        // 
        panelDetalle.BackColor = Color.White;
        panelDetalle.BorderStyle = BorderStyle.FixedSingle;
        panelDetalle.Controls.Add(lblDetalleTelefonoValue);
        panelDetalle.Controls.Add(lblDetalleEmailValue);
        panelDetalle.Controls.Add(lblDetalleDocumentoValue);
        panelDetalle.Controls.Add(lblDetalleNombreValue);
        panelDetalle.Controls.Add(lblDetalleTelefono);
        panelDetalle.Controls.Add(lblDetalleEmail);
        panelDetalle.Controls.Add(lblDetalleDocumento);
        panelDetalle.Controls.Add(lblDetalleNombre);
        panelDetalle.Controls.Add(lblDetalleTitulo);
        panelDetalle.Location = new Point(860, 189);
        panelDetalle.Name = "panelDetalle";
        panelDetalle.Size = new Size(300, 339);
        panelDetalle.TabIndex = 7;
        // 
        // lblDetalleTelefono
        // 
        lblDetalleTelefono.AutoSize = true;
        lblDetalleTelefono.ForeColor = Color.FromArgb(75, 85, 99);
        lblDetalleTelefono.Location = new Point(20, 229);
        lblDetalleTelefono.Name = "lblDetalleTelefono";
        lblDetalleTelefono.Size = new Size(67, 20);
        lblDetalleTelefono.TabIndex = 4;
        lblDetalleTelefono.Text = "Telefono";
        // 
        // lblDetalleEmail
        // 
        lblDetalleEmail.AutoSize = true;
        lblDetalleEmail.ForeColor = Color.FromArgb(75, 85, 99);
        lblDetalleEmail.Location = new Point(20, 163);
        lblDetalleEmail.Name = "lblDetalleEmail";
        lblDetalleEmail.Size = new Size(46, 20);
        lblDetalleEmail.TabIndex = 3;
        lblDetalleEmail.Text = "Email";
        // 
        // lblDetalleDocumento
        // 
        lblDetalleDocumento.AutoSize = true;
        lblDetalleDocumento.ForeColor = Color.FromArgb(75, 85, 99);
        lblDetalleDocumento.Location = new Point(20, 97);
        lblDetalleDocumento.Name = "lblDetalleDocumento";
        lblDetalleDocumento.Size = new Size(90, 20);
        lblDetalleDocumento.TabIndex = 2;
        lblDetalleDocumento.Text = "Documento";
        // 
        // lblDetalleNombre
        // 
        lblDetalleNombre.AutoSize = true;
        lblDetalleNombre.ForeColor = Color.FromArgb(75, 85, 99);
        lblDetalleNombre.Location = new Point(20, 31);
        lblDetalleNombre.Name = "lblDetalleNombre";
        lblDetalleNombre.Size = new Size(64, 20);
        lblDetalleNombre.TabIndex = 1;
        lblDetalleNombre.Text = "Nombre";
        // 
        // lblDetalleTitulo
        // 
        lblDetalleTitulo.AutoSize = true;
        lblDetalleTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDetalleTitulo.ForeColor = Color.FromArgb(30, 41, 59);
        lblDetalleTitulo.Location = new Point(20, 3);
        lblDetalleTitulo.Name = "lblDetalleTitulo";
        lblDetalleTitulo.Size = new Size(160, 23);
        lblDetalleTitulo.TabIndex = 0;
        lblDetalleTitulo.Text = "Detalle del cliente";
        // 
        // lblDetalleTelefonoValue
        // 
        lblDetalleTelefonoValue.AutoSize = true;
        lblDetalleTelefonoValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetalleTelefonoValue.ForeColor = Color.FromArgb(31, 41, 55);
        lblDetalleTelefonoValue.Location = new Point(20, 254);
        lblDetalleTelefonoValue.Name = "lblDetalleTelefonoValue";
        lblDetalleTelefonoValue.Size = new Size(11, 20);
        lblDetalleTelefonoValue.TabIndex = 8;
        lblDetalleTelefonoValue.Text = "-";
        // 
        // lblDetalleEmailValue
        // 
        lblDetalleEmailValue.AutoSize = true;
        lblDetalleEmailValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetalleEmailValue.ForeColor = Color.FromArgb(31, 41, 55);
        lblDetalleEmailValue.Location = new Point(20, 188);
        lblDetalleEmailValue.Name = "lblDetalleEmailValue";
        lblDetalleEmailValue.Size = new Size(11, 20);
        lblDetalleEmailValue.TabIndex = 7;
        lblDetalleEmailValue.Text = "-";
        // 
        // lblDetalleDocumentoValue
        // 
        lblDetalleDocumentoValue.AutoSize = true;
        lblDetalleDocumentoValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetalleDocumentoValue.ForeColor = Color.FromArgb(31, 41, 55);
        lblDetalleDocumentoValue.Location = new Point(20, 122);
        lblDetalleDocumentoValue.Name = "lblDetalleDocumentoValue";
        lblDetalleDocumentoValue.Size = new Size(11, 20);
        lblDetalleDocumentoValue.TabIndex = 6;
        lblDetalleDocumentoValue.Text = "-";
        // 
        // lblDetalleNombreValue
        // 
        lblDetalleNombreValue.AutoSize = true;
        lblDetalleNombreValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetalleNombreValue.ForeColor = Color.FromArgb(31, 41, 55);
        lblDetalleNombreValue.Location = new Point(20, 56);
        lblDetalleNombreValue.Name = "lblDetalleNombreValue";
        lblDetalleNombreValue.Size = new Size(11, 20);
        lblDetalleNombreValue.TabIndex = 5;
        lblDetalleNombreValue.Text = "-";
        // 
        // panelFilters
        // 
        panelFilters.BackColor = Color.White;
        panelFilters.BorderStyle = BorderStyle.FixedSingle;
        panelFilters.Controls.Add(btnNuevoCliente);
        panelFilters.Controls.Add(btnExportarCsv);
        panelFilters.Controls.Add(cmbCiudad);
        panelFilters.Controls.Add(cmbTipo);
        panelFilters.Controls.Add(cmbEstado);
        panelFilters.Controls.Add(btnBuscar);
        panelFilters.Controls.Add(txtBusqueda);
        panelFilters.Location = new Point(24, 65);
        panelFilters.Name = "panelFilters";
        panelFilters.Size = new Size(1136, 105);
        panelFilters.TabIndex = 1;
        // 
        // btnExportarCsv
        // 
        btnExportarCsv.BackColor = Color.FromArgb(30, 64, 175);
        btnExportarCsv.FlatAppearance.BorderSize = 0;
        btnExportarCsv.FlatStyle = FlatStyle.Flat;
        btnExportarCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnExportarCsv.ForeColor = Color.White;
        btnExportarCsv.Location = new Point(826, 58);
        btnExportarCsv.Name = "btnExportarCsv";
        btnExportarCsv.Size = new Size(145, 32);
        btnExportarCsv.TabIndex = 6;
        btnExportarCsv.Text = "Exportar CSV";
        btnExportarCsv.UseVisualStyleBackColor = false;
        btnExportarCsv.Click += btnExportarCsv_Click;
        // 
        // btnNuevoCliente
        // 
        btnNuevoCliente.BackColor = Color.FromArgb(29, 78, 216);
        btnNuevoCliente.FlatAppearance.BorderSize = 0;
        btnNuevoCliente.FlatStyle = FlatStyle.Flat;
        btnNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevoCliente.ForeColor = Color.White;
        btnNuevoCliente.Location = new Point(977, 58);
        btnNuevoCliente.Name = "btnNuevoCliente";
        btnNuevoCliente.Size = new Size(145, 32);
        btnNuevoCliente.TabIndex = 5;
        btnNuevoCliente.Text = "+ Nuevo Cliente";
        btnNuevoCliente.UseVisualStyleBackColor = false;
        btnNuevoCliente.Click += btnNuevoCliente_Click;
        // 
        // cmbCiudad
        // 
        cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCiudad.FormattingEnabled = true;
        cmbCiudad.Location = new Point(465, 60);
        cmbCiudad.Name = "cmbCiudad";
        cmbCiudad.Size = new Size(180, 28);
        cmbCiudad.TabIndex = 4;
        // 
        // cmbTipo
        // 
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.FormattingEnabled = true;
        cmbTipo.Location = new Point(254, 60);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.Size = new Size(195, 28);
        cmbTipo.TabIndex = 3;
        // 
        // cmbEstado
        // 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEstado.FormattingEnabled = true;
        cmbEstado.Location = new Point(17, 60);
        cmbEstado.Name = "cmbEstado";
        cmbEstado.Size = new Size(220, 28);
        cmbEstado.TabIndex = 2;
        // 
        // btnBuscar
        // 
        btnBuscar.BackColor = Color.FromArgb(37, 99, 235);
        btnBuscar.FlatAppearance.BorderSize = 0;
        btnBuscar.FlatStyle = FlatStyle.Flat;
        btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBuscar.ForeColor = Color.White;
        btnBuscar.Location = new Point(977, 16);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(145, 30);
        btnBuscar.TabIndex = 1;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = false;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // txtBusqueda
        // 
        txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
        txtBusqueda.Location = new Point(17, 18);
        txtBusqueda.Name = "txtBusqueda";
        txtBusqueda.PlaceholderText = "Buscar por nombre, email, DNI...";
        txtBusqueda.Size = new Size(794, 27);
        txtBusqueda.TabIndex = 0;
        // 
        // lblGestion
        // 
        lblGestion.AutoSize = true;
        lblGestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblGestion.ForeColor = Color.FromArgb(31, 41, 55);
        lblGestion.Location = new Point(24, 24);
        lblGestion.Name = "lblGestion";
        lblGestion.Size = new Size(195, 28);
        lblGestion.TabIndex = 0;
        lblGestion.Text = "Gestión de Clientes";
        // 
        // dgvClientes
        // 
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.AllowUserToResizeRows = false;
        dgvClientes.BackgroundColor = Color.White;
        dgvClientes.BorderStyle = BorderStyle.None;
        dgvClientes.ColumnHeadersHeight = 38;
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colEmail, colTelefono, colEstado, colVer, colEditar, colEliminar });
        dgvClientes.EnableHeadersVisualStyles = false;
        dgvClientes.GridColor = Color.FromArgb(229, 231, 235);
        dgvClientes.Location = new Point(24, 189);
        dgvClientes.MultiSelect = false;
        dgvClientes.Name = "dgvClientes";
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersVisible = false;
        dgvClientes.RowHeadersWidth = 51;
        dgvClientes.RowTemplate.Height = 34;
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new Size(828, 339);
        dgvClientes.TabIndex = 2;
        dgvClientes.CellContentClick += dgvClientes_CellContentClick;
        dgvClientes.CellFormatting += dgvClientes_CellFormatting;
        dgvClientes.CellMouseEnter += dgvClientes_CellMouseEnter;
        dgvClientes.CellMouseLeave += dgvClientes_CellMouseLeave;
        dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
        // 
        // colId
        // 
        colId.DataPropertyName = "Codigo";
        colId.HeaderText = "ID";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Width = 70;
        // 
        // colNombre
        // 
        colNombre.DataPropertyName = "NombreCompleto";
        colNombre.HeaderText = "Nombre";
        colNombre.MinimumWidth = 6;
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;
        colNombre.Width = 210;
        // 
        // colEmail
        // 
        colEmail.DataPropertyName = "Email";
        colEmail.HeaderText = "Email";
        colEmail.MinimumWidth = 6;
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        colEmail.Width = 240;
        // 
        // colTelefono
        // 
        colTelefono.DataPropertyName = "Telefono";
        colTelefono.HeaderText = "Teléfono";
        colTelefono.MinimumWidth = 6;
        colTelefono.Name = "colTelefono";
        colTelefono.ReadOnly = true;
        colTelefono.Width = 170;
        // 
        // colEstado
        // 
        colEstado.DataPropertyName = "Estado";
        colEstado.HeaderText = "Estado";
        colEstado.MinimumWidth = 6;
        colEstado.Name = "colEstado";
        colEstado.ReadOnly = true;
        colEstado.Width = 125;
        // 
        // colVer
        // 
        colVer.HeaderText = "";
        colVer.MinimumWidth = 6;
        colVer.Name = "colVer";
        colVer.ReadOnly = true;
        colVer.Text = "Ver";
        colVer.UseColumnTextForButtonValue = true;
        colVer.Width = 85;
        // 
        // colEditar
        // 
        colEditar.HeaderText = "";
        colEditar.MinimumWidth = 6;
        colEditar.Name = "colEditar";
        colEditar.ReadOnly = true;
        colEditar.Text = "Editar";
        colEditar.UseColumnTextForButtonValue = true;
        colEditar.Width = 95;
        // 
        // colEliminar
        // 
        colEliminar.HeaderText = "";
        colEliminar.MinimumWidth = 6;
        colEliminar.Name = "colEliminar";
        colEliminar.ReadOnly = true;
        colEliminar.Text = "Eliminar";
        colEliminar.UseColumnTextForButtonValue = true;
        colEliminar.Width = 100;
        // 
        // lblFooter
        // 
        lblFooter.AutoSize = true;
        lblFooter.Font = new Font("Segoe UI", 9F);
        lblFooter.ForeColor = Color.FromArgb(75, 85, 99);
        lblFooter.Location = new Point(24, 544);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(189, 20);
        lblFooter.TabIndex = 3;
        lblFooter.Text = "Mostrando 0 a 0 de 0 clientes";
        // 
        // btnPrev
        // 
        btnPrev.Location = new Point(623, 539);
        btnPrev.Name = "btnPrev";
        btnPrev.Size = new Size(94, 29);
        btnPrev.TabIndex = 4;
        btnPrev.Text = "< Anterior";
        btnPrev.UseVisualStyleBackColor = true;
        btnPrev.Click += btnPrev_Click;
        // 
        // btnNext
        // 
        btnNext.Location = new Point(729, 539);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(96, 29);
        btnNext.TabIndex = 5;
        btnNext.Text = "Siguiente >";
        btnNext.UseVisualStyleBackColor = true;
        btnNext.Click += btnNext_Click;
        // 
        // lblPageInfo
        // 
        lblPageInfo.AutoSize = true;
        lblPageInfo.ForeColor = Color.FromArgb(75, 85, 99);
        lblPageInfo.Location = new Point(423, 543);
        lblPageInfo.Name = "lblPageInfo";
        lblPageInfo.Size = new Size(148, 20);
        lblPageInfo.TabIndex = 6;
        lblPageInfo.Text = "Pagina 1 de 1 (0 total)";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1184, 661);
        Controls.Add(panelContent);
        Controls.Add(panelHeader);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1200, 700);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ABM Clientes - WinForms";
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        panelDetalle.ResumeLayout(false);
        panelDetalle.PerformLayout();
        panelFilters.ResumeLayout(false);
        panelFilters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panelHeader;
    private Label lblUser;
    private Label lblTitle;
    private Panel panelContent;
    private Panel panelDetalle;
    private Panel panelFilters;
    private Button btnExportarCsv;
    private Button btnNuevoCliente;
    private ComboBox cmbCiudad;
    private ComboBox cmbTipo;
    private ComboBox cmbEstado;
    private Button btnBuscar;
    private TextBox txtBusqueda;
    private Label lblGestion;
    private DataGridView dgvClientes;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colEmail;
    private DataGridViewTextBoxColumn colTelefono;
    private DataGridViewTextBoxColumn colEstado;
    private DataGridViewButtonColumn colVer;
    private DataGridViewButtonColumn colEditar;
    private DataGridViewButtonColumn colEliminar;
    private Label lblFooter;
    private Button btnPrev;
    private Button btnNext;
    private Label lblPageInfo;
    private Label lblDetalleTelefono;
    private Label lblDetalleEmail;
    private Label lblDetalleDocumento;
    private Label lblDetalleNombre;
    private Label lblDetalleTitulo;
    private Label lblDetalleTelefonoValue;
    private Label lblDetalleEmailValue;
    private Label lblDetalleDocumentoValue;
    private Label lblDetalleNombreValue;
}

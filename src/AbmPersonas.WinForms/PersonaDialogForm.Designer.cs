namespace AbmPersonas.WinForms;

partial class PersonaDialogForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblApellido = new Label();
        txtApellido = new TextBox();
        lblDocumento = new Label();
        txtDocumento = new TextBox();
        lblFechaNacimiento = new Label();
        dtpFechaNacimiento = new DateTimePicker();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        chkActivo = new CheckBox();
        btnCancelar = new Button();
        btnGuardar = new Button();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(24, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(64, 20);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(24, 43);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(234, 27);
        txtNombre.TabIndex = 1;
        // 
        // lblApellido
        // 
        lblApellido.AutoSize = true;
        lblApellido.Location = new Point(276, 20);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(66, 20);
        lblApellido.TabIndex = 2;
        lblApellido.Text = "Apellido";
        // 
        // txtApellido
        // 
        txtApellido.Location = new Point(276, 43);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(234, 27);
        txtApellido.TabIndex = 3;
        // 
        // lblDocumento
        // 
        lblDocumento.AutoSize = true;
        lblDocumento.Location = new Point(24, 85);
        lblDocumento.Name = "lblDocumento";
        lblDocumento.Size = new Size(90, 20);
        lblDocumento.TabIndex = 4;
        lblDocumento.Text = "Documento";
        // 
        // txtDocumento
        // 
        txtDocumento.Location = new Point(24, 108);
        txtDocumento.Name = "txtDocumento";
        txtDocumento.Size = new Size(234, 27);
        txtDocumento.TabIndex = 5;
        // 
        // lblFechaNacimiento
        // 
        lblFechaNacimiento.AutoSize = true;
        lblFechaNacimiento.Location = new Point(276, 85);
        lblFechaNacimiento.Name = "lblFechaNacimiento";
        lblFechaNacimiento.Size = new Size(143, 20);
        lblFechaNacimiento.TabIndex = 6;
        lblFechaNacimiento.Text = "Fecha de nacimiento";
        // 
        // dtpFechaNacimiento
        // 
        dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
        dtpFechaNacimiento.Location = new Point(276, 108);
        dtpFechaNacimiento.Name = "dtpFechaNacimiento";
        dtpFechaNacimiento.Size = new Size(234, 27);
        dtpFechaNacimiento.TabIndex = 7;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(24, 152);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(46, 20);
        lblEmail.TabIndex = 8;
        lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(24, 175);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(234, 27);
        txtEmail.TabIndex = 9;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Location = new Point(276, 152);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(67, 20);
        lblTelefono.TabIndex = 10;
        lblTelefono.Text = "Telefono";
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new Point(276, 175);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(234, 27);
        txtTelefono.TabIndex = 11;
        // 
        // chkActivo
        // 
        chkActivo.AutoSize = true;
        chkActivo.Location = new Point(24, 219);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(72, 24);
        chkActivo.TabIndex = 12;
        chkActivo.Text = "Activo";
        chkActivo.UseVisualStyleBackColor = true;
        // 
        // btnCancelar
        // 
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(324, 260);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(90, 34);
        btnCancelar.TabIndex = 13;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.FromArgb(37, 99, 235);
        btnGuardar.FlatAppearance.BorderSize = 0;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(420, 260);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(90, 34);
        btnGuardar.TabIndex = 14;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // PersonaDialogForm
        // 
        AcceptButton = btnGuardar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancelar;
        ClientSize = new Size(534, 314);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        Controls.Add(chkActivo);
        Controls.Add(txtTelefono);
        Controls.Add(lblTelefono);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Controls.Add(dtpFechaNacimiento);
        Controls.Add(lblFechaNacimiento);
        Controls.Add(txtDocumento);
        Controls.Add(lblDocumento);
        Controls.Add(txtApellido);
        Controls.Add(lblApellido);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PersonaDialogForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Persona";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblApellido;
    private TextBox txtApellido;
    private Label lblDocumento;
    private TextBox txtDocumento;
    private Label lblFechaNacimiento;
    private DateTimePicker dtpFechaNacimiento;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private CheckBox chkActivo;
    private Button btnCancelar;
    private Button btnGuardar;
}

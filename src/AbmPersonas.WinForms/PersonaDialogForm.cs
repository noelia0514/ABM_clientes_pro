using AbmPersonas.Application.DTOs;

namespace AbmPersonas.WinForms;

public partial class PersonaDialogForm : Form
{
    private readonly PersonaDto? _personaOriginal;
    private readonly bool _readOnly;

    public CrearPersonaDto? CrearDto { get; private set; }
    public ActualizarPersonaDto? ActualizarDto { get; private set; }

    public PersonaDialogForm()
    {
        InitializeComponent();
        chkActivo.Checked = true;
        Text = "Nuevo Cliente";
    }

    public PersonaDialogForm(PersonaDto persona, bool readOnly = false)
    {
        InitializeComponent();
        _personaOriginal = persona;
        _readOnly = readOnly;
        BindPersona(persona);

        Text = readOnly ? "Detalle de Cliente" : "Editar Cliente";
        if (readOnly)
        {
            SetReadOnlyMode();
        }
    }

    private void BindPersona(PersonaDto persona)
    {
        txtNombre.Text = persona.Nombre;
        txtApellido.Text = persona.Apellido;
        txtDocumento.Text = persona.Documento;
        dtpFechaNacimiento.Value = persona.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
        txtEmail.Text = persona.Email ?? string.Empty;
        txtTelefono.Text = persona.Telefono ?? string.Empty;
        chkActivo.Checked = persona.Activo;
    }

    private void SetReadOnlyMode()
    {
        txtNombre.ReadOnly = true;
        txtApellido.ReadOnly = true;
        txtDocumento.ReadOnly = true;
        dtpFechaNacimiento.Enabled = false;
        txtEmail.ReadOnly = true;
        txtTelefono.ReadOnly = true;
        chkActivo.Enabled = false;
        btnGuardar.Visible = false;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        if (!ValidarFormulario())
        {
            return;
        }

        if (_personaOriginal is null)
        {
            CrearDto = new CrearPersonaDto
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value.Date),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
            };
        }
        else
        {
            ActualizarDto = new ActualizarPersonaDto
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value.Date),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                Activo = chkActivo.Checked
            };
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private bool ValidarFormulario()
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("El nombre es obligatorio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtApellido.Text))
        {
            MessageBox.Show("El apellido es obligatorio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtApellido.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtDocumento.Text))
        {
            MessageBox.Show("El documento es obligatorio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDocumento.Focus();
            return false;
        }

        return true;
    }
}

using AbmPersonas.Application.DTOs;
using AbmPersonas.Application.Interfaces;
using System.Text;

namespace AbmPersonas.WinForms;

public partial class Form1 : Form
{
    private readonly IPersonaService _personaService;
    private readonly List<ClienteView> _clientes = [];
    private List<ClienteView> _clientesFiltrados = [];
    private int _paginaActual = 1;
    private const int PageSize = 6;

    public Form1(IPersonaService personaService)
    {
        _personaService = personaService;
        InitializeComponent();
        ConfigureGridStyle();
        LoadCombos();
        txtBusqueda.KeyDown += txtBusqueda_KeyDown;
        cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
        cmbTipo.Enabled = false;
        cmbCiudad.Enabled = false;
        Shown += Form1_Shown;
    }

    private void ConfigureGridStyle()
    {
        dgvClientes.AutoGenerateColumns = false;
        dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
        dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dgvClientes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dgvClientes.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
        dgvClientes.DefaultCellStyle.BackColor = Color.White;
        colVer.DefaultCellStyle.BackColor = Color.FromArgb(219, 234, 254);
        colEditar.DefaultCellStyle.BackColor = Color.FromArgb(220, 252, 231);
        colEliminar.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
        colVer.DefaultCellStyle.ForeColor = Color.FromArgb(30, 64, 175);
        colEditar.DefaultCellStyle.ForeColor = Color.FromArgb(21, 128, 61);
        colEliminar.DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28);
        colVer.DefaultCellStyle.SelectionBackColor = colVer.DefaultCellStyle.BackColor;
        colEditar.DefaultCellStyle.SelectionBackColor = colEditar.DefaultCellStyle.BackColor;
        colEliminar.DefaultCellStyle.SelectionBackColor = colEliminar.DefaultCellStyle.BackColor;
        colVer.DefaultCellStyle.SelectionForeColor = colVer.DefaultCellStyle.ForeColor;
        colEditar.DefaultCellStyle.SelectionForeColor = colEditar.DefaultCellStyle.ForeColor;
        colEliminar.DefaultCellStyle.SelectionForeColor = colEliminar.DefaultCellStyle.ForeColor;
        colVer.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        colEditar.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        colEliminar.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        colVer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colEditar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colVer.ToolTipText = "Ver detalle del cliente";
        colEditar.ToolTipText = "Editar cliente";
        colEliminar.ToolTipText = "Eliminar cliente";
    }

    private void LoadCombos()
    {
        cmbEstado.Items.AddRange(["Todos", "Activo", "Inactivo"]);
        cmbTipo.Items.AddRange(["Todos"]);
        cmbCiudad.Items.AddRange(["Todas"]);

        cmbEstado.SelectedIndex = 0;
        cmbTipo.SelectedIndex = 0;
        cmbCiudad.SelectedIndex = 0;
    }

    private async void Form1_Shown(object? sender, EventArgs e)
    {
        await RefreshFromDatabaseAsync();
    }

    private async Task RefreshFromDatabaseAsync()
    {
        try
        {
            var personas = await _personaService.GetAllAsync();
            _clientes.Clear();
            _clientes.AddRange(personas.Select(MapToView));
            _paginaActual = 1;
            AplicarFiltros();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"No se pudo cargar la informacion de SQL Server.\nDetalle: {ex.Message}",
                "Error de conexion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void AplicarFiltros()
    {
        var texto = txtBusqueda.Text.Trim().ToLowerInvariant();
        var estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

        var query = _clientes.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(texto))
        {
            query = query.Where(x =>
                x.NombreCompleto.ToLowerInvariant().Contains(texto) ||
                x.Email.ToLowerInvariant().Contains(texto) ||
                x.Codigo.ToLowerInvariant().Contains(texto) ||
                x.Documento.ToLowerInvariant().Contains(texto));
        }

        if (!string.Equals(estado, "Todos", StringComparison.OrdinalIgnoreCase))
        {
            query = query.Where(x => x.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase));
        }

        _clientesFiltrados = query.ToList();
        CargarPagina();
    }

    private void CargarPagina()
    {
        var total = _clientesFiltrados.Count;
        var totalPaginas = Math.Max(1, (int)Math.Ceiling(total / (double)PageSize));
        if (_paginaActual > totalPaginas)
        {
            _paginaActual = totalPaginas;
        }
        if (_paginaActual < 1)
        {
            _paginaActual = 1;
        }

        var inicio = (_paginaActual - 1) * PageSize;
        var pagina = _clientesFiltrados.Skip(inicio).Take(PageSize).ToList();
        dgvClientes.DataSource = pagina;

        var desde = total == 0 ? 0 : inicio + 1;
        var hasta = total == 0 ? 0 : inicio + pagina.Count;
        lblFooter.Text = $"Mostrando {desde} a {hasta} de {total} clientes";
        lblPageInfo.Text = $"Pagina {_paginaActual} de {totalPaginas} ({total} total)";

        btnPrev.Enabled = _paginaActual > 1;
        btnNext.Enabled = _paginaActual < totalPaginas;
        ActualizarPanelDetalle();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        _paginaActual = 1;
        AplicarFiltros();
    }

    private void cmbEstado_SelectedIndexChanged(object? sender, EventArgs e)
    {
        _paginaActual = 1;
        AplicarFiltros();
    }

    private void txtBusqueda_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
        {
            return;
        }

        e.SuppressKeyPress = true;
        _paginaActual = 1;
        AplicarFiltros();
    }

    private async void btnNuevoCliente_Click(object sender, EventArgs e)
    {
        using var dialog = new PersonaDialogForm();
        if (dialog.ShowDialog(this) != DialogResult.OK || dialog.CrearDto is null)
        {
            return;
        }

        try
        {
            await _personaService.CreateAsync(dialog.CrearDto);
            await RefreshFromDatabaseAsync();
            MessageBox.Show("Cliente creado correctamente.", "ABM Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem as ClienteView;
        if (cliente is null)
        {
            return;
        }

        var columnName = dgvClientes.Columns[e.ColumnIndex].Name;
        if (columnName == "colVer")
        {
            using var dialog = new PersonaDialogForm(cliente.ToPersonaDto(), true);
            dialog.ShowDialog(this);
        }
        else if (columnName == "colEditar")
        {
            using var dialog = new PersonaDialogForm(cliente.ToPersonaDto());
            if (dialog.ShowDialog(this) != DialogResult.OK || dialog.ActualizarDto is null)
            {
                return;
            }

            try
            {
                await _personaService.UpdateAsync(cliente.Id, dialog.ActualizarDto);
                await RefreshFromDatabaseAsync();
                MessageBox.Show("Cliente actualizado.", "ABM Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else if (columnName == "colEliminar")
        {
            var confirmar = MessageBox.Show(
                $"Confirma eliminar a {cliente.NombreCompleto}?",
                "Eliminar cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            try
            {
                await _personaService.DeleteAsync(cliente.Id);
                await RefreshFromDatabaseAsync();
                MessageBox.Show("Cliente eliminado.", "ABM Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var columnName = dgvClientes.Columns[e.ColumnIndex].Name;
        if (columnName == "colEstado")
        {
            var estado = e.Value?.ToString() ?? string.Empty;
            if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }
        }
    }

    private void dgvClientes_SelectionChanged(object sender, EventArgs e)
    {
        ActualizarPanelDetalle();
    }

    private void dgvClientes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
        {
            return;
        }

        var columnName = dgvClientes.Columns[e.ColumnIndex].Name;
        Cursor = columnName is "colVer" or "colEditar" or "colEliminar"
            ? Cursors.Hand
            : Cursors.Default;
    }

    private void dgvClientes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
    {
        Cursor = Cursors.Default;
    }

    private void ActualizarPanelDetalle()
    {
        var cliente = ObtenerClienteSeleccionado();
        if (cliente is null)
        {
            lblDetalleNombreValue.Text = "-";
            lblDetalleDocumentoValue.Text = "-";
            lblDetalleEmailValue.Text = "-";
            lblDetalleTelefonoValue.Text = "-";
            return;
        }

        lblDetalleNombreValue.Text = cliente.NombreCompleto;
        lblDetalleDocumentoValue.Text = cliente.Documento;
        lblDetalleEmailValue.Text = cliente.Email;
        lblDetalleTelefonoValue.Text = cliente.Telefono;
    }

    private ClienteView? ObtenerClienteSeleccionado()
    {
        if (dgvClientes.CurrentRow?.DataBoundItem is ClienteView cliente)
        {
            return cliente;
        }

        return null;
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
        _paginaActual--;
        CargarPagina();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        _paginaActual++;
        CargarPagina();
    }

    private void btnExportarCsv_Click(object sender, EventArgs e)
    {
        if (_clientesFiltrados.Count == 0)
        {
            MessageBox.Show("No hay datos para exportar.", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Filter = "CSV (*.csv)|*.csv",
            FileName = $"clientes_{DateTime.Now:yyyyMMdd_HHmm}.csv",
            Title = "Exportar clientes filtrados"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var sb = new StringBuilder();
        sb.AppendLine("Id,Nombre,Documento,Email,Telefono,Estado");
        foreach (var item in _clientesFiltrados)
        {
            sb.AppendLine(
                $"{item.Codigo}," +
                $"{EscapeCsv(item.NombreCompleto)}," +
                $"{EscapeCsv(item.Documento)}," +
                $"{EscapeCsv(item.Email)}," +
                $"{EscapeCsv(item.Telefono)}," +
                $"{item.Estado}");
        }

        File.WriteAllText(dialog.FileName, sb.ToString(), Encoding.UTF8);
        MessageBox.Show("Exportacion generada correctamente.", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static string EscapeCsv(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return string.Empty;
        }

        if (!value.Contains(',') && !value.Contains('"') && !value.Contains('\n'))
        {
            return value;
        }

        return $"\"{value.Replace("\"", "\"\"")}\"";
    }

    private static ClienteView MapToView(PersonaDto dto) =>
        new(
            dto,
            dto.Id.ToString("D3"),
            $"{dto.Nombre} {dto.Apellido}",
            dto.Documento,
            dto.Email ?? "-",
            dto.Telefono ?? "-",
            dto.Activo ? "Activo" : "Inactivo");
}

public record ClienteView(
    PersonaDto Persona,
    string Codigo,
    string NombreCompleto,
    string Documento,
    string Email,
    string Telefono,
    string Estado)
{
    public int Id => Persona.Id;

    public PersonaDto ToPersonaDto() => Persona;
}

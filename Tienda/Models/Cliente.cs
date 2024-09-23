using System;
using System.Collections.Generic;

namespace Tienda.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public int? Telefono { get; set; }

    public string? Direccion { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}

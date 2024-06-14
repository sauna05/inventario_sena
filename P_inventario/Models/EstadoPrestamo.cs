using System;
using System.Collections.Generic;

namespace P_inventario.DB;

public partial class EstadoPrestamo
{
    public int Id { get; set; }

    public string? NombreEstadoPrestamo { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}

using System;
using System.Collections.Generic;

namespace CRUD_PRUEBA.Models;

public partial class Empleado
{
    public string Nue { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Puesto { get; set; }
}

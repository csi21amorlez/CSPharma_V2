using System;
using System.Collections.Generic;

namespace DAL_CSPharmaV2.Models;

/// <summary>
/// Tabla de la base de datos &quot;dlk_informacional&quot; la cual contendra la informacion de los usuarios registrados en nuestra aplicacion web 
/// </summary>
public partial class DlkCatAccEmpleado
{
    public string MdUidd { get; set; } = null!;

    public TimeOnly? MdDate { get; set; }

    public string CodEmpleado { get; set; } = null!;

    public string ClaveEmpleado { get; set; } = null!;

    public int NivelAccesoEmpleado { get; set; }
}

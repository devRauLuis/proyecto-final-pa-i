using System.ComponentModel.DataAnnotations;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.Entidades;

public class Sintoma : ICreatedUpdated, IIdentifiable
{
    [Key] public int? Id { get; set; }

    [Required] public string Descripcion { get; set; }

    public DateTime? CreadoEn { get; set; } = DateTime.Now;

    public DateTime? ActualizadoEn { get; set; } = DateTime.Now;
}
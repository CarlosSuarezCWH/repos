using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }

    [Required]
    [StringLength(100)]
    public string NombreEmpleado { get; set; }

    [Required]
    [StringLength(100)]
    public string ApellidoEmpleado { get; set; }

    [StringLength(50)]
    public string Puesto { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salario { get; set; }

    public DateTime FechaContratacion { get; set; }

    [ForeignKey("Departamento")]
    public int IdDepartamento { get; set; }

    [JsonIgnore] // Opcional: Para evitar que aparezca en Swagger
    public Departamento Departamento { get; set; }
}

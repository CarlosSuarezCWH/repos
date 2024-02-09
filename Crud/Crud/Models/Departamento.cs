using System.ComponentModel.DataAnnotations;

public class Departamento
{
    [Key]
    public int IdDepartamento { get; set; }

    public string NombreDepartamento { get; set; }

    // Otras propiedades del departamento

    // Relación con los empleados (opcional)
    public List<Empleado> Empleados { get; set; }
}

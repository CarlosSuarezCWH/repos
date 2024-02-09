using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class EmpleadoController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public EmpleadoController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Empleado>> GetEmpleados()
    {
        return _dbContext.Empleados.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Empleado> GetEmpleado(int id)
    {
        var empleado = _dbContext.Empleados.Find(id);

        if (empleado == null)
        {
            return NotFound();
        }

        return empleado;
    }

    // Otros métodos para crear, actualizar y eliminar empleados
}

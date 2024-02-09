using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    // Otros DbSet para tus otras entidades si las tienes

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuraciones adicionales, como restricciones, índices, etc.
        // Puedes agregar configuraciones específicas aquí si es necesario.

        // Ejemplo: Configuración de la relación entre Empleado y Departamento
        modelBuilder.Entity<Empleado>()
            .HasOne(e => e.Departamento)
            .WithMany()
            .HasForeignKey(e => e.IdDepartamento)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

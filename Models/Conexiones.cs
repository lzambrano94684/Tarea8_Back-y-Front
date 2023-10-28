using Microsoft.EntityFrameworkCore;

namespace ApiEmpresa.Models;

public class Conexiones : DbContext{

    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Estudiante> Estudiantes { get; set;}=null!;


}
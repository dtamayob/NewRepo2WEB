using Dapper;
using Microsoft.Data.SqlClient;
using ProyectoWEB.Models;

namespace ProyectoWEB.Servicios
{
    public class RepositorioRegistro : IRepositorioRegistro
    {
        private readonly string connectionString;

        public RepositorioRegistro(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection") ??
                               throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }


        public void Create(Persona persona)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>(
                @"INSERT INTO Persona 
        (NombreCompleto, Usuario, Contrasena, Correo, Sexo, Ciudad, AceptaTerminos) 
        VALUES 
        (@NombreCompleto, @Usuario, @Contrasena, @Correo, @Sexo, @Ciudad, @AceptaTerminos);
        SELECT SCOPE_IDENTITY();", persona);

            persona.Id = id;
        }
    }
}
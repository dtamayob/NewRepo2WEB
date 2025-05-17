using Microsoft.AspNetCore.Mvc;
using ProyectoWEB.Models;

namespace ProyectoWEB.Servicios
{
    public interface IRepositorioRegistro 
    {
        void Create(Persona persona);
    }
}

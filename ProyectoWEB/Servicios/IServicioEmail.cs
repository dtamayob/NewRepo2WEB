using ProyectoWEB.Models;

namespace ProyectoWEB.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
}
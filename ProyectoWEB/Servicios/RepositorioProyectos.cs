using ProyectoWEB.Models;

namespace ProyectoWEB.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> listadoProyectos = new List<Proyecto> {
                new Proyecto
                {
                    Titulo = "Tarta de Manzana Casera",
                    Descripcion = "Una tarta crujiente por fuera y suave por dentro, con manzanas caramelizadas, un toque de canela y una masa dorada perfecta. Ideal para acompañar con una bola de helado de vainilla o una taza de café.",
                    Link = "https://www.youtube.com/watch?v=SzQWsRETIBU&pp=0gcJCdgAo7VqN5tD",
                    ImagenURL = "/imagenes/Recetas/receta1.jpg"
                },
                new Proyecto
                {
                    Titulo = "Brownies de Chocolate y Nueces",
                    Descripcion = "Estos brownies son la mezcla perfecta entre lo denso y lo suave, con trozos de nuez que agregan un toque crujiente. Un postre irresistible para los amantes del chocolate, ideal para acompañar con un vaso de leche fría o una taza de café.    .",
                    Link = "https://www.youtube.com/watch?v=e6Zs8_5V7T4&t=1s",
                    ImagenURL = "/imagenes/Recetas/receta2.jpg"
                },
                new Proyecto
                {
                    Titulo = "Ensalada Mediterránea de Pollo",
                    Descripcion = "Una ensalada fresca y saludable que combina pechuga de pollo a la parrilla, vegetales frescos, aceitunas negras, pepino, tomate, cebolla roja y queso feta. Todo ello aderezado con una vinagreta de aceite de oliva, limón y orégano. Esta ensalada es perfecta para una comida ligera pero satisfactoria, ideal para el almuerzo o una cena ligera.",
                    Link = "https://www.youtube.com/watch?v=T8rlSu5WP60",
                    ImagenURL = "/imagenes/Recetas/receta3.jpg"
                },  
                new Proyecto
                {
                    Titulo = "Tostadas de aguacate con huevo pochado\n",
                    Descripcion = "Un desayuno nutritivo y rápido de preparar. La combinación cremosa del aguacate con la yema suave del huevo pochado sobre pan crujiente es perfecta para empezar bien el día",
                    Link = "https://www.youtube.com/watch?v=4Gc8vYgLAII",
                    ImagenURL = "/imagenes/Recetas/receta4.jpg"
                }
                ,
                new Proyecto
                {
                    Titulo = "Pasta cremosa con espinacas y champiñones\n",
                    Descripcion = "Una receta vegetariana y reconfortante, con una salsa cremosa que se mezcla perfectamente con espinacas frescas y champiñones salteados.",
                    Link = "https://www.youtube.com/watch?v=v-lboZGw6ishttps://www.youtube.com/watch?v=v-lboZGw6is",
                    ImagenURL = "/imagenes/Recetas/receta5.jpg"
                }
                ,
                new Proyecto
                {
                    Titulo = "Pollo al horno con papas y hierbas",
                    Descripcion = "Un plato fuerte clásico, fácil de preparar y lleno de sabor. El pollo queda jugoso y las papas absorben los jugos y las hierbas.",
                    Link = "https://www.youtube.com/watch?v=bqZ5mKYc0AQ",
                    ImagenURL = "/imagenes/Recetas/receta6.jpg"
                }
            };

            return listadoProyectos;
        }
    }
}

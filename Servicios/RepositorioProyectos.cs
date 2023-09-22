using _1.proyecto.Models;

namespace _1.proyecto.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> { 
                new Proyecto
                {
                    Titulo = "Multicash revolution -> Picmatic",
                    Descripcion = "Actualmente desarrollando",
                    Link = "https://www.picmatic.es/index.php/multicash-revolution/",
                    ImagenURL = "/imagenes/revolution.png"
                },
                new Proyecto
                {
                    Titulo = "Multicash platino -> Picmatic",
                    Descripcion = "Desarrollo, testeo y puesta en producción del software multicash",
                    Link = "https://www.picmatic.es/index.php/multicash-platino",
                    ImagenURL = "/imagenes/platino.png"
                },
                new Proyecto
                {
                    Titulo = "Eroski",
                    Descripcion = "Microservicios con asp .net",
                    Link = "https://www.eroski.es/",
                    ImagenURL = "/imagenes/eroski.png"
                },
                new Proyecto
                {
                    Titulo = "Arratek",
                    Descripcion = "Mantenimiento de la web con wordpress + php",
                    Link = "https://arratek.com",
                    ImagenURL = "/imagenes/arratek.png"
                }
            };
        }
    }
}
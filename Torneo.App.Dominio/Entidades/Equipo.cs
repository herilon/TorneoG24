using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
        public DirectorTecnico DirectorTecnico { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace APIORACLE.Entities
{
    public class Alumnos
    {
        // Mapea la columna 'id_alumno', que es la clave primaria
        public int id_alumno { get; set; }

        // Mapea la columna 'nombre_alumno'
        public string nombre_alumno { get; set; }

        // Mapea la columna 'apellido_alumno'
        public string apellido_alumno { get; set; }

        // Mapea la columna 'bday_alumno' que es de tipo DATE
        public DateTime bday_alumno { get; set; }

        // Mapea la columna 'correo_alumno'
        public string correo_alumno { get; set; }

        // Mapea la columna 'id_grupo' que es una clave foránea
        public int id_grupo { get; set; }

        [ForeignKey(nameof(id_grupo))]
        public Grupos? GRUPOS_NAV { get; set; }
    }
}

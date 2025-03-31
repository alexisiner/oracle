namespace APIORACLE.Entities
{
    public class Grupos
    {

        public int IdGrupo { get; set; }  // La clave primaria de la tabla Grupos
        public string NombreGrupo { get; set; }  // Otros atributos de la tabla Grupos

        // Relación con Alumnos
        public ICollection<Alumno> Alumnos { get; set; }  // Un Grupo puede tener muchos Alumnos
    }
}

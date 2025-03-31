using APIORACLE.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIORACLE.Intefaces
{
    public interface IAlumnoRepository
    {
        List<Alumno> ObtenerAlumnos(int aux);
        List<Alumnos> ObtenerAlumnosfull();
    }
}

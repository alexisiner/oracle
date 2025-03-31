using APIORACLE.Data;
using APIORACLE.Entities;
using APIORACLE.Intefaces;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace APIORACLE.Infrastructure
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly OracleDbContext _context;

        public AlumnoRepository(OracleDbContext context)
        {
            _context = context;
        }

        public List<Alumno> ObtenerAlumnos(int id_alumno)
        {
            try
            {
                var listaAlumnos = _context.Alumno
                .FromSqlRaw("EXEC Lista @id_alumno = {0}", id_alumno)
                .ToList();

                return listaAlumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }

        public List<Alumnos> ObtenerAlumnosfull()
        {
            return _context.Alumnos.ToList();
        }

    }

}

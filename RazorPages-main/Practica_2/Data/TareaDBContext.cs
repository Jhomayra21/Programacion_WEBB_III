using Microsoft.EntityFrameworkCore;
using Practica_2.Models;

namespace Practica_2.Data
{
    public class TareaDBContext:DbContext
    {
        public TareaDBContext(DbContextOptions<TareaDBContext> options):base(options)//investigacion de que hace esta linea
        {

        }
        public DbSet<Tarea> Tareas { get; set; }//tarea de investigacion 
     
    }
}

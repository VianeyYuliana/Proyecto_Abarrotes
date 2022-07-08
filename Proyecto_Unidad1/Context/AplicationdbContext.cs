using Microsoft.EntityFrameworkCore;
using Proyecto_Unidad1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Unidad1.Context
{
    public class AplicationdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseMySQL("server = localhost; database= proyecto_unidad1; user= root; password= ");
        }
        public DbSet<Usuario> Usuario { get; set; }

    }
}

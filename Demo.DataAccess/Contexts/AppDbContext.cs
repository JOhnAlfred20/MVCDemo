using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        // parent => child 
        // public void test (animal  a ) 




        //nada
        // nada nada = new nada (4) ;

        //public AppContext(nada nada)  ask clr to create object from nada
        //{

        //}
        //step  1 : inject




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("ConnectionString");
        //}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        }
        public DbSet<Department> Departments { get; set; }
    }
}

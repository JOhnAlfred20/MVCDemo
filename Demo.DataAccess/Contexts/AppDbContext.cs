using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Contexts
{
    public class AppDbContext : DbContext
    {
        // Constructor with Dependency Injection
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // يمكنك إضافة أي كود تهيئة هنا إذا لزم الأمر
        }

        // parent => child 
        // public void test (animal  a ) 

        // مثال على إنشاء كائن:
        // nada nada = new nada (4);

        // مثال على حقن التبعية:
        // public AppContext(nada nada) // سيطلب من CLR إنشاء كائن من nada
        // {
        // }

        // طريقة بديلة لتهيئة الاتصال (غير مستحبة عند استخدام DI)
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    //optionsBuilder.UseSqlServer("ConnectionString");
        // }

        // تهيئة نموذج البيانات
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // تطبيق جميع تكوينات الكيانات من الأسمبلي الحالي
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // طريقة بديلة:
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        // تعريف الجداول في قاعدة البيانات




        public DbSet<Department> Departments { get; set; }
    }
}
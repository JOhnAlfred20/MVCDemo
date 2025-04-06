
namespace Demo.DataAccess.Data.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(dept=>dept.Id).UseIdentityColumn(10,10);
            builder.Property(dept => dept.Name).HasColumnType("varchar(20)");
            builder.Property(dept => dept.Code).HasColumnType("varchar(20)");


            builder.Property(dept => dept.CreatedOn).HasDefaultValueSql("GETDATE()");
            //if row is Insert without value , the default value will be used
            //on insert
            //Cant refernce other columns 
            //Canc be overridden
            builder.Property(dept => dept.LastModifiedOn).HasComputedColumnSql("GETDATE()");
            //Value is computed every time changed 
            //on update
        }
    }
}

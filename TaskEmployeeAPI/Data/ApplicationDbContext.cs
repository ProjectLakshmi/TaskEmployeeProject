using Microsoft.EntityFrameworkCore;
using TaskEmployeeAPI.Modals;
using  TaskEmployeeAPI.Modals;

namespace TaskEmployeeAPI.Modals
{
    public partial class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Task> Tasks { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-52LKJQU;Initial Catalog=TaskManager;Integrated Security=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId).HasName("PK__employee__C52E0BA82B1A4D23");

                entity.ToTable("employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("employee_id");
                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");
                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");
                entity.Property(e => e.Role)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValue("Employee")
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.TaskId).HasColumnName("task_id");
                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_id");
                entity.Property(e => e.TaskDiscrption)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("task_discrption");
                entity.Property(e => e.TaskStatus).HasColumnName("task_status");
            });
            modelBuilder.HasSequence<int>("EmployeeTaskSequence").HasMin(1L);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCProject1.Models
{
    public partial class projectDemoContext : DbContext
    {
        public projectDemoContext()
        {
        }

        public projectDemoContext(DbContextOptions<projectDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpTemp> EmpTemp { get; set; }
        public virtual DbSet<Employee2> Employee2 { get; set; }
        public virtual DbSet<Employee4> Employee4 { get; set; }
        public virtual DbSet<EmployeeTemp> EmployeeTemp { get; set; }
        public virtual DbSet<Employees3> Employees3 { get; set; }
        public virtual DbSet<Leave4> Leave4 { get; set; }
        public virtual DbSet<Leave5> Leave5 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-HSCV0U7;Database=projectDemo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpTemp>(entity =>
            {
                entity.ToTable("Emp_Temp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dmanager)
                    .IsRequired()
                    .HasColumnName("dmanager")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LeaveDesc)
                    .HasColumnName("leave_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveFrom)
                    .HasColumnName("leave_from")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveTo)
                    .HasColumnName("leave_to")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveType)
                    .HasColumnName("leave_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavesInHand).HasColumnName("leaves_in_hand");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Employee4>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__employee__7AD04FF14549B8BB");

                entity.ToTable("employee4");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_ManagerID2");
            });

            modelBuilder.Entity<EmployeeTemp>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees3>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1C5058090");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveEndDate).HasColumnType("date");

                entity.Property(e => e.LeaveStartDate).HasColumnType("date");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_ManagerID");
            });

            modelBuilder.Entity<Leave4>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PK__leave4__C6555721A2D0D9DD");

                entity.ToTable("leave4");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveEnd)
                    .HasColumnName("Leave_End")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveStart)
                    .HasColumnName("Leave_Start")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveStatus).HasColumnName("Leave_status");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasColumnName("Leave_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Leave4)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeID4");
            });

            modelBuilder.Entity<Leave5>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PK__leave5__C655572195498972");

                entity.ToTable("leave5");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveEnd)
                    .HasColumnName("Leave_End")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveStart)
                    .HasColumnName("Leave_Start")
                    .HasColumnType("date");

                entity.Property(e => e.LeaveStatus)
                    .HasColumnName("Leave_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasColumnName("Leave_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

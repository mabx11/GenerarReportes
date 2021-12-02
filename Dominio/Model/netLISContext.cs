using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dominio.Model
{
    public partial class netLISContext : DbContext
    {
        

        public netLISContext(DbContextOptions<netLISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public virtual DbSet<TblCatAreasLabServicio> TblCatAreasLabServicios { get; set; }
        public virtual DbSet<TblCatAreasServ> TblCatAreasServs { get; set; }
        public virtual DbSet<TblCatCategoriaExamene> TblCatCategoriaExamenes { get; set; }
        public virtual DbSet<TblCatDepartamento> TblCatDepartamentos { get; set; }
        public virtual DbSet<TblCatEstadoCivil> TblCatEstadoCivils { get; set; }
        public virtual DbSet<TblCatHospital> TblCatHospitals { get; set; }
        public virtual DbSet<TblCatIdentificacion> TblCatIdentificacions { get; set; }
        public virtual DbSet<TblCatIndicacionExaPaciente> TblCatIndicacionExaPacientes { get; set; }
        public virtual DbSet<TblCatMetodologium> TblCatMetodologia { get; set; }
        public virtual DbSet<TblCatNacionalidad> TblCatNacionalidads { get; set; }
        public virtual DbSet<TblCatOcupacione> TblCatOcupaciones { get; set; }
        public virtual DbSet<TblCatPai> TblCatPais { get; set; }
        public virtual DbSet<TblCatPerfile> TblCatPerfiles { get; set; }
        public virtual DbSet<TblCatPerfilesExamene> TblCatPerfilesExamenes { get; set; }
        public virtual DbSet<TblCatProfesione> TblCatProfesiones { get; set; }
        public virtual DbSet<TblCatSexo> TblCatSexos { get; set; }
        public virtual DbSet<TblCatSucursale> TblCatSucursales { get; set; }
        public virtual DbSet<TblCatTipoMuestra> TblCatTipoMuestras { get; set; }
        public virtual DbSet<TblCatTipoOrden> TblCatTipoOrdens { get; set; }
        public virtual DbSet<TblCatTipoResultado> TblCatTipoResultados { get; set; }
        public virtual DbSet<TblCatTipoSangre> TblCatTipoSangres { get; set; }
        public virtual DbSet<TblCatTipoServicio> TblCatTipoServicios { get; set; }
        public virtual DbSet<TblCatTipoUsuario> TblCatTipoUsuarios { get; set; }
        public virtual DbSet<TblCatUnidadMedida> TblCatUnidadMedidas { get; set; }
        public virtual DbSet<TblCatValoresNormale> TblCatValoresNormales { get; set; }
        public virtual DbSet<TblEmpleado> TblEmpleados { get; set; }
        public virtual DbSet<TblExamene> TblExamenes { get; set; }
        public virtual DbSet<TblMedico> TblMedicos { get; set; }
        public virtual DbSet<TblOrdene> TblOrdenes { get; set; }
        public virtual DbSet<TblOrdenesDetalle> TblOrdenesDetalles { get; set; }
        public virtual DbSet<TblPaciente> TblPacientes { get; set; }
        public virtual DbSet<TblResultado> TblResultados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=netLIS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TblAreaServLabEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdAreaServLabEmpleados)
                    .HasName("PK15");

                entity.ToTable("tbl_AreaServLabEmpleados");

                entity.HasOne(d => d.IdAreaLabServicioNavigation)
                    .WithMany(p => p.TblAreaServLabEmpleados)
                    .HasForeignKey(d => d.IdAreaLabServicio)
                    .HasConstraintName("Reftbl_cat_AreasLabServicio401");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.TblAreaServLabEmpleados)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_Empleado411");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.TblAreaServLabEmpleados)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_AreaServLabEmpleados_tbl_cat_Sucursales");
            });

            modelBuilder.Entity<TblCatAreasLabServicio>(entity =>
            {
                entity.HasKey(e => e.IdAreaLabServicio)
                    .HasName("PK13");

                entity.ToTable("tbl_cat_AreasLabServicio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatAreasServ>(entity =>
            {
                entity.HasKey(e => e.IdAreaServ)
                    .HasName("PK12");

                entity.ToTable("tbl_cat_AreasServ");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DescripcionCorta)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblCatCategoriaExamene>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaExamenes)
                    .HasName("PK27");

                entity.ToTable("tbl_cat_CategoriaExamenes");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatDepartamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK5");

                entity.ToTable("tbl_cat_Departamento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCatEstadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil)
                    .HasName("PK2");

                entity.ToTable("tbl_cat_EstadoCivil");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblCatHospital>(entity =>
            {
                entity.HasKey(e => e.IdHospital)
                    .HasName("PK10");

                entity.ToTable("tbl_cat_Hospital");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatIdentificacion>(entity =>
            {
                entity.HasKey(e => e.IdIdentificacion)
                    .HasName("PK8");

                entity.ToTable("tbl_cat_Identificacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.TblCatIdentificacions)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_cat_Identificacion_tbl_cat_Nacionalidad");
            });

            modelBuilder.Entity<TblCatIndicacionExaPaciente>(entity =>
            {
                entity.HasKey(e => e.IdIndicacionExaPaciente)
                    .HasName("PK22");

                entity.ToTable("tbl_cat_IndicacionExaPaciente");

                entity.Property(e => e.Indicacion)
                    .IsRequired()
                    .HasMaxLength(1200);

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.TblCatIndicacionExaPacientes)
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_Examenes741");
            });

            modelBuilder.Entity<TblCatMetodologium>(entity =>
            {
                entity.HasKey(e => e.IdMetodologia)
                    .HasName("PK24");

                entity.ToTable("tbl_cat_Metodologia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatNacionalidad>(entity =>
            {
                entity.HasKey(e => e.IdNacionalidad)
                    .HasName("PK7");

                entity.ToTable("tbl_cat_Nacionalidad");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblCatOcupacione>(entity =>
            {
                entity.HasKey(e => e.IdOcupaciones)
                    .HasName("PK54");

                entity.ToTable("tbl_cat_Ocupaciones");

                entity.Property(e => e.Descripcion).HasMaxLength(10);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.TblCatOcupaciones)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_Empleado1031");

                entity.HasOne(d => d.IdProfesionesNavigation)
                    .WithMany(p => p.TblCatOcupaciones)
                    .HasForeignKey(d => d.IdProfesiones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Profesiones1021");
            });

            modelBuilder.Entity<TblCatPai>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK4");

                entity.ToTable("tbl_cat_Pais");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCatPerfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfiles)
                    .HasName("PK39");

                entity.ToTable("tbl_cat_Perfiles");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatPerfilesExamene>(entity =>
            {
                entity.HasKey(e => e.IdPerfilesExamenes)
                    .HasName("PK40");

                entity.ToTable("tbl_cat_PerfilesExamenes");

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.TblCatPerfilesExamenes)
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_Examenes771");

                entity.HasOne(d => d.IdPerfilesNavigation)
                    .WithMany(p => p.TblCatPerfilesExamenes)
                    .HasForeignKey(d => d.IdPerfiles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Perfiles481");
            });

            modelBuilder.Entity<TblCatProfesione>(entity =>
            {
                entity.HasKey(e => e.IdProfesiones)
                    .HasName("PK51");

                entity.ToTable("tbl_cat_Profesiones");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCatSexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo)
                    .HasName("PK3");

                entity.ToTable("tbl_cat_Sexo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblCatSucursale>(entity =>
            {
                entity.HasKey(e => e.IdSucursal)
                    .HasName("PK11");

                entity.ToTable("tbl_cat_Sucursales");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Telefono).HasMaxLength(10);

                entity.Property(e => e.UrlLogo).HasMaxLength(50);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.TblCatSucursales)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Departamento381");

                entity.HasOne(d => d.IdHospitalNavigation)
                    .WithMany(p => p.TblCatSucursales)
                    .HasForeignKey(d => d.IdHospital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_cat_Sucursales_tbl_cat_Hospital");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblCatSucursales)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Pais371");
            });

            modelBuilder.Entity<TblCatTipoMuestra>(entity =>
            {
                entity.HasKey(e => e.IdTipoMuestra)
                    .HasName("PK20");

                entity.ToTable("tbl_cat_TipoMuestra");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatTipoOrden>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrden)
                    .HasName("PK48");

                entity.ToTable("tbl_cat_TipoOrden");

                entity.Property(e => e.Descripcion).HasMaxLength(15);
            });

            modelBuilder.Entity<TblCatTipoResultado>(entity =>
            {
                entity.HasKey(e => e.IdTipoResultado)
                    .HasName("PK25");

                entity.ToTable("tbl_cat_TipoResultado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblCatTipoSangre>(entity =>
            {
                entity.HasKey(e => e.IdTipoSangre)
                    .HasName("PK56");

                entity.ToTable("tbl_cat_TipoSangre");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<TblCatTipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio)
                    .HasName("PK49");

                entity.ToTable("tbl_cat_TipoServicio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblCatTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK74");

                entity.ToTable("tbl_cat_TipoUsuario");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblCatUnidadMedida>(entity =>
            {
                entity.HasKey(e => e.IdUnidadMedidas)
                    .HasName("PK21");

                entity.ToTable("tbl_cat_UnidadMedidas");

                entity.Property(e => e.UnidadMedida)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblCatValoresNormale>(entity =>
            {
                entity.HasKey(e => e.IdValoresNormales)
                    .HasName("PK38");

                entity.ToTable("tbl_cat_ValoresNormales");

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.TblCatValoresNormales)
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_Examenes701");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.TblCatValoresNormales)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Sexo711");
            });

            modelBuilder.Entity<TblEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK1");

                entity.ToTable("tbl_Empleado");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CodMinsa).HasMaxLength(10);

                entity.Property(e => e.DireccionDomiciliar)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EdadIngreso)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FechaContrato).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNac).HasColumnType("date");

                entity.Property(e => e.NumIdentificacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NumInss)
                    .HasMaxLength(15)
                    .HasColumnName("NumINSS");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido).HasMaxLength(50);

                entity.Property(e => e.SegundoNombre).HasMaxLength(50);

                entity.Property(e => e.TelefonoDomiciliar).HasMaxLength(10);

                entity.Property(e => e.TelefonoMovil).HasMaxLength(10);

                entity.Property(e => e.UrlFoto).HasMaxLength(50);

                entity.Property(e => e.UsuarioCrea)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UsuarioElimina).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifica).HasMaxLength(50);

                entity.HasOne(d => d.IdDepartamentoNacNavigation)
                    .WithMany(p => p.TblEmpleadoIdDepartamentoNacNavigations)
                    .HasForeignKey(d => d.IdDepartamentoNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Departamento241");

                entity.HasOne(d => d.IdDepartamentoResNavigation)
                    .WithMany(p => p.TblEmpleadoIdDepartamentoResNavigations)
                    .HasForeignKey(d => d.IdDepartamentoRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Departamento231");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.TblEmpleados)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_EstadoCivil71");

                entity.HasOne(d => d.IdIdentificacionNavigation)
                    .WithMany(p => p.TblEmpleados)
                    .HasForeignKey(d => d.IdIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Identificacion81");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.TblEmpleados)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Nacionalidad91");

                entity.HasOne(d => d.IdPaisNacNavigation)
                    .WithMany(p => p.TblEmpleadoIdPaisNacNavigations)
                    .HasForeignKey(d => d.IdPaisNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Pais221");

                entity.HasOne(d => d.IdPaisResNavigation)
                    .WithMany(p => p.TblEmpleadoIdPaisResNavigations)
                    .HasForeignKey(d => d.IdPaisRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Pais211");

                entity.HasOne(d => d.IdProfesionesNavigation)
                    .WithMany(p => p.TblEmpleados)
                    .HasForeignKey(d => d.IdProfesiones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Profesiones981");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.TblEmpleados)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Sexo61");
            });

            modelBuilder.Entity<TblExamene>(entity =>
            {
                entity.HasKey(e => e.IdExamen)
                    .HasName("PK41");

                entity.ToTable("tbl_Examenes");

                entity.Property(e => e.Confidencial)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionCorta)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.IdAreaLabServicioNavigation)
                    .WithMany(p => p.TblExamenes)
                    .HasForeignKey(d => d.IdAreaLabServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_AreasLabServicio691");

                entity.HasOne(d => d.IdCategoriaExamenesNavigation)
                    .WithMany(p => p.TblExamenes)
                    .HasForeignKey(d => d.IdCategoriaExamenes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_CategoriaExamenes651");

                entity.HasOne(d => d.IdTipoMuestraNavigation)
                    .WithMany(p => p.TblExamenes)
                    .HasForeignKey(d => d.IdTipoMuestra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_TipoMuestra641");

                entity.HasOne(d => d.IdTipoResultadoNavigation)
                    .WithMany(p => p.TblExamenes)
                    .HasForeignKey(d => d.IdTipoResultado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_TipoResultado611");

                entity.HasOne(d => d.IdUnidadMedidasNavigation)
                    .WithMany(p => p.TblExamenes)
                    .HasForeignKey(d => d.IdUnidadMedidas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_UnidadMedidas631");
            });

            modelBuilder.Entity<TblMedico>(entity =>
            {
                entity.HasKey(e => e.IdTblMedico)
                    .HasName("idtblMedico");

                entity.ToTable("tbl_Medico");

                entity.Property(e => e.IdTblMedico).HasColumnName("idTblMedico");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CodMinsa)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.IdtblCatSucursales).HasColumnName("Idtbl_cat_Sucursales");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.NumIdentificacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UrlFoto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdDepartamentoNacNavigation)
                    .WithMany(p => p.TblMedicoIdDepartamentoNacNavigations)
                    .HasForeignKey(d => d.IdDepartamentoNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico595295");

                entity.HasOne(d => d.IdDepartamentoResNavigation)
                    .WithMany(p => p.TblMedicoIdDepartamentoResNavigations)
                    .HasForeignKey(d => d.IdDepartamentoRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico591311");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.TblMedicos)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico837462");

                entity.HasOne(d => d.IdIdentificacionNavigation)
                    .WithMany(p => p.TblMedicos)
                    .HasForeignKey(d => d.IdIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico536173");

                entity.HasOne(d => d.IdPaisNacNavigation)
                    .WithMany(p => p.TblMedicoIdPaisNacNavigations)
                    .HasForeignKey(d => d.IdPaisNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPaisNac_tblMedico");

                entity.HasOne(d => d.IdPaisResNavigation)
                    .WithMany(p => p.TblMedicoIdPaisResNavigations)
                    .HasForeignKey(d => d.IdPaisRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PaisRES_tblMedico");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.TblMedicos)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico774196");

                entity.HasOne(d => d.IdtblCatSucursalesNavigation)
                    .WithMany(p => p.TblMedicos)
                    .HasForeignKey(d => d.IdtblCatSucursales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Medico643765");
            });

            modelBuilder.Entity<TblOrdene>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.ToTable("tbl_Ordenes");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Asistencia)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FechaCita).HasColumnType("date");

                entity.Property(e => e.FechaImprime).HasColumnType("datetime");

                entity.Property(e => e.FechaOrden).HasColumnType("date");

                entity.Property(e => e.FechaPreporte)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaPReporte");

                entity.Property(e => e.Finalizado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IdtblMedico).HasColumnName("Idtbl_Medico");

                entity.Property(e => e.NOrden)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("N_Orden");

                entity.Property(e => e.Observaciones).HasMaxLength(200);

                entity.Property(e => e.UsuarioImprime).HasMaxLength(50);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.TblOrdenes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Ordenes_tbl_Paciente");

                entity.HasOne(d => d.IdTipoOrdenNavigation)
                    .WithMany(p => p.TblOrdenes)
                    .HasForeignKey(d => d.IdTipoOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Ordenes_tbl_cat_TipoOrden");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.TblOrdenes)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Ordenes_tbl_cat_TipoServicio");

                entity.HasOne(d => d.IdtblMedicoNavigation)
                    .WithMany(p => p.TblOrdenes)
                    .HasForeignKey(d => d.IdtblMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_Ordene175911");
            });

            modelBuilder.Entity<TblOrdenesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdOrdenDetalle)
                    .HasName("PK78");

                entity.ToTable("tbl_OrdenesDetalle");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.NOrden)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("N_Orden");

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.TblOrdenesDetalles)
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrdenesDetalle_tbl_Examenes");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.TblOrdenesDetalles)
                    .HasForeignKey(d => d.IdOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrdenesDetalle_tbl_Ordenes");
            });

            modelBuilder.Entity<TblPaciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK46");

                entity.ToTable("tbl_Paciente");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DireccionDomiciliar)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Emabrazada).HasMaxLength(1);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Fallecido).HasMaxLength(1);

                entity.Property(e => e.FechaNac).HasColumnType("date");

                entity.Property(e => e.NumIdentificacion).HasMaxLength(20);

                entity.Property(e => e.NumInss)
                    .HasMaxLength(15)
                    .HasColumnName("NumINSS");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido).HasMaxLength(50);

                entity.Property(e => e.SegundoNombre).HasMaxLength(50);

                entity.Property(e => e.TelefonoDomiciliar).HasMaxLength(10);

                entity.Property(e => e.TelefonoMovil).HasMaxLength(10);

                entity.HasOne(d => d.IdDepartamentoNacNavigation)
                    .WithMany(p => p.TblPacienteIdDepartamentoNacNavigations)
                    .HasForeignKey(d => d.IdDepartamentoNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Departamento841");

                entity.HasOne(d => d.IdDepartamentoResNavigation)
                    .WithMany(p => p.TblPacienteIdDepartamentoResNavigations)
                    .HasForeignKey(d => d.IdDepartamentoRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Departamento851");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.TblPacientes)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_EstadoCivil881");

                entity.HasOne(d => d.IdIdentificacionNavigation)
                    .WithMany(p => p.TblPacientes)
                    .HasForeignKey(d => d.IdIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Identificacion791");

                entity.HasOne(d => d.IdPaisNacNavigation)
                    .WithMany(p => p.TblPacienteIdPaisNacNavigations)
                    .HasForeignKey(d => d.IdPaisNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Pais821");

                entity.HasOne(d => d.IdPaisResNavigation)
                    .WithMany(p => p.TblPacienteIdPaisResNavigations)
                    .HasForeignKey(d => d.IdPaisRes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Pais831");

                entity.HasOne(d => d.IdProfesionesNavigation)
                    .WithMany(p => p.TblPacientes)
                    .HasForeignKey(d => d.IdProfesiones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Profesiones901");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.TblPacientes)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_Sexo811");

                entity.HasOne(d => d.IdTipoSangreNavigation)
                    .WithMany(p => p.TblPacientes)
                    .HasForeignKey(d => d.IdTipoSangre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reftbl_cat_TipoSangre1041");
            });

            modelBuilder.Entity<TblResultado>(entity =>
            {
                entity.HasKey(e => e.IdResultados)
                    .HasName("PK73");

                entity.ToTable("tbl_Resultados");

                entity.Property(e => e.FechaImprime).HasColumnType("datetime");

                entity.Property(e => e.FechaProcesa).HasColumnType("datetime");

                entity.Property(e => e.FechaValida).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Procesado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Resultado)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UsuarioImprime).HasMaxLength(50);

                entity.Property(e => e.UsuarioProcesa).HasMaxLength(50);

                entity.Property(e => e.UsuarioValida).HasMaxLength(50);

                entity.Property(e => e.Validado).HasMaxLength(1);

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.TblResultados)
                    .HasForeignKey(d => d.IdExamen)
                    .HasConstraintName("FK_tbl_Resultados_tbl_Examenes");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.TblResultados)
                    .HasForeignKey(d => d.IdOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Resultados_tbl_Ordenes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

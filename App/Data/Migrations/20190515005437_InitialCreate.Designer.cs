﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190515005437_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("App.Models.Actividad", b =>
                {
                    b.Property<int>("actividadClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cursoactividadClave");

                    b.Property<string>("nombreActidad");

                    b.Property<int>("puntaje");

                    b.Property<int>("trabajoClave");

                    b.HasKey("actividadClave");

                    b.HasIndex("cursoactividadClave");

                    b.HasIndex("trabajoClave");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("App.Models.ActividadAlumno", b =>
                {
                    b.Property<int>("actividadalumnoClave")
                        .ValueGeneratedOnAdd();

                    b.HasKey("actividadalumnoClave");

                    b.ToTable("ActividadAlumnos");
                });

            modelBuilder.Entity("App.Models.Alumno", b =>
                {
                    b.Property<int>("alumnoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("actividadalumnoClave");

                    b.Property<int>("calificacionClave");

                    b.Property<string>("nombre");

                    b.HasKey("alumnoId");

                    b.HasIndex("actividadalumnoClave");

                    b.HasIndex("calificacionClave");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("App.Models.Calificacion", b =>
                {
                    b.Property<int>("calificacionClave")
                        .ValueGeneratedOnAdd();

                    b.HasKey("calificacionClave");

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("App.Models.Carrera", b =>
                {
                    b.Property<string>("carreraClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("materiaClave");

                    b.Property<string>("materiaClave1");

                    b.Property<string>("nombre");

                    b.HasKey("carreraClave");

                    b.HasIndex("materiaClave1");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("App.Models.Ciclo", b =>
                {
                    b.Property<string>("cicloClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cursoClave");

                    b.Property<DateTime>("fin");

                    b.Property<DateTime>("inicio");

                    b.HasKey("cicloClave");

                    b.HasIndex("cursoClave");

                    b.ToTable("Ciclos");
                });

            modelBuilder.Entity("App.Models.Competencia", b =>
                {
                    b.Property<int>("competenciaClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("competencia");

                    b.Property<int>("trabajoClave");

                    b.HasKey("competenciaClave");

                    b.HasIndex("trabajoClave");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("App.Models.Curso", b =>
                {
                    b.Property<int>("cursoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("calificacionClave");

                    b.Property<int>("cursoactividadClave");

                    b.HasKey("cursoClave");

                    b.HasIndex("calificacionClave");

                    b.HasIndex("cursoactividadClave");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("App.Models.CursoActividad", b =>
                {
                    b.Property<int>("cursoactividadClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("actividadalumnoClave");

                    b.HasKey("cursoactividadClave");

                    b.HasIndex("actividadalumnoClave");

                    b.ToTable("CursoActividades");
                });

            modelBuilder.Entity("App.Models.Materia", b =>
                {
                    b.Property<string>("materiaClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cursoclave");

                    b.Property<string>("Nombre");

                    b.HasKey("materiaClave");

                    b.HasIndex("Cursoclave");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("App.Models.Profesor", b =>
                {
                    b.Property<int>("profesorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CursoClave");

                    b.Property<string>("nombre");

                    b.HasKey("profesorId");

                    b.HasIndex("CursoClave");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("App.Models.Tipo", b =>
                {
                    b.Property<int>("tipoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("competenciaClave");

                    b.Property<string>("nombre");

                    b.HasKey("tipoClave");

                    b.HasIndex("competenciaClave");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("App.Models.Trabajo", b =>
                {
                    b.Property<int>("trabajoClave")
                        .ValueGeneratedOnAdd();

                    b.HasKey("trabajoClave");

                    b.ToTable("Trabajos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Models.Actividad", b =>
                {
                    b.HasOne("App.Models.CursoActividad", "CursoActividad")
                        .WithMany("Actividades")
                        .HasForeignKey("cursoactividadClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Trabajo", "Trabajo")
                        .WithMany("Actividades")
                        .HasForeignKey("trabajoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Alumno", b =>
                {
                    b.HasOne("App.Models.ActividadAlumno", "ActividadAlumno")
                        .WithMany("Alumnos")
                        .HasForeignKey("actividadalumnoClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Calificacion", "Calificacion")
                        .WithMany("Alumnos")
                        .HasForeignKey("calificacionClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Carrera", b =>
                {
                    b.HasOne("App.Models.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("materiaClave1");
                });

            modelBuilder.Entity("App.Models.Ciclo", b =>
                {
                    b.HasOne("App.Models.Curso", "Curso")
                        .WithMany("Ciclos")
                        .HasForeignKey("cursoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Competencia", b =>
                {
                    b.HasOne("App.Models.Trabajo", "Trabajo")
                        .WithMany("Competencias")
                        .HasForeignKey("trabajoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Curso", b =>
                {
                    b.HasOne("App.Models.Calificacion", "Calificacion")
                        .WithMany("Cursos")
                        .HasForeignKey("calificacionClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.CursoActividad", "CursoActividad")
                        .WithMany("Cursos")
                        .HasForeignKey("cursoactividadClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.CursoActividad", b =>
                {
                    b.HasOne("App.Models.ActividadAlumno", "ActividadAlumno")
                        .WithMany("CursoActividades")
                        .HasForeignKey("actividadalumnoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Materia", b =>
                {
                    b.HasOne("App.Models.Curso", "Curso")
                        .WithMany("Materias")
                        .HasForeignKey("Cursoclave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Profesor", b =>
                {
                    b.HasOne("App.Models.Curso", "Curso")
                        .WithMany("Profesores")
                        .HasForeignKey("CursoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Tipo", b =>
                {
                    b.HasOne("App.Models.Competencia", "Competencia")
                        .WithMany()
                        .HasForeignKey("competenciaClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

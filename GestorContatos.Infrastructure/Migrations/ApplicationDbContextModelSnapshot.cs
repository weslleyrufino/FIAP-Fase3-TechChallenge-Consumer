﻿// <auto-generated />
using GestorContatos.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestorContatos.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestorContatos.Core.Entities.ContatoModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Nome");

                    b.Property<int>("RegiaoId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Telefone");

                    b.Property<string>("TesteMigration")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("TesteMigration");

                    b.HasKey("Id");

                    b.HasIndex("RegiaoId");

                    b.ToTable("Contatos", (string)null);
                });

            modelBuilder.Entity("GestorContatos.Core.Entities.RegiaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegiaoModel");
                });

            modelBuilder.Entity("GestorContatos.Core.Entities.ContatoModel", b =>
                {
                    b.HasOne("GestorContatos.Core.Entities.RegiaoModel", "Regiao")
                        .WithMany()
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Regiao");
                });
#pragma warning restore 612, 618
        }
    }
}

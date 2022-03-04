﻿// <auto-generated />
using System;
using ApiProcessoSeletivo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiProcessoSeletivo.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiProcessoSeletivo.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("text")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Datanasc");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("Endereco");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Sexo")
                        .HasColumnType("text")
                        .HasColumnName("Sexo");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
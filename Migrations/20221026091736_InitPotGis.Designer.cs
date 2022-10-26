﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestPostGis.Models;

#nullable disable

namespace TestPostGis.Migrations
{
    [DbContext(typeof(BEDBContext))]
    [Migration("20221026091736_InitPotGis")]
    partial class InitPotGis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestPostGis.Models.GeometryDAO", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Geometry>("DataGeometry")
                        .HasColumnType("geometry");

                    b.HasKey("ID");

                    b.ToTable("Geometries");
                });
#pragma warning restore 612, 618
        }
    }
}

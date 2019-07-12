﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using travelingo;

namespace sdgreacttemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("travelingo.models.Site", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("Language");

                    b.Property<string>("LastName");

                    b.Property<double>("Latitude");

                    b.Property<string>("LocationName");

                    b.Property<double>("Longitude");

                    b.Property<string>("State");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("travelingo.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateJoined");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190615135248_Zmiana2")]
    partial class Zmiana2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Entities.Autor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("Database.Entities.Library", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorID");

                    b.Property<string>("BlobID")
                        .IsRequired();

                    b.Property<DateTime?>("DateRent");

                    b.Property<string>("Lender");

                    b.Property<string>("Renter");

                    b.Property<bool>("State");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("TypeofMedia");

                    b.Property<string>("Year")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.ToTable("Librarys");
                });

            modelBuilder.Entity("Database.Entities.Library", b =>
                {
                    b.HasOne("Database.Entities.Autor", "Autor")
                        .WithMany("Librarys")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

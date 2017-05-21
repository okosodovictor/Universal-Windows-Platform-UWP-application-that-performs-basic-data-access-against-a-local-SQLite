using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreSQLITEProject.Model;

namespace EFCoreSQLITEProject.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("EFCoreSQLITEProject.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<string>("IconUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });
        }
    }
}

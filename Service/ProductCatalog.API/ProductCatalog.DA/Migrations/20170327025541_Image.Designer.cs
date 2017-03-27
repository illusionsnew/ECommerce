using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProductCatalog.DA;

namespace ProductCatalog.DA.Migrations
{
    [DbContext(typeof(CatlogDB))]
    [Migration("20170327025541_Image")]
    partial class Image
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCatalog.DA.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<byte[]>("ProductImage");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
        }
    }
}

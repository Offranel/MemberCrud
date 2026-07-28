using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MemberCrud.Data;

#nullable disable

namespace MemberCrud.Migrations
{
    [DbContext(typeof(ChurchContext))]
    partial class MemberCrudModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("MemberCrud.Models.Ministry", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int");
                b.Property<string>("Name").IsRequired().HasColumnType("nvarchar(max)");
                b.HasKey("Id");
                b.ToTable("Ministries");
            });

            modelBuilder.Entity("MemberCrud.Models.Member", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int");
                b.Property<string>("Email").IsRequired().HasColumnType("nvarchar(max)");
                b.Property<DateTime>("CreateAt").HasColumnType("datetime2");
                b.Property<string>("FirstName").IsRequired().HasColumnType("nvarchar(max)");
                b.Property<string>("LastName").IsRequired().HasColumnType("nvarchar(max)");
                b.Property<string>("MembershipStatus").IsRequired().HasColumnType("nvarchar(max)");
                b.Property<string>("Phone").IsRequired().HasColumnType("nvarchar(max)");
                b.HasKey("Id");
                b.ToTable("Members");
            });

            modelBuilder.Entity("MemberCrud.Models.MemberMinistry", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int");
                b.Property<int>("MemberId").HasColumnType("int");
                b.Property<int>("MinistryId").HasColumnType("int");
                b.HasKey("Id");
                b.HasIndex("MemberId");
                b.HasIndex("MinistryId");
                b.ToTable("MemberMinistries");
            });

            modelBuilder.Entity("MemberCrud.Models.MemberMinistry", b =>
            {
                b.HasOne("MemberCrud.Models.Member").WithMany().HasForeignKey("MemberId").OnDelete(DeleteBehavior.Cascade).IsRequired();
                b.HasOne("MemberCrud.Models.Ministry").WithMany().HasForeignKey("MinistryId").OnDelete(DeleteBehavior.Cascade).IsRequired();
            });
        }
    }
}

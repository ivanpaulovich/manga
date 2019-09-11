// <auto-generated />
using System;
using Manga.Infrastructure.EntityFrameworkDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    [DbContext(typeof(MangaContext))]
    partial class MangaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Manga.Domain.Accounts.Account", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<Guid>("CustomerId");

                b.HasKey("Id");

                b.ToTable("Account");

                b.HasData(
                    new
                    {
                        Id = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            CustomerId = new Guid("197d0438-e04b-453d-b5de-eca05960c6ae")
                    });
            });

            modelBuilder.Entity("Manga.Domain.Accounts.Credit", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<Guid>("AccountId");

                b.Property<decimal?>("Amount");

                b.Property<DateTime>("TransactionDate");

                b.HasKey("Id");

                b.ToTable("Credit");

                b.HasData(
                    new
                    {
                        Id = new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                            AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            Amount = 400.0,
                            TransactionDate = new DateTime(2019, 6, 26, 18, 7, 24, 681, DateTimeKind.Utc).AddTicks(3880)
                    });
            });

            modelBuilder.Entity("Manga.Domain.Accounts.Debit", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<Guid>("AccountId");

                b.Property<decimal?>("Amount");

                b.Property<DateTime>("TransactionDate");

                b.HasKey("Id");

                b.ToTable("Debit");

                b.HasData(
                    new
                    {
                        Id = new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                            AccountId = new Guid("4c510cfe-5d61-4a46-a3d9-c4313426655f"),
                            Amount = 400.0,
                            TransactionDate = new DateTime(2019, 6, 26, 18, 7, 24, 681, DateTimeKind.Utc).AddTicks(4900)
                    });
            });

            modelBuilder.Entity("Manga.Domain.Customers.Customer", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.Property<string>("SSN");

                b.HasKey("Id");

                b.ToTable("Customer");

                b.HasData(
                    new
                    {
                        Id = new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"),
                            Name = "Test User",
                            SSN = "19860817-9999"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
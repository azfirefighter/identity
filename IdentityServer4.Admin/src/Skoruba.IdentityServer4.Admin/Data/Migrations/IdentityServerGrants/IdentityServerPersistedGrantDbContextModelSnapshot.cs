﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts;

namespace Skoruba.IdentityServer4.Admin.Data.Migrations.IdentityServerGrants
{
    [DbContext(typeof(IdentityServerPersistedGrantDbContext))]
    partial class IdentityServerPersistedGrantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired();

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });
#pragma warning restore 612, 618
        }
    }
}

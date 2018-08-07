﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nucleus.EntityFramework;

namespace Nucleus.EntityFramework.Migrations
{
    [DbContext(typeof(NucleusDbContext))]
    partial class NucleusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nucleus.Core.Permissions.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new { Id = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"), DisplayName = "Member access", Name = "Permissions_Member_Access" },
                        new { Id = new Guid("86d804bd-d022-49a5-821a-d2240478aac4"), DisplayName = "User list", Name = "Permissions_User_List" }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new { Id = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), ConcurrencyStamp = "cd325621-b937-4b17-ba62-8e4a4f66d8d3", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"), ConcurrencyStamp = "1c5f8671-b8a7-492c-aa6c-cb0c345f9955", Name = "Member", NormalizedName = "MEMBER" }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Roles.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Nucleus.Core.Roles.RolePermission", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("PermissionId");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("86d804bd-d022-49a5-821a-d2240478aac4") },
                        new { RoleId = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"), PermissionId = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d") }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"), AccessFailedCount = 5, ConcurrencyStamp = "c70f7182-0afa-4e33-be87-3912ad373179", Email = "admin@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "ADMIN@MAIL.COM", NormalizedUserName = "ADMIN", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"), AccessFailedCount = 5, ConcurrencyStamp = "7ebba9d6-66ff-47ef-983e-f26426613854", Email = "memberuser@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "MEMBERUSER@MAIL.COM", NormalizedUserName = "MEMBERUSER", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "memberuser" }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new { UserId = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"), RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263") },
                        new { UserId = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"), RoleId = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce") }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Nucleus.Core.Roles.RoleClaim", b =>
                {
                    b.HasOne("Nucleus.Core.Roles.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nucleus.Core.Roles.RolePermission", b =>
                {
                    b.HasOne("Nucleus.Core.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nucleus.Core.Roles.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserClaim", b =>
                {
                    b.HasOne("Nucleus.Core.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserLogin", b =>
                {
                    b.HasOne("Nucleus.Core.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserRole", b =>
                {
                    b.HasOne("Nucleus.Core.Roles.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nucleus.Core.Users.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nucleus.Core.Users.UserToken", b =>
                {
                    b.HasOne("Nucleus.Core.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

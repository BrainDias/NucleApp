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
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nucleus.Core.Permissions.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<Guid>("CreateUserId");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<Guid>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new { Id = new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Administration access", Name = "Permissions_Administration", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Member access", Name = "Permissions_Member_Access", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("86d804bd-d022-49a5-821a-d2240478aac4"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "User read", Name = "Permissions_User_Read", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "User create", Name = "Permissions_User_Create", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "User update", Name = "Permissions_User_Update", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "User delete", Name = "Permissions_User_Delete", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Role read", Name = "Permissions_Role_Read", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Role create", Name = "Permissions_Role_Create", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("ea003a99-4755-4c19-b126-c5cffbc65088"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Role update", Name = "Permissions_Role_Update", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") },
                        new { Id = new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c"), CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"), DisplayName = "Role delete", Name = "Permissions_Role_Delete", UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000") }
                    );
                });

            modelBuilder.Entity("Nucleus.Core.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<bool>("IsSystemDefault");

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
                        new { Id = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), ConcurrencyStamp = "ee74b5ba-4147-4114-8573-e1cda562d882", IsSystemDefault = true, Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"), ConcurrencyStamp = "bf5a66a5-8e05-436d-b064-ed1957bb5002", IsSystemDefault = true, Name = "Member", NormalizedName = "MEMBER" }
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
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("86d804bd-d022-49a5-821a-d2240478aac4") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("ea003a99-4755-4c19-b126-c5cffbc65088") },
                        new { RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"), PermissionId = new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c") },
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
                        new { Id = new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"), AccessFailedCount = 5, ConcurrencyStamp = "e763da6f-16f7-45e1-a0f2-d60ee3ddae4a", Email = "admin@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "ADMIN@MAIL.COM", NormalizedUserName = "ADMIN", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"), AccessFailedCount = 5, ConcurrencyStamp = "99e2faec-c41b-4e81-98a8-91cffdb531c5", Email = "memberuser@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "MEMBERUSER@MAIL.COM", NormalizedUserName = "MEMBERUSER", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "memberuser" },
                        new { Id = new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"), AccessFailedCount = 5, ConcurrencyStamp = "d3ffa8e2-0447-4ec0-9cbd-8d2fb624adbf", Email = "testadmin@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "TESTADMIN@MAIL.COM", NormalizedUserName = "TESTADMIN", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "testadmin" }
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
                        new { UserId = new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"), RoleId = new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263") },
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

﻿// <auto-generated />
using System;
using MarinaHR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarinaHR.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("MarinaHR.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "ادارات شركه مارينا"
                        },
                        new
                        {
                            ID = 2,
                            Name = "اداره العملاء"
                        },
                        new
                        {
                            ID = 3,
                            Name = "الاداره الماليه"
                        },
                        new
                        {
                            ID = 4,
                            Name = "اداره الموردين"
                        },
                        new
                        {
                            ID = 5,
                            Name = "اداره السبتيه "
                        },
                        new
                        {
                            ID = 6,
                            Name = "اداره المخازن"
                        },
                        new
                        {
                            ID = 7,
                            Name = "اداره البرنامج"
                        },
                        new
                        {
                            ID = 8,
                            Name = "اداره الفيوم"
                        },
                        new
                        {
                            ID = 9,
                            Name = "اداره شئون الافراد"
                        });
                });

            modelBuilder.Entity("MarinaHR.Models.Place", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "مخزن الضغط"
                        },
                        new
                        {
                            ID = 2,
                            Name = "مخزن اللزق"
                        },
                        new
                        {
                            ID = 3,
                            Name = "مخزن البولى"
                        },
                        new
                        {
                            ID = 4,
                            Name = "مخزن الصندره"
                        },
                        new
                        {
                            ID = 5,
                            Name = "مخزن النواكل"
                        },
                        new
                        {
                            ID = 6,
                            Name = "مخزن المول "
                        },
                        new
                        {
                            ID = 7,
                            Name = "مخزن الجراج"
                        },
                        new
                        {
                            ID = 8,
                            Name = "مخزن المواسير"
                        },
                        new
                        {
                            ID = 9,
                            Name = "مخزن الحجاز"
                        },
                        new
                        {
                            ID = 10,
                            Name = "مخزن روض الفرج"
                        },
                        new
                        {
                            ID = 11,
                            Name = "مخزن محل مارينا جروب( متواجد بمحل مارينا جروب )"
                        },
                        new
                        {
                            ID = 12,
                            Name = "مخزن جسر السويس ( بدون موظفين)"
                        },
                        new
                        {
                            ID = 13,
                            Name = "مارينا بلاست"
                        },
                        new
                        {
                            ID = 14,
                            Name = "مول مارينا بلاس"
                        },
                        new
                        {
                            ID = 15,
                            Name = "محل الاخوه"
                        },
                        new
                        {
                            ID = 16,
                            Name = "محل مارينا جروب"
                        },
                        new
                        {
                            ID = 17,
                            Name = "محل مارينا التجمع"
                        },
                        new
                        {
                            ID = 18,
                            Name = "اكوامارينا"
                        });
                });

            modelBuilder.Entity("MarinaHR.Models.Vacation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VacationType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("vacationStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "6510262c-bbcb-4629-b1e7-20de05ef7ae6",
                            RoleId = "57784dee-54ff-4115-9835-da06239d6117"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MarinaHR.Models.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("NameInArabic")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("UserRole");

                    b.HasData(
                        new
                        {
                            Id = "93c4a412-3af5-49f8-9b27-cecc7b6f6e79",
                            ConcurrencyStamp = "456a2606-e421-4f8b-a522-8428ee3f3e3b",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE",
                            NameInArabic = "موظف"
                        },
                        new
                        {
                            Id = "57784dee-54ff-4115-9835-da06239d6117",
                            ConcurrencyStamp = "797c239a-e0d6-4b3a-9d6a-984f1c8084cf",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR",
                            NameInArabic = "مدير"
                        });
                });

            modelBuilder.Entity("MarinaHR.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlaceID")
                        .HasColumnType("INTEGER");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("PlaceID");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "6510262c-bbcb-4629-b1e7-20de05ef7ae6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cf2f4514-1abc-4b7b-994f-06bc5becfd73",
                            Email = "azizmichael@aucegypt.edu",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "AZIZMICHAEL@AUCEGYPT.EDU",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENJGFGMVyMc2Qz+/TPkHNkws3JYpZeS1KZlKtRrbjP0Jf+vTX8WQcy/mN+FRCtcG9w==",
                            PhoneNumber = "01111257052",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0ba042f3-ce5f-4661-95c5-179dffda54f8",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 1,
                            Name = "عزيز حنا",
                            PlaceID = 14
                        });
                });

            modelBuilder.Entity("MarinaHR.Models.Vacation", b =>
                {
                    b.HasOne("MarinaHR.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarinaHR.Models.User", b =>
                {
                    b.HasOne("MarinaHR.Models.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarinaHR.Models.Place", "Place")
                        .WithMany("Users")
                        .HasForeignKey("PlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

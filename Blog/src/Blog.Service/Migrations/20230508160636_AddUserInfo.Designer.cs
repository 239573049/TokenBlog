﻿// <auto-generated />
using System;
using Blog.Service.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Blog.Service.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20230508160636_AddUserInfo")]
    partial class AddUserInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasComment("分类id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("character varying(50000)")
                        .HasComment("文章内容");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Like")
                        .HasColumnType("integer")
                        .HasComment("点赞量");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("timestamp with time zone")
                        .HasComment("发布时间");

                    b.Property<int>("ReadCount")
                        .HasColumnType("integer")
                        .HasComment("阅读量");

                    b.Property<string>("Tabs")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("标签id json数组格式");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("标题");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasComment("用户id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Title");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.Tab", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("Blog.Service.Domain.Users.Aggregates.UserInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Account");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UserInfos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dfcb4d6e-5123-4dce-80b5-4be3b0d56432"),
                            Account = "admin",
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg",
                            CreationTime = new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2050),
                            Email = "239573049@qq.com",
                            IsDeleted = false,
                            ModificationTime = new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2052),
                            Password = "dd666666",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("Masa.BuildingBlocks.Dispatcher.IntegrationEvents.Logs.IntegrationEventLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("RowVersion");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("TimesSent")
                        .HasColumnType("integer");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EventId", "RowVersion" }, "IX_EventId_Version");

                    b.HasIndex(new[] { "State", "ModificationTime" }, "IX_State_MTime");

                    b.HasIndex(new[] { "State", "TimesSent", "ModificationTime" }, "IX_State_TimesSent_MTime");

                    b.ToTable("IntegrationEventLog", (string)null);
                });

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.Article", b =>
                {
                    b.HasOne("Blog.Service.Domain.Bloggers.Aggregates.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
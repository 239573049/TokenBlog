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
    [Migration("20230607071315_MaxContent")]
    partial class MaxContent
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasComment("分类id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("character varying(100000)")
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

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.Failarmy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name");

                    b.ToTable("Failarmies");
                });

            modelBuilder.Entity("Blog.Service.Domain.Bloggers.Aggregates.FailarmyItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ActicleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FailarmyId")
                        .HasColumnType("uuid");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ActicleId");

                    b.HasIndex("FailarmyId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("FailarmyItems");
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

            modelBuilder.Entity("Blog.Service.Domain.Resources.Aggregates.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("描述");

                    b.Property<int>("DownloadCount")
                        .HasColumnType("integer")
                        .HasComment("下载次数");

                    b.Property<string>("Href")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<int>("Referee")
                        .HasColumnType("integer")
                        .HasComment("推荐数量");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("标题");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Resources");
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

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
                            Id = new Guid("e3802769-0506-4058-8f64-44aabc83632b"),
                            Account = "admin",
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg",
                            CreationTime = new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7284),
                            Email = "239573049@qq.com",
                            IsDeleted = false,
                            ModificationTime = new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7286),
                            Name = "Token",
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

                    b.Property<string>("ExpandContent")
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

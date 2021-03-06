﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(EbsContext))]
    [Migration("20200503201925_NewBookTransactionProperties")]
    partial class NewBookTransactionProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.BcBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thickness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BcBooks");
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InGoodCondition")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBorrowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPainted")
                        .HasColumnType("bit");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("СlickCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Жюль Верн",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(605),
                            Description = "Very good book",
                            ImageSource = "https://static.librebook.me/uploads/pics/01/61/852.jpg",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "20 тысяч лье под водой",
                            UserId = 1,
                            СlickCount = 30
                        },
                        new
                        {
                            Id = 2,
                            Author = "Жюль Верн",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9306),
                            Description = "Very good book",
                            ImageSource = "https://www.mann-ivanov-ferber.ru/assets/images/covers/37/21737/1.00x-thumb.png",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 4.0,
                            Title = "Дети капитана Гранта",
                            UserId = 1,
                            СlickCount = 20
                        },
                        new
                        {
                            Id = 3,
                            Author = "Жюль Верн",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9529),
                            Description = "Very good book",
                            ImageSource = "https://be2.aldebaran.ru/static/bookimages/42/41/09/42410912.bin.dir/42410912.cover.jpg",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "Вокруг света за 80 дней",
                            UserId = 1,
                            СlickCount = 15
                        },
                        new
                        {
                            Id = 4,
                            Author = "Жюль Верн",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9536),
                            Description = "Very good book",
                            ImageSource = "https://j.livelib.ru/boocover/1001542410/o/1833/Zhyul_Vern__Puteshestvie_k_tsentru_Zemli.jpeg",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 2.0,
                            Title = "Путешествие к центру земли",
                            UserId = 1,
                            СlickCount = 20
                        },
                        new
                        {
                            Id = 5,
                            Author = "Джоан Роулинг",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9539),
                            Description = "Very good book",
                            ImageSource = "https://i4.mybook.io/p/512x852/book_covers/86/25/86251214-92ea-44e9-a394-1a9ef1211400.jpe?v2",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "Гарри Поттер и философский камень",
                            UserId = 1,
                            СlickCount = 35
                        },
                        new
                        {
                            Id = 6,
                            Author = "Джоан Роулинг",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9550),
                            Description = "Very good book",
                            ImageSource = "https://i4.mybook.io/p/512x852/book_covers/37/81/37811194-8ad9-45a1-b394-9960b57b511f.jpe?v2",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "Гарри Поттер и кубок огня книга",
                            UserId = 2,
                            СlickCount = 56
                        },
                        new
                        {
                            Id = 7,
                            Author = "Джоан Роулинг",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9554),
                            Description = "Very good book",
                            ImageSource = "https://i4.mybook.io/p/512x852/book_covers/db/53/db53dd7e-10da-471a-b33e-2669f5a5abe9.jpe?v2",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "Гарри Поттер и орден феникса",
                            UserId = 2,
                            СlickCount = 23
                        },
                        new
                        {
                            Id = 8,
                            Author = "Федор Достоевский",
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 189, DateTimeKind.Utc).AddTicks(9557),
                            Description = "Very good book",
                            ImageSource = "https://azbyka.ru/fiction/wp-content/uploads/2013/02/55.jpg",
                            InGoodCondition = true,
                            IsBorrowed = false,
                            IsDeleted = false,
                            IsPainted = false,
                            Rate = 3.0,
                            Title = "Идиот",
                            UserId = 2,
                            СlickCount = 76
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.BookTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BorrowStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BorrowerId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSuccess")
                        .HasColumnType("bit");

                    b.Property<bool?>("OwnerAgreed")
                        .HasColumnType("bit");

                    b.Property<bool>("OwnerHasSeen")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookTransactions");
                });

            modelBuilder.Entity("DataAccess.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 190, DateTimeKind.Utc).AddTicks(2261),
                            IsDeleted = false,
                            Text = "I think this is amazing book!",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            BookId = 6,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 190, DateTimeKind.Utc).AddTicks(4111),
                            IsDeleted = false,
                            Text = "This is awful book...",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.DialogControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstInterlocutorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirstInterlocutorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastMessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondInterlocutorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecondInterlocutorId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DialogControls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 190, DateTimeKind.Utc).AddTicks(6863),
                            FirstInterlocutorEmail = "foxxychmoxy@gmail.com",
                            FirstInterlocutorId = 1,
                            IsDeleted = false,
                            LastMessage = "Hello! Yes, I know. Thank you!",
                            LastMessageDate = new DateTime(2020, 5, 3, 20, 19, 25, 191, DateTimeKind.Utc).AddTicks(1450),
                            SecondInterlocutorEmail = "almasgaara@mail.ru",
                            SecondInterlocutorId = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DialogControlId")
                        .HasColumnType("int");

                    b.Property<bool>("HasRead")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserReceiverEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserReceiverId")
                        .HasColumnType("int");

                    b.Property<string>("UserSenderEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserSenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DialogControlId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 191, DateTimeKind.Utc).AddTicks(5857),
                            DialogControlId = 1,
                            HasRead = true,
                            IsDeleted = false,
                            Text = "Hi! You are beautiful.",
                            UserReceiverEmail = "almasgaara@mail.ru",
                            UserReceiverId = 2,
                            UserSenderEmail = "foxxychmoxy@gmail.com",
                            UserSenderId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 192, DateTimeKind.Utc).AddTicks(316),
                            DialogControlId = 1,
                            HasRead = true,
                            IsDeleted = false,
                            Text = "Hello! Yes, I know. Thank you!",
                            UserReceiverEmail = "foxxychmoxy@gmail.com",
                            UserReceiverId = 1,
                            UserSenderEmail = "almasgaara@mail.ru",
                            UserSenderId = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("94821232-58b5-4fe4-8161-242d33991ec0"),
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 181, DateTimeKind.Utc).AddTicks(5328),
                            IsDeleted = false,
                            Name = "admin"
                        },
                        new
                        {
                            Id = new Guid("23b1fb71-0252-40d3-ae2a-918e132d38fd"),
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 181, DateTimeKind.Utc).AddTicks(8030),
                            IsDeleted = false,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 182, DateTimeKind.Utc).AddTicks(1071),
                            Email = "foxxychmoxy@gmail.com",
                            IsDeleted = false,
                            Password = "d9edce5cc424444d5c03fb834de779e9924eb69d05ea3f7be7dd5041bb87864e18b1b75c4d7a9b4abd9d9c784dc482701bdb711256c1f93610a107a161ceb2c2",
                            RoleId = new Guid("94821232-58b5-4fe4-8161-242d33991ec0")
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "ebs",
                            CreatedDate = new DateTime(2020, 5, 3, 20, 19, 25, 188, DateTimeKind.Utc).AddTicks(1991),
                            Email = "almasgaara@mail.ru",
                            IsDeleted = false,
                            Password = "d9edce5cc424444d5c03fb834de779e9924eb69d05ea3f7be7dd5041bb87864e18b1b75c4d7a9b4abd9d9c784dc482701bdb711256c1f93610a107a161ceb2c2",
                            RoleId = new Guid("23b1fb71-0252-40d3-ae2a-918e132d38fd")
                        });
                });

            modelBuilder.Entity("DataAccess.Models.BookGroup", b =>
                {
                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.ToTable("BookGroup");
                });

            modelBuilder.Entity("DataAccess.Models.GoodBookList", b =>
                {
                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastCommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastCommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("GoodBookList");
                });

            modelBuilder.Entity("DataAccess.Models.ShortUserList", b =>
                {
                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.ToTable("ShortUserList");
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.HasOne("DataAccess.Entities.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.BookTransaction", b =>
                {
                    b.HasOne("DataAccess.Entities.Book", "Book")
                        .WithMany("BookTransactions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.Comment", b =>
                {
                    b.HasOne("DataAccess.Entities.Book", null)
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.DialogControl", b =>
                {
                    b.HasOne("DataAccess.Entities.User", null)
                        .WithMany("Dialogs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DataAccess.Entities.Message", b =>
                {
                    b.HasOne("DataAccess.Entities.DialogControl", null)
                        .WithMany("Messages")
                        .HasForeignKey("DialogControlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.HasOne("DataAccess.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

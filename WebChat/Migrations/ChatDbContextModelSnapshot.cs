﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebChat.Database;

namespace WebChat.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    partial class ChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebChat.Database.Model.Message", b =>
                {
                    b.Property<DateTime>("SendingTime")
                        .HasColumnName("sending_time");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("MessageValue")
                        .HasColumnName("message_value");

                    b.Property<int>("RoomId")
                        .HasColumnName("room_id");

                    b.Property<int>("Type")
                        .HasColumnName("type");

                    b.HasKey("SendingTime", "UserId");

                    b.HasIndex("RoomId")
                        .HasName("ix_messages_room_id");

                    b.HasIndex("UserId")
                        .HasName("ix_messages_user_id");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("WebChat.Database.Model.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_rooms");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .HasName("ix_rooms_user_id");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2017, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Developers",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2016, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Managers",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("WebChat.Database.Model.RoomCredential", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnName("room_id");

                    b.Property<string>("HashedPassword")
                        .HasColumnName("hashed_password");

                    b.Property<byte[]>("Salt")
                        .HasColumnName("salt");

                    b.HasKey("RoomId")
                        .HasName("pk_room_credentials");

                    b.ToTable("room_credentials");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            HashedPassword = "PPX8GDu6mBzWsrlhmd2YES09Xxqg9zodg4YpwXqE78A=",
                            Salt = new byte[] { 223, 54, 155, 234, 69, 21, 182, 205, 175, 229, 95, 171, 155, 244, 208, 136 }
                        },
                        new
                        {
                            RoomId = 2,
                            HashedPassword = "Tmwj0kFo8lyxxxfU14K/Sbnt8nJsGqjJpAbJiavYpOs=",
                            Salt = new byte[] { 151, 246, 200, 5, 32, 134, 87, 132, 52, 226, 214, 187, 189, 175, 226, 166 }
                        });
                });

            modelBuilder.Entity("WebChat.Database.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("CurrentRoomId")
                        .HasColumnName("current_room_id");

                    b.Property<string>("Nickname")
                        .HasColumnName("nickname");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("CurrentRoomId")
                        .HasName("ix_users_current_room_id");

                    b.HasIndex("Nickname")
                        .IsUnique();

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nickname = "JFoster"
                        },
                        new
                        {
                            Id = 2,
                            Nickname = "AShishkin"
                        },
                        new
                        {
                            Id = 3,
                            Nickname = "AShurikov"
                        });
                });

            modelBuilder.Entity("WebChat.Database.Model.UserCredential", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("HashedPassword")
                        .HasColumnName("hashed_password");

                    b.Property<byte[]>("Salt")
                        .HasColumnName("salt");

                    b.HasKey("UserId")
                        .HasName("pk_user_credentials");

                    b.ToTable("user_credentials");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            HashedPassword = "yfsoPj8WKltZ1F5z3ZQ5ynK/jBmHgZJ+Mh0st9GawFI=",
                            Salt = new byte[] { 101, 215, 149, 8, 100, 101, 22, 27, 240, 58, 164, 110, 39, 197, 8, 97 }
                        },
                        new
                        {
                            UserId = 2,
                            HashedPassword = "dTsd0qaAFkzXVJw10viNng4NAajZfHcrG88DPrIZPJM=",
                            Salt = new byte[] { 139, 26, 81, 250, 117, 128, 76, 235, 184, 138, 49, 225, 237, 76, 126, 220 }
                        },
                        new
                        {
                            UserId = 3,
                            HashedPassword = "dnVQh5/iMCv80Epqm1YKTW1d7o17ZbpdRgyfIRFOfrg=",
                            Salt = new byte[] { 183, 23, 14, 204, 44, 7, 36, 234, 160, 78, 96, 194, 251, 99, 79, 199 }
                        });
                });

            modelBuilder.Entity("WebChat.Database.Model.Message", b =>
                {
                    b.HasOne("WebChat.Database.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .HasConstraintName("fk_messages_rooms_room_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebChat.Database.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_messages_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebChat.Database.Model.Room", b =>
                {
                    b.HasOne("WebChat.Database.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_rooms_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebChat.Database.Model.RoomCredential", b =>
                {
                    b.HasOne("WebChat.Database.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .HasConstraintName("fk_room_credentials_rooms_room_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebChat.Database.Model.User", b =>
                {
                    b.HasOne("WebChat.Database.Model.Room", "CurrentRoom")
                        .WithMany()
                        .HasForeignKey("CurrentRoomId")
                        .HasConstraintName("fk_users_rooms_current_room_id");
                });

            modelBuilder.Entity("WebChat.Database.Model.UserCredential", b =>
                {
                    b.HasOne("WebChat.Database.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_credentials_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
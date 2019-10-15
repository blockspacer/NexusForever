﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NexusForever.Database.Auth;

namespace NexusForever.Database.Auth.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountCostumeUnlockModel", b =>
                {
                    b.Property<uint>("Id");

                    b.Property<uint>("ItemId");

                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id", "ItemId");

                    b.ToTable("account_costume_unlock");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountCurrencyModel", b =>
                {
                    b.Property<uint>("Id");

                    b.Property<byte>("CurrencyId");

                    b.Property<ulong>("Amount");

                    b.HasKey("Id", "CurrencyId");

                    b.ToTable("account_currency");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountEntitlementModel", b =>
                {
                    b.Property<uint>("Id");

                    b.Property<byte>("EntitlementId");

                    b.Property<uint>("Amount");

                    b.HasKey("Id", "EntitlementId");

                    b.ToTable("account_entitlement");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountGenericUnlockModel", b =>
                {
                    b.Property<uint>("Id");

                    b.Property<uint>("Entry");

                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id", "Entry");

                    b.ToTable("account_generic_unlock");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountKeybindingModel", b =>
                {
                    b.Property<uint>("Id");

                    b.Property<ushort>("InputActionId");

                    b.Property<uint>("Code00");

                    b.Property<uint>("Code01");

                    b.Property<uint>("Code02");

                    b.Property<uint>("DeviceEnum00");

                    b.Property<uint>("DeviceEnum01");

                    b.Property<uint>("DeviceEnum02");

                    b.Property<uint>("EventTypeEnum00");

                    b.Property<uint>("EventTypeEnum01");

                    b.Property<uint>("EventTypeEnum02");

                    b.Property<uint>("MetaKeys00");

                    b.Property<uint>("MetaKeys01");

                    b.Property<uint>("MetaKeys02");

                    b.HasKey("Id", "InputActionId");

                    b.ToTable("account_keybinding");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountModel", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("GameToken")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("S")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("SessionKey")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("V")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("GameToken");

                    b.HasIndex("SessionKey");

                    b.ToTable("account");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.ServerMessageModel", b =>
                {
                    b.Property<byte>("Index");

                    b.Property<byte>("Language");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("Index", "Language");

                    b.ToTable("server_message");
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.ServerModel", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<ushort>("Port");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("server");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Host = "127.0.0.1",
                            Name = "NexusForever",
                            Port = (ushort)24000,
                            Type = (byte)0
                        });
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountCostumeUnlockModel", b =>
                {
                    b.HasOne("NexusForever.Database.Auth.Model.AccountModel", "Account")
                        .WithMany("CostumeUnlocks")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountCurrencyModel", b =>
                {
                    b.HasOne("NexusForever.Database.Auth.Model.AccountModel", "Account")
                        .WithMany("Currencies")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountEntitlementModel", b =>
                {
                    b.HasOne("NexusForever.Database.Auth.Model.AccountModel", "Account")
                        .WithMany("Entitlements")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountGenericUnlockModel", b =>
                {
                    b.HasOne("NexusForever.Database.Auth.Model.AccountModel", "Account")
                        .WithMany("GenericUnlocks")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NexusForever.Database.Auth.Model.AccountKeybindingModel", b =>
                {
                    b.HasOne("NexusForever.Database.Auth.Model.AccountModel", "Account")
                        .WithMany("Keybindings")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

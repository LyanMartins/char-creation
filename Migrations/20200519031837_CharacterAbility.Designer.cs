﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using char_creation.Models;

namespace char_creation.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200519031837_CharacterAbility")]
    partial class CharacterAbility
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("char_creation.Models.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("char_creation.Models.Atributtes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("agility")
                        .HasColumnType("int");

                    b.Property<int>("aura")
                        .HasColumnType("int");

                    b.Property<int>("charisma")
                        .HasColumnType("int");

                    b.Property<int>("force")
                        .HasColumnType("int");

                    b.Property<int>("intellect")
                        .HasColumnType("int");

                    b.Property<int>("perception")
                        .HasColumnType("int");

                    b.Property<int>("physicist")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atributtes");
                });

            modelBuilder.Entity("char_creation.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("appearence")
                        .HasColumnType("text");

                    b.Property<string>("bio")
                        .HasColumnType("text");

                    b.Property<int?>("characterLineageId")
                        .HasColumnType("int");

                    b.Property<int>("experence")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("nivel")
                        .HasColumnType("int");

                    b.Property<int?>("profissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("characterLineageId");

                    b.HasIndex("profissionId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("char_creation.Models.CharacterAbility", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("abilityId")
                        .HasColumnType("int");

                    b.Property<int>("characterId")
                        .HasColumnType("int");

                    b.HasKey("Id", "abilityId", "characterId");

                    b.HasIndex("abilityId");

                    b.HasIndex("characterId");

                    b.ToTable("CharacterAbility");
                });

            modelBuilder.Entity("char_creation.Models.CharacterLineage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("lineageId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("lineageId");

                    b.ToTable("CharacterLineage");
                });

            modelBuilder.Entity("char_creation.Models.Lineage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("lineageAtributtesId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("lineageAtributtesId");

                    b.ToTable("Lineage");
                });

            modelBuilder.Entity("char_creation.Models.LineageAtributtes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("agility")
                        .HasColumnType("int");

                    b.Property<int>("aura")
                        .HasColumnType("int");

                    b.Property<int>("charisma")
                        .HasColumnType("int");

                    b.Property<int>("force")
                        .HasColumnType("int");

                    b.Property<int>("intellect")
                        .HasColumnType("int");

                    b.Property<int>("perception")
                        .HasColumnType("int");

                    b.Property<int>("physicist")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LineageAtributtes");
                });

            modelBuilder.Entity("char_creation.Models.Profission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("acquisitionPoints")
                        .HasColumnType("int");

                    b.Property<int?>("characterLineageId")
                        .HasColumnType("int");

                    b.Property<int>("combatPoints")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("penalizedGroups")
                        .HasColumnType("text");

                    b.Property<string>("specializedSkills")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("characterLineageId");

                    b.ToTable("Profission");
                });

            modelBuilder.Entity("char_creation.Models.Character", b =>
                {
                    b.HasOne("char_creation.Models.CharacterLineage", "characterLineage")
                        .WithMany()
                        .HasForeignKey("characterLineageId");

                    b.HasOne("char_creation.Models.Profission", "profission")
                        .WithMany()
                        .HasForeignKey("profissionId");
                });

            modelBuilder.Entity("char_creation.Models.CharacterAbility", b =>
                {
                    b.HasOne("char_creation.Models.Ability", "ability")
                        .WithMany("characterAbility")
                        .HasForeignKey("abilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("char_creation.Models.Character", "character")
                        .WithMany("characterAbility")
                        .HasForeignKey("characterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("char_creation.Models.CharacterLineage", b =>
                {
                    b.HasOne("char_creation.Models.Lineage", "lineage")
                        .WithMany()
                        .HasForeignKey("lineageId");
                });

            modelBuilder.Entity("char_creation.Models.Lineage", b =>
                {
                    b.HasOne("char_creation.Models.LineageAtributtes", "lineageAtributtes")
                        .WithMany()
                        .HasForeignKey("lineageAtributtesId");
                });

            modelBuilder.Entity("char_creation.Models.Profission", b =>
                {
                    b.HasOne("char_creation.Models.CharacterLineage", "characterLineage")
                        .WithMany()
                        .HasForeignKey("characterLineageId");
                });
#pragma warning restore 612, 618
        }
    }
}
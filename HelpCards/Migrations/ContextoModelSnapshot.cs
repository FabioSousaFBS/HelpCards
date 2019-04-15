﻿// <auto-generated />
using System;
using HelpCards;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HelpCards.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("HelpCards.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAbertura");

                    b.Property<string>("Municipio");

                    b.Property<string>("Problema");

                    b.Property<string>("Provedor");

                    b.Property<string>("Situacao");

                    b.Property<string>("Solucao");

                    b.HasKey("Id");

                    b.ToTable("OrdemServicos");
                });
#pragma warning restore 612, 618
        }
    }
}
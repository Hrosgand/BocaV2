﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Administrador_de_entradas_para_la_Superliga.GlobalSvc
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities1 : DbContext
{
    public Entities1()
        : base("name=Entities1")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Match> Match { get; set; }

    public virtual DbSet<Billet> Billet { get; set; }

    public virtual DbSet<Places> Places { get; set; }

    public virtual DbSet<Socios> Socios { get; set; }

    public virtual DbSet<Table> Table { get; set; }

    public virtual DbSet<Tribunes> Tribunes { get; set; }

}

}


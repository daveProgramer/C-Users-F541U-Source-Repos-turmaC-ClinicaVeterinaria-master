﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vets.Models
{
        public class VetsDB : DbContext {
      //representar a Base de Dados
      //descrever as tabelas que lá estão contidas
      
      //representar o 'construtor' desta classe
      //indetifica onde se encontra a Base de Dados
        public VetsDB() : base("VetsDBConnection"){ }
    
      //descrever as tabelas que estão na base de dados
        public virtual DbSet<Donos> Donos { get; set; }
        public virtual DbSet<Animais> Animais { get; set;}
        public virtual DbSet<Donos> Veterinarios { get; set; }
        public virtual DbSet<Animais> Consultas { get; set; }

    }
}
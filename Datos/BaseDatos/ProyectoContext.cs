﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos.Models;

namespace Datos.BaseDatos
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext() : base("name=ProyectoRad")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Utilizamos using System.Data.Entity.ModelConfiguration.Conventions;
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //No queremos Nombres en plural
        }

    }
}

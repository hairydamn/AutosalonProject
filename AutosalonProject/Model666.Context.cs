﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutosalonProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutosalonEntities3 : DbContext
    {
        public AutosalonEntities3()
            : base("name=AutosalonEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Autorization> Autorization { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
    }
}
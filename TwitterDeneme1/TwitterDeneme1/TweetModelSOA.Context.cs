﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterDeneme1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbTwitterEntitiesSOA : DbContext
    {
        public dbTwitterEntitiesSOA()
            : base("name=dbTwitterEntitiesSOA")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblTwit> tblTwit { get; set; }
        public virtual DbSet<tblTwitFav> tblTwitFav { get; set; }
        public virtual DbSet<tblUye> tblUye { get; set; }
        public virtual DbSet<tblUyeTakip> tblUyeTakip { get; set; }
    }
}

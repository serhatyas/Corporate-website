﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ozyer.Areas.admin.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServiceDB : DbContext
    {
        public ServiceDB()
            : base("name=ServiceDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<ContactMessages> ContactMessages { get; set; }
        public virtual DbSet<Corporate> Corporate { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<Participations> Participations { get; set; }
        public virtual DbSet<ParticipationSectorCategories> ParticipationSectorCategories { get; set; }
        public virtual DbSet<ParticipationSectorWorkFile> ParticipationSectorWorkFile { get; set; }
        public virtual DbSet<ParticipationSectorWorks> ParticipationSectorWorks { get; set; }
        public virtual DbSet<ParticipationsGroups> ParticipationsGroups { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Sliders> Sliders { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorkPartnerFiles> WorkPartnerFiles { get; set; }
        public virtual DbSet<WorkPartners> WorkPartners { get; set; }
    }
}

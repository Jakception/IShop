﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IShop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBaseIShopEntities : DbContext
    {
        public DataBaseIShopEntities()
            : base("name=DataBaseIShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIE> CATEGORIE { get; set; }
        public virtual DbSet<COMMANDE> COMMANDE { get; set; }
        public virtual DbSet<COMMENTAIRE> COMMENTAIRE { get; set; }
        public virtual DbSet<IMAGE> IMAGE { get; set; }
        public virtual DbSet<PAIEMENT> PAIEMENT { get; set; }
        public virtual DbSet<PAYS> PAYS { get; set; }
        public virtual DbSet<PRODUIT> PRODUIT { get; set; }
        public virtual DbSet<PRODUIT_COMMANDE> PRODUIT_COMMANDE { get; set; }
        public virtual DbSet<PRODUIT_SOCIETE> PRODUIT_SOCIETE { get; set; }
        public virtual DbSet<SOCIETE> SOCIETE { get; set; }
        public virtual DbSet<UTILISATEUR> UTILISATEUR { get; set; }
        public virtual DbSet<VILLE> VILLE { get; set; }
    }
}
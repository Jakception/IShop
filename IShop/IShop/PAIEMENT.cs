//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PAIEMENT
    {
        public short ID_PAIEMENT { get; set; }
        public Nullable<short> ID_UTILISATEUR { get; set; }
        public string TYPE_CARTE_PAIEMENT { get; set; }
        public Nullable<int> NUMERO_CARTE_PAIEMENT { get; set; }
        public Nullable<short> CODE_CARTE_PAIEMENT { get; set; }
        public string NOM_TITULAIRE_CARTE_PAIEMENT { get; set; }
        public string PRENOM_TITULAIRE_CARTE_PAIEMENT { get; set; }
        public Nullable<System.DateTime> DATE_VALIDITE_CARTE_PAIEMENT { get; set; }
        public string ADR_FACTURATION { get; set; }
    
        public virtual UTILISATEUR UTILISATEUR { get; set; }
    }
}
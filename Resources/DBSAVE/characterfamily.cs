//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class characterfamily
    {
        public long CharacterId { get; set; }
        public string Xp { get; set; }
        public string Authority { get; set; }
        public string Message { get; set; }
        public string FamilyName { get; set; }
    
        public virtual family family { get; set; }
    }
}

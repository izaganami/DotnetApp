//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JaBak.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class acheter
    {
        public int id_achat { get; set; }
        public Nullable<int> id_produit { get; set; }
        public string id_client { get; set; }
        public string libelle { get; set; }
        public string id_fournisseur { get; set; }
        public string catégorie { get; set; }
        public string Email { get; set; }
        public Nullable<double> Prix { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geography.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Continents
    {
        public Continents()
        {
            this.Countries = new HashSet<Countries>();
        }
    
        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }
    
        public virtual ICollection<Countries> Countries { get; set; }
    }
}
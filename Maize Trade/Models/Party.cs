//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maize_Trade.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Party()
        {
            this.Sales = new HashSet<Sale>();
        }
        [Display(Name = "Party ID")]
        public int PartyID { get; set; }
        [Display(Name = "Party Name")]
        public string Name { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "TIN")]
        public string TIN { get; set; }
        [Display(Name = "Contact Number")]
        
        [Required, StringLength(13, MinimumLength = 10,ErrorMessage ="Enter a valid Contact number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Note")]
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Display(Name = "Sales")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

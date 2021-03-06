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
    public partial class Purchase
    {
        [Display(Name = "Purchase ID")]
        public int PurchaseID { get; set; }
        [Required, Display(Name = "Date"), DataType(DataType.Date, ErrorMessage = "Date not valid.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Farmer")]
        public int FarmerID { get; set; }
        [Display(Name = "Maize Weight")]
        public Nullable<decimal> MaizeWeight { get; set; }
        [Display(Name = "Current Rate")]
        public Nullable<decimal> MaizeRate { get; set; }
        [Display(Name = "Deduction In Weight")]
        public Nullable<decimal> DeductionInWeight { get; set; }
        [Display(Name = "Total Amount")]
        public Nullable<decimal> TotalAmount { get; set; }
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Display(Name = "Farmer Details")]
        public virtual Farmer Farmer { get; set; }
    }
}

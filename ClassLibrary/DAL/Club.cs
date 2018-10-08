
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClassLibrary.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class Club
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Club()
    {

        this.Brands = new HashSet<Brand>();

        this.Club_Benefit_Type = new HashSet<Club_Benefit_Type>();

        this.Club_Customer = new HashSet<Club_Customer>();

        this.Club_Required_Fields = new HashSet<Club_Required_Fields>();

        this.Categories = new HashSet<Category>();

    }


    public int ClubId { get; set; }

    public string ClubName { get; set; }

    public string description { get; set; }

    public string Terms { get; set; }

    public string Image_Logo { get; set; }

    public string URL_Internet_site { get; set; }

    public string קרקרק { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Brand> Brands { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Club_Benefit_Type> Club_Benefit_Type { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Club_Customer> Club_Customer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Club_Required_Fields> Club_Required_Fields { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Category> Categories { get; set; }

}

}

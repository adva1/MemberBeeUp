
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
    
public partial class Club_Benefit_Type
{

    public int ClubClubId { get; set; }

    public int Benefit_TypeCode { get; set; }

    public string Specific_Benefit { get; set; }



    public virtual Benefit_Type Benefit_Type { get; set; }

    public virtual Club Club { get; set; }

}

}

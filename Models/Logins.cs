//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindGitHubMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logins
    {
        public int LoginID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string LoginErrorMessage { get; set; }
        public Nullable<System.DateTime> RegisterationDate { get; set; }
    }
}

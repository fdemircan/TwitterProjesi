//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterDeneme1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTwit
    {
        public int twitID { get; set; }
        public string icerik { get; set; }
        public Nullable<System.DateTime> atilmaTarihi { get; set; }
        public Nullable<int> uyeID { get; set; }
    
        public virtual tblUye tblUye { get; set; }
    }
}

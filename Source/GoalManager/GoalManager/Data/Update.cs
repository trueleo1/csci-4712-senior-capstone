//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoalManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Update
    {
        public int UpID { get; set; }
        public int GID { get; set; }
        public int Progress { get; set; }
        public string Notes { get; set; }
        public string Subject { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Goal Goal { get; set; }
    }
}

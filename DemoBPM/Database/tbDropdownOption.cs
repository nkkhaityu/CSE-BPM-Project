//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoBPM.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDropdownOption : DemoBPM.Common.APISupport.SEObject
    {
        public int ID { get; set; }
        public Nullable<int> InputFieldID { get; set; }
        public string Content { get; set; }
    
        public virtual tbInputField tbInputField { get; set; }
    }
}

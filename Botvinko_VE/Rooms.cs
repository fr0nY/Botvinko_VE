//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Botvinko_VE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rooms()
        {
            this.Cleaning_shedule = new HashSet<Cleaning_shedule>();
            this.Room_accsess = new HashSet<Room_accsess>();
        }
    
        public int id { get; set; }
        public string floor { get; set; }
        public Nullable<int> number { get; set; }
        public string category { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cleaning_shedule> Cleaning_shedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room_accsess> Room_accsess { get; set; }
    }
}

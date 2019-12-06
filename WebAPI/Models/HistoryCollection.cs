//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryCollection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistoryCollection()
        {
            this.Consolidate = new HashSet<Consolidate>();
        }
    
        public string IdHistoryCollection { get; set; }
        public string IdVehicle { get; set; }
        public string IdRoute { get; set; }
        public string DateStart { get; set; }
        public string DateFinal { get; set; }
        public Nullable<int> MinutesV { get; set; }
        public Nullable<int> Passenger { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<double> Kilometers { get; set; }
        public Nullable<double> Laps { get; set; }
        public string IdSector { get; set; }
        public Nullable<double> LapsManual { get; set; }
        public string IdRegistry { get; set; }
        public Nullable<double> InRegistry { get; set; }
        public Nullable<double> InSector { get; set; }
        public Nullable<double> InRoutes { get; set; }
        public Nullable<double> AmountDiscountedBrands { get; set; }
        public Nullable<int> Blocks { get; set; }
        public Nullable<int> UpsDoorOne { get; set; }
        public Nullable<int> DownsDoorOne { get; set; }
        public Nullable<int> BlocksDoorOne { get; set; }
        public Nullable<int> UpsDoorTwo { get; set; }
        public Nullable<int> DownsDoorTwo { get; set; }
        public Nullable<int> BlocksDoorTwo { get; set; }
        public Nullable<int> InVehicle { get; set; }
        public Nullable<double> InHistoryRealTime { get; set; }
        public Nullable<int> DiscountedBrands { get; set; }
        public string IdConsolidate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consolidate> Consolidate { get; set; }
        public virtual Route Route { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

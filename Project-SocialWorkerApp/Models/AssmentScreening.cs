//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_SocialWorkerApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssmentScreening
    {
        public long ID { get; set; }
        public string SoicialWorker { get; set; }
        public int ReportMonthID { get; set; }
        public string SiteId { get; set; }
        public int VinelandsCompleted { get; set; }
        public int SocialHistories { get; set; }
        public int AutismEvaluations { get; set; }
        public int StudentsScreened { get; set; }
        public int ASOtherNo { get; set; }
        public string ASOtherText { get; set; }
        public byte Active { get; set; }
    }
}

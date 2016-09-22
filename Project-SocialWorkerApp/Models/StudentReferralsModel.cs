using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Project_SocialWorkerApp.Models
{
    public class StudentReferralsModel
    {
        [Key]
        public int ID { get; set; }
        public int ReportMonthID { get; set; }
        [MaxLength(4)]
        [Display(Name = "American Indian Female")]
        public int AmericanIndianFemale { get; set; }
        [Display(Name = "American Indian Male")]
        public int AmericanIndianMale { get; set; }
        [Display(Name = "Asian Female")]
        public int AsianFemale { get; set; }
        [Display(Name = "Asian Male")]
        public int AsianMale { get; set; }
        [Display(Name = "Black Female")]
        public int BlackFemale { get; set; }
        [Display(Name = "Black Male")]
        public int BlackMale { get; set; }
        [Display(Name = "Hispanic Female")]
        public int HispanicFemale { get; set; }
        [Display(Name = "Hispanic Male")]
        public int HispanicMale { get; set; }
        [Display(Name = "Multiracial Female")]
        public int MultiracialFemale { get; set; }
        [Display(Name = "Multiracial Male")]
        public int MultiracialMale { get; set; }
        [Display(Name = "White Female")]
        public int WhiteFemale { get; set; }
        [Display(Name = "White Male")]
        public int WhiteMale { get; set; }

        [Display(Name = "Academic Performance")]
        public bool AcademicPerformance { get; set; }
        [Display(Name = "Abuse/Neglect Consult")]
        public bool AbuseNeglectConsult { get; set; }
        [Display(Name = "Administrative Request")]
        public bool AdministrativeRequest { get; set; }
        [Display(Name = "Alcohol/ Drug/Substance Abuse")]
        public bool AlcoholDrugSubstanceAbuse { get; set; }
        [Display(Name = "Attendance")]
        public bool Attendance { get; set; }
        [Display(Name = "Behavior Management")]
        public bool BehaviorManagement { get; set; }
        [Display(Name = "Bullying")]
        public bool Bullying { get; set; }
        [Display(Name = "Character Development")]
        public bool CharacterDevelopment { get; set; }
        [Display(Name = "Conflict Resolution")]
        public bool ConflictResolution { get; set; }
        [Display(Name = "Dropout Prevention")]
        public bool DropoutPrevention { get; set; }
        [Display(Name = "EC Referrals")]
        public bool ECReferrals { get; set; }
        [Display(Name = "Emergency Assistance")]
        public bool EmergencyAssistance { get; set; }
        [Display(Name = "Health/Dental")]
        public bool HealthDental { get; set; }
        [Display(Name = "Homelessness")]
        public bool Homelessness { get; set; }
        [Display(Name = "Mental Health")]
        public bool MentalHealth { get; set; }
        [Display(Name = "Needs Assessment")]
        public bool NeedsAssessment { get; set; }
        [Display(Name = "SIT (Suicide Intervention)")]
        public bool SIT { get; set; }
        [Display(Name = "SMOD")]
        public bool SMOD { get; set; }
        [Display(Name = "Social Service Needs")]
        public bool SocialServiceNeeds { get; set; }
        [Display(Name = "Suspension Follow up")]
        public bool SuspensionFollowup { get; set; }


    }
}
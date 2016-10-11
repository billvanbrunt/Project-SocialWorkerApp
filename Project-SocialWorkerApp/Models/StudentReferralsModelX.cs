using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Project_SocialWorkerApp.Models
{
    [MetadataType(typeof(StudentReferralsMetadata))]
    public partial class StudentReferrals { }


        public partial class StudentReferralsMetadata
        {
        [Key]
        public int ID;
        public int ReportMonthID;
        [MaxLength(4)]
        [Display(Name = "American Indian Female")]
        public int AmericanIndianFemale;
        [Display(Name = "American Indian Male")]
        public int AmericanIndianMale;
        [Display(Name = "Asian Female")]
        public int AsianFemale;
        [Display(Name = "Asian Male")]
        public int AsianMale;
        [Display(Name = "Black Female")]
        public int BlackFemale;
        [Display(Name = "Black Male")]
        public int BlackMale;
        [Display(Name = "Hispanic Female")]
        public int HispanicFemale;
        [Display(Name = "Hispanic Male")]
        public int HispanicMale;
        [Display(Name = "Multiracial Female")]
        public int MultiracialFemale;
        [Display(Name = "Multiracial Male")]
        public int MultiracialMale;
        [Display(Name = "White Female")]
        public int WhiteFemale;
        [Display(Name = "White Male")]
        public int WhiteMale;

        [Display(Name = "Academic Performance")]
        public bool AcademicPerformance;
        [Display(Name = "Abuse/Neglect Consult")]
        public bool AbuseNeglectConsult;
        [Display(Name = "Administrative Request")]
        public bool AdministrativeRequest;
        [Display(Name = "Alcohol/ Drug/Substance Abuse")]
        public bool AlcoholDrugSubstanceAbuse;
        [Display(Name = "Attendance")]
        public bool Attendance;
        [Display(Name = "Behavior Management")]
        public bool BehaviorManagement;
        [Display(Name = "Bullying")]
        public bool Bullying;
        [Display(Name = "Character Development")]
        public bool CharacterDevelopment;
        [Display(Name = "Conflict Resolution")]
        public bool ConflictResolution;
        [Display(Name = "Dropout Prevention")]
        public bool DropoutPrevention;
        [Display(Name = "EC Referrals")]
        public bool ECReferrals;
        [Display(Name = "Emergency Assistance")]
        public bool EmergencyAssistance;
        [Display(Name = "Health/Dental")]
        public bool HealthDental;
        [Display(Name = "Homelessness")]
        public bool Homelessness;
        [Display(Name = "Mental Health")]
        public bool MentalHealth;
        [Display(Name = "Needs Assessment")]
        public bool NeedsAssessment;
        [Display(Name = "SIT (Suicide Intervention)")]
        public bool SIT;
        [Display(Name = "SMOD")]
        public bool SMOD;
        [Display(Name = "Social Service Needs")]
        public bool SocialServiceNeeds;
        [Display(Name = "Suspension Follow up")]
        public bool SuspensionFollowup;


    }
}
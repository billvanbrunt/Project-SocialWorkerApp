using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Project_SocialWorkerApp.Models
{
    public class ResponsiveModel
    {
        public int ID { get; set; }
             
        [Display(Name = "No of sessions with individual students")]
        public int IndividualCounselingSession { get; set; }
        [Display(Name = "No of small group sessions")]
        public int SmallGroupSession { get; set; }
        [Display(Name = "No of classroom presentations")]
        public int ClassRoomSession { get; set; }
        [Display(Name = "No of parent conferences")]
        public int ParentConferences { get; set; }
        [Display(Name = "No of home visits")]
        public int HomeVisits { get; set; }
        [Display(Name = "No of parent telephone calls")]
        public int  ParentTelephoneCalls { get; set; }
        [Display(Name = "No of parent workshops facilitated")]
        public int ParentWorkshopsFacilitated { get; set; }
        [Display(Name = "No of SIT interventions")]
        public int SITInterventions { get; set; }
        [Display(Name = "Other")]
        public String OtherServices { get; set; }
        [Display(Name = "Drug Facts Action Pack")]
        public bool DrugFactsActionPack  { get; set; }
        [Display(Name = "Wise Owls")]
        public bool WiseOwls { get; set; }
        [Display(Name = "S.M.A.R.T. Teams")]
        public bool SMARTTeam { get; set; }
        [Display(Name = "Bully Proofing Schools")]
        public bool BullyProofingSchools { get; set; }
        [Display(Name = "Conflict Resolution ")]
        public bool ConflictResolution  { get; set; }
        [Display(Name = "7 Habits of Highly Effective Teens")]
        public bool HabitsofHighlyEffectiveTeens { get; set; }
        [Display(Name = "101 Support Group Activities")]
        public bool SupportGroupActivities { get; set; }
        [Display(Name = "Horizons – All About Me ")]
        public bool AllAboutMe  { get; set; }
        [Display(Name = "Skills for Growing")]
        public bool SkillsforGrowing { get; set; }
        [Display(Name = "Peacemakers in Training")]
        public bool Peacemakers { get; set; }
        [Display(Name = "The Other Wes Moore ")]
        public bool TheOtherWesMoore  { get; set; }
        [Display(Name = "How Children Succeed")]
        public bool HowChildrenSucceed { get; set; }
        [Display(Name = "The School Social Work Toolkit")]
        public bool SocialWorkToolkit { get; set; }
        [Display(Name = "20,000 Days and Counting ")]
        public bool DaysandCounting  { get; set; }
        [Display(Name = "Why Try?")]
        public bool WhyTry { get; set; }
        [Display(Name = "Tools for Teaching Social Skills")]
        public bool ToolsforTeachingSocialSkills { get; set; }
        [Display(Name = "Other(s)")]
        public string CurriculumOther { get; set; }


    }

}

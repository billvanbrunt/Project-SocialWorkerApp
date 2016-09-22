using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_SocialWorkerApp.Models;

namespace Project_SocialWorkerApp.Controllers
{
    public class StudentReferralsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: StudentReferrals
        public ActionResult Index()
        {
            return View(db.StudentReferralsModels.ToList());
        }

        // GET: StudentReferrals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentReferralsModel studentReferralsModel = db.StudentReferralsModels.Find(id);
            if (studentReferralsModel == null)
            {
                return HttpNotFound();
            }
            return View(studentReferralsModel);
        }

        // GET: StudentReferrals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentReferrals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ReportMonthID,AmericanIndianFemale,AmericanIndianMale,AsianFemale,AsianMale,BlackFemale,BlackMale,HispanicFemale,HispanicMale,MultiracialFemale,MultiracialMale,WhiteFemale,WhiteMale,AcademicPerformance,AbuseNeglectConsult,AdministrativeRequest,AlcoholDrugSubstanceAbuse,Attendance,BehaviorManagement,Bullying,CharacterDevelopment,ConflictResolution,DropoutPrevention,ECReferrals,EmergencyAssistance,HealthDental,Homelessness,MentalHealth,NeedsAssessment,SIT,SMOD,SocialServiceNeeds,SuspensionFollowup")] StudentReferralsModel studentReferralsModel)
        {
            if (ModelState.IsValid)
            {
                db.StudentReferralsModels.Add(studentReferralsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentReferralsModel);
        }

        // GET: StudentReferrals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentReferralsModel studentReferralsModel = db.StudentReferralsModels.Find(id);
            if (studentReferralsModel == null)
            {
                return HttpNotFound();
            }
            return View(studentReferralsModel);
        }

        // POST: StudentReferrals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ReportMonthID,AmericanIndianFemale,AmericanIndianMale,AsianFemale,AsianMale,BlackFemale,BlackMale,HispanicFemale,HispanicMale,MultiracialFemale,MultiracialMale,WhiteFemale,WhiteMale,AcademicPerformance,AbuseNeglectConsult,AdministrativeRequest,AlcoholDrugSubstanceAbuse,Attendance,BehaviorManagement,Bullying,CharacterDevelopment,ConflictResolution,DropoutPrevention,ECReferrals,EmergencyAssistance,HealthDental,Homelessness,MentalHealth,NeedsAssessment,SIT,SMOD,SocialServiceNeeds,SuspensionFollowup")] StudentReferralsModel studentReferralsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentReferralsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentReferralsModel);
        }

        // GET: StudentReferrals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentReferralsModel studentReferralsModel = db.StudentReferralsModels.Find(id);
            if (studentReferralsModel == null)
            {
                return HttpNotFound();
            }
            return View(studentReferralsModel);
        }

        // POST: StudentReferrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentReferralsModel studentReferralsModel = db.StudentReferralsModels.Find(id);
            db.StudentReferralsModels.Remove(studentReferralsModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

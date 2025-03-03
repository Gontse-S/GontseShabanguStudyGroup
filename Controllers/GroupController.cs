using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GontseShabanguStudyGroup.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult StudyList()
        {
            List<Models.Study> student = new List<Models.Study>();
            student.Add(new Models.Study { StudentNumber = "u24698505", FirstName = "Gontse", LastName = "Shabangu", EmailAddress = "u24698505@tuks.co.za" });
            student.Add(new Models.Study { StudentNumber = "u24686752", FirstName = "Thato", LastName = "Mokgothu", EmailAddress = "u24686752@tuks.co.za" });
            student.Add(new Models.Study { StudentNumber = "u24951405", FirstName = "Lathitha", LastName = "Mqoboli", EmailAddress = "u24951405@tuks.co.za" });
            student.Add(new Models.Study { StudentNumber = "u24742661", FirstName = "Dumo", LastName = "Ngobese", EmailAddress = "u2262308@tuks.co.za" });
            student.Add(new Models.Study{ StudentNumber = "u24752038", FirstName = "Langaleftu", LastName = "Manzini", EmailAddress = "u24752038@tuks.co.za" });

            return View(student);
        }
    }
}
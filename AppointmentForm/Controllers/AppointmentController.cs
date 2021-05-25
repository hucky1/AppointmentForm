using AppointmentForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentForm.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowAppointmentDetails(AppointmentModel model)
        {
            model.DoctorLastName = model.DoctorLastName ?? "Potroshitel";
            return View("ShowAppointmentDetails",model);
        }
    }
}
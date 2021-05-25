using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppointmentForm.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength =4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Choose the desired date for your next visit")]
        public DateTime AppointmentDate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("How much money do you have?")]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("What is the name of the doctor you wish to see?")]
        public string DoctorLastName { get; set; } = "Potroshitel'";
        [Required]
        [Range(1,10)]
        [DisplayName("What is your current pain level (0 to 10)?")]
        public int CurrentPainLevel { get; set; }

        public AppointmentModel(string patientName, DateTime appointmentDate, decimal patientNetWorth, string doctorLastName, int currentPainLevel)
        {
            PatientName = patientName;
            AppointmentDate = appointmentDate;
            PatientNetWorth = patientNetWorth;
            DoctorLastName = doctorLastName;
            CurrentPainLevel = currentPainLevel;
        }

        public AppointmentModel()
        {
        }
    }
}
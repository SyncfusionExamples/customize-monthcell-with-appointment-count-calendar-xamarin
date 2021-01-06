using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class ViewModel : INotifyPropertyChanged
    {
        public CalendarEventCollection Appointments { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentCount { get; set; }
        public bool IsAppointment { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
        {
            this.AddAppointments();
        }
        private void AddAppointments()
        {
            Appointments = new CalendarEventCollection();
            var random = new Random();
            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-5).AddHours(10),
                EndTime = DateTime.Now.Date.AddDays(-5).AddHours(12),
                Subject = "Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-9).AddHours(10),
                EndTime = DateTime.Now.Date.AddDays(-9).AddHours(12),
                Subject = "Planning",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-9).AddHours(15),
                EndTime = DateTime.Now.Date.AddDays(-9).AddHours(17),
                Subject = "Execution",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-15).AddHours(10),
                EndTime = DateTime.Now.Date.AddDays(-15).AddHours(12),
                Subject = "Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-15).AddHours(13),
                EndTime = DateTime.Now.Date.AddDays(-15).AddHours(15),
                Subject = "Planning",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-15).AddHours(15),
                EndTime = DateTime.Now.Date.AddDays(-15).AddHours(17),
                Subject = "Execution",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-4).AddHours(10),
                EndTime = DateTime.Now.Date.AddDays(-4).AddHours(12),
                Subject = "Scrum Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-4).AddHours(13),
                EndTime = DateTime.Now.Date.AddDays(-4).AddHours(15),
                Subject = "Product Planning",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-4).AddHours(15),
                EndTime = DateTime.Now.Date.AddDays(-4).AddHours(17),
                Subject = "Execution",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-4).AddHours(17),
                EndTime = DateTime.Now.Date.AddDays(-4).AddHours(18),
                Subject = "Review Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-24).AddHours(09),
                EndTime = DateTime.Now.Date.AddDays(-24).AddHours(10),
                Subject = "Scrum Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-28).AddHours(11),
                EndTime = DateTime.Now.Date.AddDays(-28).AddHours(13),
                Subject = "Product Planning",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-28).AddHours(15),
                EndTime = DateTime.Now.Date.AddDays(-28).AddHours(17),
                Subject = "Plan Execution",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-20).AddHours(17),
                EndTime = DateTime.Now.Date.AddDays(-20).AddHours(18),
                Subject = "Review Meeting",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-20).AddHours(18),
                EndTime = DateTime.Now.Date.AddDays(-20).AddHours(19),
                Subject = "Testing",
                Color = Color.FromHex("#889e81")
            });

            Appointments.Add(new CalendarInlineEvent()
            {
                StartTime = DateTime.Now.Date.AddDays(-20).AddHours(18),
                EndTime = DateTime.Now.Date.AddDays(-20).AddHours(19),
                Subject = "Testing",
                Color = Color.FromHex("#889e81")
            });
        }
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }
}

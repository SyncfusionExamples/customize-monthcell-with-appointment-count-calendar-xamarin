using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarPageBehavior : Behavior<ContentPage>
    {
        SfCalendar calendar;
        CalendarEventCollection appointments;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable.FindByName<SfCalendar>("calendar");
            this.WireEvents();
        }
        private void WireEvents()
        {
            this.calendar.OnMonthCellLoaded += Calendar_OnMonthCellLoaded;
        }
        private void Calendar_OnMonthCellLoaded(object sender, MonthCellLoadedEventArgs args)
        {
            var viewModel = (calendar.BindingContext as ViewModel);
            viewModel.Date = args.Date;
            viewModel.IsAppointment = false;
            viewModel.AppointmentCount = "";

            appointments = calendar.DataSource as CalendarEventCollection;

            for (int i = 0; i < appointments.Count; i++)
            {
                var appointment = appointments[i];
                if (args.Date.Date == appointment.StartTime.Date)
                {
                    // Count Starts from 0
                    viewModel.AppointmentCount = (i + 1).ToString();
                    viewModel.IsAppointment = true;
                }
            }
            args.CellBindingContext = viewModel;
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.UnWireEvents();
        }
        private void UnWireEvents()
        {
            this.calendar.OnMonthCellLoaded -= Calendar_OnMonthCellLoaded;
        }
    }
}


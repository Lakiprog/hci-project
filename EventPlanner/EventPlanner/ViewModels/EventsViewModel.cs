﻿using EventPlanner.Commands;
using EventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using System.Windows.Input;

namespace EventPlanner.ViewModels
{
    class EventsViewModel : ObservableObject
    {
        public EventsViewModel()
        {
            InitData();
            InitCommands();
        }
        private ObservableCollection<Event> organizerEvents;
        private ObservableCollection<Event> upcomingEvents;
        private Event selectedEvent;
        
        public ObservableCollection<Event> OrganizerEvents
        {
            get => organizerEvents;
            set { organizerEvents = value; RaisePropertyChngedEvent("OrganizerEvents"); }
        }
        public ObservableCollection<Event> UpcomingEvents
        {
            get => upcomingEvents;
            set { upcomingEvents = value; RaisePropertyChngedEvent("UpcomingEvents"); }
        }
        public Event SelectedEvent
        {
            get => selectedEvent;
            set { selectedEvent = value; RaisePropertyChngedEvent("SelectedEvent"); }
        }
        private void InitCommands()
        {
        }
        private void InitData()
        {
            organizerEvents = new ObservableCollection<Event>();
            upcomingEvents = new ObservableCollection<Event>();
            AddOriginalData();
        }
        private void AddOriginalData()
        {
            this.organizerEvents.Clear();
            List<Event> organizerEvents = new List<Event>();
            User user = new User("micko", "micko123", "Mica", "Lakic");
            organizerEvents.Add(new Event(1,"Resourceful project manager with 10 years of experience", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            organizerEvents.Add(new Event(2,"Engaging high school teacher skilled in ESL and IEPS", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            organizerEvents.Add(new Event(3,"Multi-lingual licensed RN with 5+ years of experience in pediatrics", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            organizerEvents.Add(new Event(4,"Hard-working CNA and Nightingale Award recipient", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));

            organizerEvents.ForEach(this.organizerEvents.Add);

            this.upcomingEvents.Clear();
            List<Event> upcomingEvents = new List<Event>();
            upcomingEvents.Add(new Event(5,"Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            upcomingEvents.Add(new Event(6,"System.Runtime.Serialization.Formatters.dll", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            upcomingEvents.Add(new Event(7,"EventPlanner.exe", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));
            upcomingEvents.Add(new Event(8,"Title 24", EventType.WEDDING, "desc1", DateTime.ParseExact("2021-06-05 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), DateTime.ParseExact("2021-06-05 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture), user));

            upcomingEvents.ForEach(this.upcomingEvents.Add);
        }

    }
}

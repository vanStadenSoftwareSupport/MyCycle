using System;
using System.Collections.Generic;
using MyCycle.Entity;
using Xamarin.Forms;

namespace MyCycle
{
    public partial class TripListPage : ContentPage
    {
        private static List<Trip> trips = new List<Trip> {
            new Trip{StartDate= DateTime.Now, EndDate= DateTime.Now.AddHours(1.00), DistanceInMeters = 50000, FromSuburb = "?", ToSuburb= "?"},
            new Trip{StartDate= DateTime.Now.Add(TimeSpan.FromHours(1.5)), EndDate= DateTime.Now.Add(TimeSpan.FromMinutes(35)), DistanceInMeters = 30186, FromSuburb = "?", ToSuburb= "?"}
        };

        public TripListPage()
        {
            InitializeComponent();
            lstTrips.ItemsSource = trips;
            //var displayCell = new DataTemplate(typeof(TextCell)); 
            //displayCell.SetBinding(TextCell.TextProperty, new Binding(".StartDate"));
            //displayCell.SetBinding(TextCell.DetailProperty, new Binding(".FromSuburb"));
            //lstTrips.ItemTemplate = displayCell;
        }
        public List<Trip> Trips
        {
            get {
                return trips;
            }

        }
    }
}

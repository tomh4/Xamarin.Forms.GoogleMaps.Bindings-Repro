using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        public ObservableCollection<Pin> Pins { get; set; }

        public MoveToRegionRequest Request { get; } = new MoveToRegionRequest();


        public Command MoveCommand => new Command(() =>
        {
            Request.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(49.628222, 6.164697),
                    Distance.FromKilometers(2)),
                true);
            Pins.Add(new Pin()
            {
                Label = "Test1",
                Address = "1, rue Lala",
                Position = new Position(49.628222, 6.164697)
            });
        });

        public MainPage()
        {
            InitializeComponent();
        }
    }
}

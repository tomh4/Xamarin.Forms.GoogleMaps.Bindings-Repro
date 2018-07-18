using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps.Bindings;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapView
	{
        public MoveToRegionRequest MoveToRegionRequest { get; } = new MoveToRegionRequest();

        public MapView()
        {
            InitializeComponent();
        }
    }
}
using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grouping_maps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            imageryLayer.Markers.Add(new CustomMarker() { Latitude = "20.766387", Longitude = "78.750000", ImageName = ImageSource.FromResource("Grouping_maps.Icons.pin.png") });
        }

        /// <summary>
        /// This method is called whenever the zoom level changes and the markers can be grouped based on your requirement with this event
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The zoom level changing event args</param>
        private void ImageryLayer_ZoomLevelChanging(object sender, ZoomLevelChangingEventArgs e)
        {
            // Marker is added based on the zoom level
            if (e.CurrentLevel <= 3)
            {
                if(imageryLayer.Markers.Count > 1)
                {
                    imageryLayer.Markers.Clear();
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "20.766387", Longitude = "78.750000", ImageName = ImageSource.FromResource("Grouping_maps.Icons.pin.png") });
                }          
            }

            if (e.CurrentLevel >= 4)
            {
                if (imageryLayer.Markers.Count == 1)
                {
                    imageryLayer.Markers.Clear();
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "12.331952", Longitude = "78.002930", ImageName = ImageSource.FromResource("Grouping_maps.Icons.one.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "17.678045", Longitude = "78.793945", ImageName = ImageSource.FromResource("Grouping_maps.Icons.two.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "18.346705", Longitude = "73.608398", ImageName = ImageSource.FromResource("Grouping_maps.Icons.three.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "21.486297", Longitude = "84.418945", ImageName = ImageSource.FromResource("Grouping_maps.Icons.four.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "22.139076", Longitude = "72.905273", ImageName = ImageSource.FromResource("Grouping_maps.Icons.five.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "26.463197", Longitude = "81.166992", ImageName = ImageSource.FromResource("Grouping_maps.Icons.six.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "26.463197", Longitude = "74.487305", ImageName = ImageSource.FromResource("Grouping_maps.Icons.seven.png") });
                    imageryLayer.Markers.Add(new CustomMarker() { Latitude = "28.952879", Longitude = "77.915039", ImageName = ImageSource.FromResource("Grouping_maps.Icons.eight.png") });
                }

            }
        }
    }

    /// <summary>
    /// The custom marker
    /// </summary>
    public class CustomMarker : MapMarker
    {
        /// <summary>
        /// Gets or sets the image source
        /// </summary>
        public ImageSource ImageName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MapSample
{
    public partial class FrmMain : Form
    {
        private List<PointLatLng> _points;

        public FrmMain()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        void FrmMain_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.ShowCenter = false;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.SetPositionByKeywords("Bangkok,Thailand");
            map.MinZoom = 10;        //Min Zoom Level
            map.MaxZoom = 100;      //Max Zoom Level
            map.Zoom = 10;          //Current Zoom Level
        }

        GMapOverlay markers = new GMapOverlay("markers");

        private void btnLoadInfoMap_Click(object sender, EventArgs e)
        {
            map.MinZoom = 5;        //Min Zoom Level
            map.MaxZoom = 100;      //Max Zoom Level
            map.Zoom = 20;          //Current Zoom Level

            //Reverse Geocoding
            if (!(txtLat.Text.Trim().Equals("") && txtLong.Text.Trim().Equals("")))
            {
                var point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                LoadAndMark(point);
                GeoCoderStatusCode statusCode;
                var placeMark = GoogleMapProvider.Instance.GetPlacemark(point, out statusCode);
                if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    txtAddress.Text = placeMark?.Address;
                }
                else
                {
                    txtAddress.Text = "Something Went Wrong. Returned Status Code: " + statusCode;
                }

            }

            //Geocoding
            else
            {
                if (!(txtAddress.Text.Trim().Equals("")))
                {
                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(txtAddress.Text.Trim(), out statusCode);
                    if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS)
                    {
                        var pt = pointLatLng ?? default(PointLatLng);
                        txtLat.Text = pointLatLng?.Lat.ToString();
                        txtLong.Text = pointLatLng?.Lng.ToString();
                        LoadAndMark(pt);
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Returned Status Code: " + statusCode);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Data to Load");
                }
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
            map.Refresh();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            _points.Clear();
            txtAddress.Clear();
            txtLat.Clear();
            txtLong.Clear();
            lblDistance.Text = "Distance in KM";
        }

        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            lblDistance.Text = route.Distance + " KM";
            map.MinZoom = 10;
            map.MaxZoom = 100;
            map.Zoom--;
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_points, "My Area")
            {
                Stroke = new Pen(Color.DarkGreen, 4),
                //Fill = new SolidBrush(Color.BurlyWood)
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMouseClick.Checked == true && e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat + "";
                txtLong.Text = lng + "";

                LoadMap(point);
                AddMarker(point);

                var addresses = GetAddress(point);

                if (addresses != null)
                    txtAddress.Text = "Address: \n------------------\n" + addresses[0];
                else
                    txtAddress.Text = "Unable to Load Address!";
            }
            else
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat + "";
                txtLong.Text = lng + "";

                LoadMap(point);

                var addresses = GetAddress(point);

                if (addresses != null)
                    txtAddress.Text = "Address: \n------------------\n" + addresses[0];
                else
                    txtAddress.Text = "Unable to Load Address!";
                //txtAddress.Clear();
                //txtLat.Clear();
                //txtLong.Clear();
            }
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS && placemarks != null)
            {
                List<String> addresses = new List<string>();
                foreach (var placemark in placemarks)
                    addresses.Add(placemark.Address);

                return addresses;
            }
            return null;
        }

        private List<Placemark> temp()
        {
            List<Placemark> placemarks = new List<Placemark>();
            return placemarks;
        }

        private void LoadAndMark(PointLatLng point)
        {
            LoadMap(point);
            AddMarker(point);
        }
    }
}

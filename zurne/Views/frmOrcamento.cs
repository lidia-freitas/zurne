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
using GoogleDirections;

namespace Views
{
    public partial class frmOrcamento : Form
    {
        Geocoder geocoder = new Geocoder("AIzaSyALjpTJ4uk2k4_ebxFfMjTNnlfWPefH8v8");
        
        GMapOverlay markerOverlay;

        PointLatLng inicio;
        PointLatLng final;

        double LatInicial = -25.428954;
        double LngInicial = -49.267137;


        public frmOrcamento()
        {
            InitializeComponent();
        }
          

        private void frmOrcamento_Load(object sender, EventArgs e)
        {
            gMapControl.ShowCenter = false;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.CanDragMap = true;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 9;
            gMapControl.AutoScroll = true;
        }

        private void btCalcularOrcamento_Click(object sender, EventArgs e)
        {
            markerOverlay = new GMapOverlay("Marcador");


            var origem = geocoder.Geocode(txtOrigem.Text).First();
            inicio = new PointLatLng(origem.LatLng.Latitude, origem.LatLng.Longitude);

            var destino = geocoder.Geocode(txtDestino.Text).First();
            final = new PointLatLng(destino.LatLng.Latitude, destino.LatLng.Longitude);


            GMarkerGoogle markerOrigem = new GMarkerGoogle(inicio, GMarkerGoogleType.green);
            markerOrigem.Position = inicio;
            markerOrigem.ToolTipMode = MarkerTooltipMode.Always;
            markerOrigem.ToolTipText = string.Format("Localização: \n {0}", txtOrigem.Text);
            markerOverlay.Markers.Add(markerOrigem);


            GMarkerGoogle markerDestino = new GMarkerGoogle(final, GMarkerGoogleType.red);
            markerDestino.Position = final;
            markerDestino.ToolTipMode = MarkerTooltipMode.Always;
            markerDestino.ToolTipText = string.Format("Localização: \n {0}", txtOrigem.Text);
            markerOverlay.Markers.Add(markerDestino);

            GDirections direction;

            var RotasDirection = GMapProviders.GoogleMap.GetDirections(out direction, inicio, final, false, false, false, false, false);
            GMapRoute RotaObtida = new GMapRoute(direction.Route, "Rota Obtida");
            GMapOverlay CamadaRotas = new GMapOverlay("Camada da Rota");
            CamadaRotas.Routes.Add(RotaObtida);

            gMapControl.Overlays.Add(markerOverlay);
            gMapControl.Overlays.Add(CamadaRotas);

            gMapControl.Zoom = gMapControl.Zoom + 1;
            gMapControl.Zoom = gMapControl.Zoom - 1;

            lbDistancia.Text = Math.Round(RotaObtida.Distance, 2).ToString() + "KM";
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelevo_Click(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl.Zoom = trackZoom.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMapControl.Zoom);
        }
    }
}

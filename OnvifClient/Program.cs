using System;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Gtk;
using Onvif.Media;
using Onvif.PTZ;

namespace OnvifClient
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ServiceHost mediaHost = null, ptzHost = null;

			string uri = "http://localhost:8690/onvif/";
			var mediaTask = Task.Run(() =>
			{
				mediaHost = new ServiceHost(typeof(MediaService),
													new Uri(uri + "media_service"));
				mediaHost.Open();
			});

			var ptzTask = Task.Run(() =>
			{
				ptzHost = new ServiceHost(typeof(PTZService),
													new Uri(uri + "ptz_service"));
				ptzHost.Open();
			});

			Application.Init();
			MainWindow win = new MainWindow(uri);
			win.Show();
			Application.Run();
			Console.WriteLine("Hello World!");
			mediaHost.Close();
			ptzHost.Close();
		}
	}
}

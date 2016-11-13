using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Onvif.Media;
using Onvif.PTZ;

namespace OnvifService
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var mediaTask = Task.Run(() =>
			{
				ServiceHost mediaHost = new ServiceHost(typeof(MediaService),
													new Uri("http://localhost:8690/onvif/media_service"));
				mediaHost.Open();
			});

			var ptzTask = Task.Run(() =>
			{
				ServiceHost mediaHost = new ServiceHost(typeof(PTZService),
													new Uri("http://localhost:8690/onvif/ptz_service"));
				mediaHost.Open();
			});

			Task.WaitAll(mediaTask, ptzTask);
		}
	}
}

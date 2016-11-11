using System;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Onvif.Media;
using Onvif.PTZ;

namespace OnvifTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			EndpointAddress serviceAddress = new EndpointAddress("http://62.238.246.143:9191/onvif/");
			HttpTransportBindingElement httpBinding = new HttpTransportBindingElement();
			httpBinding.AuthenticationScheme = AuthenticationSchemes.Digest;
			var messageElement = new TextMessageEncodingBindingElement();
			messageElement.MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None);
			CustomBinding bind = new CustomBinding(messageElement, httpBinding);

			MediaClient media = new MediaClient(bind, new EndpointAddress("http://62.238.246.143:9191/onvif/media_service"));
			media.ClientCredentials.UserName.UserName = @"admin";
			media.ClientCredentials.UserName.Password = @"admin";

			PTZClient ptz = new PTZClient(bind, new EndpointAddress("http://62.238.246.143:9191/onvif/ptz_service"));
			ptz.ClientCredentials.UserName.UserName = @"admin";
			ptz.ClientCredentials.UserName.Password = @"admin";

			foreach (var v in media.GetVideoSources())
			{
				Console.WriteLine(v.Resolution.Width + "x" + v.Resolution.Height);
				Console.WriteLine(v.token);
			}

			foreach (Profile profile in media.GetProfiles())
			{
				Console.WriteLine(profile.VideoSourceConfiguration.Name);
				Console.WriteLine(profile.VideoEncoderConfiguration.Resolution.Width + " " + profile.VideoEncoderConfiguration.Resolution.Height);


				Transport t = new Transport
				{
					Protocol = TransportProtocol.RTSP,
					Tunnel = null,
				};
				Console.WriteLine(media.GetStreamUri(
					new StreamSetup { Stream = StreamType.RTPUnicast, Transport = t },
					profile.token).Uri);

				var ptzOptions = ptz.GetConfigurationOptions(profile.PTZConfiguration.token);
				float xmax = ptzOptions.Spaces.ContinuousPanTiltVelocitySpace[0].XRange.Max;
				float xmin = ptzOptions.Spaces.ContinuousPanTiltVelocitySpace[0].XRange.Min;
				float ymax = ptzOptions.Spaces.ContinuousPanTiltVelocitySpace[0].YRange.Max;
				float ymin = ptzOptions.Spaces.ContinuousPanTiltVelocitySpace[0].YRange.Min;
				float zmax = ptzOptions.Spaces.ContinuousZoomVelocitySpace[0].XRange.Max;
				float zmin = ptzOptions.Spaces.ContinuousZoomVelocitySpace[0].XRange.Min;
				string tmax = ptzOptions.PTZTimeout.Max;

				ptz.ContinuousMove(profile.token,
								   new Onvif.PTZ.PTZSpeed
								   {
									   PanTilt = new Onvif.PTZ.Vector2D { x = xmax, y = 0 },
									   Zoom = new Onvif.PTZ.Vector1D { x = 0 },
								   }, tmax);


				/*
				ptz.ContinuousMove(profile.token,
								   new Onvif.PTZ.PTZSpeed
								   {
									   PanTilt = new Onvif.PTZ.Vector2D { x = 0, y = 0 },
									   Zoom = new Onvif.PTZ.Vector1D { x = zmax }
								   }, tmax);
								   */
			}
		}
	}

}

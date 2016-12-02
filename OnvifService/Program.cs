using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Onvif.Media;
using Onvif.PTZ;

using System.ServiceModel.Discovery;
using System.ServiceModel.Channels;
using System.Net;

namespace OnvifService
{
	class MainClass
	{
		/*
		public static void Main (string [] args)
		{
			var mediaTask = Task.Run (() => {
				ServiceHost mediaHost = new ServiceHost (typeof (MediaService),
													new Uri ("http://localhost:8690/onvif/media_service"));
				mediaHost.Open ();
			});

			var ptzTask = Task.Run (() => {
				try {
					ServiceHost mediaHost = new ServiceHost (typeof (PTZService),
														new Uri ("http://localhost:8690/onvif/ptz_service"));
					mediaHost.Open ();
				} catch (Exception ex) {
				}
			});

			Task.WaitAll (mediaTask, ptzTask);
		}
		*/

		/*
		static void Main (string [] args)
		{
			try {
				var endPoint = new UdpDiscoveryEndpoint (DiscoveryVersion.WSDiscoveryApril2005);

				var discoveryClient = new DiscoveryClient (endPoint);

				discoveryClient.FindProgressChanged += discoveryClient_FindProgressChanged;
				discoveryClient.FindCompleted += (sender, e) => {
					Console.WriteLine ("Discovery finished");
				};
				FindCriteria findCriteria = new FindCriteria ();
				findCriteria.Duration = TimeSpan.MaxValue;
				findCriteria.MaxResults = int.MaxValue;
				discoveryClient.FindAsync (findCriteria);



				Console.ReadKey ();
			} catch (Exception ex) {
			}
		}
		*/

		/*
		static void discoveryClient_FindProgressChanged (object sender, FindProgressChangedEventArgs e)
		{
			//Check endpoint metadata here for required types.
			var a = e.EndpointDiscoveryMetadata.Address;
		}


		static void Main (string [] args)
		{
			try {
				int port = 8554;
				Uri multicastUri = new Uri (string.Format ("soap.udp://239.255.255.250:{0}/", port));
				UdpDiscoveryEndpoint ude = new UdpDiscoveryEndpoint (DiscoveryVersion.WSDiscovery11, multicastUri);
				//UdpDiscoveryEndpoint ude = new UdpDiscoveryEndpoint (DiscoveryVersion.WSDiscoveryApril2005);
				DiscoveryClient discoveryClient = new DiscoveryClient (ude);
				FindCriteria findCriteria = new FindCriteria ();
				findCriteria.MaxResults = int.MaxValue;
				findCriteria.Duration = TimeSpan.FromSeconds (5);
				discoveryClient.FindProgressChanged += discoveryClient_FindProgressChanged;
				var a = discoveryClient.Find (findCriteria);

				Console.ReadKey ();
			} catch (Exception ex) {
				Console.WriteLine (ex.Message + Environment.NewLine + ex.StackTrace);
			}
		}
		*/


		const string DiscoveryTypeName = "NetworkVideoTransmitter";
		const string DiscoveryNamespace = "http://www.onvif.org/ver10/network/wsdl";

		static void Main (string [] args)
		{
			try {
				/* Discovery doesn't work in Mono
				var endPoint = new UdpDiscoveryEndpoint (DiscoveryVersion.WSDiscoveryApril2005);

				var discoveryClient = new DiscoveryClient (endPoint);

				discoveryClient.FindProgressChanged += discoveryClient_FindProgressChanged;
				discoveryClient.FindCompleted += (sender, e) => {
					Console.WriteLine ("Discovery finished");
				};
				FindCriteria findCriteria = new FindCriteria ();
				//findCriteria.Duration = TimeSpan.MaxValue;
				findCriteria.Duration = TimeSpan.FromSeconds (10);
				findCriteria.MaxResults = int.MaxValue;
				discoveryClient.FindAsync (findCriteria);

				//Console.ReadKey ();
				*/

				HttpTransportBindingElement httpBinding = new HttpTransportBindingElement ();
				httpBinding.AuthenticationScheme = AuthenticationSchemes.Digest;
				var messageElement = new TextMessageEncodingBindingElement ();
				// FIXME: Probe for Soap12 if Soap11 fails
				messageElement.MessageVersion = MessageVersion.CreateVersion (EnvelopeVersion.Soap12, AddressingVersion.None);
				CustomBinding binding = new CustomBinding (messageElement, httpBinding);
				EndpointAddress address = new EndpointAddress (@"http://192.168.1.130:8080/onvif/device_service");

				OnvifServices.OnvifDeviceService.DeviceClient device = new OnvifServices.OnvifDeviceService.DeviceClient (binding, address);
				device.ClientCredentials.UserName.UserName = @"admin";
				device.ClientCredentials.UserName.Password = @"admin";

				var dateTime = device.GetSystemDateAndTime ();
				var services = device.GetServices (true);
				foreach (var service in services) {
					if (service.Namespace == "http://www.onvif.org/ver10/media/wsdl") {
						OnvifServices.OnvifMediaService.MediaClient client = new OnvifServices.OnvifMediaService.MediaClient (binding, address);
						client.ClientCredentials.UserName.UserName = @"admin";
						client.ClientCredentials.UserName.Password = @"admin";
						var profiles = client.GetProfiles ();

						// use the first profile (the device has at least one media profile). 
						var targetProfileToken = profiles [0].token;
						// set the GetStreamUriRequest paramater 
						var streamSetup = new OnvifServices.OnvifMediaService.StreamSetup ();
						streamSetup.Stream = OnvifServices.OnvifMediaService.StreamType.RTPUnicast;
						streamSetup.Transport = new OnvifServices.OnvifMediaService.Transport ();
						streamSetup.Transport.Protocol = OnvifServices.OnvifMediaService.TransportProtocol.RTSP;
						streamSetup.Transport.Tunnel = null;
						var mediaUri = client.GetStreamUri (streamSetup, targetProfileToken);
					}
				}
			} catch (Exception ex) {
				Console.Out.WriteLine ($"Error: {ex.Message} \r\n{ex.StackTrace}");
			}
		}

		static void discoveryClient_FindProgressChanged (object sender, FindProgressChangedEventArgs e)
		{

			foreach (var ctn in e.EndpointDiscoveryMetadata.ContractTypeNames) {
				if (ctn.Namespace == DiscoveryNamespace && ctn.Name == DiscoveryTypeName) {
					Console.Out.WriteLine (e.EndpointDiscoveryMetadata.ListenUris [0].Host);
					//AddEndPoint (e.EndpointDiscoveryMetadata);
				}
			}
		}

		static void AddEndPoint (EndpointDiscoveryMetadata endpoint)
		{
			if (endpoint.ListenUris != null && endpoint.ListenUris.Count > 0) {
				foreach (var uri in endpoint.ListenUris) {
					string uriString = uri.AbsoluteUri;


					HttpTransportBindingElement httpBinding = new HttpTransportBindingElement ();
					httpBinding.AuthenticationScheme = AuthenticationSchemes.Digest;
					var messageElement = new TextMessageEncodingBindingElement ();
					// FIXME: Probe for Soap12 if Soap11 fails
					messageElement.MessageVersion = MessageVersion.CreateVersion (EnvelopeVersion.Soap12, AddressingVersion.None);
					CustomBinding binding = new CustomBinding (messageElement, httpBinding);
					EndpointAddress address = new EndpointAddress (uriString);

					OnvifServices.OnvifDeviceService.DeviceClient device = new OnvifServices.OnvifDeviceService.DeviceClient (binding, address);
					//device.ClientCredentials.HttpDigest.ClientCredential = new NetworkCredential("admin", "admin");
					//device.ClientCredentials.UserName.UserName = @"admin";
					//device.ClientCredentials.UserName.Password = @"admin";
					try {
						//device.Open();

						var dateTime = device.GetSystemDateAndTime ();
						//var hostName = device.GetHostname();
						/*
						var caps = device.GetCapabilities(new OnvifServices.OnvifDeviceService.CapabilityCategory[] {
							 OnvifServices.OnvifDeviceService.CapabilityCategory.All
						});
						*/
						//string model, firmware, serialNumber, hardwareId;
						//string deviceName = device.GetDeviceInformation(out model, out firmware, out serialNumber, out hardwareId);

						var services = device.GetServices (true);
						foreach (var service in services) {
							if (service.Namespace == "http://www.onvif.org/ver10/media/wsdl") {

								OnvifServices.OnvifMediaService.MediaClient client = new OnvifServices.OnvifMediaService.MediaClient (binding, address);
								var profiles = client.GetProfiles ();
							}
						}


						Console.WriteLine ($"{uriString} --> OK");
						device.Close ();
					} catch (Exception ex) {
						Console.WriteLine ($"{uriString} --> KO");
					}
				}

			}
		}
	}
}

using System;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Gtk;
using Onvif.Media;
using Onvif.PTZ;

public partial class MainWindow : Gtk.Window
{
	MediaClient media;
	PTZClient ptz;
	Profile profile;
	float xmax, xmin, ymax, ymin, zmax, zmin;
	string tmax;

	public MainWindow(string uri) : base(Gtk.WindowType.Toplevel)
	{
		Build();
		uriEntry.Text = uri;
		connectButton.Clicked += (sender, e) =>
		{
			Connect();
		};
		upButton.Clicked += (sender, e) =>
		{
			MoveUp();
		};
		downButton.Clicked += (sender, e) =>
		{
			MoveDown();
		};
		leftButton.Clicked += (sender, e) =>
		{
			MoveLeft();
		};
		rightButton.Clicked += (sender, e) =>
		{
			MoveRight();
		};
		zoominButton.Clicked += (sender, e) =>
		{
			ZoomIn();
		};
		zoomoutButton.Clicked += (sender, e) =>
		{
			ZoomOut();
		};
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	void Connect()
	{
		HttpTransportBindingElement httpBinding = new HttpTransportBindingElement();
		httpBinding.AuthenticationScheme = AuthenticationSchemes.Digest;
		var messageElement = new TextMessageEncodingBindingElement();

		// FIXME: Probe for Soap12 if Soap11 fails
		messageElement.MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap11, AddressingVersion.None);
		CustomBinding bind = new CustomBinding(messageElement, httpBinding);

		media = new MediaClient(bind, new EndpointAddress(uriEntry.Text + "media_service"));
		media.ClientCredentials.UserName.UserName = @"admin";
		media.ClientCredentials.UserName.Password = @"admin";

		ptz = new PTZClient(bind, new EndpointAddress(uriEntry.Text + "ptz_service"));
		ptz.ClientCredentials.UserName.UserName = @"admin";
		ptz.ClientCredentials.UserName.Password = @"admin";

		foreach (var v in media.GetVideoSources())
		{
			Console.WriteLine(v.Resolution.Width + "x" + v.Resolution.Height);
			Console.WriteLine(v.token);
		}

		profile = media.GetProfiles().First();
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

		xmax = profile.PTZConfiguration.PanTiltLimits.Range.XRange.Max;
		xmin = profile.PTZConfiguration.PanTiltLimits.Range.XRange.Min;
		ymax = profile.PTZConfiguration.PanTiltLimits.Range.YRange.Max;
		ymin = profile.PTZConfiguration.PanTiltLimits.Range.YRange.Min;
		zmax = profile.PTZConfiguration.ZoomLimits.Range.XRange.Max;
		zmin = profile.PTZConfiguration.ZoomLimits.Range.XRange.Min;
		tmax = "1";
		hbox1.Visible = true;
	}

	void MoveLeft()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = xmin, y = 0 },
					   Zoom = new Onvif.PTZ.Vector1D { x = 0 },
				   }, tmax);

	}

	void MoveRight()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = xmax, y = 0 },
					   Zoom = new Onvif.PTZ.Vector1D { x = 0 },
				   }, tmax);

	}

	void MoveUp()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = 0, y = ymin },
					   Zoom = new Onvif.PTZ.Vector1D { x = 0 },
				   }, tmax);

	}

	void MoveDown()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = 0, y = ymax },
					   Zoom = new Onvif.PTZ.Vector1D { x = 0 },
				   }, tmax);

	}

	void ZoomIn()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = 0, y = 0 },
					   Zoom = new Onvif.PTZ.Vector1D { x = zmin },
				   }, tmax);

	}

	void ZoomOut()
	{
		ptz.ContinuousMove(profile.token,
				   new Onvif.PTZ.PTZSpeed
				   {
					   PanTilt = new Onvif.PTZ.Vector2D { x = 0, y = 0 },
					   Zoom = new Onvif.PTZ.Vector1D { x = zmax },
				   }, tmax);

	}
}

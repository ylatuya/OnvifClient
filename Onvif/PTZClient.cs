using System;
namespace Onvif.PTZ
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface PTZChannel : Onvif.PTZ.PTZ, System.ServiceModel.IClientChannel
	{
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public partial class PTZClient : System.ServiceModel.ClientBase<Onvif.PTZ.PTZ>, Onvif.PTZ.PTZ
	{

		public PTZClient()
		{
		}

		public PTZClient(string endpointConfigurationName) :
				base(endpointConfigurationName)
		{
		}

		public PTZClient(string endpointConfigurationName, string remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public PTZClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public PTZClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
				base(binding, remoteAddress)
		{
		}

		public Onvif.PTZ.Capabilities GetServiceCapabilities()
		{
			return base.Channel.GetServiceCapabilities();
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.Capabilities> GetServiceCapabilitiesAsync()
		{
			return base.Channel.GetServiceCapabilitiesAsync();
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.GetNodesResponse Onvif.PTZ.PTZ.GetNodes(Onvif.PTZ.GetNodesRequest request)
		{
			return base.Channel.GetNodes(request);
		}

		public Onvif.PTZ.PTZNode[] GetNodes()
		{
			Onvif.PTZ.GetNodesRequest inValue = new Onvif.PTZ.GetNodesRequest();
			Onvif.PTZ.GetNodesResponse retVal = ((Onvif.PTZ.PTZ)(this)).GetNodes(inValue);
			return retVal.PTZNode;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.GetNodesResponse> Onvif.PTZ.PTZ.GetNodesAsync(Onvif.PTZ.GetNodesRequest request)
		{
			return base.Channel.GetNodesAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.GetNodesResponse> GetNodesAsync()
		{
			Onvif.PTZ.GetNodesRequest inValue = new Onvif.PTZ.GetNodesRequest();
			return ((Onvif.PTZ.PTZ)(this)).GetNodesAsync(inValue);
		}

		public Onvif.PTZ.PTZNode GetNode(string NodeToken)
		{
			return base.Channel.GetNode(NodeToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PTZNode> GetNodeAsync(string NodeToken)
		{
			return base.Channel.GetNodeAsync(NodeToken);
		}

		public Onvif.PTZ.PTZConfiguration GetConfiguration(string PTZConfigurationToken)
		{
			return base.Channel.GetConfiguration(PTZConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken)
		{
			return base.Channel.GetConfigurationAsync(PTZConfigurationToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.GetConfigurationsResponse Onvif.PTZ.PTZ.GetConfigurations(Onvif.PTZ.GetConfigurationsRequest request)
		{
			return base.Channel.GetConfigurations(request);
		}

		public Onvif.PTZ.PTZConfiguration[] GetConfigurations()
		{
			Onvif.PTZ.GetConfigurationsRequest inValue = new Onvif.PTZ.GetConfigurationsRequest();
			Onvif.PTZ.GetConfigurationsResponse retVal = ((Onvif.PTZ.PTZ)(this)).GetConfigurations(inValue);
			return retVal.PTZConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.GetConfigurationsResponse> Onvif.PTZ.PTZ.GetConfigurationsAsync(Onvif.PTZ.GetConfigurationsRequest request)
		{
			return base.Channel.GetConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.GetConfigurationsResponse> GetConfigurationsAsync()
		{
			Onvif.PTZ.GetConfigurationsRequest inValue = new Onvif.PTZ.GetConfigurationsRequest();
			return ((Onvif.PTZ.PTZ)(this)).GetConfigurationsAsync(inValue);
		}

		public void SetConfiguration(Onvif.PTZ.PTZConfiguration PTZConfiguration, bool ForcePersistence)
		{
			base.Channel.SetConfiguration(PTZConfiguration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetConfigurationAsync(Onvif.PTZ.PTZConfiguration PTZConfiguration, bool ForcePersistence)
		{
			return base.Channel.SetConfigurationAsync(PTZConfiguration, ForcePersistence);
		}

		public Onvif.PTZ.PTZConfigurationOptions GetConfigurationOptions(string ConfigurationToken)
		{
			return base.Channel.GetConfigurationOptions(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken)
		{
			return base.Channel.GetConfigurationOptionsAsync(ConfigurationToken);
		}

		public string SendAuxiliaryCommand(string ProfileToken, string AuxiliaryData)
		{
			return base.Channel.SendAuxiliaryCommand(ProfileToken, AuxiliaryData);
		}

		public System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData)
		{
			return base.Channel.SendAuxiliaryCommandAsync(ProfileToken, AuxiliaryData);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.GetPresetsResponse Onvif.PTZ.PTZ.GetPresets(Onvif.PTZ.GetPresetsRequest request)
		{
			return base.Channel.GetPresets(request);
		}

		public Onvif.PTZ.PTZPreset[] GetPresets(string ProfileToken)
		{
			Onvif.PTZ.GetPresetsRequest inValue = new Onvif.PTZ.GetPresetsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.PTZ.GetPresetsResponse retVal = ((Onvif.PTZ.PTZ)(this)).GetPresets(inValue);
			return retVal.Preset;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.GetPresetsResponse> Onvif.PTZ.PTZ.GetPresetsAsync(Onvif.PTZ.GetPresetsRequest request)
		{
			return base.Channel.GetPresetsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.GetPresetsResponse> GetPresetsAsync(string ProfileToken)
		{
			Onvif.PTZ.GetPresetsRequest inValue = new Onvif.PTZ.GetPresetsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.PTZ.PTZ)(this)).GetPresetsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.SetPresetResponse Onvif.PTZ.PTZ.SetPreset(Onvif.PTZ.SetPresetRequest request)
		{
			return base.Channel.SetPreset(request);
		}

		public void SetPreset(string ProfileToken, string PresetName, ref string PresetToken)
		{
			Onvif.PTZ.SetPresetRequest inValue = new Onvif.PTZ.SetPresetRequest();
			inValue.ProfileToken = ProfileToken;
			inValue.PresetName = PresetName;
			inValue.PresetToken = PresetToken;
			Onvif.PTZ.SetPresetResponse retVal = ((Onvif.PTZ.PTZ)(this)).SetPreset(inValue);
			PresetToken = retVal.PresetToken;
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.SetPresetResponse> SetPresetAsync(Onvif.PTZ.SetPresetRequest request)
		{
			return base.Channel.SetPresetAsync(request);
		}

		public void RemovePreset(string ProfileToken, string PresetToken)
		{
			base.Channel.RemovePreset(ProfileToken, PresetToken);
		}

		public System.Threading.Tasks.Task RemovePresetAsync(string ProfileToken, string PresetToken)
		{
			return base.Channel.RemovePresetAsync(ProfileToken, PresetToken);
		}

		public void GotoPreset(string ProfileToken, string PresetToken, Onvif.PTZ.PTZSpeed Speed)
		{
			base.Channel.GotoPreset(ProfileToken, PresetToken, Speed);
		}

		public System.Threading.Tasks.Task GotoPresetAsync(string ProfileToken, string PresetToken, Onvif.PTZ.PTZSpeed Speed)
		{
			return base.Channel.GotoPresetAsync(ProfileToken, PresetToken, Speed);
		}

		public void GotoHomePosition(string ProfileToken, Onvif.PTZ.PTZSpeed Speed)
		{
			base.Channel.GotoHomePosition(ProfileToken, Speed);
		}

		public System.Threading.Tasks.Task GotoHomePositionAsync(string ProfileToken, Onvif.PTZ.PTZSpeed Speed)
		{
			return base.Channel.GotoHomePositionAsync(ProfileToken, Speed);
		}

		public void SetHomePosition(string ProfileToken)
		{
			base.Channel.SetHomePosition(ProfileToken);
		}

		public System.Threading.Tasks.Task SetHomePositionAsync(string ProfileToken)
		{
			return base.Channel.SetHomePositionAsync(ProfileToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.ContinuousMoveResponse Onvif.PTZ.PTZ.ContinuousMove(Onvif.PTZ.ContinuousMoveRequest request)
		{
			return base.Channel.ContinuousMove(request);
		}

		public void ContinuousMove(string ProfileToken, Onvif.PTZ.PTZSpeed Velocity, string Timeout)
		{
			Onvif.PTZ.ContinuousMoveRequest inValue = new Onvif.PTZ.ContinuousMoveRequest();
			inValue.ProfileToken = ProfileToken;
			inValue.Velocity = Velocity;
			inValue.Timeout = Timeout;
			Onvif.PTZ.ContinuousMoveResponse retVal = ((Onvif.PTZ.PTZ)(this)).ContinuousMove(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.ContinuousMoveResponse> Onvif.PTZ.PTZ.ContinuousMoveAsync(Onvif.PTZ.ContinuousMoveRequest request)
		{
			return base.Channel.ContinuousMoveAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.ContinuousMoveResponse> ContinuousMoveAsync(string ProfileToken, Onvif.PTZ.PTZSpeed Velocity, string Timeout)
		{
			Onvif.PTZ.ContinuousMoveRequest inValue = new Onvif.PTZ.ContinuousMoveRequest();
			inValue.ProfileToken = ProfileToken;
			inValue.Velocity = Velocity;
			inValue.Timeout = Timeout;
			return ((Onvif.PTZ.PTZ)(this)).ContinuousMoveAsync(inValue);
		}

		public void RelativeMove(string ProfileToken, Onvif.PTZ.PTZVector Translation, Onvif.PTZ.PTZSpeed Speed)
		{
			base.Channel.RelativeMove(ProfileToken, Translation, Speed);
		}

		public System.Threading.Tasks.Task RelativeMoveAsync(string ProfileToken, Onvif.PTZ.PTZVector Translation, Onvif.PTZ.PTZSpeed Speed)
		{
			return base.Channel.RelativeMoveAsync(ProfileToken, Translation, Speed);
		}

		public Onvif.PTZ.PTZStatus GetStatus(string ProfileToken)
		{
			return base.Channel.GetStatus(ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PTZStatus> GetStatusAsync(string ProfileToken)
		{
			return base.Channel.GetStatusAsync(ProfileToken);
		}

		public void AbsoluteMove(string ProfileToken, Onvif.PTZ.PTZVector Position, Onvif.PTZ.PTZSpeed Speed)
		{
			base.Channel.AbsoluteMove(ProfileToken, Position, Speed);
		}

		public System.Threading.Tasks.Task AbsoluteMoveAsync(string ProfileToken, Onvif.PTZ.PTZVector Position, Onvif.PTZ.PTZSpeed Speed)
		{
			return base.Channel.AbsoluteMoveAsync(ProfileToken, Position, Speed);
		}

		public void Stop(string ProfileToken, bool PanTilt, bool Zoom)
		{
			base.Channel.Stop(ProfileToken, PanTilt, Zoom);
		}

		public System.Threading.Tasks.Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom)
		{
			return base.Channel.StopAsync(ProfileToken, PanTilt, Zoom);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.GetPresetToursResponse Onvif.PTZ.PTZ.GetPresetTours(Onvif.PTZ.GetPresetToursRequest request)
		{
			return base.Channel.GetPresetTours(request);
		}

		public Onvif.PTZ.PresetTour[] GetPresetTours(string ProfileToken)
		{
			Onvif.PTZ.GetPresetToursRequest inValue = new Onvif.PTZ.GetPresetToursRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.PTZ.GetPresetToursResponse retVal = ((Onvif.PTZ.PTZ)(this)).GetPresetTours(inValue);
			return retVal.PresetTour;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.GetPresetToursResponse> Onvif.PTZ.PTZ.GetPresetToursAsync(Onvif.PTZ.GetPresetToursRequest request)
		{
			return base.Channel.GetPresetToursAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.GetPresetToursResponse> GetPresetToursAsync(string ProfileToken)
		{
			Onvif.PTZ.GetPresetToursRequest inValue = new Onvif.PTZ.GetPresetToursRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.PTZ.PTZ)(this)).GetPresetToursAsync(inValue);
		}

		public Onvif.PTZ.PresetTour GetPresetTour(string ProfileToken, string PresetTourToken)
		{
			return base.Channel.GetPresetTour(ProfileToken, PresetTourToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken)
		{
			return base.Channel.GetPresetTourAsync(ProfileToken, PresetTourToken);
		}

		public Onvif.PTZ.PTZPresetTourOptions GetPresetTourOptions(string ProfileToken, string PresetTourToken)
		{
			return base.Channel.GetPresetTourOptions(ProfileToken, PresetTourToken);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken)
		{
			return base.Channel.GetPresetTourOptionsAsync(ProfileToken, PresetTourToken);
		}

		public string CreatePresetTour(string ProfileToken)
		{
			return base.Channel.CreatePresetTour(ProfileToken);
		}

		public System.Threading.Tasks.Task<string> CreatePresetTourAsync(string ProfileToken)
		{
			return base.Channel.CreatePresetTourAsync(ProfileToken);
		}

		public void ModifyPresetTour(string ProfileToken, Onvif.PTZ.PresetTour PresetTour)
		{
			base.Channel.ModifyPresetTour(ProfileToken, PresetTour);
		}

		public System.Threading.Tasks.Task ModifyPresetTourAsync(string ProfileToken, Onvif.PTZ.PresetTour PresetTour)
		{
			return base.Channel.ModifyPresetTourAsync(ProfileToken, PresetTour);
		}

		public void OperatePresetTour(string ProfileToken, string PresetTourToken, Onvif.PTZ.PTZPresetTourOperation Operation)
		{
			base.Channel.OperatePresetTour(ProfileToken, PresetTourToken, Operation);
		}

		public System.Threading.Tasks.Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, Onvif.PTZ.PTZPresetTourOperation Operation)
		{
			return base.Channel.OperatePresetTourAsync(ProfileToken, PresetTourToken, Operation);
		}

		public void RemovePresetTour(string ProfileToken, string PresetTourToken)
		{
			base.Channel.RemovePresetTour(ProfileToken, PresetTourToken);
		}

		public System.Threading.Tasks.Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken)
		{
			return base.Channel.RemovePresetTourAsync(ProfileToken, PresetTourToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.PTZ.GetCompatibleConfigurationsResponse Onvif.PTZ.PTZ.GetCompatibleConfigurations(Onvif.PTZ.GetCompatibleConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleConfigurations(request);
		}

		public Onvif.PTZ.PTZConfiguration[] GetCompatibleConfigurations(string ProfileToken)
		{
			Onvif.PTZ.GetCompatibleConfigurationsRequest inValue = new Onvif.PTZ.GetCompatibleConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.PTZ.GetCompatibleConfigurationsResponse retVal = ((Onvif.PTZ.PTZ)(this)).GetCompatibleConfigurations(inValue);
			return retVal.PTZConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.PTZ.GetCompatibleConfigurationsResponse> Onvif.PTZ.PTZ.GetCompatibleConfigurationsAsync(Onvif.PTZ.GetCompatibleConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.PTZ.GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(string ProfileToken)
		{
			Onvif.PTZ.GetCompatibleConfigurationsRequest inValue = new Onvif.PTZ.GetCompatibleConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.PTZ.PTZ)(this)).GetCompatibleConfigurationsAsync(inValue);
		}
	}
}

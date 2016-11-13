using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Onvif.PTZ
{
	public class PTZService : PTZ
	{
		public PTZService()
		{
		}

		public void AbsoluteMove(string ProfileToken, PTZVector Position, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public Task AbsoluteMoveAsync(string ProfileToken, PTZVector Position, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public ContinuousMoveResponse ContinuousMove(ContinuousMoveRequest request)
		{
			Console.WriteLine(string.Format("Moving X:{0} Y:{1} Z:{2}",
							  request.Velocity.PanTilt.x,
							  request.Velocity.PanTilt.y,
											request.Velocity.Zoom.x));
			return new ContinuousMoveResponse();
		}

		public Task<ContinuousMoveResponse> ContinuousMoveAsync(ContinuousMoveRequest request)
		{
			return Task.FromResult(ContinuousMove(request));
		}

		[return: MessageParameter(Name = "PresetTourToken")]
		public string CreatePresetTour(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PresetTourToken")]
		public Task<string> CreatePresetTourAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfiguration")]
		public GetCompatibleConfigurationsResponse GetCompatibleConfigurations(GetCompatibleConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(GetCompatibleConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfiguration")]
		public PTZConfiguration GetConfiguration(string PTZConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfiguration")]
		public Task<PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfigurationOptions")]
		public PTZConfigurationOptions GetConfigurationOptions(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfigurationOptions")]
		public Task<PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZConfiguration")]
		public GetConfigurationsResponse GetConfigurations(GetConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetConfigurationsResponse> GetConfigurationsAsync(GetConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZNode")]
		public PTZNode GetNode(string NodeToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZNode")]
		public Task<PTZNode> GetNodeAsync(string NodeToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZNode")]
		public GetNodesResponse GetNodes(GetNodesRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetNodesResponse> GetNodesAsync(GetNodesRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Preset")]
		public GetPresetsResponse GetPresets(GetPresetsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetPresetsResponse> GetPresetsAsync(GetPresetsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PresetTour")]
		public PresetTour GetPresetTour(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PresetTour")]
		public Task<PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public PTZPresetTourOptions GetPresetTourOptions(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PresetTour")]
		public GetPresetToursResponse GetPresetTours(GetPresetToursRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetPresetToursResponse> GetPresetToursAsync(GetPresetToursRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Capabilities")]
		public Capabilities GetServiceCapabilities()
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Capabilities")]
		public Task<Capabilities> GetServiceCapabilitiesAsync()
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZStatus")]
		public PTZStatus GetStatus(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "PTZStatus")]
		public Task<PTZStatus> GetStatusAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void GotoHomePosition(string ProfileToken, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public Task GotoHomePositionAsync(string ProfileToken, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public void GotoPreset(string ProfileToken, string PresetToken, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public Task GotoPresetAsync(string ProfileToken, string PresetToken, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public void ModifyPresetTour(string ProfileToken, PresetTour PresetTour)
		{
			throw new NotImplementedException();
		}

		public Task ModifyPresetTourAsync(string ProfileToken, PresetTour PresetTour)
		{
			throw new NotImplementedException();
		}

		public void OperatePresetTour(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation)
		{
			throw new NotImplementedException();
		}

		public Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation)
		{
			throw new NotImplementedException();
		}

		public void RelativeMove(string ProfileToken, PTZVector Translation, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public Task RelativeMoveAsync(string ProfileToken, PTZVector Translation, PTZSpeed Speed)
		{
			throw new NotImplementedException();
		}

		public void RemovePreset(string ProfileToken, string PresetToken)
		{
			throw new NotImplementedException();
		}

		public Task RemovePresetAsync(string ProfileToken, string PresetToken)
		{
			throw new NotImplementedException();
		}

		public void RemovePresetTour(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		public Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "AuxiliaryResponse")]
		public string SendAuxiliaryCommand(string ProfileToken, string AuxiliaryData)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "AuxiliaryResponse")]
		public Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData)
		{
			throw new NotImplementedException();
		}

		public void SetConfiguration(PTZConfiguration PTZConfiguration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetConfigurationAsync(PTZConfiguration PTZConfiguration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetHomePosition(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task SetHomePositionAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public SetPresetResponse SetPreset(SetPresetRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<SetPresetResponse> SetPresetAsync(SetPresetRequest request)
		{
			throw new NotImplementedException();
		}

		public void Stop(string ProfileToken, bool PanTilt, bool Zoom)
		{
			throw new NotImplementedException();
		}

		public Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom)
		{
			throw new NotImplementedException();
		}
	}
}

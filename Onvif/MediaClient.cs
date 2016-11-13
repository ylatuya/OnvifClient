using System;
namespace Onvif.Media
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface MediaChannel : Onvif.Media.Media, System.ServiceModel.IClientChannel
	{
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public partial class MediaClient : System.ServiceModel.ClientBase<Onvif.Media.Media>, Onvif.Media.Media
	{

		public MediaClient()
		{
		}

		public MediaClient(string endpointConfigurationName) :
				base(endpointConfigurationName)
		{
		}

		public MediaClient(string endpointConfigurationName, string remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public MediaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public MediaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
				base(binding, remoteAddress)
		{
		}

		public Onvif.Media.Capabilities GetServiceCapabilities()
		{
			return base.Channel.GetServiceCapabilities();
		}

		public System.Threading.Tasks.Task<Onvif.Media.Capabilities> GetServiceCapabilitiesAsync()
		{
			return base.Channel.GetServiceCapabilitiesAsync();
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetVideoSourcesResponse Onvif.Media.Media.GetVideoSources(Onvif.Media.GetVideoSourcesRequest request)
		{
			return base.Channel.GetVideoSources(request);
		}

		public Onvif.Media.VideoSource[] GetVideoSources()
		{
			Onvif.Media.GetVideoSourcesRequest inValue = new Onvif.Media.GetVideoSourcesRequest();
			Onvif.Media.GetVideoSourcesResponse retVal = ((Onvif.Media.Media)(this)).GetVideoSources(inValue);
			return retVal.VideoSources;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetVideoSourcesResponse> Onvif.Media.Media.GetVideoSourcesAsync(Onvif.Media.GetVideoSourcesRequest request)
		{
			return base.Channel.GetVideoSourcesAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetVideoSourcesResponse> GetVideoSourcesAsync()
		{
			Onvif.Media.GetVideoSourcesRequest inValue = new Onvif.Media.GetVideoSourcesRequest();
			return ((Onvif.Media.Media)(this)).GetVideoSourcesAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioSourcesResponse Onvif.Media.Media.GetAudioSources(Onvif.Media.GetAudioSourcesRequest request)
		{
			return base.Channel.GetAudioSources(request);
		}

		public Onvif.Media.AudioSource[] GetAudioSources()
		{
			Onvif.Media.GetAudioSourcesRequest inValue = new Onvif.Media.GetAudioSourcesRequest();
			Onvif.Media.GetAudioSourcesResponse retVal = ((Onvif.Media.Media)(this)).GetAudioSources(inValue);
			return retVal.AudioSources;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioSourcesResponse> Onvif.Media.Media.GetAudioSourcesAsync(Onvif.Media.GetAudioSourcesRequest request)
		{
			return base.Channel.GetAudioSourcesAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioSourcesResponse> GetAudioSourcesAsync()
		{
			Onvif.Media.GetAudioSourcesRequest inValue = new Onvif.Media.GetAudioSourcesRequest();
			return ((Onvif.Media.Media)(this)).GetAudioSourcesAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioOutputsResponse Onvif.Media.Media.GetAudioOutputs(Onvif.Media.GetAudioOutputsRequest request)
		{
			return base.Channel.GetAudioOutputs(request);
		}

		public Onvif.Media.AudioOutput[] GetAudioOutputs()
		{
			Onvif.Media.GetAudioOutputsRequest inValue = new Onvif.Media.GetAudioOutputsRequest();
			Onvif.Media.GetAudioOutputsResponse retVal = ((Onvif.Media.Media)(this)).GetAudioOutputs(inValue);
			return retVal.AudioOutputs;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioOutputsResponse> Onvif.Media.Media.GetAudioOutputsAsync(Onvif.Media.GetAudioOutputsRequest request)
		{
			return base.Channel.GetAudioOutputsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioOutputsResponse> GetAudioOutputsAsync()
		{
			Onvif.Media.GetAudioOutputsRequest inValue = new Onvif.Media.GetAudioOutputsRequest();
			return ((Onvif.Media.Media)(this)).GetAudioOutputsAsync(inValue);
		}

		public Onvif.Media.Profile CreateProfile(string Name, string Token)
		{
			return base.Channel.CreateProfile(Name, Token);
		}

		public System.Threading.Tasks.Task<Onvif.Media.Profile> CreateProfileAsync(string Name, string Token)
		{
			return base.Channel.CreateProfileAsync(Name, Token);
		}

		public Onvif.Media.Profile GetProfile(string ProfileToken)
		{
			return base.Channel.GetProfile(ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.Profile> GetProfileAsync(string ProfileToken)
		{
			return base.Channel.GetProfileAsync(ProfileToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetProfilesResponse Onvif.Media.Media.GetProfiles(Onvif.Media.GetProfilesRequest request)
		{
			return base.Channel.GetProfiles(request);
		}

		public Onvif.Media.Profile[] GetProfiles()
		{
			Onvif.Media.GetProfilesRequest inValue = new Onvif.Media.GetProfilesRequest();
			Onvif.Media.GetProfilesResponse retVal = ((Onvif.Media.Media)(this)).GetProfiles(inValue);
			return retVal.Profiles;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetProfilesResponse> Onvif.Media.Media.GetProfilesAsync(Onvif.Media.GetProfilesRequest request)
		{
			return base.Channel.GetProfilesAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetProfilesResponse> GetProfilesAsync()
		{
			Onvif.Media.GetProfilesRequest inValue = new Onvif.Media.GetProfilesRequest();
			return ((Onvif.Media.Media)(this)).GetProfilesAsync(inValue);
		}

		public void AddVideoEncoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddVideoEncoderConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddVideoEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveVideoEncoderConfiguration(string ProfileToken)
		{
			base.Channel.RemoveVideoEncoderConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveVideoEncoderConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveVideoEncoderConfigurationAsync(ProfileToken);
		}

		public void AddVideoSourceConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddVideoSourceConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddVideoSourceConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveVideoSourceConfiguration(string ProfileToken)
		{
			base.Channel.RemoveVideoSourceConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveVideoSourceConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveVideoSourceConfigurationAsync(ProfileToken);
		}

		public void AddAudioEncoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddAudioEncoderConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddAudioEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveAudioEncoderConfiguration(string ProfileToken)
		{
			base.Channel.RemoveAudioEncoderConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveAudioEncoderConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveAudioEncoderConfigurationAsync(ProfileToken);
		}

		public void AddAudioSourceConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddAudioSourceConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddAudioSourceConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveAudioSourceConfiguration(string ProfileToken)
		{
			base.Channel.RemoveAudioSourceConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveAudioSourceConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveAudioSourceConfigurationAsync(ProfileToken);
		}

		public void AddPTZConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddPTZConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddPTZConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemovePTZConfiguration(string ProfileToken)
		{
			base.Channel.RemovePTZConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemovePTZConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemovePTZConfigurationAsync(ProfileToken);
		}

		public void AddVideoAnalyticsConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddVideoAnalyticsConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddVideoAnalyticsConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveVideoAnalyticsConfiguration(string ProfileToken)
		{
			base.Channel.RemoveVideoAnalyticsConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveVideoAnalyticsConfigurationAsync(ProfileToken);
		}

		public void AddMetadataConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddMetadataConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddMetadataConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveMetadataConfiguration(string ProfileToken)
		{
			base.Channel.RemoveMetadataConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveMetadataConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveMetadataConfigurationAsync(ProfileToken);
		}

		public void AddAudioOutputConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddAudioOutputConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddAudioOutputConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveAudioOutputConfiguration(string ProfileToken)
		{
			base.Channel.RemoveAudioOutputConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveAudioOutputConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveAudioOutputConfigurationAsync(ProfileToken);
		}

		public void AddAudioDecoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			base.Channel.AddAudioDecoderConfiguration(ProfileToken, ConfigurationToken);
		}

		public System.Threading.Tasks.Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			return base.Channel.AddAudioDecoderConfigurationAsync(ProfileToken, ConfigurationToken);
		}

		public void RemoveAudioDecoderConfiguration(string ProfileToken)
		{
			base.Channel.RemoveAudioDecoderConfiguration(ProfileToken);
		}

		public System.Threading.Tasks.Task RemoveAudioDecoderConfigurationAsync(string ProfileToken)
		{
			return base.Channel.RemoveAudioDecoderConfigurationAsync(ProfileToken);
		}

		public void DeleteProfile(string ProfileToken)
		{
			base.Channel.DeleteProfile(ProfileToken);
		}

		public System.Threading.Tasks.Task DeleteProfileAsync(string ProfileToken)
		{
			return base.Channel.DeleteProfileAsync(ProfileToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetVideoSourceConfigurationsResponse Onvif.Media.Media.GetVideoSourceConfigurations(Onvif.Media.GetVideoSourceConfigurationsRequest request)
		{
			return base.Channel.GetVideoSourceConfigurations(request);
		}

		public Onvif.Media.VideoSourceConfiguration[] GetVideoSourceConfigurations()
		{
			Onvif.Media.GetVideoSourceConfigurationsRequest inValue = new Onvif.Media.GetVideoSourceConfigurationsRequest();
			Onvif.Media.GetVideoSourceConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetVideoSourceConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetVideoSourceConfigurationsResponse> Onvif.Media.Media.GetVideoSourceConfigurationsAsync(Onvif.Media.GetVideoSourceConfigurationsRequest request)
		{
			return base.Channel.GetVideoSourceConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync()
		{
			Onvif.Media.GetVideoSourceConfigurationsRequest inValue = new Onvif.Media.GetVideoSourceConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetVideoSourceConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetVideoEncoderConfigurationsResponse Onvif.Media.Media.GetVideoEncoderConfigurations(Onvif.Media.GetVideoEncoderConfigurationsRequest request)
		{
			return base.Channel.GetVideoEncoderConfigurations(request);
		}

		public Onvif.Media.VideoEncoderConfiguration[] GetVideoEncoderConfigurations()
		{
			Onvif.Media.GetVideoEncoderConfigurationsRequest inValue = new Onvif.Media.GetVideoEncoderConfigurationsRequest();
			Onvif.Media.GetVideoEncoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetVideoEncoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetVideoEncoderConfigurationsResponse> Onvif.Media.Media.GetVideoEncoderConfigurationsAsync(Onvif.Media.GetVideoEncoderConfigurationsRequest request)
		{
			return base.Channel.GetVideoEncoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync()
		{
			Onvif.Media.GetVideoEncoderConfigurationsRequest inValue = new Onvif.Media.GetVideoEncoderConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetVideoEncoderConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioSourceConfigurationsResponse Onvif.Media.Media.GetAudioSourceConfigurations(Onvif.Media.GetAudioSourceConfigurationsRequest request)
		{
			return base.Channel.GetAudioSourceConfigurations(request);
		}

		public Onvif.Media.AudioSourceConfiguration[] GetAudioSourceConfigurations()
		{
			Onvif.Media.GetAudioSourceConfigurationsRequest inValue = new Onvif.Media.GetAudioSourceConfigurationsRequest();
			Onvif.Media.GetAudioSourceConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetAudioSourceConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioSourceConfigurationsResponse> Onvif.Media.Media.GetAudioSourceConfigurationsAsync(Onvif.Media.GetAudioSourceConfigurationsRequest request)
		{
			return base.Channel.GetAudioSourceConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync()
		{
			Onvif.Media.GetAudioSourceConfigurationsRequest inValue = new Onvif.Media.GetAudioSourceConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetAudioSourceConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioEncoderConfigurationsResponse Onvif.Media.Media.GetAudioEncoderConfigurations(Onvif.Media.GetAudioEncoderConfigurationsRequest request)
		{
			return base.Channel.GetAudioEncoderConfigurations(request);
		}

		public Onvif.Media.AudioEncoderConfiguration[] GetAudioEncoderConfigurations()
		{
			Onvif.Media.GetAudioEncoderConfigurationsRequest inValue = new Onvif.Media.GetAudioEncoderConfigurationsRequest();
			Onvif.Media.GetAudioEncoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetAudioEncoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioEncoderConfigurationsResponse> Onvif.Media.Media.GetAudioEncoderConfigurationsAsync(Onvif.Media.GetAudioEncoderConfigurationsRequest request)
		{
			return base.Channel.GetAudioEncoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync()
		{
			Onvif.Media.GetAudioEncoderConfigurationsRequest inValue = new Onvif.Media.GetAudioEncoderConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetAudioEncoderConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetVideoAnalyticsConfigurationsResponse Onvif.Media.Media.GetVideoAnalyticsConfigurations(Onvif.Media.GetVideoAnalyticsConfigurationsRequest request)
		{
			return base.Channel.GetVideoAnalyticsConfigurations(request);
		}

		public Onvif.Media.VideoAnalyticsConfiguration[] GetVideoAnalyticsConfigurations()
		{
			Onvif.Media.GetVideoAnalyticsConfigurationsRequest inValue = new Onvif.Media.GetVideoAnalyticsConfigurationsRequest();
			Onvif.Media.GetVideoAnalyticsConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetVideoAnalyticsConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetVideoAnalyticsConfigurationsResponse> Onvif.Media.Media.GetVideoAnalyticsConfigurationsAsync(Onvif.Media.GetVideoAnalyticsConfigurationsRequest request)
		{
			return base.Channel.GetVideoAnalyticsConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync()
		{
			Onvif.Media.GetVideoAnalyticsConfigurationsRequest inValue = new Onvif.Media.GetVideoAnalyticsConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetVideoAnalyticsConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetMetadataConfigurationsResponse Onvif.Media.Media.GetMetadataConfigurations(Onvif.Media.GetMetadataConfigurationsRequest request)
		{
			return base.Channel.GetMetadataConfigurations(request);
		}

		public Onvif.Media.MetadataConfiguration[] GetMetadataConfigurations()
		{
			Onvif.Media.GetMetadataConfigurationsRequest inValue = new Onvif.Media.GetMetadataConfigurationsRequest();
			Onvif.Media.GetMetadataConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetMetadataConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetMetadataConfigurationsResponse> Onvif.Media.Media.GetMetadataConfigurationsAsync(Onvif.Media.GetMetadataConfigurationsRequest request)
		{
			return base.Channel.GetMetadataConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync()
		{
			Onvif.Media.GetMetadataConfigurationsRequest inValue = new Onvif.Media.GetMetadataConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetMetadataConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioOutputConfigurationsResponse Onvif.Media.Media.GetAudioOutputConfigurations(Onvif.Media.GetAudioOutputConfigurationsRequest request)
		{
			return base.Channel.GetAudioOutputConfigurations(request);
		}

		public Onvif.Media.AudioOutputConfiguration[] GetAudioOutputConfigurations()
		{
			Onvif.Media.GetAudioOutputConfigurationsRequest inValue = new Onvif.Media.GetAudioOutputConfigurationsRequest();
			Onvif.Media.GetAudioOutputConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetAudioOutputConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioOutputConfigurationsResponse> Onvif.Media.Media.GetAudioOutputConfigurationsAsync(Onvif.Media.GetAudioOutputConfigurationsRequest request)
		{
			return base.Channel.GetAudioOutputConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync()
		{
			Onvif.Media.GetAudioOutputConfigurationsRequest inValue = new Onvif.Media.GetAudioOutputConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetAudioOutputConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetAudioDecoderConfigurationsResponse Onvif.Media.Media.GetAudioDecoderConfigurations(Onvif.Media.GetAudioDecoderConfigurationsRequest request)
		{
			return base.Channel.GetAudioDecoderConfigurations(request);
		}

		public Onvif.Media.AudioDecoderConfiguration[] GetAudioDecoderConfigurations()
		{
			Onvif.Media.GetAudioDecoderConfigurationsRequest inValue = new Onvif.Media.GetAudioDecoderConfigurationsRequest();
			Onvif.Media.GetAudioDecoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetAudioDecoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetAudioDecoderConfigurationsResponse> Onvif.Media.Media.GetAudioDecoderConfigurationsAsync(Onvif.Media.GetAudioDecoderConfigurationsRequest request)
		{
			return base.Channel.GetAudioDecoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync()
		{
			Onvif.Media.GetAudioDecoderConfigurationsRequest inValue = new Onvif.Media.GetAudioDecoderConfigurationsRequest();
			return ((Onvif.Media.Media)(this)).GetAudioDecoderConfigurationsAsync(inValue);
		}

		public Onvif.Media.VideoSourceConfiguration GetVideoSourceConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetVideoSourceConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetVideoSourceConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.VideoEncoderConfiguration GetVideoEncoderConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetVideoEncoderConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetVideoEncoderConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.AudioSourceConfiguration GetAudioSourceConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetAudioSourceConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetAudioSourceConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.AudioEncoderConfiguration GetAudioEncoderConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetAudioEncoderConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetAudioEncoderConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.VideoAnalyticsConfiguration GetVideoAnalyticsConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetVideoAnalyticsConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetVideoAnalyticsConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.MetadataConfiguration GetMetadataConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetMetadataConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetMetadataConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.AudioOutputConfiguration GetAudioOutputConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetAudioOutputConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetAudioOutputConfigurationAsync(ConfigurationToken);
		}

		public Onvif.Media.AudioDecoderConfiguration GetAudioDecoderConfiguration(string ConfigurationToken)
		{
			return base.Channel.GetAudioDecoderConfiguration(ConfigurationToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken)
		{
			return base.Channel.GetAudioDecoderConfigurationAsync(ConfigurationToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleVideoEncoderConfigurationsResponse Onvif.Media.Media.GetCompatibleVideoEncoderConfigurations(Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoEncoderConfigurations(request);
		}

		public Onvif.Media.VideoEncoderConfiguration[] GetCompatibleVideoEncoderConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleVideoEncoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleVideoEncoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoEncoderConfigurationsResponse> Onvif.Media.Media.GetCompatibleVideoEncoderConfigurationsAsync(Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoEncoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoEncoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleVideoEncoderConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleVideoSourceConfigurationsResponse Onvif.Media.Media.GetCompatibleVideoSourceConfigurations(Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoSourceConfigurations(request);
		}

		public Onvif.Media.VideoSourceConfiguration[] GetCompatibleVideoSourceConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleVideoSourceConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleVideoSourceConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoSourceConfigurationsResponse> Onvif.Media.Media.GetCompatibleVideoSourceConfigurationsAsync(Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoSourceConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoSourceConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleVideoSourceConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleAudioEncoderConfigurationsResponse Onvif.Media.Media.GetCompatibleAudioEncoderConfigurations(Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioEncoderConfigurations(request);
		}

		public Onvif.Media.AudioEncoderConfiguration[] GetCompatibleAudioEncoderConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleAudioEncoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleAudioEncoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioEncoderConfigurationsResponse> Onvif.Media.Media.GetCompatibleAudioEncoderConfigurationsAsync(Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioEncoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioEncoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleAudioEncoderConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleAudioSourceConfigurationsResponse Onvif.Media.Media.GetCompatibleAudioSourceConfigurations(Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioSourceConfigurations(request);
		}

		public Onvif.Media.AudioSourceConfiguration[] GetCompatibleAudioSourceConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleAudioSourceConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleAudioSourceConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioSourceConfigurationsResponse> Onvif.Media.Media.GetCompatibleAudioSourceConfigurationsAsync(Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioSourceConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioSourceConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleAudioSourceConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsResponse Onvif.Media.Media.GetCompatibleVideoAnalyticsConfigurations(Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoAnalyticsConfigurations(request);
		}

		public Onvif.Media.VideoAnalyticsConfiguration[] GetCompatibleVideoAnalyticsConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleVideoAnalyticsConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsResponse> Onvif.Media.Media.GetCompatibleVideoAnalyticsConfigurationsAsync(Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleVideoAnalyticsConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest inValue = new Onvif.Media.GetCompatibleVideoAnalyticsConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleVideoAnalyticsConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleMetadataConfigurationsResponse Onvif.Media.Media.GetCompatibleMetadataConfigurations(Onvif.Media.GetCompatibleMetadataConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleMetadataConfigurations(request);
		}

		public Onvif.Media.MetadataConfiguration[] GetCompatibleMetadataConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleMetadataConfigurationsRequest inValue = new Onvif.Media.GetCompatibleMetadataConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleMetadataConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleMetadataConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleMetadataConfigurationsResponse> Onvif.Media.Media.GetCompatibleMetadataConfigurationsAsync(Onvif.Media.GetCompatibleMetadataConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleMetadataConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleMetadataConfigurationsRequest inValue = new Onvif.Media.GetCompatibleMetadataConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleMetadataConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleAudioOutputConfigurationsResponse Onvif.Media.Media.GetCompatibleAudioOutputConfigurations(Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioOutputConfigurations(request);
		}

		public Onvif.Media.AudioOutputConfiguration[] GetCompatibleAudioOutputConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleAudioOutputConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleAudioOutputConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioOutputConfigurationsResponse> Onvif.Media.Media.GetCompatibleAudioOutputConfigurationsAsync(Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioOutputConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioOutputConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleAudioOutputConfigurationsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetCompatibleAudioDecoderConfigurationsResponse Onvif.Media.Media.GetCompatibleAudioDecoderConfigurations(Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioDecoderConfigurations(request);
		}

		public Onvif.Media.AudioDecoderConfiguration[] GetCompatibleAudioDecoderConfigurations(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			Onvif.Media.GetCompatibleAudioDecoderConfigurationsResponse retVal = ((Onvif.Media.Media)(this)).GetCompatibleAudioDecoderConfigurations(inValue);
			return retVal.Configurations;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioDecoderConfigurationsResponse> Onvif.Media.Media.GetCompatibleAudioDecoderConfigurationsAsync(Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest request)
		{
			return base.Channel.GetCompatibleAudioDecoderConfigurationsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(string ProfileToken)
		{
			Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest inValue = new Onvif.Media.GetCompatibleAudioDecoderConfigurationsRequest();
			inValue.ProfileToken = ProfileToken;
			return ((Onvif.Media.Media)(this)).GetCompatibleAudioDecoderConfigurationsAsync(inValue);
		}

		public void SetVideoSourceConfiguration(Onvif.Media.VideoSourceConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetVideoSourceConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetVideoSourceConfigurationAsync(Onvif.Media.VideoSourceConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetVideoSourceConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetVideoEncoderConfiguration(Onvif.Media.VideoEncoderConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetVideoEncoderConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetVideoEncoderConfigurationAsync(Onvif.Media.VideoEncoderConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetVideoEncoderConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetAudioSourceConfiguration(Onvif.Media.AudioSourceConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetAudioSourceConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetAudioSourceConfigurationAsync(Onvif.Media.AudioSourceConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetAudioSourceConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetAudioEncoderConfiguration(Onvif.Media.AudioEncoderConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetAudioEncoderConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetAudioEncoderConfigurationAsync(Onvif.Media.AudioEncoderConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetAudioEncoderConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetVideoAnalyticsConfiguration(Onvif.Media.VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetVideoAnalyticsConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetVideoAnalyticsConfigurationAsync(Onvif.Media.VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetVideoAnalyticsConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetMetadataConfiguration(Onvif.Media.MetadataConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetMetadataConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetMetadataConfigurationAsync(Onvif.Media.MetadataConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetMetadataConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetAudioOutputConfiguration(Onvif.Media.AudioOutputConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetAudioOutputConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetAudioOutputConfigurationAsync(Onvif.Media.AudioOutputConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetAudioOutputConfigurationAsync(Configuration, ForcePersistence);
		}

		public void SetAudioDecoderConfiguration(Onvif.Media.AudioDecoderConfiguration Configuration, bool ForcePersistence)
		{
			base.Channel.SetAudioDecoderConfiguration(Configuration, ForcePersistence);
		}

		public System.Threading.Tasks.Task SetAudioDecoderConfigurationAsync(Onvif.Media.AudioDecoderConfiguration Configuration, bool ForcePersistence)
		{
			return base.Channel.SetAudioDecoderConfigurationAsync(Configuration, ForcePersistence);
		}

		public Onvif.Media.VideoSourceConfigurationOptions GetVideoSourceConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetVideoSourceConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetVideoSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.VideoEncoderConfigurationOptions GetVideoEncoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetVideoEncoderConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetVideoEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.AudioSourceConfigurationOptions GetAudioSourceConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioSourceConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.AudioEncoderConfigurationOptions GetAudioEncoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioEncoderConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.MetadataConfigurationOptions GetMetadataConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetMetadataConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetMetadataConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.AudioOutputConfigurationOptions GetAudioOutputConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioOutputConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioOutputConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		public Onvif.Media.AudioDecoderConfigurationOptions GetAudioDecoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioDecoderConfigurationOptions(ConfigurationToken, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			return base.Channel.GetAudioDecoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesResponse Onvif.Media.Media.GetGuaranteedNumberOfVideoEncoderInstances(Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
		{
			return base.Channel.GetGuaranteedNumberOfVideoEncoderInstances(request);
		}

		public int GetGuaranteedNumberOfVideoEncoderInstances(string ConfigurationToken, out int JPEG, out int H264, out int MPEG4)
		{
			Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest inValue = new Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest();
			inValue.ConfigurationToken = ConfigurationToken;
			Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesResponse retVal = ((Onvif.Media.Media)(this)).GetGuaranteedNumberOfVideoEncoderInstances(inValue);
			JPEG = retVal.JPEG;
			H264 = retVal.H264;
			MPEG4 = retVal.MPEG4;
			return retVal.TotalNumber;
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(Onvif.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
		{
			return base.Channel.GetGuaranteedNumberOfVideoEncoderInstancesAsync(request);
		}

		public Onvif.Media.MediaUri GetStreamUri(Onvif.Media.StreamSetup StreamSetup, string ProfileToken)
		{
			return base.Channel.GetStreamUri(StreamSetup, ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.MediaUri> GetStreamUriAsync(Onvif.Media.StreamSetup StreamSetup, string ProfileToken)
		{
			return base.Channel.GetStreamUriAsync(StreamSetup, ProfileToken);
		}

		public void StartMulticastStreaming(string ProfileToken)
		{
			base.Channel.StartMulticastStreaming(ProfileToken);
		}

		public System.Threading.Tasks.Task StartMulticastStreamingAsync(string ProfileToken)
		{
			return base.Channel.StartMulticastStreamingAsync(ProfileToken);
		}

		public void StopMulticastStreaming(string ProfileToken)
		{
			base.Channel.StopMulticastStreaming(ProfileToken);
		}

		public System.Threading.Tasks.Task StopMulticastStreamingAsync(string ProfileToken)
		{
			return base.Channel.StopMulticastStreamingAsync(ProfileToken);
		}

		public void SetSynchronizationPoint(string ProfileToken)
		{
			base.Channel.SetSynchronizationPoint(ProfileToken);
		}

		public System.Threading.Tasks.Task SetSynchronizationPointAsync(string ProfileToken)
		{
			return base.Channel.SetSynchronizationPointAsync(ProfileToken);
		}

		public Onvif.Media.MediaUri GetSnapshotUri(string ProfileToken)
		{
			return base.Channel.GetSnapshotUri(ProfileToken);
		}

		public System.Threading.Tasks.Task<Onvif.Media.MediaUri> GetSnapshotUriAsync(string ProfileToken)
		{
			return base.Channel.GetSnapshotUriAsync(ProfileToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetVideoSourceModesResponse Onvif.Media.Media.GetVideoSourceModes(Onvif.Media.GetVideoSourceModesRequest request)
		{
			return base.Channel.GetVideoSourceModes(request);
		}

		public Onvif.Media.VideoSourceMode[] GetVideoSourceModes(string VideoSourceToken)
		{
			Onvif.Media.GetVideoSourceModesRequest inValue = new Onvif.Media.GetVideoSourceModesRequest();
			inValue.VideoSourceToken = VideoSourceToken;
			Onvif.Media.GetVideoSourceModesResponse retVal = ((Onvif.Media.Media)(this)).GetVideoSourceModes(inValue);
			return retVal.VideoSourceModes;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetVideoSourceModesResponse> Onvif.Media.Media.GetVideoSourceModesAsync(Onvif.Media.GetVideoSourceModesRequest request)
		{
			return base.Channel.GetVideoSourceModesAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetVideoSourceModesResponse> GetVideoSourceModesAsync(string VideoSourceToken)
		{
			Onvif.Media.GetVideoSourceModesRequest inValue = new Onvif.Media.GetVideoSourceModesRequest();
			inValue.VideoSourceToken = VideoSourceToken;
			return ((Onvif.Media.Media)(this)).GetVideoSourceModesAsync(inValue);
		}

		public bool SetVideoSourceMode(string VideoSourceToken, string VideoSourceModeToken)
		{
			return base.Channel.SetVideoSourceMode(VideoSourceToken, VideoSourceModeToken);
		}

		public System.Threading.Tasks.Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken)
		{
			return base.Channel.SetVideoSourceModeAsync(VideoSourceToken, VideoSourceModeToken);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetOSDsResponse Onvif.Media.Media.GetOSDs(Onvif.Media.GetOSDsRequest request)
		{
			return base.Channel.GetOSDs(request);
		}

		public Onvif.Media.OSDConfiguration[] GetOSDs(string ConfigurationToken)
		{
			Onvif.Media.GetOSDsRequest inValue = new Onvif.Media.GetOSDsRequest();
			inValue.ConfigurationToken = ConfigurationToken;
			Onvif.Media.GetOSDsResponse retVal = ((Onvif.Media.Media)(this)).GetOSDs(inValue);
			return retVal.OSDs;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.Threading.Tasks.Task<Onvif.Media.GetOSDsResponse> Onvif.Media.Media.GetOSDsAsync(Onvif.Media.GetOSDsRequest request)
		{
			return base.Channel.GetOSDsAsync(request);
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetOSDsResponse> GetOSDsAsync(string ConfigurationToken)
		{
			Onvif.Media.GetOSDsRequest inValue = new Onvif.Media.GetOSDsRequest();
			inValue.ConfigurationToken = ConfigurationToken;
			return ((Onvif.Media.Media)(this)).GetOSDsAsync(inValue);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetOSDResponse Onvif.Media.Media.GetOSD(Onvif.Media.GetOSDRequest request)
		{
			return base.Channel.GetOSD(request);
		}

		public Onvif.Media.OSDConfiguration GetOSD(string OSDToken, ref System.Xml.XmlElement[] Any)
		{
			Onvif.Media.GetOSDRequest inValue = new Onvif.Media.GetOSDRequest();
			inValue.OSDToken = OSDToken;
			inValue.Any = Any;
			Onvif.Media.GetOSDResponse retVal = ((Onvif.Media.Media)(this)).GetOSD(inValue);
			Any = retVal.Any;
			return retVal.OSD;
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetOSDResponse> GetOSDAsync(Onvif.Media.GetOSDRequest request)
		{
			return base.Channel.GetOSDAsync(request);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.GetOSDOptionsResponse Onvif.Media.Media.GetOSDOptions(Onvif.Media.GetOSDOptionsRequest request)
		{
			return base.Channel.GetOSDOptions(request);
		}

		public Onvif.Media.OSDConfigurationOptions GetOSDOptions(string ConfigurationToken, ref System.Xml.XmlElement[] Any)
		{
			Onvif.Media.GetOSDOptionsRequest inValue = new Onvif.Media.GetOSDOptionsRequest();
			inValue.ConfigurationToken = ConfigurationToken;
			inValue.Any = Any;
			Onvif.Media.GetOSDOptionsResponse retVal = ((Onvif.Media.Media)(this)).GetOSDOptions(inValue);
			Any = retVal.Any;
			return retVal.OSDOptions;
		}

		public System.Threading.Tasks.Task<Onvif.Media.GetOSDOptionsResponse> GetOSDOptionsAsync(Onvif.Media.GetOSDOptionsRequest request)
		{
			return base.Channel.GetOSDOptionsAsync(request);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.SetOSDResponse Onvif.Media.Media.SetOSD(Onvif.Media.SetOSDRequest request)
		{
			return base.Channel.SetOSD(request);
		}

		public void SetOSD(Onvif.Media.OSDConfiguration OSD, ref System.Xml.XmlElement[] Any)
		{
			Onvif.Media.SetOSDRequest inValue = new Onvif.Media.SetOSDRequest();
			inValue.OSD = OSD;
			inValue.Any = Any;
			Onvif.Media.SetOSDResponse retVal = ((Onvif.Media.Media)(this)).SetOSD(inValue);
			Any = retVal.Any;
		}

		public System.Threading.Tasks.Task<Onvif.Media.SetOSDResponse> SetOSDAsync(Onvif.Media.SetOSDRequest request)
		{
			return base.Channel.SetOSDAsync(request);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.CreateOSDResponse Onvif.Media.Media.CreateOSD(Onvif.Media.CreateOSDRequest request)
		{
			return base.Channel.CreateOSD(request);
		}

		public string CreateOSD(Onvif.Media.OSDConfiguration OSD, ref System.Xml.XmlElement[] Any)
		{
			Onvif.Media.CreateOSDRequest inValue = new Onvif.Media.CreateOSDRequest();
			inValue.OSD = OSD;
			inValue.Any = Any;
			Onvif.Media.CreateOSDResponse retVal = ((Onvif.Media.Media)(this)).CreateOSD(inValue);
			Any = retVal.Any;
			return retVal.OSDToken;
		}

		public System.Threading.Tasks.Task<Onvif.Media.CreateOSDResponse> CreateOSDAsync(Onvif.Media.CreateOSDRequest request)
		{
			return base.Channel.CreateOSDAsync(request);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		Onvif.Media.DeleteOSDResponse Onvif.Media.Media.DeleteOSD(Onvif.Media.DeleteOSDRequest request)
		{
			return base.Channel.DeleteOSD(request);
		}

		public void DeleteOSD(string OSDToken, ref System.Xml.XmlElement[] Any)
		{
			Onvif.Media.DeleteOSDRequest inValue = new Onvif.Media.DeleteOSDRequest();
			inValue.OSDToken = OSDToken;
			inValue.Any = Any;
			Onvif.Media.DeleteOSDResponse retVal = ((Onvif.Media.Media)(this)).DeleteOSD(inValue);
			Any = retVal.Any;
		}

		public System.Threading.Tasks.Task<Onvif.Media.DeleteOSDResponse> DeleteOSDAsync(Onvif.Media.DeleteOSDRequest request)
		{
			return base.Channel.DeleteOSDAsync(request);
		}
	}
}

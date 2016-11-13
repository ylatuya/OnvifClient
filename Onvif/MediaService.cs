using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Onvif.Media;

namespace Onvif.Media
{
	public partial class MediaService : Onvif.Media.Media
	{
		VideoSource source;
		Profile profile;
		MediaUri mediaURI;

		public MediaService()
		{
			source = new VideoSource
			{
				Framerate = 25,
				Resolution = new VideoResolution { Width = 720, Height = 480 },
				token = "source",
			};

			profile = new Profile
			{
				VideoSourceConfiguration = new VideoSourceConfiguration
				{
					Name = "Stream 1",
					SourceToken = source.token,
					token = "profile",
				},
				VideoEncoderConfiguration = new VideoEncoderConfiguration
				{
					Name = "Encoder 1",
					Encoding = VideoEncoding.H264,
					Resolution = new VideoResolution { Width = 720, Height = 480 },
					Quality = 1,
					RateControl = new VideoRateControl
					{
						FrameRateLimit = 25,
						EncodingInterval = 25,
						BitrateLimit = 5000,
					},
				},
				PTZConfiguration = new PTZConfiguration
				{
					PanTiltLimits = new PanTiltLimits
					{
						Range = new Space2DDescription
						{
							XRange = new FloatRange
							{
								Min = -1,
								Max = 1,
							},
							YRange = new FloatRange
							{
								Min = -1,
								Max = 1,
							}
						}
					},
					ZoomLimits = new ZoomLimits
					{
						Range = new Space1DDescription
						{
							XRange = new FloatRange
							{
								Min = -1,
								Max = 1,
							}
						}
					}
				}
			};
			mediaURI = new MediaUri
			{
				Uri = "rtsp://localhost:8691/video"
			};
		}

		[return: MessageParameter(Name = "VideoSources")]
		public GetVideoSourcesResponse GetVideoSources(GetVideoSourcesRequest request)
		{
			var response = new GetVideoSourcesResponse();

			response.VideoSources = new VideoSource[] { source };
			return response;
		}

		public Task<GetVideoSourcesResponse> GetVideoSourcesAsync(GetVideoSourcesRequest request)
		{
			return Task.FromResult(GetVideoSources(request));
		}

		[return: MessageParameter(Name = "Profiles")]
		public GetProfilesResponse GetProfiles(GetProfilesRequest request)
		{
			return new GetProfilesResponse
			{
				Profiles = new Profile[] { profile },
			};
		}

		[return: MessageParameter(Name = "MediaUri")]
		public MediaUri GetStreamUri(StreamSetup StreamSetup, string ProfileToken)
		{
			return mediaURI;
		}

		[return: MessageParameter(Name = "MediaUri")]
		public Task<MediaUri> GetStreamUriAsync(StreamSetup StreamSetup, string ProfileToken)
		{
			return Task.FromResult(GetStreamUri(StreamSetup, ProfileToken));
		}

		public Task<GetProfilesResponse> GetProfilesAsync(GetProfilesRequest request)
		{
			return Task.FromResult(GetProfiles(request));
		}

		public void AddAudioDecoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddAudioEncoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddAudioOutputConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddAudioSourceConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddMetadataConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddPTZConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddVideoAnalyticsConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddVideoEncoderConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public void AddVideoSourceConfiguration(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		public CreateOSDResponse CreateOSD(CreateOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<CreateOSDResponse> CreateOSDAsync(CreateOSDRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Profile")]
		public Profile CreateProfile(string Name, string Token)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Profile")]
		public Task<Profile> CreateProfileAsync(string Name, string Token)
		{
			throw new NotImplementedException();
		}

		public DeleteOSDResponse DeleteOSD(DeleteOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<DeleteOSDResponse> DeleteOSDAsync(DeleteOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public void DeleteProfile(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task DeleteProfileAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public AudioDecoderConfiguration GetAudioDecoderConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public AudioDecoderConfigurationOptions GetAudioDecoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetAudioDecoderConfigurationsResponse GetAudioDecoderConfigurations(GetAudioDecoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync(GetAudioDecoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public AudioEncoderConfiguration GetAudioEncoderConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public AudioEncoderConfigurationOptions GetAudioEncoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetAudioEncoderConfigurationsResponse GetAudioEncoderConfigurations(GetAudioEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync(GetAudioEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public AudioOutputConfiguration GetAudioOutputConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public AudioOutputConfigurationOptions GetAudioOutputConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetAudioOutputConfigurationsResponse GetAudioOutputConfigurations(GetAudioOutputConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync(GetAudioOutputConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "AudioOutputs")]
		public GetAudioOutputsResponse GetAudioOutputs(GetAudioOutputsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioOutputsResponse> GetAudioOutputsAsync(GetAudioOutputsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public AudioSourceConfiguration GetAudioSourceConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public AudioSourceConfigurationOptions GetAudioSourceConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetAudioSourceConfigurationsResponse GetAudioSourceConfigurations(GetAudioSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync(GetAudioSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "AudioSources")]
		public GetAudioSourcesResponse GetAudioSources(GetAudioSourcesRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetAudioSourcesResponse> GetAudioSourcesAsync(GetAudioSourcesRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleAudioDecoderConfigurationsResponse GetCompatibleAudioDecoderConfigurations(GetCompatibleAudioDecoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(GetCompatibleAudioDecoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleAudioEncoderConfigurationsResponse GetCompatibleAudioEncoderConfigurations(GetCompatibleAudioEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(GetCompatibleAudioEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleAudioOutputConfigurationsResponse GetCompatibleAudioOutputConfigurations(GetCompatibleAudioOutputConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(GetCompatibleAudioOutputConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleAudioSourceConfigurationsResponse GetCompatibleAudioSourceConfigurations(GetCompatibleAudioSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(GetCompatibleAudioSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleMetadataConfigurationsResponse GetCompatibleMetadataConfigurations(GetCompatibleMetadataConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(GetCompatibleMetadataConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleVideoAnalyticsConfigurationsResponse GetCompatibleVideoAnalyticsConfigurations(GetCompatibleVideoAnalyticsConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(GetCompatibleVideoAnalyticsConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleVideoEncoderConfigurationsResponse GetCompatibleVideoEncoderConfigurations(GetCompatibleVideoEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(GetCompatibleVideoEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetCompatibleVideoSourceConfigurationsResponse GetCompatibleVideoSourceConfigurations(GetCompatibleVideoSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(GetCompatibleVideoSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public GetGuaranteedNumberOfVideoEncoderInstancesResponse GetGuaranteedNumberOfVideoEncoderInstances(GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public MetadataConfiguration GetMetadataConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public MetadataConfigurationOptions GetMetadataConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetMetadataConfigurationsResponse GetMetadataConfigurations(GetMetadataConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync(GetMetadataConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public GetOSDResponse GetOSD(GetOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetOSDResponse> GetOSDAsync(GetOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public GetOSDOptionsResponse GetOSDOptions(GetOSDOptionsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetOSDOptionsResponse> GetOSDOptionsAsync(GetOSDOptionsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "OSDs")]
		public GetOSDsResponse GetOSDs(GetOSDsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetOSDsResponse> GetOSDsAsync(GetOSDsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Profile")]
		public Profile GetProfile(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Profile")]
		public Task<Profile> GetProfileAsync(string ProfileToken)
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

		[return: MessageParameter(Name = "MediaUri")]
		public MediaUri GetSnapshotUri(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "MediaUri")]
		public Task<MediaUri> GetSnapshotUriAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public VideoAnalyticsConfiguration GetVideoAnalyticsConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetVideoAnalyticsConfigurationsResponse GetVideoAnalyticsConfigurations(GetVideoAnalyticsConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync(GetVideoAnalyticsConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public VideoEncoderConfiguration GetVideoEncoderConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public VideoEncoderConfigurationOptions GetVideoEncoderConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetVideoEncoderConfigurationsResponse GetVideoEncoderConfigurations(GetVideoEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync(GetVideoEncoderConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public VideoSourceConfiguration GetVideoSourceConfiguration(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configuration")]
		public Task<VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public VideoSourceConfigurationOptions GetVideoSourceConfigurationOptions(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Options")]
		public Task<VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Configurations")]
		public GetVideoSourceConfigurationsResponse GetVideoSourceConfigurations(GetVideoSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync(GetVideoSourceConfigurationsRequest request)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "VideoSourceModes")]
		public GetVideoSourceModesResponse GetVideoSourceModes(GetVideoSourceModesRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<GetVideoSourceModesResponse> GetVideoSourceModesAsync(GetVideoSourceModesRequest request)
		{
			throw new NotImplementedException();
		}

		public void RemoveAudioDecoderConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAudioDecoderConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveAudioEncoderConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAudioEncoderConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveAudioOutputConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAudioOutputConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveAudioSourceConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAudioSourceConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveMetadataConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveMetadataConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemovePTZConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemovePTZConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveVideoAnalyticsConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveVideoEncoderConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveVideoEncoderConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void RemoveVideoSourceConfiguration(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task RemoveVideoSourceConfigurationAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void SetAudioDecoderConfiguration(AudioDecoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetAudioDecoderConfigurationAsync(AudioDecoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetAudioEncoderConfiguration(AudioEncoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetAudioEncoderConfigurationAsync(AudioEncoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetAudioOutputConfiguration(AudioOutputConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetAudioOutputConfigurationAsync(AudioOutputConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetAudioSourceConfiguration(AudioSourceConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetAudioSourceConfigurationAsync(AudioSourceConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetMetadataConfiguration(MetadataConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetMetadataConfigurationAsync(MetadataConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public SetOSDResponse SetOSD(SetOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<SetOSDResponse> SetOSDAsync(SetOSDRequest request)
		{
			throw new NotImplementedException();
		}

		public void SetSynchronizationPoint(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task SetSynchronizationPointAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void SetVideoAnalyticsConfiguration(VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetVideoAnalyticsConfigurationAsync(VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetVideoEncoderConfiguration(VideoEncoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetVideoEncoderConfigurationAsync(VideoEncoderConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public void SetVideoSourceConfiguration(VideoSourceConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		public Task SetVideoSourceConfigurationAsync(VideoSourceConfiguration Configuration, bool ForcePersistence)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Reboot")]
		public bool SetVideoSourceMode(string VideoSourceToken, string VideoSourceModeToken)
		{
			throw new NotImplementedException();
		}

		[return: MessageParameter(Name = "Reboot")]
		public Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken)
		{
			throw new NotImplementedException();
		}

		public void StartMulticastStreaming(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task StartMulticastStreamingAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public void StopMulticastStreaming(string ProfileToken)
		{
			throw new NotImplementedException();
		}

		public Task StopMulticastStreamingAsync(string ProfileToken)
		{
			throw new NotImplementedException();
		}
	}
}
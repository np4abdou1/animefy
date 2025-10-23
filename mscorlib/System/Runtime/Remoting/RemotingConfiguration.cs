using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	/// <summary>Provides various static methods for configuring the remoting infrastructure.</summary>
	// Token: 0x0200030A RID: 778
	[ComVisible(true)]
	public static class RemotingConfiguration
	{
		/// <summary>Gets or sets the name of a remoting application.</summary>
		/// <returns>The name of a remoting application.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0006EF6C File Offset: 0x0006D16C
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0006EF73 File Offset: 0x0006D173
		public static string ApplicationName
		{
			get
			{
				return RemotingConfiguration.applicationName;
			}
			set
			{
				RemotingConfiguration.applicationName = value;
			}
		}

		/// <summary>Gets the ID of the currently executing process.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the ID of the currently executing process.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0006EF7B File Offset: 0x0006D17B
		public static string ProcessId
		{
			get
			{
				if (RemotingConfiguration.processGuid == null)
				{
					RemotingConfiguration.processGuid = AppDomain.GetProcessGuid();
				}
				return RemotingConfiguration.processGuid;
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0006EF94 File Offset: 0x0006D194
		internal static void LoadDefaultDelayedChannels()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (!RemotingConfiguration.defaultDelayedConfigRead && !RemotingConfiguration.defaultConfigRead)
				{
					SmallXmlParser smallXmlParser = new SmallXmlParser();
					using (TextReader textReader = new StreamReader(Environment.GetMachineConfigPath()))
					{
						ConfigHandler handler = new ConfigHandler(true);
						smallXmlParser.Parse(textReader, handler);
					}
					RemotingConfiguration.defaultDelayedConfigRead = true;
				}
			}
		}

		/// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a remotely activated client type.</summary>
		/// <param name="svrType">The object type to check. </param>
		/// <returns>The <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> that corresponds to the specified object type.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x0600198B RID: 6539 RVA: 0x0006F020 File Offset: 0x0006D220
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			ActivatedClientTypeEntry result;
			lock (obj)
			{
				result = (RemotingConfiguration.activatedClientEntries[svrType] as ActivatedClientTypeEntry);
			}
			return result;
		}

		/// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a well-known client type.</summary>
		/// <param name="svrType">The object <see cref="T:System.Type" /> to check. </param>
		/// <returns>The <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> that corresponds to the specified object type.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x0600198C RID: 6540 RVA: 0x0006F06C File Offset: 0x0006D26C
		public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			WellKnownClientTypeEntry result;
			lock (obj)
			{
				result = (RemotingConfiguration.wellKnownClientEntries[svrType] as WellKnownClientTypeEntry);
			}
			return result;
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> on the client end as a type that can be activated on the server.</summary>
		/// <param name="entry">Configuration settings for the client-activated type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x0600198D RID: 6541 RVA: 0x0006F0B8 File Offset: 0x0006D2B8
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (RemotingConfiguration.wellKnownClientEntries.ContainsKey(entry.ObjectType) || RemotingConfiguration.activatedClientEntries.ContainsKey(entry.ObjectType))
				{
					throw new RemotingException("Attempt to redirect activation of type '" + entry.ObjectType.FullName + "' which is already redirected.");
				}
				RemotingConfiguration.activatedClientEntries[entry.ObjectType] = entry;
				ActivationServices.EnableProxyActivation(entry.ObjectType, true);
			}
		}

		/// <summary>Registers an object type recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> on the service end as one that can be activated on request from a client.</summary>
		/// <param name="entry">Configuration settings for the client-activated type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x0600198E RID: 6542 RVA: 0x0006F154 File Offset: 0x0006D354
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				RemotingConfiguration.activatedServiceEntries.Add(entry.ObjectType, entry);
			}
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> on the client end as a well-known type that can be activated on the server.</summary>
		/// <param name="entry">Configuration settings for the well-known type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x0600198F RID: 6543 RVA: 0x0006F1A0 File Offset: 0x0006D3A0
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (RemotingConfiguration.wellKnownClientEntries.ContainsKey(entry.ObjectType) || RemotingConfiguration.activatedClientEntries.ContainsKey(entry.ObjectType))
				{
					throw new RemotingException("Attempt to redirect activation of type '" + entry.ObjectType.FullName + "' which is already redirected.");
				}
				RemotingConfiguration.wellKnownClientEntries[entry.ObjectType] = entry;
				ActivationServices.EnableProxyActivation(entry.ObjectType, true);
			}
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> on the service end as a well-known type.</summary>
		/// <param name="entry">Configuration settings for the well-known type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x06001990 RID: 6544 RVA: 0x0006F23C File Offset: 0x0006D43C
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				RemotingConfiguration.wellKnownServiceEntries[entry.ObjectUri] = entry;
				RemotingServices.CreateWellKnownServerIdentity(entry.ObjectType, entry.ObjectUri, entry.Mode);
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0006F2A0 File Offset: 0x0006D4A0
		internal static void RegisterChannelTemplate(ChannelData channel)
		{
			RemotingConfiguration.channelTemplates[channel.Id] = channel;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0006F2B3 File Offset: 0x0006D4B3
		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
			RemotingConfiguration.clientProviderTemplates[prov.Id] = prov;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0006F2C6 File Offset: 0x0006D4C6
		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
			RemotingConfiguration.serverProviderTemplates[prov.Id] = prov;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		internal static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
			foreach (object obj in channels)
			{
				ChannelData channelData = (ChannelData)obj;
				if ((!onlyDelayed || !(channelData.DelayLoadAsClientChannel != "true")) && (!RemotingConfiguration.defaultDelayedConfigRead || !(channelData.DelayLoadAsClientChannel == "true")))
				{
					if (channelData.Ref != null)
					{
						ChannelData channelData2 = (ChannelData)RemotingConfiguration.channelTemplates[channelData.Ref];
						if (channelData2 == null)
						{
							throw new RemotingException("Channel template '" + channelData.Ref + "' not found");
						}
						channelData.CopyFrom(channelData2);
					}
					foreach (object obj2 in channelData.ServerProviders)
					{
						ProviderData providerData = (ProviderData)obj2;
						if (providerData.Ref != null)
						{
							ProviderData providerData2 = (ProviderData)RemotingConfiguration.serverProviderTemplates[providerData.Ref];
							if (providerData2 == null)
							{
								throw new RemotingException("Provider template '" + providerData.Ref + "' not found");
							}
							providerData.CopyFrom(providerData2);
						}
					}
					foreach (object obj3 in channelData.ClientProviders)
					{
						ProviderData providerData3 = (ProviderData)obj3;
						if (providerData3.Ref != null)
						{
							ProviderData providerData4 = (ProviderData)RemotingConfiguration.clientProviderTemplates[providerData3.Ref];
							if (providerData4 == null)
							{
								throw new RemotingException("Provider template '" + providerData3.Ref + "' not found");
							}
							providerData3.CopyFrom(providerData4);
						}
					}
					ChannelServices.RegisterChannelConfig(channelData);
				}
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		internal static void RegisterTypes(ArrayList types)
		{
			foreach (object obj in types)
			{
				TypeEntry typeEntry = (TypeEntry)obj;
				if (typeEntry is ActivatedClientTypeEntry)
				{
					RemotingConfiguration.RegisterActivatedClientType((ActivatedClientTypeEntry)typeEntry);
				}
				else if (typeEntry is ActivatedServiceTypeEntry)
				{
					RemotingConfiguration.RegisterActivatedServiceType((ActivatedServiceTypeEntry)typeEntry);
				}
				else if (typeEntry is WellKnownClientTypeEntry)
				{
					RemotingConfiguration.RegisterWellKnownClientType((WellKnownClientTypeEntry)typeEntry);
				}
				else if (typeEntry is WellKnownServiceTypeEntry)
				{
					RemotingConfiguration.RegisterWellKnownServiceType((WellKnownServiceTypeEntry)typeEntry);
				}
			}
		}

		/// <summary>Indicates whether the server channels in this application domain return filtered or complete exception information to local or remote callers.</summary>
		/// <param name="isLocalRequest">
		///       <see langword="true" /> to specify local callers; <see langword="false" /> to specify remote callers. </param>
		/// <returns>
		///     <see langword="true" /> if only filtered exception information is returned to local or remote callers, as specified by the <paramref name="isLocalRequest" /> parameter; <see langword="false" /> if complete exception information is returned.</returns>
		// Token: 0x06001996 RID: 6550 RVA: 0x0006F594 File Offset: 0x0006D794
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			return RemotingConfiguration._errorMode != CustomErrorsModes.Off && (RemotingConfiguration._errorMode == CustomErrorsModes.On || !isLocalRequest);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
		internal static void SetCustomErrorsMode(string mode)
		{
			if (mode == null)
			{
				throw new RemotingException("mode attribute is required");
			}
			string text = mode.ToLower();
			if (text != "on" && text != "off" && text != "remoteonly")
			{
				throw new RemotingException("Invalid custom error mode: " + mode);
			}
			RemotingConfiguration._errorMode = (CustomErrorsModes)Enum.Parse(typeof(CustomErrorsModes), text, true);
		}

		// Token: 0x04000AA5 RID: 2725
		private static string applicationID = null;

		// Token: 0x04000AA6 RID: 2726
		private static string applicationName = null;

		// Token: 0x04000AA7 RID: 2727
		private static string processGuid = null;

		// Token: 0x04000AA8 RID: 2728
		private static bool defaultConfigRead = false;

		// Token: 0x04000AA9 RID: 2729
		private static bool defaultDelayedConfigRead = false;

		// Token: 0x04000AAA RID: 2730
		private static CustomErrorsModes _errorMode = CustomErrorsModes.RemoteOnly;

		// Token: 0x04000AAB RID: 2731
		private static Hashtable wellKnownClientEntries = new Hashtable();

		// Token: 0x04000AAC RID: 2732
		private static Hashtable activatedClientEntries = new Hashtable();

		// Token: 0x04000AAD RID: 2733
		private static Hashtable wellKnownServiceEntries = new Hashtable();

		// Token: 0x04000AAE RID: 2734
		private static Hashtable activatedServiceEntries = new Hashtable();

		// Token: 0x04000AAF RID: 2735
		private static Hashtable channelTemplates = new Hashtable();

		// Token: 0x04000AB0 RID: 2736
		private static Hashtable clientProviderTemplates = new Hashtable();

		// Token: 0x04000AB1 RID: 2737
		private static Hashtable serverProviderTemplates = new Hashtable();
	}
}

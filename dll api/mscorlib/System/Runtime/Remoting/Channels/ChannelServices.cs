using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Provides static methods to aid with remoting channel registration, resolution, and URL discovery. This class cannot be inherited.</summary>
	// Token: 0x0200033E RID: 830
	[ComVisible(true)]
	public sealed class ChannelServices
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0007423C File Offset: 0x0007243C
		internal static CrossContextChannel CrossContextChannel
		{
			get
			{
				return ChannelServices._crossContextSink;
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00074244 File Offset: 0x00072444
		internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
		{
			object[] channelDataArray = (object[])remoteChannelData;
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in ChannelServices.registeredChannels)
				{
					IChannelSender channelSender = ((IChannel)obj) as IChannelSender;
					if (channelSender != null)
					{
						IMessageSink messageSink = ChannelServices.CreateClientChannelSinkChain(channelSender, url, channelDataArray, out objectUri);
						if (messageSink != null)
						{
							return messageSink;
						}
					}
				}
				RemotingConfiguration.LoadDefaultDelayedChannels();
				foreach (object obj2 in ChannelServices.delayedClientChannels)
				{
					IChannelSender channelSender2 = (IChannelSender)obj2;
					IMessageSink messageSink2 = ChannelServices.CreateClientChannelSinkChain(channelSender2, url, channelDataArray, out objectUri);
					if (messageSink2 != null)
					{
						ChannelServices.delayedClientChannels.Remove(channelSender2);
						ChannelServices.RegisterChannel(channelSender2);
						return messageSink2;
					}
				}
			}
			objectUri = null;
			return null;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00074368 File Offset: 0x00072568
		internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
		{
			objectUri = null;
			if (channelDataArray == null)
			{
				return sender.CreateMessageSink(url, null, out objectUri);
			}
			foreach (object obj in channelDataArray)
			{
				IMessageSink messageSink;
				if (obj is IChannelDataStore)
				{
					messageSink = sender.CreateMessageSink(null, obj, out objectUri);
				}
				else
				{
					messageSink = sender.CreateMessageSink(url, obj, out objectUri);
				}
				if (messageSink != null)
				{
					return messageSink;
				}
			}
			return null;
		}

		/// <summary>Registers a channel with the channel services. <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel)" /> is obsolete. Please use <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel,System.Boolean)" /> instead.</summary>
		/// <param name="chnl">The channel to register. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x06001AC5 RID: 6853 RVA: 0x000743BD File Offset: 0x000725BD
		public static void RegisterChannel(IChannel chnl)
		{
			ChannelServices.RegisterChannel(chnl, false);
		}

		/// <summary>Registers a channel with the channel services.</summary>
		/// <param name="chnl">The channel to register.</param>
		/// <param name="ensureSecurity">
		///       <see langword="true" /> ensures that security is enabled; otherwise <see langword="false" />. Setting the value to <see langword="false" /> does not effect the security setting on the TCP or IPC channel. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the call stack does not have permission to configure remoting types and channels. </exception>
		/// <exception cref="T:System.NotSupportedException">Not supported in Windows 98 for <see cref="T:System.Runtime.Remoting.Channels.Tcp.TcpServerChannel" /> and on all platforms for <see cref="T:System.Runtime.Remoting.Channels.Http.HttpServerChannel" />. Host the service using Internet Information Services (IIS) if you require a secure HTTP channel.</exception>
		// Token: 0x06001AC6 RID: 6854 RVA: 0x000743C8 File Offset: 0x000725C8
		public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			if (chnl == null)
			{
				throw new ArgumentNullException("chnl");
			}
			if (ensureSecurity)
			{
				ISecurableChannel securableChannel = chnl as ISecurableChannel;
				if (securableChannel == null)
				{
					throw new RemotingException(string.Format("Channel {0} is not securable while ensureSecurity is specified as true", chnl.ChannelName));
				}
				securableChannel.IsSecured = true;
			}
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				int num = -1;
				for (int i = 0; i < ChannelServices.registeredChannels.Count; i++)
				{
					IChannel channel = (IChannel)ChannelServices.registeredChannels[i];
					if (channel.ChannelName == chnl.ChannelName && chnl.ChannelName != "")
					{
						throw new RemotingException("Channel " + channel.ChannelName + " already registered");
					}
					if (channel.ChannelPriority < chnl.ChannelPriority && num == -1)
					{
						num = i;
					}
				}
				if (num != -1)
				{
					ChannelServices.registeredChannels.Insert(num, chnl);
				}
				else
				{
					ChannelServices.registeredChannels.Add(chnl);
				}
				IChannelReceiver channelReceiver = chnl as IChannelReceiver;
				if (channelReceiver != null && ChannelServices.oldStartModeTypes.Contains(chnl.GetType().ToString()))
				{
					channelReceiver.StartListening(null);
				}
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00074508 File Offset: 0x00072708
		internal static void RegisterChannelConfig(ChannelData channel)
		{
			IServerChannelSinkProvider serverChannelSinkProvider = null;
			IClientChannelSinkProvider clientChannelSinkProvider = null;
			for (int i = channel.ServerProviders.Count - 1; i >= 0; i--)
			{
				IServerChannelSinkProvider serverChannelSinkProvider2 = (IServerChannelSinkProvider)ChannelServices.CreateProvider(channel.ServerProviders[i] as ProviderData);
				serverChannelSinkProvider2.Next = serverChannelSinkProvider;
				serverChannelSinkProvider = serverChannelSinkProvider2;
			}
			for (int j = channel.ClientProviders.Count - 1; j >= 0; j--)
			{
				IClientChannelSinkProvider clientChannelSinkProvider2 = (IClientChannelSinkProvider)ChannelServices.CreateProvider(channel.ClientProviders[j] as ProviderData);
				clientChannelSinkProvider2.Next = clientChannelSinkProvider;
				clientChannelSinkProvider = clientChannelSinkProvider2;
			}
			Type type = Type.GetType(channel.Type);
			if (type == null)
			{
				throw new RemotingException("Type '" + channel.Type + "' not found");
			}
			bool flag = typeof(IChannelSender).IsAssignableFrom(type);
			bool flag2 = typeof(IChannelReceiver).IsAssignableFrom(type);
			Type[] types;
			object[] parameters;
			if (flag && flag2)
			{
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IClientChannelSinkProvider),
					typeof(IServerChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					clientChannelSinkProvider,
					serverChannelSinkProvider
				};
			}
			else if (flag)
			{
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IClientChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					clientChannelSinkProvider
				};
			}
			else
			{
				if (!flag2)
				{
					Type type2 = type;
					throw new RemotingException(((type2 != null) ? type2.ToString() : null) + " is not a valid channel type");
				}
				types = new Type[]
				{
					typeof(IDictionary),
					typeof(IServerChannelSinkProvider)
				};
				parameters = new object[]
				{
					channel.CustomProperties,
					serverChannelSinkProvider
				};
			}
			ConstructorInfo constructor = type.GetConstructor(types);
			if (constructor == null)
			{
				Type type3 = type;
				throw new RemotingException(((type3 != null) ? type3.ToString() : null) + " does not have a valid constructor");
			}
			IChannel channel2;
			try
			{
				channel2 = (IChannel)constructor.Invoke(parameters);
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				if (channel.DelayLoadAsClientChannel == "true" && !(channel2 is IChannelReceiver))
				{
					ChannelServices.delayedClientChannels.Add(channel2);
				}
				else
				{
					ChannelServices.RegisterChannel(channel2);
				}
			}
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00074794 File Offset: 0x00072994
		private static object CreateProvider(ProviderData prov)
		{
			Type type = Type.GetType(prov.Type);
			if (type == null)
			{
				throw new RemotingException("Type '" + prov.Type + "' not found");
			}
			object[] args = new object[]
			{
				prov.CustomProperties,
				prov.CustomData
			};
			object result;
			try
			{
				result = Activator.CreateInstance(type, args);
			}
			catch (Exception innerException)
			{
				if (innerException is TargetInvocationException)
				{
					innerException = ((TargetInvocationException)innerException).InnerException;
				}
				string str = "An instance of provider '";
				Type type2 = type;
				throw new RemotingException(str + ((type2 != null) ? type2.ToString() : null) + "' could not be created: " + innerException.Message);
			}
			return result;
		}

		/// <summary>Synchronously dispatches the incoming message to the server-side chain(s) based on the URI embedded in the message.</summary>
		/// <param name="msg">The message to dispatch. </param>
		/// <returns>A reply message is returned by the call to the server-side chain.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="msg" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001AC9 RID: 6857 RVA: 0x00074844 File Offset: 0x00072A44
		public static IMessage SyncDispatchMessage(IMessage msg)
		{
			IMessage message = ChannelServices.CheckIncomingMessage(msg);
			if (message != null)
			{
				return ChannelServices.CheckReturnMessage(msg, message);
			}
			message = ChannelServices._crossContextSink.SyncProcessMessage(msg);
			return ChannelServices.CheckReturnMessage(msg, message);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00074878 File Offset: 0x00072A78
		private static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			IMethodMessage methodMessage = (IMethodMessage)msg;
			ServerIdentity serverIdentity = RemotingServices.GetIdentityForUri(methodMessage.Uri) as ServerIdentity;
			if (serverIdentity == null)
			{
				return new ReturnMessage(new RemotingException("No receiver for uri " + methodMessage.Uri), (IMethodCallMessage)msg);
			}
			RemotingServices.SetMessageTargetIdentity(msg, serverIdentity);
			return null;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x000748CC File Offset: 0x00072ACC
		internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			IMethodReturnMessage methodReturnMessage = retMsg as IMethodReturnMessage;
			if (methodReturnMessage != null && methodReturnMessage.Exception != null && RemotingConfiguration.CustomErrorsEnabled(ChannelServices.IsLocalCall(callMsg)))
			{
				retMsg = new MethodResponse(new Exception("Server encountered an internal error. For more information, turn off customErrors in the server's .config file."), (IMethodCallMessage)callMsg);
			}
			return retMsg;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0000B18D File Offset: 0x0000938D
		private static bool IsLocalCall(IMessage callMsg)
		{
			return true;
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00074910 File Offset: 0x00072B10
		internal static object[] GetCurrentChannelInfo()
		{
			List<object> list = new List<object>();
			object syncRoot = ChannelServices.registeredChannels.SyncRoot;
			lock (syncRoot)
			{
				foreach (object obj in ChannelServices.registeredChannels)
				{
					IChannelReceiver channelReceiver = obj as IChannelReceiver;
					if (channelReceiver != null)
					{
						object channelData = channelReceiver.ChannelData;
						if (channelData != null)
						{
							list.Add(channelData);
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x04000B35 RID: 2869
		private static ArrayList registeredChannels = new ArrayList();

		// Token: 0x04000B36 RID: 2870
		private static ArrayList delayedClientChannels = new ArrayList();

		// Token: 0x04000B37 RID: 2871
		private static CrossContextChannel _crossContextSink = new CrossContextChannel();

		// Token: 0x04000B38 RID: 2872
		internal static string CrossContextUrl = "__CrossContext";

		// Token: 0x04000B39 RID: 2873
		private static IList oldStartModeTypes = new string[]
		{
			"Novell.Zenworks.Zmd.Public.UnixServerChannel",
			"Novell.Zenworks.Zmd.Public.UnixChannel"
		};
	}
}

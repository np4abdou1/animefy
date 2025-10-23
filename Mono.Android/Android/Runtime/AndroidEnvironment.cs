using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Android.App;
using Android.OS;
using Android.Util;
using Android.Views;
using Java.Lang;
using Java.Net;
using Java.Security;
using Java.Security.Cert;
using Javax.Net.Ssl;

namespace Android.Runtime
{
	// Token: 0x020002B7 RID: 695
	public static class AndroidEnvironment
	{
		// Token: 0x06001A85 RID: 6789 RVA: 0x00044934 File Offset: 0x00042B34
		private static void SetupTrustManager()
		{
			if (AndroidEnvironment.sslTrustManager != null)
			{
				return;
			}
			object obj = AndroidEnvironment.lock_;
			lock (obj)
			{
				TrustManagerFactory instance = TrustManagerFactory.GetInstance(TrustManagerFactory.DefaultAlgorithm);
				instance.Init(null);
				foreach (ITrustManager instance2 in instance.GetTrustManagers())
				{
					try
					{
						AndroidEnvironment.sslTrustManager = instance2.JavaCast<IX509TrustManager>();
					}
					catch
					{
					}
					if (AndroidEnvironment.sslTrustManager != null)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000449C8 File Offset: 0x00042BC8
		private static void SetupCertStore()
		{
			if (AndroidEnvironment.certStore != null)
			{
				return;
			}
			object obj = AndroidEnvironment.lock_;
			lock (obj)
			{
				try
				{
					AndroidEnvironment.certStore = KeyStore.GetInstance("AndroidCAStore");
					AndroidEnvironment.certStore.Load(null);
				}
				catch
				{
					AndroidEnvironment.certStore = null;
				}
			}
		}

		// Token: 0x06001A87 RID: 6791
		[DllImport("libc")]
		private static extern void exit(int status);

		// Token: 0x06001A88 RID: 6792 RVA: 0x00044A38 File Offset: 0x00042C38
		public static void FailFast(string message)
		{
			Logger.Log(LogLevel.Fatal, "Mono.Android", message);
			AndroidEnvironment.exit(-1);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06001A89 RID: 6793 RVA: 0x00044A4C File Offset: 0x00042C4C
		// (remove) Token: 0x06001A8A RID: 6794 RVA: 0x00044A80 File Offset: 0x00042C80
		public static event EventHandler<RaiseThrowableEventArgs> UnhandledExceptionRaiser;

		// Token: 0x06001A8B RID: 6795 RVA: 0x00044AB3 File Offset: 0x00042CB3
		public static void RaiseThrowable(Throwable throwable)
		{
			if (throwable == null)
			{
				throw new ArgumentNullException("throwable");
			}
			JNIEnv.Throw(throwable.Handle);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00044AD0 File Offset: 0x00042CD0
		internal static void UnhandledException(System.Exception e)
		{
			EventHandler<RaiseThrowableEventArgs> unhandledExceptionRaiser = AndroidEnvironment.UnhandledExceptionRaiser;
			if (unhandledExceptionRaiser != null)
			{
				RaiseThrowableEventArgs raiseThrowableEventArgs = new RaiseThrowableEventArgs(e);
				Delegate[] invocationList = unhandledExceptionRaiser.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					((EventHandler<RaiseThrowableEventArgs>)invocationList[i])(null, raiseThrowableEventArgs);
					if (raiseThrowableEventArgs.Handled)
					{
						return;
					}
				}
			}
			AndroidEnvironment.RaiseThrowable(Throwable.FromException(e));
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00044B28 File Offset: 0x00042D28
		private static bool TrustEvaluateSsl(List<byte[]> certsRawData)
		{
			AndroidEnvironment.SetupTrustManager();
			if (AndroidEnvironment.sslTrustManager == null)
			{
				return false;
			}
			CertificateFactory x509CertificateFactory = AndroidEnvironment.GetX509CertificateFactory();
			X509Certificate[] array = new X509Certificate[certsRawData.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = AndroidEnvironment.ConvertCertificate(x509CertificateFactory, certsRawData[i]);
			}
			try
			{
				AndroidEnvironment.sslTrustManager.CheckServerTrusted(array, TrustManagerFactory.DefaultAlgorithm);
				return true;
			}
			catch (System.Exception)
			{
			}
			bool result;
			try
			{
				AndroidEnvironment.sslTrustManager.CheckServerTrusted(new X509Certificate[]
				{
					array[0]
				}, TrustManagerFactory.DefaultAlgorithm);
				result = true;
			}
			catch (System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00044BD0 File Offset: 0x00042DD0
		private static byte[] CertStoreLookup(long hash, bool userStore)
		{
			AndroidEnvironment.SetupCertStore();
			if (AndroidEnvironment.certStore == null)
			{
				return null;
			}
			string alias = string.Format("{0}:{1:x8}.0", userStore ? "user" : "system", hash);
			Certificate certificate = AndroidEnvironment.certStore.GetCertificate(alias);
			if (certificate == null)
			{
				return null;
			}
			return certificate.GetEncoded();
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00044C22 File Offset: 0x00042E22
		private static CertificateFactory GetX509CertificateFactory()
		{
			return CertificateFactory.GetInstance("X.509");
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00044C2E File Offset: 0x00042E2E
		private static X509Certificate ConvertCertificate(CertificateFactory factory, byte[] certificateData)
		{
			return factory.GenerateCertificate(new MemoryStream(certificateData)).JavaCast<X509Certificate>();
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00044C44 File Offset: 0x00042E44
		private static void NotifyTimeZoneChanged()
		{
			System.Threading.Thread currentThread = System.Threading.Thread.CurrentThread;
			var array = new <>f__AnonymousType0<string, Action>[]
			{
				new
				{
					Description = "Thread.CurrentCulture.ClearCachedData()",
					Method = new Action(currentThread.CurrentCulture.ClearCachedData)
				},
				new
				{
					Description = "Thread.CurrentUICulture.ClearCachedData()",
					Method = new Action(currentThread.CurrentUICulture.ClearCachedData)
				}
			};
			for (int i = 0; i < array.Length; i++)
			{
				var <>f__AnonymousType = array[i];
				try
				{
					<>f__AnonymousType.Method();
				}
				catch (System.Exception arg)
				{
					Logger.Log(LogLevel.Warn, "MonoAndroid", string.Format("Ignoring exception from {0}: {1}", <>f__AnonymousType.Description, arg));
				}
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00044CEC File Offset: 0x00042EEC
		private static void GetDisplayDPI(out float x_dpi, out float y_dpi)
		{
			IWindowManager windowManager = Application.Context.GetSystemService("window").JavaCast<IWindowManager>();
			DisplayMetrics displayMetrics = new DisplayMetrics();
			if (windowManager != null)
			{
				Display defaultDisplay = windowManager.DefaultDisplay;
				if (defaultDisplay != null)
				{
					defaultDisplay.GetRealMetrics(displayMetrics);
				}
			}
			x_dpi = displayMetrics.Xdpi;
			y_dpi = displayMetrics.Ydpi;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00044D3C File Offset: 0x00042F3C
		private static string GetDefaultTimeZone()
		{
			IntPtr ptr = RuntimeNativeMethods._monodroid_timezone_get_default_id();
			string result;
			try
			{
				result = Marshal.PtrToStringAnsi(ptr);
			}
			finally
			{
				RuntimeNativeMethods.monodroid_free(ptr);
			}
			return result;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00044D70 File Offset: 0x00042F70
		private static SynchronizationContext GetDefaultSyncContext()
		{
			Looper mainLooper = Looper.MainLooper;
			try
			{
				if (Looper.MyLooper() == mainLooper)
				{
					return Application.SynchronizationContext;
				}
			}
			catch (System.Exception arg)
			{
				Logger.Log(LogLevel.Warn, "MonoAndroid", string.Format("GetDefaultSyncContext caught a Java exception: {0}", arg));
			}
			return null;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00044DC4 File Offset: 0x00042FC4
		private static int GetInterfaceAddresses(out IntPtr ifap)
		{
			return RuntimeNativeMethods._monodroid_getifaddrs(out ifap);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00044DCC File Offset: 0x00042FCC
		private static void FreeInterfaceAddresses(IntPtr ifap)
		{
			RuntimeNativeMethods._monodroid_freeifaddrs(ifap);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00044DD4 File Offset: 0x00042FD4
		private static void DetectCPUAndArchitecture(out ushort builtForCPU, out ushort runningOnCPU, out bool is64bit)
		{
			ushort num = 0;
			ushort num2 = 0;
			byte b = 0;
			RuntimeNativeMethods._monodroid_detect_cpu_and_architecture(ref num, ref num2, ref b);
			builtForCPU = num;
			runningOnCPU = num2;
			is64bit = (b > 0);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00044DFE File Offset: 0x00042FFE
		private static IWebProxy GetDefaultProxy()
		{
			return new AndroidEnvironment._Proxy();
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00044E08 File Offset: 0x00043008
		private static object GetHttpMessageHandler()
		{
			if (AndroidEnvironment.httpMessageHandlerType == null)
			{
				string environmentVariable = System.Environment.GetEnvironmentVariable("XA_HTTP_CLIENT_HANDLER_TYPE");
				string text = (environmentVariable != null) ? environmentVariable.Trim() : null;
				Type type = null;
				if (!string.IsNullOrEmpty(text))
				{
					type = Type.GetType(text, false);
				}
				if (type == null || !AndroidEnvironment.IsAcceptableHttpMessageHandlerType(type))
				{
					type = AndroidEnvironment.GetFallbackHttpMessageHandlerType("Xamarin.Android.Net.AndroidMessageHandler, Mono.Android");
				}
				AndroidEnvironment.httpMessageHandlerType = type;
			}
			object obj = Activator.CreateInstance(AndroidEnvironment.httpMessageHandlerType);
			if (obj == null)
			{
				throw new InvalidOperationException("Could not create an instance of HTTP message handler type " + AndroidEnvironment.httpMessageHandlerType.AssemblyQualifiedName);
			}
			return obj;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00044E89 File Offset: 0x00043089
		private static bool IsAcceptableHttpMessageHandlerType(Type handlerType)
		{
			if (!AndroidEnvironment.Extends(handlerType, "System.Net.Http.HttpMessageHandler, System.Net.Http"))
			{
				Logger.Log(LogLevel.Warn, "MonoAndroid", "The type " + handlerType.AssemblyQualifiedName + " set as the default HTTP handler is invalid. Use a type that extends System.Net.Http.HttpMessageHandler.");
				return false;
			}
			return true;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00044EBB File Offset: 0x000430BB
		private static bool Extends(Type handlerType, string baseTypeName)
		{
			Type type = Type.GetType(baseTypeName, false);
			return type != null && type.IsAssignableFrom(handlerType);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00044ED0 File Offset: 0x000430D0
		private static Type GetFallbackHttpMessageHandlerType(string typeName = "Xamarin.Android.Net.AndroidMessageHandler, Mono.Android")
		{
			Type type = Type.GetType(typeName, false);
			if (type == null)
			{
				throw new InvalidOperationException("The " + typeName + " was not found. The type was probably linked away.");
			}
			Logger.Log(LogLevel.Info, "MonoAndroid", "Using " + typeName + " as the native HTTP message handler.");
			return type;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00044F0E File Offset: 0x0004310E
		internal static bool VSAndroidDesignerIsEnabled { get; } = AndroidEnvironment.InitializeVSAndroidDesignerIsEnabled();

		// Token: 0x06001A9E RID: 6814 RVA: 0x00044F18 File Offset: 0x00043118
		private static bool InitializeVSAndroidDesignerIsEnabled()
		{
			bool flag;
			return !AppContext.TryGetSwitch("Xamarin.Android.VSAndroidDesigner.IsSupported", out flag) || flag;
		}

		// Token: 0x04000B65 RID: 2917
		public const string AndroidLogAppName = "Mono.Android";

		// Token: 0x04000B66 RID: 2918
		private static IX509TrustManager sslTrustManager;

		// Token: 0x04000B67 RID: 2919
		private static KeyStore certStore;

		// Token: 0x04000B68 RID: 2920
		private static object lock_ = new object();

		// Token: 0x04000B69 RID: 2921
		private static Type httpMessageHandlerType;

		// Token: 0x020002B8 RID: 696
		private class _Proxy : IWebProxy
		{
			// Token: 0x06001AA0 RID: 6816 RVA: 0x00044F4C File Offset: 0x0004314C
			private static URI CreateJavaUri(Uri destination)
			{
				URI result;
				try
				{
					result = new URI(destination.Scheme, destination.UserInfo, destination.Host, destination.Port, destination.AbsolutePath, destination.Query, destination.Fragment);
				}
				catch (Throwable throwable) when (JNIEnv.ShouldWrapJavaException(throwable, "CreateJavaUri"))
				{
					throw new UriFormatException(throwable.Message, throwable);
				}
				return result;
			}

			// Token: 0x06001AA1 RID: 6817 RVA: 0x00044FC8 File Offset: 0x000431C8
			public Uri GetProxy(Uri destination)
			{
				IList<Proxy> list;
				using (URI uri = AndroidEnvironment._Proxy.CreateJavaUri(destination))
				{
					list = this.selector.Select(uri);
				}
				if (list.Count < 1)
				{
					return destination;
				}
				Proxy proxy = list[0];
				if (proxy.Equals(Proxy.NoProxy))
				{
					return destination;
				}
				InetSocketAddress inetSocketAddress = proxy.Address() as InetSocketAddress;
				if (inetSocketAddress == null)
				{
					return destination;
				}
				return new Uri(string.Format("http://{0}:{1}/", inetSocketAddress.HostString, inetSocketAddress.Port));
			}

			// Token: 0x06001AA2 RID: 6818 RVA: 0x00045058 File Offset: 0x00043258
			public bool IsBypassed(Uri host)
			{
				IList<Proxy> list;
				using (URI uri = AndroidEnvironment._Proxy.CreateJavaUri(host))
				{
					list = this.selector.Select(uri);
				}
				return list.Count < 1 || list[0].Equals(Proxy.NoProxy);
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x000450B4 File Offset: 0x000432B4
			public ICredentials Credentials { get; }

			// Token: 0x04000B6C RID: 2924
			private readonly ProxySelector selector = ProxySelector.Default;
		}
	}
}

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Mono;

namespace System
{
	/// <summary>Provides information about, and means to manipulate, the current environment and platform. This class cannot be inherited.</summary>
	// Token: 0x02000162 RID: 354
	[ComVisible(true)]
	public static class Environment
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x0000245A File Offset: 0x0000065A
		internal static string GetResourceString(string key)
		{
			return key;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003C81F File Offset: 0x0003AA1F
		internal static string GetResourceString(string key, params object[] values)
		{
			return string.Format(CultureInfo.InvariantCulture, key, values);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003C830 File Offset: 0x0003AA30
		internal static string GetResourceStringEncodingName(int codePage)
		{
			if (codePage <= 12000)
			{
				if (codePage == 1200)
				{
					return Environment.GetResourceString("Unicode");
				}
				if (codePage == 1201)
				{
					return Environment.GetResourceString("Unicode (Big-Endian)");
				}
				if (codePage == 12000)
				{
					return Environment.GetResourceString("Unicode (UTF-32)");
				}
			}
			else if (codePage <= 20127)
			{
				if (codePage == 12001)
				{
					return Environment.GetResourceString("Unicode (UTF-32 Big-Endian)");
				}
				if (codePage == 20127)
				{
					return Environment.GetResourceString("US-ASCII");
				}
			}
			else
			{
				if (codePage == 65000)
				{
					return Environment.GetResourceString("Unicode (UTF-7)");
				}
				if (codePage == 65001)
				{
					return Environment.GetResourceString("Unicode (UTF-8)");
				}
			}
			return codePage.ToString(CultureInfo.InvariantCulture);
		}

		/// <summary>Gets or sets the fully qualified path of the current working directory.</summary>
		/// <returns>A string containing a directory path.</returns>
		/// <exception cref="T:System.ArgumentException">Attempted to set to an empty string ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Attempted to set to <see langword="null." /></exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Attempted to set a local path that cannot be found.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the appropriate permission.</exception>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		public static string CurrentDirectory
		{
			get
			{
				return Directory.InsecureGetCurrentDirectory();
			}
		}

		/// <summary>Gets a unique identifier for the current managed thread.</summary>
		/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0003C8EB File Offset: 0x0003AAEB
		public static int CurrentManagedThreadId
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId;
			}
		}

		/// <summary>Gets a value that indicates whether the current application domain is being unloaded or the common language runtime (CLR) is shutting down. </summary>
		/// <returns>
		///     <see langword="true" /> if the current application domain is being unloaded or the CLR is shutting down; otherwise, <see langword="false." /></returns>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000E49 RID: 3657
		public static extern bool HasShutdownStarted { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		/// <summary>Gets the NetBIOS name of this local computer.</summary>
		/// <returns>A string containing the name of this computer.</returns>
		/// <exception cref="T:System.InvalidOperationException">The name of this computer cannot be obtained.</exception>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000E4A RID: 3658
		public static extern string MachineName { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E4B RID: 3659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetNewLine();

		/// <summary>Gets the newline string defined for this environment.</summary>
		/// <returns>A string containing "\r\n" for non-Unix platforms, or a string containing "\n" for Unix platforms.</returns>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0003C8F7 File Offset: 0x0003AAF7
		public static string NewLine
		{
			get
			{
				if (Environment.nl != null)
				{
					return Environment.nl;
				}
				Environment.nl = Environment.GetNewLine();
				return Environment.nl;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000E4D RID: 3661
		internal static extern PlatformID Platform { [CompilerGenerated] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E4E RID: 3662
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetOSVersionString();

		/// <summary>Gets an <see cref="T:System.OperatingSystem" /> object that contains the current platform identifier and version number.</summary>
		/// <returns>An object that contains the platform identifier and version number.</returns>
		/// <exception cref="T:System.InvalidOperationException">This property was unable to obtain the system version.-or- The obtained platform identifier is not a member of <see cref="T:System.PlatformID" /></exception>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003C918 File Offset: 0x0003AB18
		public static OperatingSystem OSVersion
		{
			get
			{
				if (Environment.os == null)
				{
					Version version = Environment.CreateVersionFromString(Environment.GetOSVersionString());
					PlatformID platformID = Environment.Platform;
					if (platformID == PlatformID.MacOSX)
					{
						platformID = PlatformID.Unix;
					}
					Environment.os = new OperatingSystem(platformID, version);
				}
				return Environment.os;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0003C954 File Offset: 0x0003AB54
		internal static Version CreateVersionFromString(string info)
		{
			int major = 0;
			int minor = 0;
			int build = 0;
			int revision = 0;
			int num = 1;
			int num2 = -1;
			if (info == null)
			{
				return new Version(0, 0, 0, 0);
			}
			foreach (char c in info)
			{
				if (char.IsDigit(c))
				{
					if (num2 < 0)
					{
						num2 = (int)(c - '0');
					}
					else
					{
						num2 = num2 * 10 + (int)(c - '0');
					}
				}
				else if (num2 >= 0)
				{
					switch (num)
					{
					case 1:
						major = num2;
						break;
					case 2:
						minor = num2;
						break;
					case 3:
						build = num2;
						break;
					case 4:
						revision = num2;
						break;
					}
					num2 = -1;
					num++;
				}
				if (num == 5)
				{
					break;
				}
			}
			if (num2 >= 0)
			{
				switch (num)
				{
				case 1:
					major = num2;
					break;
				case 2:
					minor = num2;
					break;
				case 3:
					build = num2;
					break;
				case 4:
					revision = num2;
					break;
				}
			}
			return new Version(major, minor, build, revision);
		}

		/// <summary>Gets current stack trace information.</summary>
		/// <returns>A string containing stack trace information. This value can be <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003CA3C File Offset: 0x0003AC3C
		public static string StackTrace
		{
			get
			{
				return new StackTrace(0, true).ToString();
			}
		}

		/// <summary>Gets the number of milliseconds elapsed since the system started.</summary>
		/// <returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started. </returns>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000E52 RID: 3666
		public static extern int TickCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		/// <summary>Gets the network domain name associated with the current user.</summary>
		/// <returns>The network domain name associated with the current user.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The operating system does not support retrieving the network domain name.</exception>
		/// <exception cref="T:System.InvalidOperationException">The network domain name cannot be retrieved.</exception>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003CA4A File Offset: 0x0003AC4A
		public static string UserDomainName
		{
			get
			{
				return Environment.MachineName;
			}
		}

		/// <summary>Gets the user name of the person who is currently logged on to the Windows operating system.</summary>
		/// <returns>The user name of the person who is logged on to Windows.</returns>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000E54 RID: 3668
		public static extern string UserName { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E55 RID: 3669
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string internalGetEnvironmentVariable_native(IntPtr variable);

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003CA54 File Offset: 0x0003AC54
		internal static string internalGetEnvironmentVariable(string variable)
		{
			if (variable == null)
			{
				return null;
			}
			string result;
			using (SafeStringMarshal safeStringMarshal = RuntimeMarshal.MarshalString(variable))
			{
				result = Environment.internalGetEnvironmentVariable_native(safeStringMarshal.Value);
			}
			return result;
		}

		/// <summary>Retrieves the value of an environment variable from the current process. </summary>
		/// <param name="variable">The name of the environment variable.</param>
		/// <returns>The value of the environment variable specified by <paramref name="variable" />, or <see langword="null" /> if the environment variable is not found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="variable" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation. </exception>
		// Token: 0x06000E57 RID: 3671 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		public static string GetEnvironmentVariable(string variable)
		{
			return Environment.internalGetEnvironmentVariable(variable);
		}

		/// <summary>Gets the path to the system special folder that is identified by the specified enumeration.</summary>
		/// <param name="folder">An enumerated constant that identifies a system special folder.</param>
		/// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current platform is not supported.</exception>
		// Token: 0x06000E58 RID: 3672 RVA: 0x0003CAA4 File Offset: 0x0003ACA4
		public static string GetFolderPath(Environment.SpecialFolder folder)
		{
			return Environment.GetFolderPath(folder, Environment.SpecialFolderOption.None);
		}

		/// <summary>Gets the path to the system special folder that is identified by the specified enumeration, and uses a specified option for accessing special folders.</summary>
		/// <param name="folder">An enumerated constant that identifies a system special folder.</param>
		/// <param name="option">Specifies options to use for accessing a special folder.</param>
		/// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" /></exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///         <see cref="T:System.PlatformNotSupportedException" />
		///       </exception>
		// Token: 0x06000E59 RID: 3673 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
		public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			SecurityManager.EnsureElevatedPermissions();
			return Environment.UnixGetFolderPath(folder, option);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0003CAD0 File Offset: 0x0003ACD0
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			string text = Environment.internalGetEnvironmentVariable(key);
			if (text != null && text != string.Empty)
			{
				return text;
			}
			string path = Path.Combine(config_dir, "user-dirs.dirs");
			if (!File.Exists(path))
			{
				return Path.Combine(home_dir, fallback);
			}
			try
			{
				using (StreamReader streamReader = new StreamReader(path))
				{
					string text2;
					while ((text2 = streamReader.ReadLine()) != null)
					{
						text2 = text2.Trim();
						int num = text2.IndexOf('=');
						if (num > 8 && text2.Substring(0, num) == key)
						{
							string text3 = text2.Substring(num + 1).Trim('"');
							bool flag = false;
							if (text3.StartsWithOrdinalUnchecked("$HOME/"))
							{
								flag = true;
								text3 = text3.Substring(6);
							}
							else if (!text3.StartsWithOrdinalUnchecked("/"))
							{
								flag = true;
							}
							return flag ? Path.Combine(home_dir, text3) : text3;
						}
					}
				}
			}
			catch (FileNotFoundException)
			{
			}
			return Path.Combine(home_dir, fallback);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0003CBE0 File Offset: 0x0003ADE0
		internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			string text = Environment.internalGetHome();
			string text2 = Environment.internalGetEnvironmentVariable("XDG_DATA_HOME");
			if (text2 == null || text2 == string.Empty)
			{
				text2 = Path.Combine(text, ".local");
				text2 = Path.Combine(text2, "share");
			}
			string text3 = Environment.internalGetEnvironmentVariable("XDG_CONFIG_HOME");
			if (text3 == null || text3 == string.Empty)
			{
				text3 = Path.Combine(text, ".config");
			}
			switch (folder)
			{
			case Environment.SpecialFolder.Desktop:
			case Environment.SpecialFolder.DesktopDirectory:
				return Environment.ReadXdgUserDir(text3, text, "XDG_DESKTOP_DIR", "Desktop");
			case Environment.SpecialFolder.Programs:
			case Environment.SpecialFolder.Startup:
			case Environment.SpecialFolder.Recent:
			case Environment.SpecialFolder.SendTo:
			case Environment.SpecialFolder.StartMenu:
			case Environment.SpecialFolder.NetworkShortcuts:
			case Environment.SpecialFolder.CommonStartMenu:
			case Environment.SpecialFolder.CommonPrograms:
			case Environment.SpecialFolder.CommonStartup:
			case Environment.SpecialFolder.CommonDesktopDirectory:
			case Environment.SpecialFolder.PrinterShortcuts:
			case Environment.SpecialFolder.Cookies:
			case Environment.SpecialFolder.History:
			case Environment.SpecialFolder.Windows:
			case Environment.SpecialFolder.System:
			case Environment.SpecialFolder.SystemX86:
			case Environment.SpecialFolder.ProgramFilesX86:
			case Environment.SpecialFolder.CommonProgramFiles:
			case Environment.SpecialFolder.CommonProgramFilesX86:
			case Environment.SpecialFolder.CommonDocuments:
			case Environment.SpecialFolder.CommonAdminTools:
			case Environment.SpecialFolder.AdminTools:
			case Environment.SpecialFolder.CommonMusic:
			case Environment.SpecialFolder.CommonPictures:
			case Environment.SpecialFolder.CommonVideos:
			case Environment.SpecialFolder.Resources:
			case Environment.SpecialFolder.LocalizedResources:
			case Environment.SpecialFolder.CommonOemLinks:
			case Environment.SpecialFolder.CDBurning:
				return string.Empty;
			case Environment.SpecialFolder.MyDocuments:
				return text;
			case Environment.SpecialFolder.Favorites:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return Path.Combine(text, "Library", "Favorites");
				}
				return string.Empty;
			case Environment.SpecialFolder.MyMusic:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return Path.Combine(text, "Music");
				}
				return Environment.ReadXdgUserDir(text3, text, "XDG_MUSIC_DIR", "Music");
			case Environment.SpecialFolder.MyVideos:
				return Environment.ReadXdgUserDir(text3, text, "XDG_VIDEOS_DIR", "Videos");
			case Environment.SpecialFolder.MyComputer:
				return string.Empty;
			case Environment.SpecialFolder.Fonts:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return Path.Combine(text, "Library", "Fonts");
				}
				return Path.Combine(text, ".fonts");
			case Environment.SpecialFolder.Templates:
				return Environment.ReadXdgUserDir(text3, text, "XDG_TEMPLATES_DIR", "Templates");
			case Environment.SpecialFolder.ApplicationData:
				return text3;
			case Environment.SpecialFolder.LocalApplicationData:
				return text2;
			case Environment.SpecialFolder.InternetCache:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return Path.Combine(text, "Library", "Caches");
				}
				return string.Empty;
			case Environment.SpecialFolder.CommonApplicationData:
				return "/usr/share";
			case Environment.SpecialFolder.ProgramFiles:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return "/Applications";
				}
				return string.Empty;
			case Environment.SpecialFolder.MyPictures:
				if (Environment.Platform == PlatformID.MacOSX)
				{
					return Path.Combine(text, "Pictures");
				}
				return Environment.ReadXdgUserDir(text3, text, "XDG_PICTURES_DIR", "Pictures");
			case Environment.SpecialFolder.UserProfile:
				return text;
			case Environment.SpecialFolder.CommonTemplates:
				return "/usr/share/templates";
			}
			throw new ArgumentException("Invalid SpecialFolder");
		}

		/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary>
		/// <param name="message">A message that explains why the process was terminated, or <see langword="null" /> if no explanation is provided.</param>
		/// <param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a <see langword="catch" /> block.</param>
		// Token: 0x06000E5C RID: 3676 RVA: 0x0003CE6B File Offset: 0x0003B06B
		[SecurityCritical]
		public static void FailFast(string message, Exception exception)
		{
			Environment.FailFast(message, exception, null);
		}

		// Token: 0x06000E5D RID: 3677
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FailFast(string message, Exception exception, string errorSource);

		/// <summary>Gets the number of processors on the current machine.</summary>
		/// <returns>The 32-bit signed integer that specifies the number of processors on the current machine. There is no default. If the current machine contains multiple processor groups, this property returns the number of logical processors that are available for use by the common language runtime (CLR).</returns>
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000E5E RID: 3678
		public static extern int ProcessorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E5F RID: 3679
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string GetMachineConfigPath();

		// Token: 0x06000E60 RID: 3680
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string internalGetHome();

		// Token: 0x06000E61 RID: 3681
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetPageSize();

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003CE78 File Offset: 0x0003B078
		internal static bool IsUnix
		{
			get
			{
				int platform = (int)Environment.Platform;
				return platform == 4 || platform == 128 || platform == 6;
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003CEA0 File Offset: 0x0003B0A0
		internal static string GetStackTrace(Exception e, bool needFileInfo)
		{
			StackTrace stackTrace;
			if (e == null)
			{
				stackTrace = new StackTrace(needFileInfo);
			}
			else
			{
				stackTrace = new StackTrace(e, needFileInfo);
			}
			return stackTrace.ToString(System.Diagnostics.StackTrace.TraceFormat.Normal);
		}

		// Token: 0x0400051D RID: 1309
		private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

		// Token: 0x0400051E RID: 1310
		private static string nl;

		// Token: 0x0400051F RID: 1311
		private static OperatingSystem os;

		/// <summary>Specifies enumerated constants used to retrieve directory paths to system special folders.</summary>
		// Token: 0x02000163 RID: 355
		[ComVisible(true)]
		public enum SpecialFolder
		{
			/// <summary>The My Documents folder.</summary>
			// Token: 0x04000521 RID: 1313
			MyDocuments = 5,
			/// <summary>The logical Desktop rather than the physical file system location.</summary>
			// Token: 0x04000522 RID: 1314
			Desktop = 0,
			/// <summary>The My Computer folder. </summary>
			// Token: 0x04000523 RID: 1315
			MyComputer = 17,
			/// <summary>The directory that contains the user's program groups.</summary>
			// Token: 0x04000524 RID: 1316
			Programs = 2,
			/// <summary>The directory that serves as a common repository for documents.</summary>
			// Token: 0x04000525 RID: 1317
			Personal = 5,
			/// <summary>The directory that serves as a common repository for the user's favorite items.</summary>
			// Token: 0x04000526 RID: 1318
			Favorites,
			/// <summary>The directory that corresponds to the user's Startup program group.</summary>
			// Token: 0x04000527 RID: 1319
			Startup,
			/// <summary>The directory that contains the user's most recently used documents.</summary>
			// Token: 0x04000528 RID: 1320
			Recent,
			/// <summary>The directory that contains the Send To menu items.</summary>
			// Token: 0x04000529 RID: 1321
			SendTo,
			/// <summary>The directory that contains the Start menu items.</summary>
			// Token: 0x0400052A RID: 1322
			StartMenu = 11,
			/// <summary>The My Music folder.</summary>
			// Token: 0x0400052B RID: 1323
			MyMusic = 13,
			/// <summary>The directory used to physically store file objects on the desktop.</summary>
			// Token: 0x0400052C RID: 1324
			DesktopDirectory = 16,
			/// <summary>The directory that serves as a common repository for document templates.</summary>
			// Token: 0x0400052D RID: 1325
			Templates = 21,
			/// <summary>The directory that serves as a common repository for application-specific data for the current roaming user.</summary>
			// Token: 0x0400052E RID: 1326
			ApplicationData = 26,
			/// <summary>The directory that serves as a common repository for application-specific data that is used by the current, non-roaming user.</summary>
			// Token: 0x0400052F RID: 1327
			LocalApplicationData = 28,
			/// <summary>The directory that serves as a common repository for temporary Internet files.</summary>
			// Token: 0x04000530 RID: 1328
			InternetCache = 32,
			/// <summary>The directory that serves as a common repository for Internet cookies.</summary>
			// Token: 0x04000531 RID: 1329
			Cookies,
			/// <summary>The directory that serves as a common repository for Internet history items.</summary>
			// Token: 0x04000532 RID: 1330
			History,
			/// <summary>The directory that serves as a common repository for application-specific data that is used by all users.</summary>
			// Token: 0x04000533 RID: 1331
			CommonApplicationData,
			/// <summary>The System directory.</summary>
			// Token: 0x04000534 RID: 1332
			System = 37,
			/// <summary>The program files directory.On a non-x86 system, passing <see cref="F:System.Environment.SpecialFolder.ProgramFiles" /> to the <see cref="M:System.Environment.GetFolderPath(System.Environment.SpecialFolder)" /> method returns the path for non-x86 programs. To get the x86 program files directory on a non-x86 system, use the <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" /> member. </summary>
			// Token: 0x04000535 RID: 1333
			ProgramFiles,
			/// <summary>The My Pictures folder.</summary>
			// Token: 0x04000536 RID: 1334
			MyPictures,
			/// <summary>The directory for components that are shared across applications.To get the x86 common program files directory on a non-x86 system, use the <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" /> member. </summary>
			// Token: 0x04000537 RID: 1335
			CommonProgramFiles = 43,
			/// <summary>The file system directory that serves as a repository for videos that belong to a user.  Added in the .NET Framework 4. </summary>
			// Token: 0x04000538 RID: 1336
			MyVideos = 14,
			/// <summary>A file system directory that contains the link objects that may exist in the My Network Places virtual folder. Added in the .NET Framework 4. </summary>
			// Token: 0x04000539 RID: 1337
			NetworkShortcuts = 19,
			/// <summary>A virtual folder that contains fonts. Added in the .NET Framework 4. </summary>
			// Token: 0x0400053A RID: 1338
			Fonts,
			/// <summary>The file system directory that contains the programs and folders that appear on the Start menu for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4. </summary>
			// Token: 0x0400053B RID: 1339
			CommonStartMenu = 22,
			/// <summary>A folder for components that are shared across applications. This special folder is valid only for Windows NT, Windows 2000, and Windows XP systems. Added in the .NET Framework 4. </summary>
			// Token: 0x0400053C RID: 1340
			CommonPrograms,
			/// <summary>The file system directory that contains the programs that appear in the Startup folder for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4.</summary>
			// Token: 0x0400053D RID: 1341
			CommonStartup,
			/// <summary>The file system directory that contains files and folders that appear on the desktop for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4. </summary>
			// Token: 0x0400053E RID: 1342
			CommonDesktopDirectory,
			/// <summary>The file system directory that contains the link objects that can exist in the Printers virtual folder. Added in the .NET Framework 4. </summary>
			// Token: 0x0400053F RID: 1343
			PrinterShortcuts = 27,
			/// <summary>The Windows directory or SYSROOT. This corresponds to the %windir% or %SYSTEMROOT% environment variables. Added in the .NET Framework 4. </summary>
			// Token: 0x04000540 RID: 1344
			Windows = 36,
			/// <summary>The user's profile folder. Applications should not create files or folders at this level; they should put their data under the locations referred to by <see cref="F:System.Environment.SpecialFolder.ApplicationData" />. Added in the .NET Framework 4. </summary>
			// Token: 0x04000541 RID: 1345
			UserProfile = 40,
			/// <summary>The Windows System folder. Added in the .NET Framework 4. </summary>
			// Token: 0x04000542 RID: 1346
			SystemX86,
			/// <summary>The x86 Program Files folder. Added in the .NET Framework 4. </summary>
			// Token: 0x04000543 RID: 1347
			ProgramFilesX86,
			/// <summary>The Program Files folder. Added in the .NET Framework 4. </summary>
			// Token: 0x04000544 RID: 1348
			CommonProgramFilesX86 = 44,
			/// <summary>The file system directory that contains the templates that are available to all users. This special folder is valid only for Windows NT systems.  Added in the .NET Framework 4. </summary>
			// Token: 0x04000545 RID: 1349
			CommonTemplates,
			/// <summary>The file system directory that contains documents that are common to all users. This special folder is valid for Windows NT systems, Windows 95, and Windows 98 systems with Shfolder.dll installed. Added in the .NET Framework 4. </summary>
			// Token: 0x04000546 RID: 1350
			CommonDocuments,
			/// <summary>The file system directory that contains administrative tools for all users of the computer. Added in the .NET Framework 4. </summary>
			// Token: 0x04000547 RID: 1351
			CommonAdminTools,
			/// <summary>The file system directory that is used to store administrative tools for an individual user. The Microsoft Management Console (MMC) will save customized consoles to this directory, and it will roam with the user. Added in the .NET Framework 4.</summary>
			// Token: 0x04000548 RID: 1352
			AdminTools,
			/// <summary>The file system directory that serves as a repository for music files common to all users. Added in the .NET Framework 4. </summary>
			// Token: 0x04000549 RID: 1353
			CommonMusic = 53,
			/// <summary>The file system directory that serves as a repository for image files common to all users. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054A RID: 1354
			CommonPictures,
			/// <summary>The file system directory that serves as a repository for video files common to all users. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054B RID: 1355
			CommonVideos,
			/// <summary>The file system directory that contains resource data. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054C RID: 1356
			Resources,
			/// <summary>The file system directory that contains localized resource data. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054D RID: 1357
			LocalizedResources,
			/// <summary>This value is recognized in Windows Vista for backward compatibility, but the special folder itself is no longer used. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054E RID: 1358
			CommonOemLinks,
			/// <summary>The file system directory that acts as a staging area for files waiting to be written to a CD. Added in the .NET Framework 4. </summary>
			// Token: 0x0400054F RID: 1359
			CDBurning
		}

		/// <summary>Specifies options to use for getting the path to a special folder. </summary>
		// Token: 0x02000164 RID: 356
		public enum SpecialFolderOption
		{
			/// <summary>The path to the folder is verified. If the folder exists, the path is returned. If the folder does not exist, an empty string is returned. This is the default behavior. </summary>
			// Token: 0x04000551 RID: 1361
			None,
			/// <summary>The path to the folder is returned without verifying whether the path exists. If the folder is located on a network, specifying this option can reduce lag time. </summary>
			// Token: 0x04000552 RID: 1362
			DoNotVerify = 16384,
			/// <summary>The path to the folder is created if it does not already exist.</summary>
			// Token: 0x04000553 RID: 1363
			Create = 32768
		}
	}
}

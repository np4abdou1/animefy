using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using Mono.Security;

namespace System
{
	/// <summary>Represents assembly binding information that can be added to an instance of <see cref="T:System.AppDomain" />.</summary>
	// Token: 0x02000169 RID: 361
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public sealed class AppDomainSetup
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainSetup" /> class.</summary>
		// Token: 0x06000E6D RID: 3693 RVA: 0x00003ACD File Offset: 0x00001CCD
		public AppDomainSetup()
		{
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0003CF5C File Offset: 0x0003B15C
		internal AppDomainSetup(AppDomainSetup setup)
		{
			this.application_base = setup.application_base;
			this.application_name = setup.application_name;
			this.cache_path = setup.cache_path;
			this.configuration_file = setup.configuration_file;
			this.dynamic_base = setup.dynamic_base;
			this.license_file = setup.license_file;
			this.private_bin_path = setup.private_bin_path;
			this.private_bin_path_probe = setup.private_bin_path_probe;
			this.shadow_copy_directories = setup.shadow_copy_directories;
			this.shadow_copy_files = setup.shadow_copy_files;
			this.publisher_policy = setup.publisher_policy;
			this.path_changed = setup.path_changed;
			this.loader_optimization = setup.loader_optimization;
			this.disallow_binding_redirects = setup.disallow_binding_redirects;
			this.disallow_code_downloads = setup.disallow_code_downloads;
			this._activationArguments = setup._activationArguments;
			this.domain_initializer = setup.domain_initializer;
			this.application_trust = setup.application_trust;
			this.domain_initializer_args = setup.domain_initializer_args;
			this.disallow_appbase_probe = setup.disallow_appbase_probe;
			this.configuration_bytes = setup.configuration_bytes;
			this.manager_assembly = setup.manager_assembly;
			this.manager_type = setup.manager_type;
			this.partial_visible_assemblies = setup.partial_visible_assemblies;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003D090 File Offset: 0x0003B290
		private static string GetAppBase(string appBase)
		{
			if (appBase == null)
			{
				return null;
			}
			if (appBase.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
			{
				appBase = new Uri(appBase).LocalPath;
				if (Path.DirectorySeparatorChar != '/')
				{
					appBase = appBase.Replace('/', Path.DirectorySeparatorChar);
				}
			}
			appBase = Path.GetFullPath(appBase);
			if (Path.DirectorySeparatorChar != '/')
			{
				bool flag = appBase.StartsWith("\\\\?\\", StringComparison.Ordinal);
				if (appBase.IndexOf(':', flag ? 6 : 2) != -1)
				{
					throw new NotSupportedException("The given path's format is not supported.");
				}
			}
			string directoryName = Path.GetDirectoryName(appBase);
			if (directoryName != null && directoryName.LastIndexOfAny(Path.GetInvalidPathChars()) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid path characters in path: '{0}'"), appBase), "appBase");
			}
			string fileName = Path.GetFileName(appBase);
			if (fileName != null && fileName.LastIndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid filename characters in path: '{0}'"), appBase), "appBase");
			}
			return appBase;
		}

		/// <summary>Gets or sets the name of the directory containing the application.</summary>
		/// <returns>The name of the application base directory.</returns>
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003D177 File Offset: 0x0003B377
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0003D184 File Offset: 0x0003B384
		public string ApplicationBase
		{
			get
			{
				return AppDomainSetup.GetAppBase(this.application_base);
			}
			set
			{
				this.application_base = value;
			}
		}

		/// <summary>Gets or sets the name of the configuration file for an application domain.</summary>
		/// <returns>The name of the configuration file.</returns>
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003D190 File Offset: 0x0003B390
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x0003D1DF File Offset: 0x0003B3DF
		public string ConfigurationFile
		{
			get
			{
				if (this.configuration_file == null)
				{
					return null;
				}
				if (Path.IsPathRooted(this.configuration_file))
				{
					return this.configuration_file;
				}
				if (this.ApplicationBase == null)
				{
					throw new MemberAccessException("The ApplicationBase must be set before retrieving this property.");
				}
				return Path.Combine(this.ApplicationBase, this.configuration_file);
			}
			set
			{
				this.configuration_file = value;
			}
		}

		/// <summary>Gets or sets the list of directories under the application base directory that are probed for private assemblies.</summary>
		/// <returns>A list of directory names separated by semicolons.</returns>
		// Token: 0x1700014F RID: 335
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		public string PrivateBinPath
		{
			set
			{
				this.private_bin_path = value;
				this.path_changed = true;
			}
		}

		/// <summary>Gets or sets the names of the directories containing assemblies to be shadow copied.</summary>
		/// <returns>A list of directory names separated by semicolons.</returns>
		// Token: 0x17000150 RID: 336
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x0003D1F8 File Offset: 0x0003B3F8
		public string ShadowCopyDirectories
		{
			set
			{
				this.shadow_copy_directories = value;
			}
		}

		/// <summary>Gets or sets a string that indicates whether shadow copying is turned on or off.</summary>
		/// <returns>The string value "true" to indicate that shadow copying is turned on; or "false" to indicate that shadow copying is turned off.</returns>
		// Token: 0x17000151 RID: 337
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x0003D201 File Offset: 0x0003B401
		public string ShadowCopyFiles
		{
			set
			{
				this.shadow_copy_files = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.AppDomainInitializer" /> delegate, which represents a callback method that is invoked when the application domain is initialized.</summary>
		/// <returns>A delegate that represents a callback method that is invoked when the application domain is initialized.</returns>
		// Token: 0x17000152 RID: 338
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0003D20A File Offset: 0x0003B40A
		public AppDomainInitializer AppDomainInitializer
		{
			set
			{
				this.domain_initializer = value;
			}
		}

		/// <summary>Gets or sets the arguments passed to the callback method represented by the <see cref="T:System.AppDomainInitializer" /> delegate. The callback method is invoked when the application domain is initialized.</summary>
		/// <returns>An array of strings that is passed to the callback method represented by the <see cref="T:System.AppDomainInitializer" /> delegate, when the callback method is invoked during <see cref="T:System.AppDomain" /> initialization.</returns>
		// Token: 0x17000153 RID: 339
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x0003D213 File Offset: 0x0003B413
		public string[] AppDomainInitializerArguments
		{
			set
			{
				this.domain_initializer_args = value;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0003D21C File Offset: 0x0003B41C
		internal void SerializeNonPrimitives()
		{
			object[] graph = new object[]
			{
				this._activationArguments,
				this.domain_initializer,
				this.application_trust
			};
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, graph);
			this.serialized_non_primitives = memoryStream.ToArray();
		}

		// Token: 0x04000558 RID: 1368
		private string application_base;

		// Token: 0x04000559 RID: 1369
		private string application_name;

		// Token: 0x0400055A RID: 1370
		private string cache_path;

		// Token: 0x0400055B RID: 1371
		private string configuration_file;

		// Token: 0x0400055C RID: 1372
		private string dynamic_base;

		// Token: 0x0400055D RID: 1373
		private string license_file;

		// Token: 0x0400055E RID: 1374
		private string private_bin_path;

		// Token: 0x0400055F RID: 1375
		private string private_bin_path_probe;

		// Token: 0x04000560 RID: 1376
		private string shadow_copy_directories;

		// Token: 0x04000561 RID: 1377
		private string shadow_copy_files;

		// Token: 0x04000562 RID: 1378
		private bool publisher_policy;

		// Token: 0x04000563 RID: 1379
		private bool path_changed;

		// Token: 0x04000564 RID: 1380
		private int loader_optimization;

		// Token: 0x04000565 RID: 1381
		private bool disallow_binding_redirects;

		// Token: 0x04000566 RID: 1382
		private bool disallow_code_downloads;

		// Token: 0x04000567 RID: 1383
		private object _activationArguments;

		// Token: 0x04000568 RID: 1384
		private object domain_initializer;

		// Token: 0x04000569 RID: 1385
		private object application_trust;

		// Token: 0x0400056A RID: 1386
		private string[] domain_initializer_args;

		// Token: 0x0400056B RID: 1387
		private bool disallow_appbase_probe;

		// Token: 0x0400056C RID: 1388
		private byte[] configuration_bytes;

		// Token: 0x0400056D RID: 1389
		private byte[] serialized_non_primitives;

		// Token: 0x0400056E RID: 1390
		private string manager_assembly;

		// Token: 0x0400056F RID: 1391
		private string manager_type;

		// Token: 0x04000570 RID: 1392
		private string[] partial_visible_assemblies;
	}
}

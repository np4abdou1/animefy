using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using Mono.Xml;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004A RID: 74
	internal class KeyPairPersistence
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00009B00 File Offset: 0x00007D00
		public KeyPairPersistence(CspParameters parameters) : this(parameters, null)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009B0A File Offset: 0x00007D0A
		public KeyPairPersistence(CspParameters parameters, string keyPair)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			this._params = this.Copy(parameters);
			this._keyvalue = keyPair;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00009B34 File Offset: 0x00007D34
		public string Filename
		{
			get
			{
				if (this._filename == null)
				{
					this._filename = string.Format(CultureInfo.InvariantCulture, "[{0}][{1}][{2}].xml", this._params.ProviderType, this.ContainerName, this._params.KeyNumber);
					if (this.UseMachineKeyStore)
					{
						this._filename = Path.Combine(KeyPairPersistence.MachinePath, this._filename);
					}
					else
					{
						this._filename = Path.Combine(KeyPairPersistence.UserPath, this._filename);
					}
				}
				return this._filename;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00009BC0 File Offset: 0x00007DC0
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00009BC8 File Offset: 0x00007DC8
		public string KeyValue
		{
			get
			{
				return this._keyvalue;
			}
			set
			{
				if (this.CanChange)
				{
					this._keyvalue = value;
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00009BDC File Offset: 0x00007DDC
		public bool Load()
		{
			bool flag = File.Exists(this.Filename);
			if (flag)
			{
				using (StreamReader streamReader = File.OpenText(this.Filename))
				{
					this.FromXml(streamReader.ReadToEnd());
				}
			}
			return flag;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009C30 File Offset: 0x00007E30
		public void Save()
		{
			using (FileStream fileStream = File.Open(this.Filename, FileMode.Create))
			{
				StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
				streamWriter.Write(this.ToXml());
				streamWriter.Close();
			}
			if (this.UseMachineKeyStore)
			{
				KeyPairPersistence.ProtectMachine(this.Filename);
				return;
			}
			KeyPairPersistence.ProtectUser(this.Filename);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009CA4 File Offset: 0x00007EA4
		public void Remove()
		{
			File.Delete(this.Filename);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00009CB4 File Offset: 0x00007EB4
		private static string UserPath
		{
			get
			{
				object obj = KeyPairPersistence.lockobj;
				lock (obj)
				{
					if (KeyPairPersistence._userPath == null || !KeyPairPersistence._userPathExists)
					{
						KeyPairPersistence._userPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".mono");
						KeyPairPersistence._userPath = Path.Combine(KeyPairPersistence._userPath, "keypairs");
						KeyPairPersistence._userPathExists = Directory.Exists(KeyPairPersistence._userPath);
						if (!KeyPairPersistence._userPathExists)
						{
							try
							{
								Directory.CreateDirectory(KeyPairPersistence._userPath);
							}
							catch (Exception inner)
							{
								throw new CryptographicException(string.Format(Locale.GetText("Could not create user key store '{0}'."), KeyPairPersistence._userPath), inner);
							}
							KeyPairPersistence._userPathExists = true;
						}
					}
					if (!KeyPairPersistence.IsUserProtected(KeyPairPersistence._userPath) && !KeyPairPersistence.ProtectUser(KeyPairPersistence._userPath))
					{
						throw new IOException(string.Format(Locale.GetText("Could not secure user key store '{0}'."), KeyPairPersistence._userPath));
					}
				}
				if (!KeyPairPersistence.IsUserProtected(KeyPairPersistence._userPath))
				{
					throw new CryptographicException(string.Format(Locale.GetText("Improperly protected user's key pairs in '{0}'."), KeyPairPersistence._userPath));
				}
				return KeyPairPersistence._userPath;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00009DD4 File Offset: 0x00007FD4
		private static string MachinePath
		{
			get
			{
				object obj = KeyPairPersistence.lockobj;
				lock (obj)
				{
					if (KeyPairPersistence._machinePath == null || !KeyPairPersistence._machinePathExists)
					{
						KeyPairPersistence._machinePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), ".mono");
						KeyPairPersistence._machinePath = Path.Combine(KeyPairPersistence._machinePath, "keypairs");
						KeyPairPersistence._machinePathExists = Directory.Exists(KeyPairPersistence._machinePath);
						if (!KeyPairPersistence._machinePathExists)
						{
							try
							{
								Directory.CreateDirectory(KeyPairPersistence._machinePath);
							}
							catch (Exception inner)
							{
								throw new CryptographicException(string.Format(Locale.GetText("Could not create machine key store '{0}'."), KeyPairPersistence._machinePath), inner);
							}
							KeyPairPersistence._machinePathExists = true;
						}
					}
					if (!KeyPairPersistence.IsMachineProtected(KeyPairPersistence._machinePath) && !KeyPairPersistence.ProtectMachine(KeyPairPersistence._machinePath))
					{
						throw new IOException(string.Format(Locale.GetText("Could not secure machine key store '{0}'."), KeyPairPersistence._machinePath));
					}
				}
				if (!KeyPairPersistence.IsMachineProtected(KeyPairPersistence._machinePath))
				{
					throw new CryptographicException(string.Format(Locale.GetText("Improperly protected machine's key pairs in '{0}'."), KeyPairPersistence._machinePath));
				}
				return KeyPairPersistence._machinePath;
			}
		}

		// Token: 0x06000159 RID: 345
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool _CanSecure(char* root);

		// Token: 0x0600015A RID: 346
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool _ProtectUser(char* path);

		// Token: 0x0600015B RID: 347
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool _ProtectMachine(char* path);

		// Token: 0x0600015C RID: 348
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool _IsUserProtected(char* path);

		// Token: 0x0600015D RID: 349
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool _IsMachineProtected(char* path);

		// Token: 0x0600015E RID: 350 RVA: 0x00009EF4 File Offset: 0x000080F4
		private unsafe static bool CanSecure(string path)
		{
			int platform = (int)Environment.OSVersion.Platform;
			if (platform == 4 || platform == 128 || platform == 6)
			{
				return true;
			}
			char* ptr = path;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return KeyPairPersistence._CanSecure(ptr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00009F34 File Offset: 0x00008134
		private unsafe static bool ProtectUser(string path)
		{
			if (KeyPairPersistence.CanSecure(path))
			{
				char* ptr = path;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				return KeyPairPersistence._ProtectUser(ptr);
			}
			return true;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00009F64 File Offset: 0x00008164
		private unsafe static bool ProtectMachine(string path)
		{
			if (KeyPairPersistence.CanSecure(path))
			{
				char* ptr = path;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				return KeyPairPersistence._ProtectMachine(ptr);
			}
			return true;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009F94 File Offset: 0x00008194
		private unsafe static bool IsUserProtected(string path)
		{
			if (KeyPairPersistence.CanSecure(path))
			{
				char* ptr = path;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				return KeyPairPersistence._IsUserProtected(ptr);
			}
			return true;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009FC4 File Offset: 0x000081C4
		private unsafe static bool IsMachineProtected(string path)
		{
			if (KeyPairPersistence.CanSecure(path))
			{
				char* ptr = path;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				return KeyPairPersistence._IsMachineProtected(ptr);
			}
			return true;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00009FF1 File Offset: 0x000081F1
		private bool CanChange
		{
			get
			{
				return this._keyvalue == null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00009FFC File Offset: 0x000081FC
		private bool UseDefaultKeyContainer
		{
			get
			{
				return (this._params.Flags & CspProviderFlags.UseDefaultKeyContainer) == CspProviderFlags.UseDefaultKeyContainer;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000A00E File Offset: 0x0000820E
		private bool UseMachineKeyStore
		{
			get
			{
				return (this._params.Flags & CspProviderFlags.UseMachineKeyStore) == CspProviderFlags.UseMachineKeyStore;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000A020 File Offset: 0x00008220
		private string ContainerName
		{
			get
			{
				if (this._container == null)
				{
					if (this.UseDefaultKeyContainer)
					{
						this._container = "default";
					}
					else if (this._params.KeyContainerName == null || this._params.KeyContainerName.Length == 0)
					{
						this._container = Guid.NewGuid().ToString();
					}
					else
					{
						byte[] bytes = Encoding.UTF8.GetBytes(this._params.KeyContainerName);
						byte[] b = MD5.Create().ComputeHash(bytes);
						this._container = new Guid(b).ToString();
					}
				}
				return this._container;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000A0C9 File Offset: 0x000082C9
		private CspParameters Copy(CspParameters p)
		{
			return new CspParameters(p.ProviderType, p.ProviderName, p.KeyContainerName)
			{
				KeyNumber = p.KeyNumber,
				Flags = p.Flags
			};
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000A0FC File Offset: 0x000082FC
		private void FromXml(string xml)
		{
			SecurityParser securityParser = new SecurityParser();
			securityParser.LoadXml(xml);
			SecurityElement securityElement = securityParser.ToXml();
			if (securityElement.Tag == "KeyPair")
			{
				SecurityElement securityElement2 = securityElement.SearchForChildByTag("KeyValue");
				if (securityElement2.Children.Count > 0)
				{
					this._keyvalue = securityElement2.Children[0].ToString();
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000A160 File Offset: 0x00008360
		private string ToXml()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("<KeyPair>{0}\t<Properties>{0}\t\t<Provider ", Environment.NewLine);
			if (this._params.ProviderName != null && this._params.ProviderName.Length != 0)
			{
				stringBuilder.AppendFormat("Name=\"{0}\" ", this._params.ProviderName);
			}
			stringBuilder.AppendFormat("Type=\"{0}\" />{1}\t\t<Container ", this._params.ProviderType, Environment.NewLine);
			stringBuilder.AppendFormat("Name=\"{0}\" />{1}\t</Properties>{1}\t<KeyValue", this.ContainerName, Environment.NewLine);
			if (this._params.KeyNumber != -1)
			{
				stringBuilder.AppendFormat(" Id=\"{0}\" ", this._params.KeyNumber);
			}
			stringBuilder.AppendFormat(">{1}\t\t{0}{1}\t</KeyValue>{1}</KeyPair>{1}", this.KeyValue, Environment.NewLine);
			return stringBuilder.ToString();
		}

		// Token: 0x04000167 RID: 359
		private static bool _userPathExists;

		// Token: 0x04000168 RID: 360
		private static string _userPath;

		// Token: 0x04000169 RID: 361
		private static bool _machinePathExists;

		// Token: 0x0400016A RID: 362
		private static string _machinePath;

		// Token: 0x0400016B RID: 363
		private CspParameters _params;

		// Token: 0x0400016C RID: 364
		private string _keyvalue;

		// Token: 0x0400016D RID: 365
		private string _filename;

		// Token: 0x0400016E RID: 366
		private string _container;

		// Token: 0x0400016F RID: 367
		private static object lockobj = new object();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x020004D5 RID: 1237
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Assembly))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeAssembly : Assembly
	{
		// Token: 0x06002304 RID: 8964 RVA: 0x0008CEEC File Offset: 0x0008B0EC
		protected RuntimeAssembly()
		{
			this.resolve_event_holder = new Assembly.ResolveEventHolder();
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0008CEFF File Offset: 0x0008B0FF
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, 6, this.FullName, this);
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0008CF1D File Offset: 0x0008B11D
		internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			return (RuntimeAssembly)Assembly.LoadWithPartialName(partialName, securityEvidence);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0008CF2B File Offset: 0x0008B12B
		internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			return RuntimeAssembly.LoadWithPartialNameInternal(an.ToString(), securityEvidence, ref stackMark);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0008CF3A File Offset: 0x0008B13A
		public override AssemblyName GetName(bool copiedName)
		{
			return AssemblyName.Create(this, true);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0008CF43 File Offset: 0x0008B143
		public override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			if (name == null)
			{
				throw new ArgumentNullException(name);
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("name", "Name cannot be empty");
			}
			return base.InternalGetType(null, name, throwOnError, ignoreCase);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0008CF74 File Offset: 0x0008B174
		public override Module GetModule(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Name can't be empty");
			}
			foreach (Module module in this.GetModules(true))
			{
				if (module.ScopeName == name)
				{
					return module;
				}
			}
			return null;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0008CFD0 File Offset: 0x0008B1D0
		public override Module[] GetModules(bool getResourceModules)
		{
			Module[] modulesInternal = this.GetModulesInternal();
			if (!getResourceModules)
			{
				List<Module> list = new List<Module>(modulesInternal.Length);
				foreach (Module module in modulesInternal)
				{
					if (!module.IsResource())
					{
						list.Add(module);
					}
				}
				return list.ToArray();
			}
			return modulesInternal;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0008D020 File Offset: 0x0008B220
		internal static byte[] GetAotId()
		{
			byte[] array = new byte[16];
			if (RuntimeAssembly.GetAotIdInternal(array))
			{
				return array;
			}
			return null;
		}

		// Token: 0x0600230D RID: 8973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string get_code_base(Assembly a, bool escaped);

		// Token: 0x0600230E RID: 8974
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string get_fullname(Assembly a);

		// Token: 0x0600230F RID: 8975
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool GetAotIdInternal(byte[] aotid);

		// Token: 0x06002310 RID: 8976 RVA: 0x0008D040 File Offset: 0x0008B240
		internal static string GetCodeBase(Assembly a, bool escaped)
		{
			return RuntimeAssembly.get_code_base(a, escaped);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0008D049 File Offset: 0x0008B249
		public override string CodeBase
		{
			get
			{
				return RuntimeAssembly.GetCodeBase(this, false);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x0008D052 File Offset: 0x0008B252
		public override string FullName
		{
			get
			{
				return RuntimeAssembly.get_fullname(this);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0008D05A File Offset: 0x0008B25A
		internal override IntPtr MonoAssembly
		{
			get
			{
				return this._mono_assembly;
			}
		}

		// Token: 0x06002314 RID: 8980
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern IntPtr GetManifestResourceInternal(string name, out int size, out Module module);

		// Token: 0x06002315 RID: 8981 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0008D075 File Offset: 0x0008B275
		internal override Module GetManifestModule()
		{
			return this.GetManifestModuleInternal();
		}

		// Token: 0x06002319 RID: 8985
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Module GetManifestModuleInternal();

		// Token: 0x0600231A RID: 8986
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal override extern Module[] GetModulesInternal();

		// Token: 0x0600231B RID: 8987 RVA: 0x0008D07D File Offset: 0x0008B27D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0008D085 File Offset: 0x0008B285
		public override bool Equals(object o)
		{
			return this == o || (o != null && o is RuntimeAssembly && ((RuntimeAssembly)o)._mono_assembly == this._mono_assembly);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0008D0B2 File Offset: 0x0008B2B2
		public override string ToString()
		{
			if (this.assemblyName != null)
			{
				return this.assemblyName;
			}
			this.assemblyName = this.FullName;
			return this.assemblyName;
		}

		// Token: 0x04001116 RID: 4374
		internal IntPtr _mono_assembly;

		// Token: 0x04001117 RID: 4375
		private object _evidence;

		// Token: 0x04001118 RID: 4376
		internal Assembly.ResolveEventHolder resolve_event_holder;

		// Token: 0x04001119 RID: 4377
		private object _minimum;

		// Token: 0x0400111A RID: 4378
		private object _optional;

		// Token: 0x0400111B RID: 4379
		private object _refuse;

		// Token: 0x0400111C RID: 4380
		private object _granted;

		// Token: 0x0400111D RID: 4381
		private object _denied;

		// Token: 0x0400111E RID: 4382
		internal bool fromByteArray;

		// Token: 0x0400111F RID: 4383
		internal string assemblyName;
	}
}

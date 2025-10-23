using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004D9 RID: 1241
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal BindingFlags BindingFlags
		{
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0008D2E1 File Offset: 0x0008B4E1
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0008D0FE File Offset: 0x0008B2FE
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x0008D10B File Offset: 0x0008B30B
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				return (RuntimeType)this.ReflectedType;
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0008D2E9 File Offset: 0x0008B4E9
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0008D2F6 File Offset: 0x0008B4F6
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			MemberInfoSerializationHolder.GetSerializationInfo(info, this.Name, this.ReflectedTypeInternal, this.ToString(), MemberTypes.Field);
		}

		// Token: 0x0600233F RID: 9023
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal override extern object UnsafeGetValue(object obj);

		// Token: 0x06002340 RID: 9024 RVA: 0x0008D320 File Offset: 0x0008B520
		internal override void CheckConsistency(object target)
		{
			if ((this.Attributes & FieldAttributes.Static) == FieldAttributes.Static || this.DeclaringType.IsInstanceOfType(target))
			{
				return;
			}
			if (target == null)
			{
				throw new TargetException(Environment.GetResourceString("Non-static field requires a target."));
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Field '{0}' defined on type '{1}' is not a field on the target object which is of type '{2}'."), this.Name, this.DeclaringType, target.GetType()));
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0008D388 File Offset: 0x0008B588
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			bool flag = false;
			RuntimeFieldHandle.SetValue(this, obj, value, null, this.Attributes, null, ref flag);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0008D3A9 File Offset: 0x0008B5A9
		[DebuggerStepThrough]
		[DebuggerHidden]
		public unsafe override void SetValueDirect(TypedReference obj, object value)
		{
			if (obj.IsNull)
			{
				throw new ArgumentException(Environment.GetResourceString("The TypedReference must be initialized."));
			}
			RuntimeFieldHandle.SetValueDirect(this, (RuntimeType)this.FieldType, (void*)(&obj), value, (RuntimeType)this.DeclaringType);
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x0008D3E4 File Offset: 0x0008B5E4
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0008D3EC File Offset: 0x0008B5EC
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				return this.fhandle;
			}
		}

		// Token: 0x06002345 RID: 9029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type ResolveType();

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
		public override Type FieldType
		{
			get
			{
				if (this.type == null)
				{
					this.type = this.ResolveType();
				}
				return this.type;
			}
		}

		// Token: 0x06002347 RID: 9031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type GetParentType(bool declaring);

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x0008D416 File Offset: 0x0008B616
		public override Type ReflectedType
		{
			get
			{
				return this.GetParentType(false);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0008D41F File Offset: 0x0008B61F
		public override Type DeclaringType
		{
			get
			{
				return this.GetParentType(true);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x0008D428 File Offset: 0x0008B628
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x0600234E RID: 9038
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal override extern int GetFieldOffset();

		// Token: 0x0600234F RID: 9039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object GetValueInternal(object obj);

		// Token: 0x06002350 RID: 9040 RVA: 0x0008D430 File Offset: 0x0008B630
		public override object GetValue(object obj)
		{
			if (!base.IsStatic)
			{
				if (obj == null)
				{
					throw new TargetException("Non-static field requires a target");
				}
				if (!this.DeclaringType.IsAssignableFrom(obj.GetType()))
				{
					throw new ArgumentException(string.Format("Field {0} defined on type {1} is not a field on the target object which is of type {2}.", this.Name, this.DeclaringType, obj.GetType()), "obj");
				}
			}
			if (!base.IsLiteral)
			{
				this.CheckGeneric();
			}
			return this.GetValueInternal(obj);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0008D4A2 File Offset: 0x0008B6A2
		public override string ToString()
		{
			return string.Format("{0} {1}", this.FieldType, this.name);
		}

		// Token: 0x06002352 RID: 9042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x06002353 RID: 9043 RVA: 0x0008D4BC File Offset: 0x0008B6BC
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			if (!base.IsStatic)
			{
				if (obj == null)
				{
					throw new TargetException("Non-static field requires a target");
				}
				if (!this.DeclaringType.IsAssignableFrom(obj.GetType()))
				{
					throw new ArgumentException(string.Format("Field {0} defined on type {1} is not a field on the target object which is of type {2}.", this.Name, this.DeclaringType, obj.GetType()), "obj");
				}
			}
			if (base.IsLiteral)
			{
				throw new FieldAccessException("Cannot set a constant field");
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			this.CheckGeneric();
			if (val != null)
			{
				val = ((RuntimeType)this.FieldType).CheckValue(val, binder, culture, invokeAttr);
			}
			RuntimeFieldInfo.SetValueInternal(this, obj, val);
		}

		// Token: 0x06002354 RID: 9044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern object GetRawConstantValue();

		// Token: 0x06002355 RID: 9045 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributes(this);
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0008D560 File Offset: 0x0008B760
		private void CheckGeneric()
		{
			if (this.DeclaringType.ContainsGenericParameters)
			{
				throw new InvalidOperationException("Late bound operations cannot be performed on fields with types for which Type.ContainsGenericParameters is true.");
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x0008D57A File Offset: 0x0008B77A
		public override int MetadataToken
		{
			get
			{
				return RuntimeFieldInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06002358 RID: 9048
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeFieldInfo monoField);

		// Token: 0x0400112A RID: 4394
		internal IntPtr klass;

		// Token: 0x0400112B RID: 4395
		internal RuntimeFieldHandle fhandle;

		// Token: 0x0400112C RID: 4396
		private string name;

		// Token: 0x0400112D RID: 4397
		private Type type;

		// Token: 0x0400112E RID: 4398
		private FieldAttributes attrs;
	}
}

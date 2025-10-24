using System;
using System.Collections.Generic;

namespace Java.Interop
{
	// Token: 0x02000070 RID: 112
	public class JniPeerMembers
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0000DE8C File Offset: 0x0000C08C
		public JniPeerMembers(string jniPeerTypeName, Type managedPeerType, bool isInterface) : this(jniPeerTypeName, managedPeerType, true, isInterface)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000DE98 File Offset: 0x0000C098
		public JniPeerMembers(string jniPeerTypeName, Type managedPeerType) : this(jniPeerTypeName = JniPeerMembers.GetReplacementType(jniPeerTypeName), managedPeerType, true, false)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000024DC File Offset: 0x000006DC
		private static string GetReplacementType(string jniPeerTypeName)
		{
			return jniPeerTypeName;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		private JniPeerMembers(string jniPeerTypeName, Type managedPeerType, bool checkManagedPeerType, bool isInterface = false)
		{
			if (jniPeerTypeName == null)
			{
				throw new ArgumentNullException("jniPeerTypeName");
			}
			if (checkManagedPeerType)
			{
				if (managedPeerType == null)
				{
					throw new ArgumentNullException("managedPeerType");
				}
				if (!typeof(IJavaPeerable).IsAssignableFrom(managedPeerType))
				{
					throw new ArgumentException("'managedPeerType' must implement the IJavaPeerable interface.", "managedPeerType");
				}
			}
			this.JniPeerTypeName = jniPeerTypeName;
			this.ManagedPeerType = managedPeerType;
			this.isInterface = isInterface;
			this.instanceMethods = new JniPeerMembers.JniInstanceMethods(this);
			this.instanceFields = new JniPeerMembers.JniInstanceFields(this);
			this.staticMethods = new JniPeerMembers.JniStaticMethods(this);
			this.staticFields = new JniPeerMembers.JniStaticFields(this);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000DF4C File Offset: 0x0000C14C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000DF54 File Offset: 0x0000C154
		public Type ManagedPeerType { get; private set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000DF5D File Offset: 0x0000C15D
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000DF65 File Offset: 0x0000C165
		public string JniPeerTypeName { get; private set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000DF6E File Offset: 0x0000C16E
		public JniType JniPeerType
		{
			get
			{
				JniType cachedJniType = JniType.GetCachedJniType(ref this.jniPeerType, this.JniPeerTypeName);
				cachedJniType.RegisterWithRuntime();
				return cachedJniType;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000DF87 File Offset: 0x0000C187
		public JniPeerMembers.JniInstanceMethods InstanceMethods
		{
			get
			{
				return JniPeerMembers.Assert<JniPeerMembers.JniInstanceMethods>(this.instanceMethods);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000DF94 File Offset: 0x0000C194
		public JniPeerMembers.JniInstanceFields InstanceFields
		{
			get
			{
				return JniPeerMembers.Assert<JniPeerMembers.JniInstanceFields>(this.instanceFields);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000DFA1 File Offset: 0x0000C1A1
		public JniPeerMembers.JniStaticMethods StaticMethods
		{
			get
			{
				return JniPeerMembers.Assert<JniPeerMembers.JniStaticMethods>(this.staticMethods);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000DFAE File Offset: 0x0000C1AE
		public JniPeerMembers.JniStaticFields StaticFields
		{
			get
			{
				return JniPeerMembers.Assert<JniPeerMembers.JniStaticFields>(this.staticFields);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000DFBB File Offset: 0x0000C1BB
		private static T Assert<T>(T value) where T : class
		{
			if (value == null)
			{
				throw new ObjectDisposedException("JniPeerMembers");
			}
			return value;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000DFD1 File Offset: 0x0000C1D1
		protected virtual bool UsesVirtualDispatch(IJavaPeerable value, Type declaringType)
		{
			return value.GetType() == declaringType || declaringType == null || value.GetType() == value.JniPeerMembers.ManagedPeerType;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000E002 File Offset: 0x0000C202
		protected virtual JniPeerMembers GetPeerMembers(IJavaPeerable value)
		{
			if (!this.isInterface)
			{
				return value.JniPeerMembers;
			}
			return this;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000E014 File Offset: 0x0000C214
		internal static void AssertSelf(IJavaPeerable self)
		{
			if (self == null)
			{
				throw new ArgumentNullException("self");
			}
			if (!self.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(self.GetType().FullName);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000E050 File Offset: 0x0000C250
		internal static int GetSignatureSeparatorIndex(string encodedMember)
		{
			if (encodedMember == null)
			{
				throw new ArgumentNullException("encodedMember");
			}
			int num = encodedMember.IndexOf(".", StringComparison.Ordinal);
			if (num < 0)
			{
				throw new ArgumentException("Invalid encoding; 'encodedMember' should be encoded as \"<NAME>.<SIGNATURE>\".", "encodedMember");
			}
			if (encodedMember.Length <= num + 1)
			{
				throw new ArgumentException("Invalid encoding; 'encodedMember' is missing a JNI signature, and should be in the format \"<NAME>.<SIGNATURE>\".", "encodedMember");
			}
			return num;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		internal static void GetNameAndSignature(string encodedMember, out string name, out string signature)
		{
			int signatureSeparatorIndex = JniPeerMembers.GetSignatureSeparatorIndex(encodedMember);
			name = encodedMember.Substring(0, signatureSeparatorIndex);
			signature = encodedMember.Substring(signatureSeparatorIndex + 1);
		}

		// Token: 0x04000105 RID: 261
		private bool isInterface;

		// Token: 0x04000106 RID: 262
		private JniType jniPeerType;

		// Token: 0x04000107 RID: 263
		private JniPeerMembers.JniInstanceMethods instanceMethods;

		// Token: 0x04000108 RID: 264
		private JniPeerMembers.JniInstanceFields instanceFields;

		// Token: 0x04000109 RID: 265
		private JniPeerMembers.JniStaticMethods staticMethods;

		// Token: 0x0400010A RID: 266
		private JniPeerMembers.JniStaticFields staticFields;

		// Token: 0x02000071 RID: 113
		public sealed class JniInstanceFields
		{
			// Token: 0x060003BA RID: 954 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
			public bool GetBooleanValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				bool booleanField = JniEnvironment.InstanceFields.GetBooleanField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return booleanField;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0000E104 File Offset: 0x0000C304
			public void SetValue(string encodedMember, IJavaPeerable self, bool value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetBooleanField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0000E134 File Offset: 0x0000C334
			public sbyte GetSByteValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				sbyte byteField = JniEnvironment.InstanceFields.GetByteField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return byteField;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x0000E164 File Offset: 0x0000C364
			public void SetValue(string encodedMember, IJavaPeerable self, sbyte value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetByteField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000E194 File Offset: 0x0000C394
			public char GetCharValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				char charField = JniEnvironment.InstanceFields.GetCharField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return charField;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
			public void SetValue(string encodedMember, IJavaPeerable self, char value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetCharField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
			public short GetInt16Value(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				short shortField = JniEnvironment.InstanceFields.GetShortField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return shortField;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000E224 File Offset: 0x0000C424
			public void SetValue(string encodedMember, IJavaPeerable self, short value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetShortField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0000E254 File Offset: 0x0000C454
			public int GetInt32Value(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				int intField = JniEnvironment.InstanceFields.GetIntField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return intField;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x0000E284 File Offset: 0x0000C484
			public void SetValue(string encodedMember, IJavaPeerable self, int value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetIntField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
			public long GetInt64Value(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				long longField = JniEnvironment.InstanceFields.GetLongField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return longField;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
			public void SetValue(string encodedMember, IJavaPeerable self, long value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetLongField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x0000E314 File Offset: 0x0000C514
			public float GetSingleValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				float floatField = JniEnvironment.InstanceFields.GetFloatField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return floatField;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000E344 File Offset: 0x0000C544
			public void SetValue(string encodedMember, IJavaPeerable self, float value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetFloatField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000E374 File Offset: 0x0000C574
			public double GetDoubleValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				double doubleField = JniEnvironment.InstanceFields.GetDoubleField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return doubleField;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
			public void SetValue(string encodedMember, IJavaPeerable self, double value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetDoubleField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
			public JniObjectReference GetObjectValue(string encodedMember, IJavaPeerable self)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniObjectReference objectField = JniEnvironment.InstanceFields.GetObjectField(self.PeerReference, fieldInfo);
				GC.KeepAlive(self);
				return objectField;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0000E404 File Offset: 0x0000C604
			public void SetValue(string encodedMember, IJavaPeerable self, JniObjectReference value)
			{
				JniPeerMembers.AssertSelf(self);
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.InstanceFields.SetObjectField(self.PeerReference, fieldInfo, value);
				GC.KeepAlive(self);
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0000E432 File Offset: 0x0000C632
			internal JniInstanceFields(JniPeerMembers members)
			{
				this.Members = members;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0000E454 File Offset: 0x0000C654
			public JniFieldInfo GetFieldInfo(string encodedMember)
			{
				Dictionary<string, JniFieldInfo> instanceFields = this.InstanceFields;
				JniFieldInfo result;
				lock (instanceFields)
				{
					JniFieldInfo instanceField;
					if (!this.InstanceFields.TryGetValue(encodedMember, out instanceField))
					{
						string name;
						string signature;
						JniPeerMembers.GetNameAndSignature(encodedMember, out name, out signature);
						instanceField = this.Members.JniPeerType.GetInstanceField(name, signature);
						this.InstanceFields.Add(encodedMember, instanceField);
					}
					result = instanceField;
				}
				return result;
			}

			// Token: 0x0400010D RID: 269
			private readonly JniPeerMembers Members;

			// Token: 0x0400010E RID: 270
			private Dictionary<string, JniFieldInfo> InstanceFields = new Dictionary<string, JniFieldInfo>(StringComparer.Ordinal);
		}

		// Token: 0x02000072 RID: 114
		public sealed class JniStaticFields
		{
			// Token: 0x060003CE RID: 974 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
			public bool GetBooleanValue(string encodedMember)
			{
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				return JniEnvironment.StaticFields.GetStaticBooleanField(this.Members.JniPeerType.PeerReference, fieldInfo);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000E4FC File Offset: 0x0000C6FC
			public int GetInt32Value(string encodedMember)
			{
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				return JniEnvironment.StaticFields.GetStaticIntField(this.Members.JniPeerType.PeerReference, fieldInfo);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000E528 File Offset: 0x0000C728
			public void SetValue(string encodedMember, int value)
			{
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.StaticFields.SetStaticIntField(this.Members.JniPeerType.PeerReference, fieldInfo, value);
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000E554 File Offset: 0x0000C754
			public JniObjectReference GetObjectValue(string encodedMember)
			{
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				return JniEnvironment.StaticFields.GetStaticObjectField(this.Members.JniPeerType.PeerReference, fieldInfo);
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0000E580 File Offset: 0x0000C780
			public void SetValue(string encodedMember, JniObjectReference value)
			{
				JniFieldInfo fieldInfo = this.GetFieldInfo(encodedMember);
				JniEnvironment.StaticFields.SetStaticObjectField(this.Members.JniPeerType.PeerReference, fieldInfo, value);
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0000E5AC File Offset: 0x0000C7AC
			internal JniStaticFields(JniPeerMembers members)
			{
				this.Members = members;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0000E5CC File Offset: 0x0000C7CC
			public JniFieldInfo GetFieldInfo(string encodedMember)
			{
				Dictionary<string, JniFieldInfo> staticFields = this.StaticFields;
				JniFieldInfo result;
				lock (staticFields)
				{
					JniFieldInfo staticField;
					if (!this.StaticFields.TryGetValue(encodedMember, out staticField))
					{
						string name;
						string signature;
						JniPeerMembers.GetNameAndSignature(encodedMember, out name, out signature);
						staticField = this.Members.JniPeerType.GetStaticField(name, signature);
						this.StaticFields.Add(encodedMember, staticField);
					}
					result = staticField;
				}
				return result;
			}

			// Token: 0x0400010F RID: 271
			private readonly JniPeerMembers Members;

			// Token: 0x04000110 RID: 272
			private Dictionary<string, JniFieldInfo> StaticFields = new Dictionary<string, JniFieldInfo>(StringComparer.Ordinal);
		}

		// Token: 0x02000073 RID: 115
		public sealed class JniInstanceMethods
		{
			// Token: 0x060003D5 RID: 981 RVA: 0x0000E648 File Offset: 0x0000C848
			internal JniInstanceMethods(JniPeerMembers members)
			{
				this.DeclaringType = members.ManagedPeerType;
				this.members = members;
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0000E680 File Offset: 0x0000C880
			private JniInstanceMethods(Type declaringType)
			{
				JniTypeSignature typeSignature = JniEnvironment.Runtime.TypeManager.GetTypeSignature(declaringType);
				if (typeSignature.SimpleReference == null)
				{
					throw new NotSupportedException(string.Format("Cannot create instance of type '{0}': no Java peer type found.", declaringType.FullName));
				}
				this.DeclaringType = declaringType;
				this.jniPeerType = new JniType(typeSignature.Name);
				this.jniPeerType.RegisterWithRuntime();
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000E702 File Offset: 0x0000C902
			internal JniPeerMembers Members
			{
				get
				{
					JniPeerMembers jniPeerMembers = this.members;
					if (jniPeerMembers == null)
					{
						throw new InvalidOperationException();
					}
					return jniPeerMembers;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000E714 File Offset: 0x0000C914
			internal JniType JniPeerType
			{
				get
				{
					JniType result;
					if ((result = this.jniPeerType) == null)
					{
						JniPeerMembers jniPeerMembers = this.Members;
						if ((result = ((jniPeerMembers != null) ? jniPeerMembers.JniPeerType : null)) == null)
						{
							throw new InvalidOperationException();
						}
					}
					return result;
				}
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x0000E73C File Offset: 0x0000C93C
			public JniMethodInfo GetConstructor(string signature)
			{
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				Dictionary<string, JniMethodInfo> instanceMethods = this.InstanceMethods;
				JniMethodInfo result;
				lock (instanceMethods)
				{
					JniMethodInfo constructor;
					if (!this.InstanceMethods.TryGetValue(signature, out constructor))
					{
						constructor = this.JniPeerType.GetConstructor(signature);
						this.InstanceMethods.Add(signature, constructor);
					}
					result = constructor;
				}
				return result;
			}

			// Token: 0x060003DA RID: 986 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
			internal JniPeerMembers.JniInstanceMethods GetConstructorsForType(Type declaringType)
			{
				if (declaringType == this.DeclaringType)
				{
					return this;
				}
				Dictionary<Type, JniPeerMembers.JniInstanceMethods> subclassConstructors = this.SubclassConstructors;
				JniPeerMembers.JniInstanceMethods result;
				lock (subclassConstructors)
				{
					JniPeerMembers.JniInstanceMethods jniInstanceMethods;
					if (!this.SubclassConstructors.TryGetValue(declaringType, out jniInstanceMethods))
					{
						jniInstanceMethods = new JniPeerMembers.JniInstanceMethods(declaringType);
						this.SubclassConstructors.Add(declaringType, jniInstanceMethods);
					}
					result = jniInstanceMethods;
				}
				return result;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000E828 File Offset: 0x0000CA28
			public JniMethodInfo GetMethodInfo(string encodedMember)
			{
				Dictionary<string, JniMethodInfo> instanceMethods = this.InstanceMethods;
				lock (instanceMethods)
				{
					JniMethodInfo result;
					if (this.InstanceMethods.TryGetValue(encodedMember, out result))
					{
						return result;
					}
				}
				string method;
				string signature;
				JniPeerMembers.GetNameAndSignature(encodedMember, out method, out signature);
				JniMethodInfo methodInfo = this.GetMethodInfo(method, signature);
				instanceMethods = this.InstanceMethods;
				lock (instanceMethods)
				{
					JniMethodInfo result2;
					if (this.InstanceMethods.TryGetValue(encodedMember, out result2))
					{
						return result2;
					}
					this.InstanceMethods.Add(encodedMember, methodInfo);
				}
				return methodInfo;
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
			private JniMethodInfo GetMethodInfo(string method, string signature)
			{
				return this.JniPeerType.GetInstanceMethod(method, signature);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
			public unsafe JniObjectReference StartCreateInstance(string constructorSignature, Type declaringType, JniArgumentValue* parameters)
			{
				if (constructorSignature == null)
				{
					throw new ArgumentNullException("constructorSignature");
				}
				if (declaringType == null)
				{
					throw new ArgumentNullException("declaringType");
				}
				if (JniEnvironment.Runtime.NewObjectRequired)
				{
					return this.NewObject(constructorSignature, declaringType, parameters);
				}
				JniObjectReference result = this.GetConstructorsForType(declaringType).JniPeerType.AllocObject();
				result.Flags = JniObjectReferenceFlags.Alloc;
				return result;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x0000E954 File Offset: 0x0000CB54
			internal unsafe JniObjectReference NewObject(string constructorSignature, Type declaringType, JniArgumentValue* parameters)
			{
				JniPeerMembers.JniInstanceMethods constructorsForType = this.GetConstructorsForType(declaringType);
				JniMethodInfo constructor = constructorsForType.GetConstructor(constructorSignature);
				return constructorsForType.JniPeerType.NewObject(constructor, parameters);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x0000E97C File Offset: 0x0000CB7C
			public unsafe void FinishCreateInstance(string constructorSignature, IJavaPeerable self, JniArgumentValue* parameters)
			{
				if (constructorSignature == null)
				{
					throw new ArgumentNullException("constructorSignature");
				}
				if (self == null)
				{
					throw new ArgumentNullException("self");
				}
				if (JniEnvironment.Runtime.NewObjectRequired)
				{
					return;
				}
				JniPeerMembers.JniInstanceMethods constructorsForType = this.GetConstructorsForType(self.GetType());
				JniMethodInfo constructor = constructorsForType.GetConstructor(constructorSignature);
				JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod(self.PeerReference, constructorsForType.JniPeerType.PeerReference, constructor, parameters);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x000021BF File Offset: 0x000003BF
			private unsafe static bool TryInvokeVoidStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters)
			{
				return false;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
			public unsafe void InvokeAbstractVoidMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					if (!JniPeerMembers.JniInstanceMethods.TryInvokeVoidStaticRedirect(methodInfo, self, parameters))
					{
						JniEnvironment.InstanceMethods.CallVoidMethod(self.PeerReference, methodInfo, parameters);
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0000EA30 File Offset: 0x0000CC30
			public unsafe void InvokeVirtualVoidMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						if (!JniPeerMembers.JniInstanceMethods.TryInvokeVoidStaticRedirect(methodInfo, self, parameters))
						{
							JniEnvironment.InstanceMethods.CallVoidMethod(self.PeerReference, methodInfo, parameters);
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						if (!JniPeerMembers.JniInstanceMethods.TryInvokeVoidStaticRedirect(methodInfo2, self, parameters))
						{
							JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
			public unsafe void InvokeNonvirtualVoidMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				try
				{
					if (!JniPeerMembers.JniInstanceMethods.TryInvokeVoidStaticRedirect(methodInfo, self, parameters))
					{
						JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0000EB2C File Offset: 0x0000CD2C
			private unsafe static bool TryInvokeBooleanStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out bool r)
			{
				r = false;
				return false;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x0000EB34 File Offset: 0x0000CD34
			public unsafe bool InvokeAbstractBooleanMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				bool result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					bool flag;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeBooleanStaticRedirect(methodInfo, self, parameters, out flag))
					{
						result = flag;
					}
					else
					{
						flag = JniEnvironment.InstanceMethods.CallBooleanMethod(self.PeerReference, methodInfo, parameters);
						result = flag;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0000EB8C File Offset: 0x0000CD8C
			public unsafe bool InvokeVirtualBooleanMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				bool result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						bool flag;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeBooleanStaticRedirect(methodInfo, self, parameters, out flag))
						{
							result = flag;
						}
						else
						{
							flag = JniEnvironment.InstanceMethods.CallBooleanMethod(self.PeerReference, methodInfo, parameters);
							result = flag;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						bool flag2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeBooleanStaticRedirect(methodInfo2, self, parameters, out flag2))
						{
							result = flag2;
						}
						else
						{
							flag2 = JniEnvironment.InstanceMethods.CallNonvirtualBooleanMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = flag2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0000EC4C File Offset: 0x0000CE4C
			public unsafe bool InvokeNonvirtualBooleanMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				bool result;
				try
				{
					bool flag;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeBooleanStaticRedirect(methodInfo, self, parameters, out flag))
					{
						result = flag;
					}
					else
					{
						flag = JniEnvironment.InstanceMethods.CallNonvirtualBooleanMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = flag;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0000EB2C File Offset: 0x0000CD2C
			private unsafe static bool TryInvokeSByteStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out sbyte r)
			{
				r = 0;
				return false;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x0000ECAC File Offset: 0x0000CEAC
			public unsafe sbyte InvokeAbstractSByteMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				sbyte result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					sbyte b;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeSByteStaticRedirect(methodInfo, self, parameters, out b))
					{
						result = b;
					}
					else
					{
						b = JniEnvironment.InstanceMethods.CallByteMethod(self.PeerReference, methodInfo, parameters);
						result = b;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x0000ED04 File Offset: 0x0000CF04
			public unsafe sbyte InvokeVirtualSByteMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				sbyte result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						sbyte b;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeSByteStaticRedirect(methodInfo, self, parameters, out b))
						{
							result = b;
						}
						else
						{
							b = JniEnvironment.InstanceMethods.CallByteMethod(self.PeerReference, methodInfo, parameters);
							result = b;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						sbyte b2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeSByteStaticRedirect(methodInfo2, self, parameters, out b2))
						{
							result = b2;
						}
						else
						{
							b2 = JniEnvironment.InstanceMethods.CallNonvirtualByteMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = b2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
			private unsafe static bool TryInvokeCharStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out char r)
			{
				r = '\0';
				return false;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x0000EDCC File Offset: 0x0000CFCC
			public unsafe char InvokeAbstractCharMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				char result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					char c;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeCharStaticRedirect(methodInfo, self, parameters, out c))
					{
						result = c;
					}
					else
					{
						c = JniEnvironment.InstanceMethods.CallCharMethod(self.PeerReference, methodInfo, parameters);
						result = c;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0000EE24 File Offset: 0x0000D024
			public unsafe char InvokeVirtualCharMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				char result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						char c;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeCharStaticRedirect(methodInfo, self, parameters, out c))
						{
							result = c;
						}
						else
						{
							c = JniEnvironment.InstanceMethods.CallCharMethod(self.PeerReference, methodInfo, parameters);
							result = c;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						char c2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeCharStaticRedirect(methodInfo2, self, parameters, out c2))
						{
							result = c2;
						}
						else
						{
							c2 = JniEnvironment.InstanceMethods.CallNonvirtualCharMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = c2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
			public unsafe char InvokeNonvirtualCharMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				char result;
				try
				{
					char c;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeCharStaticRedirect(methodInfo, self, parameters, out c))
					{
						result = c;
					}
					else
					{
						c = JniEnvironment.InstanceMethods.CallNonvirtualCharMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = c;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
			private unsafe static bool TryInvokeInt16StaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out short r)
			{
				r = 0;
				return false;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x0000EF44 File Offset: 0x0000D144
			public unsafe short InvokeAbstractInt16Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				short result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					short num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeInt16StaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallShortMethod(self.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x0000EF9C File Offset: 0x0000D19C
			public unsafe short InvokeVirtualInt16Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				short result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						short num;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt16StaticRedirect(methodInfo, self, parameters, out num))
						{
							result = num;
						}
						else
						{
							num = JniEnvironment.InstanceMethods.CallShortMethod(self.PeerReference, methodInfo, parameters);
							result = num;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						short num2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt16StaticRedirect(methodInfo2, self, parameters, out num2))
						{
							result = num2;
						}
						else
						{
							num2 = JniEnvironment.InstanceMethods.CallNonvirtualShortMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = num2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x0000F05C File Offset: 0x0000D25C
			private unsafe static bool TryInvokeInt32StaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out int r)
			{
				r = 0;
				return false;
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x0000F064 File Offset: 0x0000D264
			public unsafe int InvokeAbstractInt32Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				int result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					int num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeInt32StaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallIntMethod(self.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x0000F0BC File Offset: 0x0000D2BC
			public unsafe int InvokeVirtualInt32Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				int result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						int num;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt32StaticRedirect(methodInfo, self, parameters, out num))
						{
							result = num;
						}
						else
						{
							num = JniEnvironment.InstanceMethods.CallIntMethod(self.PeerReference, methodInfo, parameters);
							result = num;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						int num2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt32StaticRedirect(methodInfo2, self, parameters, out num2))
						{
							result = num2;
						}
						else
						{
							num2 = JniEnvironment.InstanceMethods.CallNonvirtualIntMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = num2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0000F17C File Offset: 0x0000D37C
			public unsafe int InvokeNonvirtualInt32Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				int result;
				try
				{
					int num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeInt32StaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallNonvirtualIntMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x0000F1DC File Offset: 0x0000D3DC
			private unsafe static bool TryInvokeInt64StaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out long r)
			{
				r = 0L;
				return false;
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
			public unsafe long InvokeAbstractInt64Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				long result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					long num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeInt64StaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallLongMethod(self.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x0000F23C File Offset: 0x0000D43C
			public unsafe long InvokeVirtualInt64Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				long result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						long num;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt64StaticRedirect(methodInfo, self, parameters, out num))
						{
							result = num;
						}
						else
						{
							num = JniEnvironment.InstanceMethods.CallLongMethod(self.PeerReference, methodInfo, parameters);
							result = num;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						long num2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeInt64StaticRedirect(methodInfo2, self, parameters, out num2))
						{
							result = num2;
						}
						else
						{
							num2 = JniEnvironment.InstanceMethods.CallNonvirtualLongMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = num2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0000F2FC File Offset: 0x0000D4FC
			public unsafe long InvokeNonvirtualInt64Method(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				long result;
				try
				{
					long num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeInt64StaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallNonvirtualLongMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x0000F35C File Offset: 0x0000D55C
			private unsafe static bool TryInvokeSingleStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out float r)
			{
				r = 0f;
				return false;
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x0000F368 File Offset: 0x0000D568
			public unsafe float InvokeAbstractSingleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				float result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					float num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeSingleStaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallFloatMethod(self.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
			public unsafe float InvokeVirtualSingleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				float result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						float num;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeSingleStaticRedirect(methodInfo, self, parameters, out num))
						{
							result = num;
						}
						else
						{
							num = JniEnvironment.InstanceMethods.CallFloatMethod(self.PeerReference, methodInfo, parameters);
							result = num;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						float num2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeSingleStaticRedirect(methodInfo2, self, parameters, out num2))
						{
							result = num2;
						}
						else
						{
							num2 = JniEnvironment.InstanceMethods.CallNonvirtualFloatMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = num2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x0000F480 File Offset: 0x0000D680
			public unsafe float InvokeNonvirtualSingleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				float result;
				try
				{
					float num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeSingleStaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallNonvirtualFloatMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
			private unsafe static bool TryInvokeDoubleStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out double r)
			{
				r = 0.0;
				return false;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
			public unsafe double InvokeAbstractDoubleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				double result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					double num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeDoubleStaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallDoubleMethod(self.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x0000F548 File Offset: 0x0000D748
			public unsafe double InvokeVirtualDoubleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				double result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						double num;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeDoubleStaticRedirect(methodInfo, self, parameters, out num))
						{
							result = num;
						}
						else
						{
							num = JniEnvironment.InstanceMethods.CallDoubleMethod(self.PeerReference, methodInfo, parameters);
							result = num;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						double num2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeDoubleStaticRedirect(methodInfo2, self, parameters, out num2))
						{
							result = num2;
						}
						else
						{
							num2 = JniEnvironment.InstanceMethods.CallNonvirtualDoubleMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = num2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000F608 File Offset: 0x0000D808
			public unsafe double InvokeNonvirtualDoubleMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				double result;
				try
				{
					double num;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeDoubleStaticRedirect(methodInfo, self, parameters, out num))
					{
						result = num;
					}
					else
					{
						num = JniEnvironment.InstanceMethods.CallNonvirtualDoubleMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = num;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000F668 File Offset: 0x0000D868
			private unsafe static bool TryInvokeObjectStaticRedirect(JniMethodInfo method, IJavaPeerable self, JniArgumentValue* parameters, out JniObjectReference r)
			{
				r = default(JniObjectReference);
				return false;
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0000F674 File Offset: 0x0000D874
			public unsafe JniObjectReference InvokeAbstractObjectMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniObjectReference result;
				try
				{
					JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
					JniObjectReference jniObjectReference;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeObjectStaticRedirect(methodInfo, self, parameters, out jniObjectReference))
					{
						result = jniObjectReference;
					}
					else
					{
						jniObjectReference = JniEnvironment.InstanceMethods.CallObjectMethod(self.PeerReference, methodInfo, parameters);
						result = jniObjectReference;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x0000F6CC File Offset: 0x0000D8CC
			public unsafe JniObjectReference InvokeVirtualObjectMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniObjectReference result;
				try
				{
					Type declaringType = this.DeclaringType;
					if (this.Members.UsesVirtualDispatch(self, declaringType))
					{
						JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
						JniObjectReference jniObjectReference;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeObjectStaticRedirect(methodInfo, self, parameters, out jniObjectReference))
						{
							result = jniObjectReference;
						}
						else
						{
							jniObjectReference = JniEnvironment.InstanceMethods.CallObjectMethod(self.PeerReference, methodInfo, parameters);
							result = jniObjectReference;
						}
					}
					else
					{
						JniPeerMembers peerMembers = this.Members.GetPeerMembers(self);
						JniMethodInfo methodInfo2 = peerMembers.InstanceMethods.GetMethodInfo(encodedMember);
						JniObjectReference jniObjectReference2;
						if (JniPeerMembers.JniInstanceMethods.TryInvokeObjectStaticRedirect(methodInfo2, self, parameters, out jniObjectReference2))
						{
							result = jniObjectReference2;
						}
						else
						{
							jniObjectReference2 = JniEnvironment.InstanceMethods.CallNonvirtualObjectMethod(self.PeerReference, peerMembers.JniPeerType.PeerReference, methodInfo2, parameters);
							result = jniObjectReference2;
						}
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0000F78C File Offset: 0x0000D98C
			public unsafe JniObjectReference InvokeNonvirtualObjectMethod(string encodedMember, IJavaPeerable self, JniArgumentValue* parameters)
			{
				JniPeerMembers.AssertSelf(self);
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				JniObjectReference result;
				try
				{
					JniObjectReference jniObjectReference;
					if (JniPeerMembers.JniInstanceMethods.TryInvokeObjectStaticRedirect(methodInfo, self, parameters, out jniObjectReference))
					{
						result = jniObjectReference;
					}
					else
					{
						jniObjectReference = JniEnvironment.InstanceMethods.CallNonvirtualObjectMethod(self.PeerReference, this.JniPeerType.PeerReference, methodInfo, parameters);
						result = jniObjectReference;
					}
				}
				finally
				{
					GC.KeepAlive(self);
				}
				return result;
			}

			// Token: 0x04000111 RID: 273
			private JniPeerMembers members;

			// Token: 0x04000112 RID: 274
			private JniType jniPeerType;

			// Token: 0x04000113 RID: 275
			private readonly Type DeclaringType;

			// Token: 0x04000114 RID: 276
			private Dictionary<string, JniMethodInfo> InstanceMethods = new Dictionary<string, JniMethodInfo>(StringComparer.Ordinal);

			// Token: 0x04000115 RID: 277
			private Dictionary<Type, JniPeerMembers.JniInstanceMethods> SubclassConstructors = new Dictionary<Type, JniPeerMembers.JniInstanceMethods>();
		}

		// Token: 0x02000074 RID: 116
		public sealed class JniStaticMethods
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x0000F7EC File Offset: 0x0000D9EC
			internal JniStaticMethods(JniPeerMembers members)
			{
				this.Members = members;
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x0000F80C File Offset: 0x0000DA0C
			public JniMethodInfo GetMethodInfo(string encodedMember)
			{
				Dictionary<string, JniMethodInfo> staticMethods = this.StaticMethods;
				lock (staticMethods)
				{
					JniMethodInfo result;
					if (this.StaticMethods.TryGetValue(encodedMember, out result))
					{
						return result;
					}
				}
				string method;
				string signature;
				JniPeerMembers.GetNameAndSignature(encodedMember, out method, out signature);
				JniMethodInfo methodInfo = this.GetMethodInfo(method, signature);
				staticMethods = this.StaticMethods;
				lock (staticMethods)
				{
					JniMethodInfo result2;
					if (this.StaticMethods.TryGetValue(encodedMember, out result2))
					{
						return result2;
					}
					this.StaticMethods.Add(encodedMember, methodInfo);
				}
				return methodInfo;
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
			private JniMethodInfo GetMethodInfo(string method, string signature)
			{
				return this.Members.JniPeerType.GetStaticMethod(method, signature);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
			public unsafe void InvokeVoidMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				JniEnvironment.StaticMethods.CallStaticVoidMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x0000F904 File Offset: 0x0000DB04
			public unsafe bool InvokeBooleanMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticBooleanMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0000F930 File Offset: 0x0000DB30
			public unsafe sbyte InvokeSByteMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticByteMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0000F95C File Offset: 0x0000DB5C
			public unsafe char InvokeCharMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticCharMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x0000F988 File Offset: 0x0000DB88
			public unsafe short InvokeInt16Method(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticShortMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
			public unsafe int InvokeInt32Method(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticIntMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
			public unsafe long InvokeInt64Method(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticLongMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000FA0C File Offset: 0x0000DC0C
			public unsafe float InvokeSingleMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticFloatMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0000FA38 File Offset: 0x0000DC38
			public unsafe double InvokeDoubleMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticDoubleMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x0000FA64 File Offset: 0x0000DC64
			public unsafe JniObjectReference InvokeObjectMethod(string encodedMember, JniArgumentValue* parameters)
			{
				JniMethodInfo methodInfo = this.GetMethodInfo(encodedMember);
				return JniEnvironment.StaticMethods.CallStaticObjectMethod(this.Members.JniPeerType.PeerReference, methodInfo, parameters);
			}

			// Token: 0x04000116 RID: 278
			internal readonly JniPeerMembers Members;

			// Token: 0x04000117 RID: 279
			private Dictionary<string, JniMethodInfo> StaticMethods = new Dictionary<string, JniMethodInfo>(StringComparer.Ordinal);
		}
	}
}

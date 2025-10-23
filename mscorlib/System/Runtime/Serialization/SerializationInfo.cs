using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;

namespace System.Runtime.Serialization
{
	/// <summary>Stores all the data needed to serialize or deserialize an object. This class cannot be inherited.</summary>
	// Token: 0x020003B6 RID: 950
	[ComVisible(true)]
	public sealed class SerializationInfo
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize. </param>
		/// <param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> or <paramref name="converter" /> is <see langword="null" />. </exception>
		// Token: 0x06001D53 RID: 7507 RVA: 0x0007BFB6 File Offset: 0x0007A1B6
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter) : this(type, converter, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize.</param>
		/// <param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization.</param>
		/// <param name="requireSameTokenInPartialTrust">Indicates whether the object requires same token in partial trust.</param>
		// Token: 0x06001D54 RID: 7508 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (converter == null)
			{
				throw new ArgumentNullException("converter");
			}
			this.objectType = type;
			this.m_fullTypeName = type.FullName;
			this.m_assemName = type.Module.Assembly.FullName;
			this.m_members = new string[4];
			this.m_data = new object[4];
			this.m_types = new Type[4];
			this.m_nameToIndex = new Dictionary<string, int>();
			this.m_converter = converter;
			this.requireSameTokenInPartialTrust = requireSameTokenInPartialTrust;
		}

		/// <summary>Gets or sets the full name of the <see cref="T:System.Type" /> to serialize.</summary>
		/// <returns>The full name of the type to serialize.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value this property is set to is <see langword="null" />. </exception>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0007C059 File Offset: 0x0007A259
		public string FullTypeName
		{
			get
			{
				return this.m_fullTypeName;
			}
		}

		/// <summary>Gets or sets the assembly name of the type to serialize during serialization only.</summary>
		/// <returns>The full name of the assembly of the type to serialize.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value the property is set to is <see langword="null" />. </exception>
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0007C061 File Offset: 0x0007A261
		public string AssemblyName
		{
			get
			{
				return this.m_assemName;
			}
		}

		/// <summary>Sets the <see cref="T:System.Type" /> of the object to serialize.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001D57 RID: 7511 RVA: 0x0007C06C File Offset: 0x0007A26C
		[SecuritySafeCritical]
		public void SetType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.requireSameTokenInPartialTrust)
			{
				SerializationInfo.DemandForUnsafeAssemblyNameAssignments(this.ObjectType.Assembly.FullName, type.Assembly.FullName);
			}
			if (this.objectType != type)
			{
				this.objectType = type;
				this.m_fullTypeName = type.FullName;
				this.m_assemName = type.Module.Assembly.FullName;
				this.isFullTypeNameSetExplicit = false;
				this.isAssemblyNameSetExplicit = false;
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0007C0F0 File Offset: 0x0007A2F0
		private static bool Compare(byte[] a, byte[] b)
		{
			if (a == null || b == null || a.Length == 0 || b.Length == 0 || a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0007C12E File Offset: 0x0007A32E
		[SecuritySafeCritical]
		internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			SerializationInfo.IsAssemblyNameAssignmentSafe(originalAssemblyName, newAssemblyName);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0007C138 File Offset: 0x0007A338
		internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			if (originalAssemblyName == newAssemblyName)
			{
				return true;
			}
			AssemblyName assemblyName = new AssemblyName(originalAssemblyName);
			AssemblyName assemblyName2 = new AssemblyName(newAssemblyName);
			return !string.Equals(assemblyName2.Name, "mscorlib", StringComparison.OrdinalIgnoreCase) && !string.Equals(assemblyName2.Name, "mscorlib.dll", StringComparison.OrdinalIgnoreCase) && SerializationInfo.Compare(assemblyName.GetPublicKeyToken(), assemblyName2.GetPublicKeyToken());
		}

		/// <summary>Gets the number of members that have been added to the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <returns>The number of members that have been added to the current <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0007C197 File Offset: 0x0007A397
		public int MemberCount
		{
			get
			{
				return this.m_currMember;
			}
		}

		/// <summary>Returns the type of the object to be serialized.</summary>
		/// <returns>The type of the object being serialized.</returns>
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0007C19F File Offset: 0x0007A39F
		public Type ObjectType
		{
			get
			{
				return this.objectType;
			}
		}

		/// <summary>Gets whether the full type name has been explicitly set.</summary>
		/// <returns>
		///     <see langword="True" /> if the full type name has been explicitly set; otherwise <see langword="false" />.</returns>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0007C1A7 File Offset: 0x0007A3A7
		public bool IsFullTypeNameSetExplicit
		{
			get
			{
				return this.isFullTypeNameSetExplicit;
			}
		}

		/// <summary>Gets whether the assembly name has been explicitly set.</summary>
		/// <returns>
		///     <see langword="True" /> if the assembly name has been explicitly set; otherwise <see langword="false" />.</returns>
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0007C1AF File Offset: 0x0007A3AF
		public bool IsAssemblyNameSetExplicit
		{
			get
			{
				return this.isAssemblyNameSetExplicit;
			}
		}

		/// <summary>Returns a <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" /> used to iterate through the name-value pairs in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <returns>A <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" /> for parsing the name-value pairs contained in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</returns>
		// Token: 0x06001D5F RID: 7519 RVA: 0x0007C1B7 File Offset: 0x0007A3B7
		public SerializationInfoEnumerator GetEnumerator()
		{
			return new SerializationInfoEnumerator(this.m_members, this.m_data, this.m_types, this.m_currMember);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0007C1D8 File Offset: 0x0007A3D8
		private void ExpandArrays()
		{
			int num = this.m_currMember * 2;
			if (num < this.m_currMember && 2147483647 > this.m_currMember)
			{
				num = int.MaxValue;
			}
			string[] array = new string[num];
			object[] array2 = new object[num];
			Type[] array3 = new Type[num];
			Array.Copy(this.m_members, array, this.m_currMember);
			Array.Copy(this.m_data, array2, this.m_currMember);
			Array.Copy(this.m_types, array3, this.m_currMember);
			this.m_members = array;
			this.m_data = array2;
			this.m_types = array3;
		}

		/// <summary>Adds a value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where <paramref name="value" /> is associated with <paramref name="name" /> and is serialized as being of <see cref="T:System.Type" /><paramref name="type" />.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The value to be serialized. Any children of this object will automatically be serialized. </param>
		/// <param name="type">The <see cref="T:System.Type" /> to associate with the current object. This parameter must always be the type of the object itself or of one of its base classes. </param>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="name" /> or <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D61 RID: 7521 RVA: 0x0007C26A File Offset: 0x0007A46A
		public void AddValue(string name, object value, Type type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.AddValueInternal(name, value, type);
		}

		/// <summary>Adds the specified object into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where it is associated with a specified name.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The value to be serialized. Any children of this object will automatically be serialized. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D62 RID: 7522 RVA: 0x0007C291 File Offset: 0x0007A491
		public void AddValue(string name, object value)
		{
			if (value == null)
			{
				this.AddValue(name, value, typeof(object));
				return;
			}
			this.AddValue(name, value, value.GetType());
		}

		/// <summary>Adds a Boolean value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The Boolean value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D63 RID: 7523 RVA: 0x0007C2B7 File Offset: 0x0007A4B7
		public void AddValue(string name, bool value)
		{
			this.AddValue(name, value, typeof(bool));
		}

		/// <summary>Adds an 8-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The byte value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D64 RID: 7524 RVA: 0x0007C2D0 File Offset: 0x0007A4D0
		public void AddValue(string name, byte value)
		{
			this.AddValue(name, value, typeof(byte));
		}

		/// <summary>Adds a 16-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The <see langword="Int16" /> value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D65 RID: 7525 RVA: 0x0007C2E9 File Offset: 0x0007A4E9
		public void AddValue(string name, short value)
		{
			this.AddValue(name, value, typeof(short));
		}

		/// <summary>Adds a 32-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The <see langword="Int32" /> value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D66 RID: 7526 RVA: 0x0007C302 File Offset: 0x0007A502
		public void AddValue(string name, int value)
		{
			this.AddValue(name, value, typeof(int));
		}

		/// <summary>Adds a 64-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The Int64 value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D67 RID: 7527 RVA: 0x0007C31B File Offset: 0x0007A51B
		public void AddValue(string name, long value)
		{
			this.AddValue(name, value, typeof(long));
		}

		/// <summary>Adds a 64-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The <see langword="UInt64" /> value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D68 RID: 7528 RVA: 0x0007C334 File Offset: 0x0007A534
		[CLSCompliant(false)]
		public void AddValue(string name, ulong value)
		{
			this.AddValue(name, value, typeof(ulong));
		}

		/// <summary>Adds a single-precision floating-point value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The single value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D69 RID: 7529 RVA: 0x0007C34D File Offset: 0x0007A54D
		public void AddValue(string name, float value)
		{
			this.AddValue(name, value, typeof(float));
		}

		/// <summary>Adds a <see cref="T:System.DateTime" /> value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name to associate with the value, so it can be deserialized later. </param>
		/// <param name="value">The <see cref="T:System.DateTime" /> value to serialize. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
		// Token: 0x06001D6A RID: 7530 RVA: 0x0007C366 File Offset: 0x0007A566
		public void AddValue(string name, DateTime value)
		{
			this.AddValue(name, value, typeof(DateTime));
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0007C380 File Offset: 0x0007A580
		internal void AddValueInternal(string name, object value, Type type)
		{
			if (this.m_nameToIndex.ContainsKey(name))
			{
				throw new SerializationException(Environment.GetResourceString("Cannot add the same member twice to a SerializationInfo object."));
			}
			this.m_nameToIndex.Add(name, this.m_currMember);
			if (this.m_currMember >= this.m_members.Length)
			{
				this.ExpandArrays();
			}
			this.m_members[this.m_currMember] = name;
			this.m_data[this.m_currMember] = value;
			this.m_types[this.m_currMember] = type;
			this.m_currMember++;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0007C40C File Offset: 0x0007A60C
		internal void UpdateValue(string name, object value, Type type)
		{
			int num = this.FindElement(name);
			if (num < 0)
			{
				this.AddValueInternal(name, value, type);
				return;
			}
			this.m_data[num] = value;
			this.m_types[num] = type;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0007C444 File Offset: 0x0007A644
		private int FindElement(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			int result;
			if (this.m_nameToIndex.TryGetValue(name, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0007C474 File Offset: 0x0007A674
		private object GetElement(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				throw new SerializationException(Environment.GetResourceString("Member '{0}' was not found.", new object[]
				{
					name
				}));
			}
			foundType = this.m_types[num];
			return this.m_data[num];
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0007C4BC File Offset: 0x0007A6BC
		[ComVisible(true)]
		private object GetElementNoThrow(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				foundType = null;
				return null;
			}
			foundType = this.m_types[num];
			return this.m_data[num];
		}

		/// <summary>Retrieves a value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name associated with the value to retrieve.</param>
		/// <param name="type">The <see cref="T:System.Type" /> of the value to retrieve. If the stored value cannot be converted to this type, the system will throw a <see cref="T:System.InvalidCastException" />. </param>
		/// <returns>The object of the specified <see cref="T:System.Type" /> associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> or <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to <paramref name="type" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D70 RID: 7536 RVA: 0x0007C4EC File Offset: 0x0007A6EC
		[SecuritySafeCritical]
		public object GetValue(string name, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a runtime Type object."));
			}
			Type type2;
			object element = this.GetElement(name, out type2);
			if (RemotingServices.IsTransparentProxy(element))
			{
				if (RemotingServices.ProxyCheckCast(RemotingServices.GetRealProxy(element), runtimeType))
				{
					return element;
				}
			}
			else if (type2 == type || type.IsAssignableFrom(type2) || element == null)
			{
				return element;
			}
			return this.m_converter.Convert(element, type);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0007C568 File Offset: 0x0007A768
		[SecuritySafeCritical]
		[ComVisible(true)]
		internal object GetValueNoThrow(string name, Type type)
		{
			Type type2;
			object elementNoThrow = this.GetElementNoThrow(name, out type2);
			if (elementNoThrow == null)
			{
				return null;
			}
			if (RemotingServices.IsTransparentProxy(elementNoThrow))
			{
				if (RemotingServices.ProxyCheckCast(RemotingServices.GetRealProxy(elementNoThrow), (RuntimeType)type))
				{
					return elementNoThrow;
				}
			}
			else if (type2 == type || type.IsAssignableFrom(type2) || elementNoThrow == null)
			{
				return elementNoThrow;
			}
			return this.m_converter.Convert(elementNoThrow, type);
		}

		/// <summary>Retrieves a Boolean value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name associated with the value to retrieve. </param>
		/// <returns>The Boolean value associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a Boolean value. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D72 RID: 7538 RVA: 0x0007C5C0 File Offset: 0x0007A7C0
		public bool GetBoolean(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(bool))
			{
				return (bool)element;
			}
			return this.m_converter.ToBoolean(element);
		}

		/// <summary>Retrieves a 32-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name of the value to retrieve. </param>
		/// <returns>The 32-bit signed integer associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 32-bit signed integer. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D73 RID: 7539 RVA: 0x0007C5F8 File Offset: 0x0007A7F8
		public int GetInt32(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(int))
			{
				return (int)element;
			}
			return this.m_converter.ToInt32(element);
		}

		/// <summary>Retrieves a 64-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name associated with the value to retrieve.</param>
		/// <returns>The 64-bit signed integer associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 64-bit signed integer. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D74 RID: 7540 RVA: 0x0007C630 File Offset: 0x0007A830
		public long GetInt64(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(long))
			{
				return (long)element;
			}
			return this.m_converter.ToInt64(element);
		}

		/// <summary>Retrieves a single-precision floating-point value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name of the value to retrieve. </param>
		/// <returns>The single-precision floating-point value associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a single-precision floating-point value. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D75 RID: 7541 RVA: 0x0007C668 File Offset: 0x0007A868
		public float GetSingle(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(float))
			{
				return (float)element;
			}
			return this.m_converter.ToSingle(element);
		}

		/// <summary>Retrieves a <see cref="T:System.String" /> value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
		/// <param name="name">The name associated with the value to retrieve.</param>
		/// <returns>The <see cref="T:System.String" /> associated with <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a <see cref="T:System.String" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
		// Token: 0x06001D76 RID: 7542 RVA: 0x0007C6A0 File Offset: 0x0007A8A0
		public string GetString(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(string) || element == null)
			{
				return (string)element;
			}
			return this.m_converter.ToString(element);
		}

		// Token: 0x04000C43 RID: 3139
		internal string[] m_members;

		// Token: 0x04000C44 RID: 3140
		internal object[] m_data;

		// Token: 0x04000C45 RID: 3141
		internal Type[] m_types;

		// Token: 0x04000C46 RID: 3142
		private Dictionary<string, int> m_nameToIndex;

		// Token: 0x04000C47 RID: 3143
		internal int m_currMember;

		// Token: 0x04000C48 RID: 3144
		internal IFormatterConverter m_converter;

		// Token: 0x04000C49 RID: 3145
		private string m_fullTypeName;

		// Token: 0x04000C4A RID: 3146
		private string m_assemName;

		// Token: 0x04000C4B RID: 3147
		private Type objectType;

		// Token: 0x04000C4C RID: 3148
		private bool isFullTypeNameSetExplicit;

		// Token: 0x04000C4D RID: 3149
		private bool isAssemblyNameSetExplicit;

		// Token: 0x04000C4E RID: 3150
		private bool requireSameTokenInPartialTrust;
	}
}

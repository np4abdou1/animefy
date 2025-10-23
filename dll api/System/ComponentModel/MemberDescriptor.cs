using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Represents a class member, such as a property or event. This is an abstract base class.</summary>
	// Token: 0x0200029E RID: 670
	[ComVisible(true)]
	public abstract class MemberDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MemberDescriptor" /> class with the specified name of the member and an array of attributes.</summary>
		/// <param name="name">The name of the member. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that contains the member attributes. </param>
		/// <exception cref="T:System.ArgumentException">The name is an empty string ("") or <see langword="null" />. </exception>
		// Token: 0x060011A2 RID: 4514 RVA: 0x00052BB4 File Offset: 0x00050DB4
		protected MemberDescriptor(string name, Attribute[] attributes)
		{
			try
			{
				if (name == null || name.Length == 0)
				{
					throw new ArgumentException(SR.GetString("Invalid member name."));
				}
				this.name = name;
				this.displayName = name;
				this.nameHash = name.GetHashCode();
				if (attributes != null)
				{
					this.attributes = attributes;
					this.attributesFiltered = false;
				}
				this.originalAttributes = this.attributes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MemberDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the old <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
		/// <param name="oldMemberDescriptor">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that has the name of the member and its attributes. </param>
		/// <param name="newAttributes">An array of <see cref="T:System.Attribute" /> objects with the attributes you want to add to the member. </param>
		// Token: 0x060011A3 RID: 4515 RVA: 0x00052C38 File Offset: 0x00050E38
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
			this.name = oldMemberDescriptor.Name;
			this.displayName = oldMemberDescriptor.DisplayName;
			this.nameHash = this.name.GetHashCode();
			ArrayList arrayList = new ArrayList();
			if (oldMemberDescriptor.Attributes.Count != 0)
			{
				foreach (object value in oldMemberDescriptor.Attributes)
				{
					arrayList.Add(value);
				}
			}
			if (newAttributes != null)
			{
				foreach (Attribute value2 in newAttributes)
				{
					arrayList.Add(value2);
				}
			}
			this.attributes = new Attribute[arrayList.Count];
			arrayList.CopyTo(this.attributes, 0);
			this.attributesFiltered = false;
			this.originalAttributes = this.attributes;
		}

		/// <summary>Gets or sets an array of attributes.</summary>
		/// <returns>An array of type <see cref="T:System.Attribute" /> that contains the attributes of this member. </returns>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00052D34 File Offset: 0x00050F34
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00052D48 File Offset: 0x00050F48
		protected virtual Attribute[] AttributeArray
		{
			get
			{
				this.CheckAttributesValid();
				this.FilterAttributesIfNeeded();
				return this.attributes;
			}
			set
			{
				object obj = this.lockCookie;
				lock (obj)
				{
					this.attributes = value;
					this.originalAttributes = value;
					this.attributesFiltered = false;
					this.attributeCollection = null;
				}
			}
		}

		/// <summary>Gets the collection of attributes for this member.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> that provides the attributes for this member, or an empty collection if there are no attributes in the <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" />.</returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00052DA0 File Offset: 0x00050FA0
		public virtual AttributeCollection Attributes
		{
			get
			{
				this.CheckAttributesValid();
				AttributeCollection attributeCollection = this.attributeCollection;
				if (attributeCollection == null)
				{
					object obj = this.lockCookie;
					lock (obj)
					{
						attributeCollection = this.CreateAttributeCollection();
						this.attributeCollection = attributeCollection;
					}
				}
				return attributeCollection;
			}
		}

		/// <summary>Gets the name of the member.</summary>
		/// <returns>The name of the member.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00052DFC File Offset: 0x00050FFC
		public virtual string Name
		{
			get
			{
				if (this.name == null)
				{
					return "";
				}
				return this.name;
			}
		}

		/// <summary>Gets the hash code for the name of the member, as specified in <see cref="M:System.String.GetHashCode" />.</summary>
		/// <returns>The hash code for the name of the member.</returns>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00052E12 File Offset: 0x00051012
		protected virtual int NameHashCode
		{
			get
			{
				return this.nameHash;
			}
		}

		/// <summary>Gets the name that can be displayed in a window, such as a Properties window.</summary>
		/// <returns>The name to display for the member.</returns>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00052E1C File Offset: 0x0005101C
		public virtual string DisplayName
		{
			get
			{
				DisplayNameAttribute displayNameAttribute = this.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;
				if (displayNameAttribute == null || displayNameAttribute.IsDefaultAttribute())
				{
					return this.displayName;
				}
				return displayNameAttribute.DisplayName;
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00052E5C File Offset: 0x0005105C
		private void CheckAttributesValid()
		{
			if (this.attributesFiltered && this.metadataVersion != TypeDescriptor.MetadataVersion)
			{
				this.attributesFilled = false;
				this.attributesFiltered = false;
				this.attributeCollection = null;
			}
		}

		/// <summary>Creates a collection of attributes using the array of attributes passed to the constructor.</summary>
		/// <returns>A new <see cref="T:System.ComponentModel.AttributeCollection" /> that contains the <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" /> attributes.</returns>
		// Token: 0x060011AB RID: 4523 RVA: 0x00052E88 File Offset: 0x00051088
		protected virtual AttributeCollection CreateAttributeCollection()
		{
			return new AttributeCollection(this.AttributeArray);
		}

		/// <summary>Compares this instance to the given object to see if they are equivalent.</summary>
		/// <param name="obj">The object to compare to the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if equivalent; otherwise, <see langword="false" />.</returns>
		// Token: 0x060011AC RID: 4524 RVA: 0x00052E98 File Offset: 0x00051098
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			MemberDescriptor memberDescriptor = (MemberDescriptor)obj;
			this.FilterAttributesIfNeeded();
			memberDescriptor.FilterAttributesIfNeeded();
			if (memberDescriptor.nameHash != this.nameHash)
			{
				return false;
			}
			if (memberDescriptor.category == null != (this.category == null) || (this.category != null && !memberDescriptor.category.Equals(this.category)))
			{
				return false;
			}
			if (!LocalAppContextSwitches.MemberDescriptorEqualsReturnsFalseIfEquivalent)
			{
				if (memberDescriptor.description == null != (this.description == null) || (this.description != null && !memberDescriptor.description.Equals(this.description)))
				{
					return false;
				}
			}
			else if (memberDescriptor.description == null != (this.description == null) || (this.description != null && !memberDescriptor.category.Equals(this.description)))
			{
				return false;
			}
			if (memberDescriptor.attributes == null != (this.attributes == null))
			{
				return false;
			}
			bool result = true;
			if (this.attributes != null)
			{
				if (this.attributes.Length != memberDescriptor.attributes.Length)
				{
					return false;
				}
				for (int i = 0; i < this.attributes.Length; i++)
				{
					if (!this.attributes[i].Equals(memberDescriptor.attributes[i]))
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		/// <summary>When overridden in a derived class, adds the attributes of the inheriting class to the specified list of attributes in the parent class.</summary>
		/// <param name="attributeList">An <see cref="T:System.Collections.IList" /> that lists the attributes in the parent class. Initially, this is empty. </param>
		// Token: 0x060011AD RID: 4525 RVA: 0x00052FE8 File Offset: 0x000511E8
		protected virtual void FillAttributes(IList attributeList)
		{
			if (this.originalAttributes != null)
			{
				foreach (Attribute value in this.originalAttributes)
				{
					attributeList.Add(value);
				}
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00053020 File Offset: 0x00051220
		private void FilterAttributesIfNeeded()
		{
			if (!this.attributesFiltered)
			{
				IList list;
				if (!this.attributesFilled)
				{
					list = new ArrayList();
					try
					{
						this.FillAttributes(list);
						goto IL_34;
					}
					catch (ThreadAbortException)
					{
						throw;
					}
					catch (Exception)
					{
						goto IL_34;
					}
				}
				list = new ArrayList(this.attributes);
				IL_34:
				Hashtable hashtable = new Hashtable(list.Count);
				foreach (object obj in list)
				{
					Attribute attribute = (Attribute)obj;
					hashtable[attribute.TypeId] = attribute;
				}
				Attribute[] array = new Attribute[hashtable.Values.Count];
				hashtable.Values.CopyTo(array, 0);
				object obj2 = this.lockCookie;
				lock (obj2)
				{
					this.attributes = array;
					this.attributesFiltered = true;
					this.attributesFilled = true;
					this.metadataVersion = TypeDescriptor.MetadataVersion;
				}
			}
		}

		/// <summary>Finds the given method through reflection, searching only for public methods.</summary>
		/// <param name="componentClass">The component that contains the method. </param>
		/// <param name="name">The name of the method to find. </param>
		/// <param name="args">An array of parameters for the method, used to choose between overloaded methods. </param>
		/// <param name="returnType">The type to return for the method. </param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents the method, or <see langword="null" /> if the method is not found.</returns>
		// Token: 0x060011AF RID: 4527 RVA: 0x00053144 File Offset: 0x00051344
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			return MemberDescriptor.FindMethod(componentClass, name, args, returnType, true);
		}

		/// <summary>Finds the given method through reflection, with an option to search only public methods.</summary>
		/// <param name="componentClass">The component that contains the method. </param>
		/// <param name="name">The name of the method to find. </param>
		/// <param name="args">An array of parameters for the method, used to choose between overloaded methods. </param>
		/// <param name="returnType">The type to return for the method. </param>
		/// <param name="publicOnly">Whether to restrict search to public methods. </param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents the method, or <see langword="null" /> if the method is not found.</returns>
		// Token: 0x060011B0 RID: 4528 RVA: 0x00053150 File Offset: 0x00051350
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			MethodInfo methodInfo;
			if (publicOnly)
			{
				methodInfo = componentClass.GetMethod(name, args);
			}
			else
			{
				methodInfo = componentClass.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, args, null);
			}
			if (methodInfo != null && !methodInfo.ReturnType.IsEquivalentTo(returnType))
			{
				methodInfo = null;
			}
			return methodInfo;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.MemberDescriptor" />.</returns>
		// Token: 0x060011B1 RID: 4529 RVA: 0x00052E12 File Offset: 0x00051012
		public override int GetHashCode()
		{
			return this.nameHash;
		}

		/// <summary>Retrieves the object that should be used during invocation of members.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the invocation target.</param>
		/// <param name="instance">The potential invocation target.</param>
		/// <returns>The object to be used during member invocations.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> or <paramref name="instance" /> is <see langword="null" />.</exception>
		// Token: 0x060011B2 RID: 4530 RVA: 0x00053195 File Offset: 0x00051395
		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return TypeDescriptor.GetAssociation(type, instance);
		}

		/// <summary>Gets a component site for the given component.</summary>
		/// <param name="component">The component for which you want to find a site. </param>
		/// <returns>The site of the component, or <see langword="null" /> if a site does not exist.</returns>
		// Token: 0x060011B3 RID: 4531 RVA: 0x000531C0 File Offset: 0x000513C0
		protected static ISite GetSite(object component)
		{
			if (!(component is IComponent))
			{
				return null;
			}
			return ((IComponent)component).Site;
		}

		// Token: 0x04000CA4 RID: 3236
		private string name;

		// Token: 0x04000CA5 RID: 3237
		private string displayName;

		// Token: 0x04000CA6 RID: 3238
		private int nameHash;

		// Token: 0x04000CA7 RID: 3239
		private AttributeCollection attributeCollection;

		// Token: 0x04000CA8 RID: 3240
		private Attribute[] attributes;

		// Token: 0x04000CA9 RID: 3241
		private Attribute[] originalAttributes;

		// Token: 0x04000CAA RID: 3242
		private bool attributesFiltered;

		// Token: 0x04000CAB RID: 3243
		private bool attributesFilled;

		// Token: 0x04000CAC RID: 3244
		private int metadataVersion;

		// Token: 0x04000CAD RID: 3245
		private string category;

		// Token: 0x04000CAE RID: 3246
		private string description;

		// Token: 0x04000CAF RID: 3247
		private object lockCookie = new object();
	}
}

﻿using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;

namespace System.Runtime.Serialization
{
	/// <summary>Keeps track of objects as they are deserialized.</summary>
	// Token: 0x020003A5 RID: 933
	[ComVisible(true)]
	public class ObjectManager
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x0007A33E File Offset: 0x0007853E
		[SecurityCritical]
		internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
		{
			this.m_objects = new ObjectHolder[16];
			this.m_selector = selector;
			this.m_context = context;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0007A363 File Offset: 0x00078563
		[SecurityCritical]
		private bool CanCallGetType(object obj)
		{
			return !RemotingServices.IsTransparentProxy(obj);
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0007A379 File Offset: 0x00078579
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0007A370 File Offset: 0x00078570
		internal object TopObject
		{
			get
			{
				return this.m_topObject;
			}
			set
			{
				this.m_topObject = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0007A381 File Offset: 0x00078581
		internal ObjectHolderList SpecialFixupObjects
		{
			get
			{
				if (this.m_specialFixupObjects == null)
				{
					this.m_specialFixupObjects = new ObjectHolderList();
				}
				return this.m_specialFixupObjects;
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0007A39C File Offset: 0x0007859C
		internal ObjectHolder FindObjectHolder(long objectID)
		{
			int num = (int)(objectID & 4095L);
			if (num >= this.m_objects.Length)
			{
				return null;
			}
			ObjectHolder objectHolder;
			for (objectHolder = this.m_objects[num]; objectHolder != null; objectHolder = objectHolder.m_next)
			{
				if (objectHolder.m_id == objectID)
				{
					return objectHolder;
				}
			}
			return objectHolder;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0007A3E4 File Offset: 0x000785E4
		internal ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			ObjectHolder objectHolder = this.FindObjectHolder(objectID);
			if (objectHolder == null)
			{
				objectHolder = new ObjectHolder(objectID);
				this.AddObjectHolder(objectHolder);
			}
			return objectHolder;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0007A40C File Offset: 0x0007860C
		private void AddObjectHolder(ObjectHolder holder)
		{
			if (holder.m_id >= (long)this.m_objects.Length && this.m_objects.Length != 4096)
			{
				int num = 4096;
				if (holder.m_id < 2048L)
				{
					num = this.m_objects.Length * 2;
					while ((long)num <= holder.m_id && num < 4096)
					{
						num *= 2;
					}
					if (num > 4096)
					{
						num = 4096;
					}
				}
				ObjectHolder[] array = new ObjectHolder[num];
				Array.Copy(this.m_objects, array, this.m_objects.Length);
				this.m_objects = array;
			}
			int num2 = (int)(holder.m_id & 4095L);
			ObjectHolder next = this.m_objects[num2];
			holder.m_next = next;
			this.m_objects[num2] = holder;
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0007A4C8 File Offset: 0x000786C8
		private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing)
		{
			member = fixup.m_fixupInfo;
			holder = this.FindObjectHolder(fixup.m_id);
			if (!holder.CompletelyFixed && holder.ObjectValue != null && holder.ObjectValue is ValueType)
			{
				this.SpecialFixupObjects.Add(holder);
				return false;
			}
			if (holder != null && !holder.CanObjectValueChange && holder.ObjectValue != null)
			{
				return true;
			}
			if (!bThrowIfMissing)
			{
				return false;
			}
			if (holder == null)
			{
				throw new SerializationException(Environment.GetResourceString("A fixup is registered to the object with ID {0}, but the object does not appear in the graph.", new object[]
				{
					fixup.m_id
				}));
			}
			if (holder.IsIncompleteObjectReference)
			{
				throw new SerializationException(Environment.GetResourceString("The object with ID {0} implements the IObjectReference interface for which all dependencies cannot be resolved. The likely cause is two instances of IObjectReference that have a mutual dependency on each other.", new object[]
				{
					fixup.m_id
				}));
			}
			throw new SerializationException(Environment.GetResourceString("The object with ID {0} was referenced in a fixup but does not exist.", new object[]
			{
				fixup.m_id
			}));
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0007A5B0 File Offset: 0x000787B0
		[SecurityCritical]
		private void FixupSpecialObject(ObjectHolder holder)
		{
			ISurrogateSelector selector = null;
			if (holder.HasSurrogate)
			{
				ISerializationSurrogate surrogate = holder.Surrogate;
				object obj = surrogate.SetObjectData(holder.ObjectValue, holder.SerializationInfo, this.m_context, selector);
				if (obj != null)
				{
					if (!holder.CanSurrogatedObjectValueChange && obj != holder.ObjectValue)
					{
						throw new SerializationException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("{0}.SetObjectData returns a value that is neither null nor equal to the first parameter. Such Surrogates cannot be part of cyclical reference."), surrogate.GetType().FullName));
					}
					holder.SetObjectValue(obj, this);
				}
				holder.m_surrogate = null;
				holder.SetFlags();
			}
			else
			{
				this.CompleteISerializableObject(holder.ObjectValue, holder.SerializationInfo, this.m_context);
			}
			holder.SerializationInfo = null;
			holder.RequiresSerInfoFixup = false;
			if (holder.RequiresValueTypeFixup && holder.ValueTypeFixupPerformed)
			{
				this.DoValueTypeFixup(null, holder, holder.ObjectValue);
			}
			this.DoNewlyRegisteredObjectFixups(holder);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0007A684 File Offset: 0x00078884
		[SecurityCritical]
		private bool ResolveObjectReference(ObjectHolder holder)
		{
			int num = 0;
			try
			{
				object objectValue;
				for (;;)
				{
					objectValue = holder.ObjectValue;
					holder.SetObjectValue(((IObjectReference)holder.ObjectValue).GetRealObject(this.m_context), this);
					if (holder.ObjectValue == null)
					{
						break;
					}
					if (num++ == 100)
					{
						goto Block_3;
					}
					if (!(holder.ObjectValue is IObjectReference) || objectValue == holder.ObjectValue)
					{
						goto IL_69;
					}
				}
				holder.SetObjectValue(objectValue, this);
				return false;
				Block_3:
				throw new SerializationException(Environment.GetResourceString("The implementation of the IObjectReference interface returns too many nested references to other objects that implement IObjectReference."));
				IL_69:;
			}
			catch (NullReferenceException)
			{
				return false;
			}
			holder.IsIncompleteObjectReference = false;
			this.DoNewlyRegisteredObjectFixups(holder);
			return true;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0007A724 File Offset: 0x00078924
		[SecurityCritical]
		private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value)
		{
			FieldInfo[] array = new FieldInfo[4];
			int num = 0;
			int[] array2 = null;
			object objectValue = holder.ObjectValue;
			while (holder.RequiresValueTypeFixup)
			{
				if (num + 1 >= array.Length)
				{
					FieldInfo[] array3 = new FieldInfo[array.Length * 2];
					Array.Copy(array, array3, array.Length);
					array = array3;
				}
				ValueTypeFixupInfo valueFixup = holder.ValueFixup;
				objectValue = holder.ObjectValue;
				if (valueFixup.ParentField != null)
				{
					FieldInfo parentField = valueFixup.ParentField;
					ObjectHolder objectHolder = this.FindObjectHolder(valueFixup.ContainerID);
					if (objectHolder.ObjectValue == null)
					{
						break;
					}
					if (Nullable.GetUnderlyingType(parentField.FieldType) != null)
					{
						array[num] = parentField.FieldType.GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
						num++;
					}
					array[num] = parentField;
					holder = objectHolder;
					num++;
				}
				else
				{
					holder = this.FindObjectHolder(valueFixup.ContainerID);
					array2 = valueFixup.ParentIndex;
					if (holder.ObjectValue == null)
					{
						break;
					}
					break;
				}
			}
			if (!(holder.ObjectValue is Array) && holder.ObjectValue != null)
			{
				objectValue = holder.ObjectValue;
			}
			if (num != 0)
			{
				FieldInfo[] array4 = new FieldInfo[num];
				for (int i = 0; i < num; i++)
				{
					FieldInfo fieldInfo = array[num - 1 - i];
					SerializationFieldInfo serializationFieldInfo = fieldInfo as SerializationFieldInfo;
					array4[i] = ((serializationFieldInfo == null) ? fieldInfo : serializationFieldInfo.FieldInfo);
				}
				TypedReference typedReference = TypedReference.MakeTypedReference(objectValue, array4);
				if (memberToFix != null)
				{
					((RuntimeFieldInfo)memberToFix).SetValueDirect(typedReference, value);
				}
				else
				{
					TypedReference.SetTypedReference(typedReference, value);
				}
			}
			else if (memberToFix != null)
			{
				FormatterServices.SerializationSetValue(memberToFix, objectValue, value);
			}
			if (array2 != null && holder.ObjectValue != null)
			{
				((Array)holder.ObjectValue).SetValue(objectValue, array2);
			}
			return true;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0007A8DC File Offset: 0x00078ADC
		[SecurityCritical]
		internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			FixupHolderList missingElements = holder.m_missingElements;
			object obj = null;
			ObjectHolder objectHolder = null;
			int num = 0;
			if (holder.ObjectValue == null)
			{
				throw new SerializationException(Environment.GetResourceString("The object with ID {0} was referenced in a fixup but has not been registered.", new object[]
				{
					holder.m_id
				}));
			}
			if (missingElements == null)
			{
				return;
			}
			if (holder.HasSurrogate || holder.HasISerializable)
			{
				SerializationInfo serInfo = holder.m_serInfo;
				if (serInfo == null)
				{
					throw new SerializationException(Environment.GetResourceString("A fixup on an object implementing ISerializable or having a surrogate was discovered for an object which does not have a SerializationInfo available."));
				}
				if (missingElements != null)
				{
					for (int i = 0; i < missingElements.m_count; i++)
					{
						if (missingElements.m_values[i] != null && this.GetCompletionInfo(missingElements.m_values[i], out objectHolder, out obj, bObjectFullyComplete))
						{
							object objectValue = objectHolder.ObjectValue;
							if (this.CanCallGetType(objectValue))
							{
								serInfo.UpdateValue((string)obj, objectValue, objectValue.GetType());
							}
							else
							{
								serInfo.UpdateValue((string)obj, objectValue, typeof(MarshalByRefObject));
							}
							num++;
							missingElements.m_values[i] = null;
							if (!bObjectFullyComplete)
							{
								holder.DecrementFixupsRemaining(this);
								objectHolder.RemoveDependency(holder.m_id);
							}
						}
					}
				}
			}
			else
			{
				for (int j = 0; j < missingElements.m_count; j++)
				{
					FixupHolder fixupHolder = missingElements.m_values[j];
					if (fixupHolder != null && this.GetCompletionInfo(fixupHolder, out objectHolder, out obj, bObjectFullyComplete))
					{
						if (objectHolder.TypeLoadExceptionReachable)
						{
							holder.TypeLoadException = objectHolder.TypeLoadException;
							if (holder.Reachable)
							{
								throw new SerializationException(Environment.GetResourceString("Unable to load type {0} required for deserialization.", new object[]
								{
									holder.TypeLoadException.TypeName
								}));
							}
						}
						if (holder.Reachable)
						{
							objectHolder.Reachable = true;
						}
						int fixupType = fixupHolder.m_fixupType;
						if (fixupType != 1)
						{
							if (fixupType != 2)
							{
								throw new SerializationException(Environment.GetResourceString("Cannot perform fixup."));
							}
							MemberInfo memberInfo = (MemberInfo)obj;
							if (memberInfo.MemberType != MemberTypes.Field)
							{
								throw new SerializationException(Environment.GetResourceString("Cannot perform fixup."));
							}
							if (holder.RequiresValueTypeFixup && holder.ValueTypeFixupPerformed)
							{
								if (!this.DoValueTypeFixup((FieldInfo)memberInfo, holder, objectHolder.ObjectValue))
								{
									throw new SerializationException(Environment.GetResourceString("Fixing up a partially available ValueType chain is not implemented."));
								}
							}
							else
							{
								FormatterServices.SerializationSetValue(memberInfo, holder.ObjectValue, objectHolder.ObjectValue);
							}
							if (objectHolder.RequiresValueTypeFixup)
							{
								objectHolder.ValueTypeFixupPerformed = true;
							}
						}
						else
						{
							if (holder.RequiresValueTypeFixup)
							{
								throw new SerializationException(Environment.GetResourceString("ValueType fixup on Arrays is not implemented."));
							}
							((Array)holder.ObjectValue).SetValue(objectHolder.ObjectValue, (int[])obj);
						}
						num++;
						missingElements.m_values[j] = null;
						if (!bObjectFullyComplete)
						{
							holder.DecrementFixupsRemaining(this);
							objectHolder.RemoveDependency(holder.m_id);
						}
					}
				}
			}
			this.m_fixupCount -= (long)num;
			if (missingElements.m_count == num)
			{
				holder.m_missingElements = null;
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0007ABBC File Offset: 0x00078DBC
		[SecurityCritical]
		private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			if (holder.CanObjectValueChange)
			{
				return;
			}
			LongList dependentObjects = holder.DependentObjects;
			if (dependentObjects == null)
			{
				return;
			}
			dependentObjects.StartEnumeration();
			while (dependentObjects.MoveNext())
			{
				long objectID = dependentObjects.Current;
				ObjectHolder objectHolder = this.FindObjectHolder(objectID);
				objectHolder.DecrementFixupsRemaining(this);
				if (objectHolder.DirectlyDependentObjects == 0)
				{
					if (objectHolder.ObjectValue != null)
					{
						this.CompleteObject(objectHolder, true);
					}
					else
					{
						objectHolder.MarkForCompletionWhenAvailable();
					}
				}
			}
		}

		/// <summary>Returns the object with the specified object ID.</summary>
		/// <param name="objectID">The ID of the requested object. </param>
		/// <returns>The object with the specified object ID if it has been previously stored or <see langword="null" /> if no such object has been registered.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception>
		// Token: 0x06001CDF RID: 7391 RVA: 0x0007AC24 File Offset: 0x00078E24
		public virtual object GetObject(long objectID)
		{
			if (objectID <= 0L)
			{
				throw new ArgumentOutOfRangeException("objectID", Environment.GetResourceString("objectID cannot be less than or equal to zero."));
			}
			ObjectHolder objectHolder = this.FindObjectHolder(objectID);
			if (objectHolder == null || objectHolder.CanObjectValueChange)
			{
				return null;
			}
			return objectHolder.ObjectValue;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0007AC68 File Offset: 0x00078E68
		internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
		{
			ObjectHolder holder = new ObjectHolder(obj, objectID, info, null, idOfContainingObj, (FieldInfo)member, null);
			this.AddObjectHolder(holder);
		}

		/// <summary>Registers a member of an array contained in an object while it is deserialized, associating it with <paramref name="objectID" />, and recording the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="obj">The object to register. </param>
		/// <param name="objectID">The ID of the object to register. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used if <paramref name="obj" /> implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or has a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. <paramref name="info" /> will be completed with any required fixup information and then passed to the required object when that object is completed. </param>
		/// <param name="idOfContainingObj">The ID of the object that contains <paramref name="obj" />. This parameter is required only if <paramref name="obj" /> is a value type. </param>
		/// <param name="member">The field in the containing object where <paramref name="obj" /> exists. This parameter has meaning only if <paramref name="obj" /> is a value type. </param>
		/// <param name="arrayIndex">If <paramref name="obj" /> is a <see cref="T:System.ValueType" /> and a member of an array, <paramref name="arrayIndex" /> contains the index within that array where <paramref name="obj" /> exists. <paramref name="arrayIndex" /> is ignored if <paramref name="obj" /> is not both a <see cref="T:System.ValueType" /> and a member of an array. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />, or <paramref name="member" /> is not a <see cref="T:System.Reflection.FieldInfo" /> and <paramref name="member" /> isn't <see langword="null" />. </exception>
		// Token: 0x06001CE1 RID: 7393 RVA: 0x0007AC90 File Offset: 0x00078E90
		[SecurityCritical]
		public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (objectID <= 0L)
			{
				throw new ArgumentOutOfRangeException("objectID", Environment.GetResourceString("objectID cannot be less than or equal to zero."));
			}
			if (member != null && !(member is RuntimeFieldInfo) && !(member is SerializationFieldInfo))
			{
				throw new SerializationException(Environment.GetResourceString("Only FieldInfo, PropertyInfo, and SerializationMemberInfo are recognized."));
			}
			ISerializationSurrogate surrogate = null;
			if (this.m_selector != null)
			{
				Type type;
				if (this.CanCallGetType(obj))
				{
					type = obj.GetType();
				}
				else
				{
					type = typeof(MarshalByRefObject);
				}
				ISurrogateSelector surrogateSelector;
				surrogate = this.m_selector.GetSurrogate(type, this.m_context, out surrogateSelector);
			}
			if (obj is IDeserializationCallback)
			{
				DeserializationEventHandler handler = new DeserializationEventHandler(((IDeserializationCallback)obj).OnDeserialization);
				this.AddOnDeserialization(handler);
			}
			if (arrayIndex != null)
			{
				arrayIndex = (int[])arrayIndex.Clone();
			}
			ObjectHolder objectHolder = this.FindObjectHolder(objectID);
			if (objectHolder == null)
			{
				objectHolder = new ObjectHolder(obj, objectID, info, surrogate, idOfContainingObj, (FieldInfo)member, arrayIndex);
				this.AddObjectHolder(objectHolder);
				if (objectHolder.RequiresDelayedFixup)
				{
					this.SpecialFixupObjects.Add(objectHolder);
				}
				this.AddOnDeserialized(obj);
				return;
			}
			if (objectHolder.ObjectValue != null)
			{
				throw new SerializationException(Environment.GetResourceString("An object cannot be registered twice."));
			}
			objectHolder.UpdateData(obj, info, surrogate, idOfContainingObj, (FieldInfo)member, arrayIndex, this);
			if (objectHolder.DirectlyDependentObjects > 0)
			{
				this.CompleteObject(objectHolder, false);
			}
			if (objectHolder.RequiresDelayedFixup)
			{
				this.SpecialFixupObjects.Add(objectHolder);
			}
			if (objectHolder.CompletelyFixed)
			{
				this.DoNewlyRegisteredObjectFixups(objectHolder);
				objectHolder.DependentObjects = null;
			}
			if (objectHolder.TotalDependentObjects > 0)
			{
				this.AddOnDeserialized(obj);
				return;
			}
			this.RaiseOnDeserializedEvent(obj);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0007AE28 File Offset: 0x00079028
		[SecurityCritical]
		internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (!(obj is ISerializable))
			{
				throw new ArgumentException(Environment.GetResourceString("The given object does not implement the ISerializable interface."));
			}
			RuntimeConstructorInfo runtimeConstructorInfo = null;
			RuntimeType runtimeType = (RuntimeType)obj.GetType();
			try
			{
				runtimeConstructorInfo = ObjectManager.GetConstructor(runtimeType);
			}
			catch (Exception innerException)
			{
				throw new SerializationException(Environment.GetResourceString("The constructor to deserialize an object of type '{0}' was not found.", new object[]
				{
					runtimeType
				}), innerException);
			}
			runtimeConstructorInfo.SerializationInvoke(obj, info, context);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0007AEA8 File Offset: 0x000790A8
		internal static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			RuntimeConstructorInfo serializationCtor = t.GetSerializationCtor();
			if (serializationCtor == null)
			{
				throw new SerializationException(Environment.GetResourceString("The constructor to deserialize an object of type '{0}' was not found.", new object[]
				{
					t.FullName
				}));
			}
			return serializationCtor;
		}

		/// <summary>Performs all the recorded fixups.</summary>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A fixup was not successfully completed. </exception>
		// Token: 0x06001CE4 RID: 7396 RVA: 0x0007AEE8 File Offset: 0x000790E8
		[SecuritySafeCritical]
		public virtual void DoFixups()
		{
			int num = -1;
			while (num != 0)
			{
				num = 0;
				ObjectHolderListEnumerator fixupEnumerator = this.SpecialFixupObjects.GetFixupEnumerator();
				while (fixupEnumerator.MoveNext())
				{
					ObjectHolder objectHolder = fixupEnumerator.Current;
					if (objectHolder.ObjectValue == null)
					{
						throw new SerializationException(Environment.GetResourceString("The object with ID {0} was referenced in a fixup but does not exist.", new object[]
						{
							objectHolder.m_id
						}));
					}
					if (objectHolder.TotalDependentObjects == 0)
					{
						if (objectHolder.RequiresSerInfoFixup)
						{
							this.FixupSpecialObject(objectHolder);
							num++;
						}
						else if (!objectHolder.IsIncompleteObjectReference)
						{
							this.CompleteObject(objectHolder, true);
						}
						if (objectHolder.IsIncompleteObjectReference && this.ResolveObjectReference(objectHolder))
						{
							num++;
						}
					}
				}
			}
			if (this.m_fixupCount != 0L)
			{
				for (int i = 0; i < this.m_objects.Length; i++)
				{
					for (ObjectHolder objectHolder = this.m_objects[i]; objectHolder != null; objectHolder = objectHolder.m_next)
					{
						if (objectHolder.TotalDependentObjects > 0)
						{
							this.CompleteObject(objectHolder, true);
						}
					}
					if (this.m_fixupCount == 0L)
					{
						return;
					}
				}
				throw new SerializationException(Environment.GetResourceString("The ObjectManager found an invalid number of fixups. This usually indicates a problem in the Formatter."));
			}
			if (this.TopObject is TypeLoadExceptionHolder)
			{
				throw new SerializationException(Environment.GetResourceString("Unable to load type {0} required for deserialization.", new object[]
				{
					((TypeLoadExceptionHolder)this.TopObject).TypeName
				}));
			}
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0007B020 File Offset: 0x00079220
		private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			ObjectHolder objectHolder = this.FindOrCreateObjectHolder(objectToBeFixed);
			if (objectHolder.RequiresSerInfoFixup && fixup.m_fixupType == 2)
			{
				throw new SerializationException(Environment.GetResourceString("A member fixup was registered for an object which implements ISerializable or has a surrogate. In this situation, a delayed fixup must be used."));
			}
			objectHolder.AddFixup(fixup, this);
			this.FindOrCreateObjectHolder(objectRequired).AddDependency(objectToBeFixed);
			this.m_fixupCount += 1L;
		}

		/// <summary>Records a fixup for a member of an object, to be executed later.</summary>
		/// <param name="objectToBeFixed">The ID of the object that needs the reference to the <paramref name="objectRequired" /> object. </param>
		/// <param name="member">The member of <paramref name="objectToBeFixed" /> where the fixup will be performed. </param>
		/// <param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="member" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001CE6 RID: 7398 RVA: 0x0007B078 File Offset: 0x00079278
		public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
		{
			if (objectToBeFixed <= 0L || objectRequired <= 0L)
			{
				throw new ArgumentOutOfRangeException((objectToBeFixed <= 0L) ? "objectToBeFixed" : "objectRequired", Environment.GetResourceString("Object IDs must be greater than zero."));
			}
			if (member == null)
			{
				throw new ArgumentNullException("member");
			}
			if (!(member is RuntimeFieldInfo) && !(member is SerializationFieldInfo))
			{
				throw new SerializationException(Environment.GetResourceString("Only system-provided types can be passed to the GetUninitializedObject method. '{0}' is not a valid instance of a type.", new object[]
				{
					member.GetType().ToString()
				}));
			}
			FixupHolder fixup = new FixupHolder(objectRequired, member, 2);
			this.RegisterFixup(fixup, objectToBeFixed, objectRequired);
		}

		/// <summary>Records a fixup for an object member, to be executed later.</summary>
		/// <param name="objectToBeFixed">The ID of the object that needs the reference to <paramref name="objectRequired" />. </param>
		/// <param name="memberName">The member name of <paramref name="objectToBeFixed" /> where the fixup will be performed. </param>
		/// <param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="memberName" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001CE7 RID: 7399 RVA: 0x0007B10C File Offset: 0x0007930C
		public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			if (objectToBeFixed <= 0L || objectRequired <= 0L)
			{
				throw new ArgumentOutOfRangeException((objectToBeFixed <= 0L) ? "objectToBeFixed" : "objectRequired", Environment.GetResourceString("Object IDs must be greater than zero."));
			}
			if (memberName == null)
			{
				throw new ArgumentNullException("memberName");
			}
			FixupHolder fixup = new FixupHolder(objectRequired, memberName, 4);
			this.RegisterFixup(fixup, objectToBeFixed, objectRequired);
		}

		/// <summary>Records fixups for the specified elements in an array, to be executed later.</summary>
		/// <param name="arrayToBeFixed">The ID of the array used to record a fixup. </param>
		/// <param name="indices">The indexes within the multidimensional array that a fixup is requested for. </param>
		/// <param name="objectRequired">The ID of the object the array elements will point to after fixup is completed. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="arrayToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="indices" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001CE8 RID: 7400 RVA: 0x0007B164 File Offset: 0x00079364
		public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
		{
			if (arrayToBeFixed <= 0L || objectRequired <= 0L)
			{
				throw new ArgumentOutOfRangeException((arrayToBeFixed <= 0L) ? "objectToBeFixed" : "objectRequired", Environment.GetResourceString("Object IDs must be greater than zero."));
			}
			if (indices == null)
			{
				throw new ArgumentNullException("indices");
			}
			FixupHolder fixup = new FixupHolder(objectRequired, indices, 1);
			this.RegisterFixup(fixup, arrayToBeFixed, objectRequired);
		}

		/// <summary>Raises the deserialization event to any registered object that implements <see cref="T:System.Runtime.Serialization.IDeserializationCallback" />.</summary>
		// Token: 0x06001CE9 RID: 7401 RVA: 0x0007B1BC File Offset: 0x000793BC
		public virtual void RaiseDeserializationEvent()
		{
			if (this.m_onDeserializedHandler != null)
			{
				this.m_onDeserializedHandler(this.m_context);
			}
			if (this.m_onDeserializationHandler != null)
			{
				this.m_onDeserializationHandler(null);
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0007B1EB File Offset: 0x000793EB
		internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			this.m_onDeserializationHandler = (DeserializationEventHandler)Delegate.Combine(this.m_onDeserializationHandler, handler);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0007B204 File Offset: 0x00079404
		[SecuritySafeCritical]
		internal virtual void AddOnDeserialized(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			this.m_onDeserializedHandler = serializationEventsForType.AddOnDeserialized(obj, this.m_onDeserializedHandler);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0007B230 File Offset: 0x00079430
		internal virtual void RaiseOnDeserializedEvent(object obj)
		{
			SerializationEventsCache.GetSerializationEventsForType(obj.GetType()).InvokeOnDeserialized(obj, this.m_context);
		}

		/// <summary>Invokes the method marked with the <see cref="T:System.Runtime.Serialization.OnDeserializingAttribute" />.</summary>
		/// <param name="obj">The instance of the type that contains the method to be invoked.</param>
		// Token: 0x06001CED RID: 7405 RVA: 0x0007B249 File Offset: 0x00079449
		public void RaiseOnDeserializingEvent(object obj)
		{
			SerializationEventsCache.GetSerializationEventsForType(obj.GetType()).InvokeOnDeserializing(obj, this.m_context);
		}

		// Token: 0x04000C13 RID: 3091
		private DeserializationEventHandler m_onDeserializationHandler;

		// Token: 0x04000C14 RID: 3092
		private SerializationEventHandler m_onDeserializedHandler;

		// Token: 0x04000C15 RID: 3093
		internal ObjectHolder[] m_objects;

		// Token: 0x04000C16 RID: 3094
		internal object m_topObject;

		// Token: 0x04000C17 RID: 3095
		internal ObjectHolderList m_specialFixupObjects;

		// Token: 0x04000C18 RID: 3096
		internal long m_fixupCount;

		// Token: 0x04000C19 RID: 3097
		internal ISurrogateSelector m_selector;

		// Token: 0x04000C1A RID: 3098
		internal StreamingContext m_context;
	}
}

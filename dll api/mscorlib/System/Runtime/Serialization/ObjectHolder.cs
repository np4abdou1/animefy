using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.Serialization
{
	// Token: 0x020003A6 RID: 934
	internal sealed class ObjectHolder
	{
		// Token: 0x06001CEE RID: 7406 RVA: 0x0007B262 File Offset: 0x00079462
		internal ObjectHolder(long objID) : this(null, objID, null, null, 0L, null, null)
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0007B274 File Offset: 0x00079474
		internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
		{
			this.m_object = obj;
			this.m_id = objID;
			this.m_flags = 0;
			this.m_missingElementsRemaining = 0;
			this.m_missingDecendents = 0;
			this.m_dependentObjects = null;
			this.m_next = null;
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			this.m_markForFixupWhenAvailable = false;
			if (obj is TypeLoadExceptionHolder)
			{
				this.m_typeLoad = (TypeLoadExceptionHolder)obj;
			}
			if (idOfContainingObj != 0L && ((field != null && field.FieldType.IsValueType) || arrayIndex != null))
			{
				if (idOfContainingObj == objID)
				{
					throw new SerializationException(Environment.GetResourceString("The ID of the containing object cannot be the same as the object ID."));
				}
				this.m_valueFixup = new ValueTypeFixupInfo(idOfContainingObj, field, arrayIndex);
			}
			this.SetFlags();
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0007B330 File Offset: 0x00079530
		internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex)
		{
			this.m_object = obj;
			this.m_id = objID;
			this.m_flags = 0;
			this.m_missingElementsRemaining = 0;
			this.m_missingDecendents = 0;
			this.m_dependentObjects = null;
			this.m_next = null;
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			this.m_markForFixupWhenAvailable = false;
			if (idOfContainingObj != 0L && arrayIndex != null)
			{
				this.m_valueFixup = new ValueTypeFixupInfo(idOfContainingObj, field, arrayIndex);
			}
			if (this.m_valueFixup != null)
			{
				this.m_flags |= 8;
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0007B3B9 File Offset: 0x000795B9
		private void IncrementDescendentFixups(int amount)
		{
			this.m_missingDecendents += amount;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0007B3C9 File Offset: 0x000795C9
		internal void DecrementFixupsRemaining(ObjectManager manager)
		{
			this.m_missingElementsRemaining--;
			if (this.RequiresValueTypeFixup)
			{
				this.UpdateDescendentDependencyChain(-1, manager);
			}
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0007B3E9 File Offset: 0x000795E9
		internal void RemoveDependency(long id)
		{
			this.m_dependentObjects.RemoveElement(id);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0007B3F8 File Offset: 0x000795F8
		internal void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			if (this.m_missingElements == null)
			{
				this.m_missingElements = new FixupHolderList();
			}
			this.m_missingElements.Add(fixup);
			this.m_missingElementsRemaining++;
			if (this.RequiresValueTypeFixup)
			{
				this.UpdateDescendentDependencyChain(1, manager);
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0007B438 File Offset: 0x00079638
		private void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			ObjectHolder objectHolder = this;
			do
			{
				objectHolder = manager.FindOrCreateObjectHolder(objectHolder.ContainerID);
				objectHolder.IncrementDescendentFixups(amount);
			}
			while (objectHolder.RequiresValueTypeFixup);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0007B463 File Offset: 0x00079663
		internal void AddDependency(long dependentObject)
		{
			if (this.m_dependentObjects == null)
			{
				this.m_dependentObjects = new LongList();
			}
			this.m_dependentObjects.Add(dependentObject);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0007B484 File Offset: 0x00079684
		[SecurityCritical]
		internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager)
		{
			this.SetObjectValue(obj, manager);
			this.m_serInfo = info;
			this.m_surrogate = surrogate;
			if (idOfContainer != 0L && ((field != null && field.FieldType.IsValueType) || arrayIndex != null))
			{
				if (idOfContainer == this.m_id)
				{
					throw new SerializationException(Environment.GetResourceString("The ID of the containing object cannot be the same as the object ID."));
				}
				this.m_valueFixup = new ValueTypeFixupInfo(idOfContainer, field, arrayIndex);
			}
			this.SetFlags();
			if (this.RequiresValueTypeFixup)
			{
				this.UpdateDescendentDependencyChain(this.m_missingElementsRemaining, manager);
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0007B50F File Offset: 0x0007970F
		internal void MarkForCompletionWhenAvailable()
		{
			this.m_markForFixupWhenAvailable = true;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0007B518 File Offset: 0x00079718
		internal void SetFlags()
		{
			if (this.m_object is IObjectReference)
			{
				this.m_flags |= 1;
			}
			this.m_flags &= -7;
			if (this.m_surrogate != null)
			{
				this.m_flags |= 4;
			}
			else if (this.m_object is ISerializable)
			{
				this.m_flags |= 2;
			}
			if (this.m_valueFixup != null)
			{
				this.m_flags |= 8;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0007B598 File Offset: 0x00079798
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0007B5A5 File Offset: 0x000797A5
		internal bool IsIncompleteObjectReference
		{
			get
			{
				return (this.m_flags & 1) != 0;
			}
			set
			{
				if (value)
				{
					this.m_flags |= 1;
					return;
				}
				this.m_flags &= -2;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0007B5C8 File Offset: 0x000797C8
		internal bool RequiresDelayedFixup
		{
			get
			{
				return (this.m_flags & 7) != 0;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0007B5D5 File Offset: 0x000797D5
		internal bool RequiresValueTypeFixup
		{
			get
			{
				return (this.m_flags & 8) != 0;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0007B5E2 File Offset: 0x000797E2
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0007B616 File Offset: 0x00079816
		internal bool ValueTypeFixupPerformed
		{
			get
			{
				return (this.m_flags & 32768) != 0 || (this.m_object != null && (this.m_dependentObjects == null || this.m_dependentObjects.Count == 0));
			}
			set
			{
				if (value)
				{
					this.m_flags |= 32768;
				}
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0007B62D File Offset: 0x0007982D
		internal bool HasISerializable
		{
			get
			{
				return (this.m_flags & 2) != 0;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0007B63A File Offset: 0x0007983A
		internal bool HasSurrogate
		{
			get
			{
				return (this.m_flags & 4) != 0;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0007B647 File Offset: 0x00079847
		internal bool CanSurrogatedObjectValueChange
		{
			get
			{
				return this.m_surrogate == null || this.m_surrogate.GetType() != typeof(SurrogateForCyclicalReference);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0007B66D File Offset: 0x0007986D
		internal bool CanObjectValueChange
		{
			get
			{
				return this.IsIncompleteObjectReference || (this.HasSurrogate && this.CanSurrogatedObjectValueChange);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0007B689 File Offset: 0x00079889
		internal int DirectlyDependentObjects
		{
			get
			{
				return this.m_missingElementsRemaining;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0007B691 File Offset: 0x00079891
		internal int TotalDependentObjects
		{
			get
			{
				return this.m_missingElementsRemaining + this.m_missingDecendents;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0007B6A0 File Offset: 0x000798A0
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0007B6A8 File Offset: 0x000798A8
		internal bool Reachable
		{
			get
			{
				return this.m_reachable;
			}
			set
			{
				this.m_reachable = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0007B6B1 File Offset: 0x000798B1
		internal bool TypeLoadExceptionReachable
		{
			get
			{
				return this.m_typeLoad != null;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0007B6BC File Offset: 0x000798BC
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0007B6C4 File Offset: 0x000798C4
		internal TypeLoadExceptionHolder TypeLoadException
		{
			get
			{
				return this.m_typeLoad;
			}
			set
			{
				this.m_typeLoad = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0007B6CD File Offset: 0x000798CD
		internal object ObjectValue
		{
			get
			{
				return this.m_object;
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0007B6D5 File Offset: 0x000798D5
		[SecurityCritical]
		internal void SetObjectValue(object obj, ObjectManager manager)
		{
			this.m_object = obj;
			if (obj == manager.TopObject)
			{
				this.m_reachable = true;
			}
			if (obj is TypeLoadExceptionHolder)
			{
				this.m_typeLoad = (TypeLoadExceptionHolder)obj;
			}
			if (this.m_markForFixupWhenAvailable)
			{
				manager.CompleteObject(this, true);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0007B712 File Offset: 0x00079912
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0007B71A File Offset: 0x0007991A
		internal SerializationInfo SerializationInfo
		{
			get
			{
				return this.m_serInfo;
			}
			set
			{
				this.m_serInfo = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0007B723 File Offset: 0x00079923
		internal ISerializationSurrogate Surrogate
		{
			get
			{
				return this.m_surrogate;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0007B72B File Offset: 0x0007992B
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0007B733 File Offset: 0x00079933
		internal LongList DependentObjects
		{
			get
			{
				return this.m_dependentObjects;
			}
			set
			{
				this.m_dependentObjects = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0007B73C File Offset: 0x0007993C
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x0007B763 File Offset: 0x00079963
		internal bool RequiresSerInfoFixup
		{
			get
			{
				return ((this.m_flags & 4) != 0 || (this.m_flags & 2) != 0) && (this.m_flags & 16384) == 0;
			}
			set
			{
				if (!value)
				{
					this.m_flags |= 16384;
					return;
				}
				this.m_flags &= -16385;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0007B78D File Offset: 0x0007998D
		internal ValueTypeFixupInfo ValueFixup
		{
			get
			{
				return this.m_valueFixup;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0007B795 File Offset: 0x00079995
		internal bool CompletelyFixed
		{
			get
			{
				return !this.RequiresSerInfoFixup && !this.IsIncompleteObjectReference;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0007B7AA File Offset: 0x000799AA
		internal long ContainerID
		{
			get
			{
				if (this.m_valueFixup != null)
				{
					return this.m_valueFixup.ContainerID;
				}
				return 0L;
			}
		}

		// Token: 0x04000C1B RID: 3099
		private object m_object;

		// Token: 0x04000C1C RID: 3100
		internal long m_id;

		// Token: 0x04000C1D RID: 3101
		private int m_missingElementsRemaining;

		// Token: 0x04000C1E RID: 3102
		private int m_missingDecendents;

		// Token: 0x04000C1F RID: 3103
		internal SerializationInfo m_serInfo;

		// Token: 0x04000C20 RID: 3104
		internal ISerializationSurrogate m_surrogate;

		// Token: 0x04000C21 RID: 3105
		internal FixupHolderList m_missingElements;

		// Token: 0x04000C22 RID: 3106
		internal LongList m_dependentObjects;

		// Token: 0x04000C23 RID: 3107
		internal ObjectHolder m_next;

		// Token: 0x04000C24 RID: 3108
		internal int m_flags;

		// Token: 0x04000C25 RID: 3109
		private bool m_markForFixupWhenAvailable;

		// Token: 0x04000C26 RID: 3110
		private ValueTypeFixupInfo m_valueFixup;

		// Token: 0x04000C27 RID: 3111
		private TypeLoadExceptionHolder m_typeLoad;

		// Token: 0x04000C28 RID: 3112
		private bool m_reachable;
	}
}

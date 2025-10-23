using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.</summary>
	// Token: 0x02000196 RID: 406
	[ComVisible(true)]
	[Serializable]
	public class WeakReference : ISerializable
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x00040EE4 File Offset: 0x0003F0E4
		private void AllocateHandle(object target)
		{
			if (this.isLongReference)
			{
				this.gcHandle = GCHandle.Alloc(target, GCHandleType.WeakTrackResurrection);
				return;
			}
			this.gcHandle = GCHandle.Alloc(target, GCHandleType.Weak);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected WeakReference()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, referencing the specified object.</summary>
		/// <param name="target">The object to track or <see langword="null" />. </param>
		// Token: 0x06000F7E RID: 3966 RVA: 0x00040F09 File Offset: 0x0003F109
		public WeakReference(object target) : this(target, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, referencing the specified object and using the specified resurrection tracking.</summary>
		/// <param name="target">An object to track. </param>
		/// <param name="trackResurrection">Indicates when to stop tracking the object. If <see langword="true" />, the object is tracked after finalization; if <see langword="false" />, the object is only tracked until finalization. </param>
		// Token: 0x06000F7F RID: 3967 RVA: 0x00040F13 File Offset: 0x0003F113
		public WeakReference(object target, bool trackResurrection)
		{
			this.isLongReference = trackResurrection;
			this.AllocateHandle(target);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, using deserialized data from the specified serialization and stream objects.</summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize the current <see cref="T:System.WeakReference" /> object. </param>
		/// <param name="context">(Reserved) Describes the source and destination of the serialized stream specified by <paramref name="info" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06000F80 RID: 3968 RVA: 0x00040F2C File Offset: 0x0003F12C
		protected WeakReference(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.isLongReference = info.GetBoolean("TrackResurrection");
			object value = info.GetValue("TrackedObject", typeof(object));
			this.AllocateHandle(value);
		}

		/// <summary>Gets an indication whether the object referenced by the current <see cref="T:System.WeakReference" /> object has been garbage collected.</summary>
		/// <returns>
		///     <see langword="true" /> if the object referenced by the current <see cref="T:System.WeakReference" /> object has not been garbage collected and is still accessible; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00040F7B File Offset: 0x0003F17B
		public virtual bool IsAlive
		{
			get
			{
				return this.Target != null;
			}
		}

		/// <summary>Gets or sets the object (the target) referenced by the current <see cref="T:System.WeakReference" /> object.</summary>
		/// <returns>
		///     <see langword="null" /> if the object referenced by the current <see cref="T:System.WeakReference" /> object has been garbage collected; otherwise, a reference to the object referenced by the current <see cref="T:System.WeakReference" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The reference to the target object is invalid. This exception can be thrown while setting this property if the value is a null reference or if the object has been finalized during the set operation.</exception>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00040F86 File Offset: 0x0003F186
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00040FA2 File Offset: 0x0003F1A2
		public virtual object Target
		{
			get
			{
				if (!this.gcHandle.IsAllocated)
				{
					return null;
				}
				return this.gcHandle.Target;
			}
			set
			{
				this.gcHandle.Target = value;
			}
		}

		/// <summary>Gets an indication whether the object referenced by the current <see cref="T:System.WeakReference" /> object is tracked after it is finalized.</summary>
		/// <returns>
		///     <see langword="true" /> if the object the current <see cref="T:System.WeakReference" /> object refers to is tracked after finalization; or <see langword="false" /> if the object is only tracked until finalization.</returns>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00040FB0 File Offset: 0x0003F1B0
		public virtual bool TrackResurrection
		{
			get
			{
				return this.isLongReference;
			}
		}

		/// <summary>Discards the reference to the target represented by the current <see cref="T:System.WeakReference" /> object.</summary>
		// Token: 0x06000F85 RID: 3973 RVA: 0x00040FB8 File Offset: 0x0003F1B8
		~WeakReference()
		{
			this.gcHandle.Free();
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data needed to serialize the current <see cref="T:System.WeakReference" /> object.</summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize the current <see cref="T:System.WeakReference" /> object. </param>
		/// <param name="context">(Reserved) The location where serialized data is stored and retrieved. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06000F86 RID: 3974 RVA: 0x00040FEC File Offset: 0x0003F1EC
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("TrackResurrection", this.TrackResurrection);
			try
			{
				info.AddValue("TrackedObject", this.Target);
			}
			catch (Exception)
			{
				info.AddValue("TrackedObject", null);
			}
		}

		// Token: 0x040005F1 RID: 1521
		private bool isLongReference;

		// Token: 0x040005F2 RID: 1522
		private GCHandle gcHandle;
	}
}

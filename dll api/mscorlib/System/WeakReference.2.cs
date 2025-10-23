using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a typed weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.</summary>
	/// <typeparam name="T">The type of the object referenced.</typeparam>
	// Token: 0x02000197 RID: 407
	[Serializable]
	public sealed class WeakReference<T> : ISerializable where T : class
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference`1" /> class that references the specified object.</summary>
		/// <param name="target">The object to reference, or <see langword="null" />.</param>
		// Token: 0x06000F87 RID: 3975 RVA: 0x0004104C File Offset: 0x0003F24C
		public WeakReference(T target) : this(target, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference`1" /> class that references the specified object and uses the specified resurrection tracking.</summary>
		/// <param name="target">The object to reference, or <see langword="null" />.</param>
		/// <param name="trackResurrection">
		///       <see langword="true" /> to track the object after finalization; <see langword="false" /> to track the object only until finalization.</param>
		// Token: 0x06000F88 RID: 3976 RVA: 0x00041058 File Offset: 0x0003F258
		public WeakReference(T target, bool trackResurrection)
		{
			this.trackResurrection = trackResurrection;
			GCHandleType type = trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak;
			this.handle = GCHandle.Alloc(target, type);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004108C File Offset: 0x0003F28C
		private WeakReference(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.trackResurrection = info.GetBoolean("TrackResurrection");
			object value = info.GetValue("TrackedObject", typeof(T));
			GCHandleType type = this.trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak;
			this.handle = GCHandle.Alloc(value, type);
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data necessary to serialize the current <see cref="T:System.WeakReference`1" /> object.</summary>
		/// <param name="info">An object that holds all the data necessary to serialize or deserialize the current <see cref="T:System.WeakReference`1" /> object.</param>
		/// <param name="context">The location where serialized data is stored and retrieved.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06000F8A RID: 3978 RVA: 0x000410F0 File Offset: 0x0003F2F0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("TrackResurrection", this.trackResurrection);
			if (this.handle.IsAllocated)
			{
				info.AddValue("TrackedObject", this.handle.Target);
				return;
			}
			info.AddValue("TrackedObject", null);
		}

		/// <summary>Sets the target object that is referenced by this <see cref="T:System.WeakReference`1" /> object.</summary>
		/// <param name="target">The new target object.</param>
		// Token: 0x06000F8B RID: 3979 RVA: 0x0004114C File Offset: 0x0003F34C
		public void SetTarget(T target)
		{
			this.handle.Target = target;
		}

		/// <summary>Tries to retrieve the target object that is referenced by the current <see cref="T:System.WeakReference`1" /> object.</summary>
		/// <param name="target">When this method returns, contains the target object, if it is available. This parameter is treated as uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if the target was retrieved; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F8C RID: 3980 RVA: 0x0004115F File Offset: 0x0003F35F
		public bool TryGetTarget(out T target)
		{
			if (!this.handle.IsAllocated)
			{
				target = default(T);
				return false;
			}
			target = (T)((object)this.handle.Target);
			return target != null;
		}

		/// <summary>Discards the reference to the target that is represented by the current <see cref="T:System.WeakReference`1" /> object.</summary>
		// Token: 0x06000F8D RID: 3981 RVA: 0x0004119C File Offset: 0x0003F39C
		~WeakReference()
		{
			this.handle.Free();
		}

		// Token: 0x040005F3 RID: 1523
		private GCHandle handle;

		// Token: 0x040005F4 RID: 1524
		private bool trackResurrection;
	}
}

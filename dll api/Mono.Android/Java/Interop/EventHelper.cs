using System;
using Java.Lang;

namespace Java.Interop
{
	// Token: 0x02000431 RID: 1073
	public static class EventHelper
	{
		// Token: 0x06002ECF RID: 11983 RVA: 0x00081DD8 File Offset: 0x0007FFD8
		public static void AddEventHandler<TInterface, TImplementor>(ref WeakReference implementor, Func<TImplementor> creator, Action<TInterface> setListener, Action<TImplementor> add) where TImplementor : Java.Lang.Object, TInterface
		{
			TImplementor timplementor = default(TImplementor);
			if (implementor == null || (timplementor = (TImplementor)((object)implementor.Target)) == null)
			{
				timplementor = creator();
				implementor = new WeakReference(timplementor, true);
				setListener((TInterface)((object)timplementor));
			}
			add(timplementor);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00081E34 File Offset: 0x00080034
		public static void RemoveEventHandler<TInterface, TImplementor>(ref WeakReference implementor, Func<TImplementor, bool> empty, Action<TInterface> unsetListener, Action<TImplementor> remove) where TImplementor : Java.Lang.Object, TInterface
		{
			TImplementor timplementor = default(TImplementor);
			if (implementor == null || (timplementor = (TImplementor)((object)implementor.Target)) == null)
			{
				return;
			}
			remove(timplementor);
			if (empty(timplementor))
			{
				unsetListener((TInterface)((object)timplementor));
				timplementor = default(TImplementor);
				implementor.Target = null;
				implementor = null;
			}
		}
	}
}

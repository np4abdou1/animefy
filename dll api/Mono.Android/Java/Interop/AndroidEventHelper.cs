using System;
using Java.Lang;

namespace Java.Interop
{
	// Token: 0x0200042F RID: 1071
	public static class AndroidEventHelper
	{
		// Token: 0x06002ECA RID: 11978 RVA: 0x00081D00 File Offset: 0x0007FF00
		public static void AddEventHandler<TInterface, TImplementor>(ref WeakReference implementor, Func<TImplementor> creator, Action<TInterface> setListener, Action<TImplementor> add) where TInterface : class where TImplementor : Java.Lang.Object, TInterface
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

		// Token: 0x06002ECB RID: 11979 RVA: 0x00081D5C File Offset: 0x0007FF5C
		public static void RemoveEventHandler<TInterface, TImplementor>(ref WeakReference implementor, Func<TImplementor, bool> empty, Action<TInterface> setListener, Action<TImplementor> remove) where TInterface : class where TImplementor : Java.Lang.Object, TInterface
		{
			TImplementor timplementor = default(TImplementor);
			if (implementor == null || (timplementor = (TImplementor)((object)implementor.Target)) == null)
			{
				return;
			}
			remove(timplementor);
			if (empty(timplementor))
			{
				timplementor = default(TImplementor);
				implementor = null;
				setListener((TInterface)((object)timplementor));
			}
		}
	}
}

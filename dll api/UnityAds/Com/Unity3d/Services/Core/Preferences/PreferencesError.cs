using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Preferences
{
	// Token: 0x020000D5 RID: 213
	[Register("com/unity3d/services/core/preferences/PreferencesError", DoNotGenerateAcw = true)]
	public sealed class PreferencesError : Java.Lang.Enum
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0001853C File Offset: 0x0001673C
		[Register("COULDNT_GET_VALUE")]
		public static PreferencesError CouldntGetValue
		{
			get
			{
				return Java.Lang.Object.GetObject<PreferencesError>(PreferencesError._members.StaticFields.GetObjectValue("COULDNT_GET_VALUE.Lcom/unity3d/services/core/preferences/PreferencesError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0001856C File Offset: 0x0001676C
		internal static IntPtr class_ref
		{
			get
			{
				return PreferencesError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00018590 File Offset: 0x00016790
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PreferencesError._members;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00018598 File Offset: 0x00016798
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PreferencesError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000185BC File Offset: 0x000167BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PreferencesError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0000256C File Offset: 0x0000076C
		internal PreferencesError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000185C8 File Offset: 0x000167C8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/preferences/PreferencesError;", "")]
		public unsafe static PreferencesError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PreferencesError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PreferencesError>(PreferencesError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/preferences/PreferencesError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00018634 File Offset: 0x00016834
		[Register("values", "()[Lcom/unity3d/services/core/preferences/PreferencesError;", "")]
		public static PreferencesError[] Values()
		{
			return (PreferencesError[])JNIEnv.GetArray(PreferencesError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/preferences/PreferencesError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PreferencesError));
		}

		// Token: 0x040001F6 RID: 502
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/preferences/PreferencesError", typeof(PreferencesError));
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000081 RID: 129
	[Register("androidx/core/app/RemoteInput", DoNotGenerateAcw = true)]
	public sealed class RemoteInput : Java.Lang.Object
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000163BC File Offset: 0x000145BC
		internal static IntPtr class_ref
		{
			get
			{
				return RemoteInput._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x000163E0 File Offset: 0x000145E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RemoteInput._members;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x000163E8 File Offset: 0x000145E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RemoteInput._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0001640C File Offset: 0x0001460C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RemoteInput._members.ManagedPeerType;
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002384 File Offset: 0x00000584
		internal RemoteInput(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00016418 File Offset: 0x00014618
		private bool AllowFreeFormInput
		{
			[Register("getAllowFreeFormInput", "()Z", "")]
			get
			{
				return RemoteInput._members.InstanceMethods.InvokeAbstractBooleanMethod("getAllowFreeFormInput.()Z", this, null);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00016434 File Offset: 0x00014634
		private ICollection<string> AllowedDataTypes
		{
			[Register("getAllowedDataTypes", "()Ljava/util/Set;", "")]
			get
			{
				return JavaSet<string>.FromJniHandle(RemoteInput._members.InstanceMethods.InvokeAbstractObjectMethod("getAllowedDataTypes.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00016466 File Offset: 0x00014666
		public int EditChoicesBeforeSending
		{
			[Register("getEditChoicesBeforeSending", "()I", "")]
			get
			{
				return RemoteInput._members.InstanceMethods.InvokeAbstractInt32Method("getEditChoicesBeforeSending.()I", this, null);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00016480 File Offset: 0x00014680
		private Bundle Extras
		{
			[Register("getExtras", "()Landroid/os/Bundle;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(RemoteInput._members.InstanceMethods.InvokeAbstractObjectMethod("getExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x000164B2 File Offset: 0x000146B2
		public bool IsDataOnly
		{
			[Register("isDataOnly", "()Z", "")]
			get
			{
				return RemoteInput._members.InstanceMethods.InvokeAbstractBooleanMethod("isDataOnly.()Z", this, null);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000164CC File Offset: 0x000146CC
		private ICharSequence LabelFormatted
		{
			[Register("getLabel", "()Ljava/lang/CharSequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(RemoteInput._members.InstanceMethods.InvokeAbstractObjectMethod("getLabel.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000164FE File Offset: 0x000146FE
		private string Label
		{
			get
			{
				if (this.LabelFormatted != null)
				{
					return this.LabelFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00016518 File Offset: 0x00014718
		private string ResultKey
		{
			[Register("getResultKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteInput._members.InstanceMethods.InvokeAbstractObjectMethod("getResultKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001654C File Offset: 0x0001474C
		[Register("addDataResultToIntent", "(Landroidx/core/app/RemoteInput;Landroid/content/Intent;Ljava/util/Map;)V", "")]
		public unsafe static void AddDataResultToIntent(RemoteInput remoteInput, Intent intent, IDictionary<string, Android.Net.Uri> results)
		{
			IntPtr intPtr = JavaDictionary<string, Android.Net.Uri>.ToLocalJniHandle(results);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((remoteInput == null) ? IntPtr.Zero : remoteInput.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				RemoteInput._members.StaticMethods.InvokeVoidMethod("addDataResultToIntent.(Landroidx/core/app/RemoteInput;Landroid/content/Intent;Ljava/util/Map;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(remoteInput);
				GC.KeepAlive(intent);
				GC.KeepAlive(results);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00016600 File Offset: 0x00014800
		[Register("addResultsToIntent", "([Landroidx/core/app/RemoteInput;Landroid/content/Intent;Landroid/os/Bundle;)V", "")]
		public unsafe static void AddResultsToIntent(RemoteInput[] remoteInputs, Intent intent, Bundle results)
		{
			IntPtr intPtr = JNIEnv.NewArray<RemoteInput>(remoteInputs);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue((results == null) ? IntPtr.Zero : results.Handle);
				RemoteInput._members.StaticMethods.InvokeVoidMethod("addResultsToIntent.([Landroidx/core/app/RemoteInput;Landroid/content/Intent;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				if (remoteInputs != null)
				{
					JNIEnv.CopyArray<RemoteInput>(intPtr, remoteInputs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(remoteInputs);
				GC.KeepAlive(intent);
				GC.KeepAlive(results);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000166C0 File Offset: 0x000148C0
		[Register("getChoices", "()[Ljava/lang/CharSequence;", "")]
		private ICharSequence[] GetChoicesFormatted()
		{
			return (ICharSequence[])JNIEnv.GetArray(RemoteInput._members.InstanceMethods.InvokeAbstractObjectMethod("getChoices.()[Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ICharSequence));
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00016701 File Offset: 0x00014901
		private string[] GetChoices()
		{
			return CharSequence.ArrayToStringArray(this.GetChoicesFormatted());
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00016710 File Offset: 0x00014910
		[Register("getDataResultsFromIntent", "(Landroid/content/Intent;Ljava/lang/String;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Android.Net.Uri> GetDataResultsFromIntent(Intent intent, string remoteInputResultKey)
		{
			IntPtr intPtr = JNIEnv.NewString(remoteInputResultKey);
			IDictionary<string, Android.Net.Uri> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaDictionary<string, Android.Net.Uri>.FromJniHandle(RemoteInput._members.StaticMethods.InvokeObjectMethod("getDataResultsFromIntent.(Landroid/content/Intent;Ljava/lang/String;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(intent);
			}
			return result;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000167A4 File Offset: 0x000149A4
		[Register("getResultsFromIntent", "(Landroid/content/Intent;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle GetResultsFromIntent(Intent intent)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(RemoteInput._members.StaticMethods.InvokeObjectMethod("getResultsFromIntent.(Landroid/content/Intent;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00016818 File Offset: 0x00014A18
		[Register("getResultsSource", "(Landroid/content/Intent;)I", "")]
		public unsafe static int GetResultsSource(Intent intent)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				result = RemoteInput._members.StaticMethods.InvokeInt32Method("getResultsSource.(Landroid/content/Intent;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return result;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001687C File Offset: 0x00014A7C
		[Register("setResultsSource", "(Landroid/content/Intent;I)V", "")]
		public unsafe static void SetResultsSource(Intent intent, int source)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(source);
				RemoteInput._members.StaticMethods.InvokeVoidMethod("setResultsSource.(Landroid/content/Intent;I)V", ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x040001E8 RID: 488
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/RemoteInput", typeof(RemoteInput));
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000089 RID: 137
	public struct JniValueMarshalerState : IEquatable<JniValueMarshalerState>
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00010830 File Offset: 0x0000EA30
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00010838 File Offset: 0x0000EA38
		public JniArgumentValue JniArgumentValue { readonly get; private set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00010841 File Offset: 0x0000EA41
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00010849 File Offset: 0x0000EA49
		public JniObjectReference ReferenceValue { readonly get; private set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00010852 File Offset: 0x0000EA52
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0001085A File Offset: 0x0000EA5A
		public IJavaPeerable PeerableValue { readonly get; private set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00010863 File Offset: 0x0000EA63
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0001086B File Offset: 0x0000EA6B
		public object Extra { readonly get; private set; }

		// Token: 0x0600047F RID: 1151 RVA: 0x00010874 File Offset: 0x0000EA74
		public JniValueMarshalerState(JniArgumentValue jniArgumentValue, object extra = null)
		{
			this.JniArgumentValue = jniArgumentValue;
			this.ReferenceValue = default(JniObjectReference);
			this.PeerableValue = null;
			this.Extra = extra;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000108A5 File Offset: 0x0000EAA5
		public JniValueMarshalerState(JniObjectReference referenceValue, object extra = null)
		{
			this.JniArgumentValue = new JniArgumentValue(referenceValue);
			this.ReferenceValue = referenceValue;
			this.PeerableValue = null;
			this.Extra = extra;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000108C8 File Offset: 0x0000EAC8
		public JniValueMarshalerState(IJavaPeerable peerableValue, object extra = null)
		{
			this.PeerableValue = peerableValue;
			this.ReferenceValue = ((peerableValue == null) ? default(JniObjectReference) : peerableValue.PeerReference);
			this.JniArgumentValue = new JniArgumentValue(this.ReferenceValue);
			this.Extra = extra;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001090E File Offset: 0x0000EB0E
		internal JniValueMarshalerState(JniValueMarshalerState copy, object extra = null)
		{
			this.JniArgumentValue = copy.JniArgumentValue;
			this.ReferenceValue = copy.ReferenceValue;
			this.PeerableValue = copy.PeerableValue;
			this.Extra = (extra ?? copy.Extra);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001094C File Offset: 0x0000EB4C
		public override int GetHashCode()
		{
			return this.JniArgumentValue.GetHashCode();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00010970 File Offset: 0x0000EB70
		public override bool Equals(object obj)
		{
			JniValueMarshalerState? jniValueMarshalerState = obj as JniValueMarshalerState?;
			return jniValueMarshalerState != null && this.Equals(jniValueMarshalerState.Value);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000109A4 File Offset: 0x0000EBA4
		public bool Equals(JniValueMarshalerState other)
		{
			return this.JniArgumentValue.Equals(other.JniArgumentValue) && this.ReferenceValue.Equals(other.ReferenceValue) && this.PeerableValue == other.PeerableValue && this.Extra == other.Extra;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00010A00 File Offset: 0x0000EC00
		public override string ToString()
		{
			return string.Format("JniValueMarshalerState({0}, ReferenceValue={1}, PeerableValue=0x{2}, Extra={3})", new object[]
			{
				this.JniArgumentValue.ToString(),
				this.ReferenceValue.ToString(),
				RuntimeHelpers.GetHashCode(this.PeerableValue).ToString("x"),
				this.Extra
			});
		}
	}
}

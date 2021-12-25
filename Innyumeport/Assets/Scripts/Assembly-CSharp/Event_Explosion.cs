using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class Event_Explosion : MonoBehaviour
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002B80 File Offset: 0x00000D80
	private void Start()
	{
		this.frame = 0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002B8C File Offset: 0x00000D8C
	private void FixedUpdate()
	{
		base.gameObject.GetComponent<Renderer>().material = this.explosionMAT[this.frame];
		this.frame++;
		if (this.frame >= 132)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000012 RID: 18
	private int frame;

	// Token: 0x04000013 RID: 19
	public Material[] explosionMAT = new Material[132];
}

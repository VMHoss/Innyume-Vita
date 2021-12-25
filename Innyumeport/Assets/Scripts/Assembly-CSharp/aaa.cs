using System;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class aaa : MonoBehaviour
{
	// Token: 0x0600004E RID: 78 RVA: 0x00005224 File Offset: 0x00003424
	private void Start()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00005228 File Offset: 0x00003428
	private void Update()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000522C File Offset: 0x0000342C
	private void OnMouseOver()
	{
		base.gameObject.GetComponent<Renderer>().material = this.mesMAT[1];
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00005248 File Offset: 0x00003448
	private void OnMouseExit()
	{
		base.gameObject.GetComponent<Renderer>().material = this.mesMAT[0];
	}

	// Token: 0x04000048 RID: 72
	public Material[] mesMAT = new Material[2];
}

using System;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class TitleMes : MonoBehaviour
{
	// Token: 0x06000015 RID: 21 RVA: 0x00002EF0 File Offset: 0x000010F0
	private void Start()
	{
		this.lightCOM = GameObject.Find("LightBlock.003");
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002F04 File Offset: 0x00001104
	private void FixedUpdate()
	{
		if (this.lightCOM.GetComponent<TitleScript>().state == 2)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mesMAT[0];
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002F40 File Offset: 0x00001140
	private void OnMouseOver()
	{
		if (this.lightCOM.GetComponent<TitleScript>().state == 1)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mesMAT[1];
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002F7C File Offset: 0x0000117C
	private void OnMouseExit()
	{
		if (this.lightCOM.GetComponent<TitleScript>().state == 1)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mesMAT[0];
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002FB8 File Offset: 0x000011B8
	private void OnMouseDown()
	{
		if (this.lightCOM.GetComponent<TitleScript>().state == 1)
		{
			this.lightCOM.GetComponent<TitleScript>().state = this.mesNum + 2;
		}
	}

	// Token: 0x0400001A RID: 26
	public int mesNum;

	// Token: 0x0400001B RID: 27
	public Material[] mesMAT = new Material[2];

	// Token: 0x0400001C RID: 28
	private GameObject lightCOM;
}

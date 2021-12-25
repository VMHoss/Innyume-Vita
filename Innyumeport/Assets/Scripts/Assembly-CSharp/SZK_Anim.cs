using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class SZK_Anim : MonoBehaviour
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002D4C File Offset: 0x00000F4C
	private void Start()
	{
		this.frame = 0;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002D58 File Offset: 0x00000F58
	private void FixedUpdate()
	{
		this.frame++;
		int num = 3;
		if (this.frame >= num * 0 && this.frame < num * 1)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[0];
		}
		if (this.frame >= num * 1 && this.frame < num * 2)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[1];
		}
		if (this.frame >= num * 2 && this.frame < num * 3)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[2];
		}
		if (this.frame >= num * 3 && this.frame < num * 4)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[3];
		}
		if (this.frame >= num * 4 && this.frame < num * 5)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[2];
		}
		if (this.frame >= num * 5 && this.frame < num * 6)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[1];
		}
		if (this.frame >= num * 6)
		{
			base.gameObject.GetComponent<Renderer>().material = this.mat[0];
			this.frame = 0;
		}
	}

	// Token: 0x04000018 RID: 24
	public Material[] mat = new Material[4];

	// Token: 0x04000019 RID: 25
	private int frame;
}

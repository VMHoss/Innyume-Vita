using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class GameOverCam : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002BF4 File Offset: 0x00000DF4
	private void Start()
	{
		this.frame = 0;
		this.black = GameObject.Find("Black");
		this.isClick = false;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002C14 File Offset: 0x00000E14
	private void FixedUpdate()
	{
		this.frame++;
		base.gameObject.transform.eulerAngles += new Vector3(0f, this.speed, 0f);
		if (this.frame <= 120)
		{
			this.black.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, -0.01f);
		}
		else if (this.frame >= 840)
		{
			this.isClick = true;
			if (this.isClick)
			{
				this.black.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, 0.01f);
				if (this.black.GetComponent<Renderer>().material.color.a >= 1f)
				{
					Application.LoadLevel("Title");
				}
			}
		}
	}

	// Token: 0x04000014 RID: 20
	public float speed = 0.1f;

	// Token: 0x04000015 RID: 21
	private int frame;

	// Token: 0x04000016 RID: 22
	private GameObject black;

	// Token: 0x04000017 RID: 23
	private bool isClick;
}

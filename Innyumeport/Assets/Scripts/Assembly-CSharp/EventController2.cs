using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class EventController2 : MonoBehaviour
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002414 File Offset: 0x00000614
	private void Start()
	{
		this.frame = 0;
		this.frame2 = 0;
		this.rotate = 0f;
		Cursor.visible = true;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002438 File Offset: 0x00000638
	private void FixedUpdate()
	{
		this.frame++;
		if (this.frame < 30)
		{
			this.earthOBJ.transform.localScale -= new Vector3(0.8f, 0.8f, 0f);
		}
		if (this.frame >= 30 && this.frame < 180)
		{
			this.rotate += 0.8f;
			this.earthOBJ.transform.localScale -= new Vector3(0.02f, 0.02f, 0f);
			this.earthOBJ.transform.eulerAngles = new Vector3(0f, 0f, this.rotate);
		}
		if (this.frame >= 180 && this.frame < 240)
		{
			this.rotate += 5f;
			this.earthOBJ.transform.localScale -= new Vector3(0.08f, 0.08f, 0f);
			this.earthOBJ.transform.eulerAngles = new Vector3(0f, 0f, this.rotate);
			if (this.earthOBJ.transform.localScale.x <= 0f)
			{
				this.earthOBJ.transform.localScale = new Vector3(0f, 0f, 1f);
			}
		}
		if (this.frame == 30)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(-0.6f, 0.14f, -1f), Quaternion.identity);
		}
		if (this.frame == 40)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(-1.2f, 1.6f, -1.1f), Quaternion.identity);
		}
		if (this.frame == 60)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(-1.6f, -1.6f, -1.2f), Quaternion.identity);
		}
		if (this.frame == 70)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(1.6f, 0.6f, -1.3f), Quaternion.identity);
		}
		if (this.frame == 90)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(0.9f, -1.2f, -1.4f), Quaternion.identity);
		}
		this.innyumeOBJ.transform.position += new Vector3(-0.01f, 0f, 0f);
		this.innyumeOBJ.transform.eulerAngles += new Vector3(0f, 0f, 10f);
		this.innyumeOBJ.transform.localScale += new Vector3(0.01f, 0.01f, 0f);
		this.innMesOBJ.transform.position += new Vector3(-0.01f, 0.005f, 0f);
		this.SZKOBJ.transform.position += new Vector3(0.01f, 0f, 0f);
		this.SZKOBJ.transform.eulerAngles += new Vector3(0f, 0f, -5f);
		this.SZKOBJ.transform.localScale += new Vector3(0.01f, 0.01f, 0f);
		int num = 3;
		this.frame2++;
		if (this.frame2 >= num * 0 && this.frame2 < num * 1)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[0];
		}
		if (this.frame2 >= num * 1 && this.frame2 < num * 2)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[1];
		}
		if (this.frame2 >= num * 2 && this.frame2 < num * 3)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[2];
		}
		if (this.frame2 >= num * 3 && this.frame2 < num * 4)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[3];
		}
		if (this.frame2 >= num * 4 && this.frame2 < num * 5)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[2];
		}
		if (this.frame2 >= num * 5 && this.frame2 < num * 6)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[1];
		}
		if (this.frame2 >= num * 6)
		{
			this.SZKOBJ.GetComponentInChildren<Renderer>().material = this.SZKMAT[0];
			this.frame2 = 0;
		}
		if (this.frame == 120)
		{
			UnityEngine.Object.Instantiate(this.audioPrefab, new Vector3(0f, 0f, -10f), Quaternion.identity);
		}
		if (this.frame == 240)
		{
			GameObject.Find("Main Camera").transform.eulerAngles = new Vector3(0f, 180f, 0f);
		}
		if (this.frame == 242)
		{
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(0f, 0f, -10.5f), Quaternion.Euler(0f, 180f, 0f));
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(0f, 0f, -10.5f), Quaternion.Euler(0f, 180f, 0f));
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(0f, 0f, -10.5f), Quaternion.Euler(0f, 180f, 0f));
			UnityEngine.Object.Instantiate(this.explosionPrefab, new Vector3(0f, 0f, -10.5f), Quaternion.Euler(0f, 180f, 0f));
		}
		if (this.frame == 373)
		{
			GameObject.Find("Main Camera").transform.position += new Vector3(100f, 0f, 0f);
		}
		if (this.frame == 640)
		{
			Application.LoadLevel("Title");
		}
	}

	// Token: 0x04000008 RID: 8
	public GameObject earthOBJ;

	// Token: 0x04000009 RID: 9
	public GameObject explosionPrefab;

	// Token: 0x0400000A RID: 10
	public GameObject audioPrefab;

	// Token: 0x0400000B RID: 11
	public GameObject innyumeOBJ;

	// Token: 0x0400000C RID: 12
	public GameObject SZKOBJ;

	// Token: 0x0400000D RID: 13
	public GameObject innMesOBJ;

	// Token: 0x0400000E RID: 14
	public Material[] SZKMAT = new Material[4];

	// Token: 0x0400000F RID: 15
	private int frame;

	// Token: 0x04000010 RID: 16
	private int frame2;

	// Token: 0x04000011 RID: 17
	private float rotate;
}

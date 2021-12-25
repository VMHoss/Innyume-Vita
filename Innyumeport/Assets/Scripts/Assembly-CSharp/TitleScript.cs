using System;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class TitleScript : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00003008 File Offset: 0x00001208
	private void Start()
	{
		this.frame = 0;
		this.state = 0;
		this.black = GameObject.Find("Black");
		Cursor.visible = true;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000303C File Offset: 0x0000123C
	private void FixedUpdate()
	{
		this.frame++;
		if (this.frame == 58)
		{
			base.gameObject.GetComponent<AudioSource>().PlayOneShot(this.bi);
		}
		if (this.frame == 60)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[1];
			base.gameObject.GetComponent<Light>().range = 17.5f;
		}
		if (this.frame >= 61 && this.frame < 80)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[0];
			base.gameObject.GetComponent<Light>().range = 0f;
			base.gameObject.GetComponent<AudioSource>().Stop();
			this.frame = UnityEngine.Random.Range(0, 56);
		}
		if (this.frame == 101)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[1];
			base.gameObject.GetComponent<Light>().range = 50f;
			base.gameObject.GetComponent<Light>().intensity = 10f;
			base.gameObject.GetComponent<AudioSource>().PlayOneShot(this.bi);
		}
		if (this.frame == 102)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[1];
			base.gameObject.GetComponent<Light>().range = 15f;
			base.gameObject.GetComponent<Light>().intensity = 8f;
		}
		if (this.frame == 103)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[0];
			base.gameObject.GetComponent<Light>().range = 10f;
			base.gameObject.GetComponent<Light>().intensity = 6f;
		}
		if (this.frame == 104)
		{
			base.gameObject.GetComponent<Renderer>().material = this.lightMAT[0];
			base.gameObject.GetComponent<Light>().range = 0f;
			base.gameObject.GetComponent<Light>().intensity = 5f;
		}
		if (this.frame == 107)
		{
			base.gameObject.GetComponent<AudioSource>().Stop();
		}
		if (this.frame >= 120)
		{
			this.frame = UnityEngine.Random.Range(0, 56);
		}
		if (this.state == 0)
		{
			this.black.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, -0.01f);
			if (this.black.GetComponent<Renderer>().material.color.a <= 0f)
			{
				this.black.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, 0f);
				this.state = 1;
			}
		}
		if (this.state == 2)
		{
			this.black.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, 0.01f);
			if (this.black.GetComponent<Renderer>().material.color.a >= 1f)
			{
				Application.LoadLevel("Event");
			}
		}
		if (this.state == 3)
		{
			Application.Quit();
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000033D8 File Offset: 0x000015D8
	private void OnMouseDown()
	{
		if (this.frame >= 100)
		{
			return;
		}
		this.frame = 100;
	}

	// Token: 0x0400001D RID: 29
	public Material[] lightMAT = new Material[2];

	// Token: 0x0400001E RID: 30
	private int frame;

	// Token: 0x0400001F RID: 31
	public int state;

	// Token: 0x04000020 RID: 32
	public AudioClip bi;

	// Token: 0x04000021 RID: 33
	private GameObject black;
}

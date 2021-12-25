using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class EventController1 : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002100 File Offset: 0x00000300
	private void Start()
	{
		this.state = 0;
		this.textOBJ.GetComponent<Renderer>().material = this.textMat[0];
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002124 File Offset: 0x00000324
	private void FixedUpdate()
	{
		this.innyumeOBJ.transform.position += new Vector3(-0.01f, 0f, 0f);
		if (this.innyumeOBJ.transform.position.x <= 4.02f && this.state == 0)
		{
			this.textOBJ.GetComponent<Renderer>().material = this.textMat[1];
			this.state = 1;
			this.innyumeOBJ.transform.position = new Vector3(5.11f, this.innyumeOBJ.transform.position.y, this.innyumeOBJ.transform.position.z);
		}
		if (this.innyumeOBJ.transform.position.x <= 1.79f && this.state == 1)
		{
			this.textOBJ.GetComponent<Renderer>().material = this.textMat[2];
			this.state = 2;
			this.innyumeOBJ.transform.position = new Vector3(2.3f, this.innyumeOBJ.transform.position.y, this.innyumeOBJ.transform.position.z);
		}
		if (this.innyumeOBJ.transform.position.x <= -1.52f && this.state == 2)
		{
			this.textOBJ.GetComponent<Renderer>().material = this.textMat[3];
			this.state = 3;
		}
		if (this.state == 3)
		{
			this.textOBJ.GetComponent<Renderer>().material = this.textMat[3];
			base.GetComponent<AudioSource>().Stop();
			this.BGOInnyume.transform.position = new Vector3(0f, 0f, -4.1f);
			this.BGOBJ1.transform.position = new Vector3(0f, 0f, -4f);
			this.BGOBJ2.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0f);
			this.state = 4;
		}
		if (this.state == 4)
		{
			this.BGOBJ2.GetComponent<Renderer>().material.color += new Color(0f, 0f, 0f, 0.01f);
			if (this.BGOBJ2.GetComponent<Renderer>().material.color.a >= 1f)
			{
				Application.LoadLevel("Game01");
			}
		}
	}

	// Token: 0x04000001 RID: 1
	public GameObject innyumeOBJ;

	// Token: 0x04000002 RID: 2
	public GameObject textOBJ;

	// Token: 0x04000003 RID: 3
	public GameObject BGOBJ1;

	// Token: 0x04000004 RID: 4
	public GameObject BGOBJ2;

	// Token: 0x04000005 RID: 5
	public GameObject BGOInnyume;

	// Token: 0x04000006 RID: 6
	public Material[] textMat = new Material[4];

	// Token: 0x04000007 RID: 7
	public int state;
}

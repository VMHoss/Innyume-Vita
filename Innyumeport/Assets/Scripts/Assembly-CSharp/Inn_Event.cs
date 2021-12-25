using System;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class Inn_Event : MonoBehaviour
{
	// Token: 0x06000029 RID: 41 RVA: 0x000038F0 File Offset: 0x00001AF0
	private void Start()
	{
		this.state = 0;
		this.aaa = null;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003900 File Offset: 0x00001B00
	private void FixedUpdate()
	{
		if (this.state == 1)
		{
			this.aaa = (UnityEngine.Object.Instantiate(this.innEvePrefab, new Vector3(-23f, 0f, -84f), Quaternion.Euler(0f, 180f, 0f)) as GameObject);
			this.state = 2;
		}
		if (this.aaa != null)
		{
			this.aaa.GetComponentInChildren<AudioSource>().volume -= 0.01f;
			this.aaa.transform.position += new Vector3(0f, 0f, 0.5f);
			if (this.aaa.GetComponentInChildren<AudioSource>().volume <= 0f)
			{
				UnityEngine.Object.Destroy(this.aaa);
			}
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000039E0 File Offset: 0x00001BE0
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player1" && this.state == 0)
		{
			this.state = 1;
		}
	}

	// Token: 0x0400002E RID: 46
	public GameObject innEvePrefab;

	// Token: 0x0400002F RID: 47
	private GameObject aaa;

	// Token: 0x04000030 RID: 48
	private int state;
}

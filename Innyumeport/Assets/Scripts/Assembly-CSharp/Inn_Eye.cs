using System;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class Inn_Eye : MonoBehaviour
{
	// Token: 0x0600002D RID: 45 RVA: 0x00003A24 File Offset: 0x00001C24
	private void Start()
	{
		this.player = GameObject.Find("Player1");
		Vector3 position = this.player.transform.position;
		base.gameObject.transform.LookAt(new Vector3(position.x, position.y + 3f, position.z));
		this.frame = 0;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003A8C File Offset: 0x00001C8C
	private void FixedUpdate()
	{
		this.frame++;
		float d = 10f;
		base.gameObject.transform.position += base.gameObject.transform.TransformDirection(Vector3.forward) * d;
		if (this.frame >= 6)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003AFC File Offset: 0x00001CFC
	private void InnyumeNum(int a)
	{
		this.innNum = a;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003B08 File Offset: 0x00001D08
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player1")
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (col.gameObject.tag == "Stage")
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (col.gameObject.name == "Player1")
		{
			GameObject.Find("innyume" + this.innNum).GetComponent<Innyume>().isDiscover = true;
		}
	}

	// Token: 0x04000031 RID: 49
	private GameObject player;

	// Token: 0x04000032 RID: 50
	private int frame;

	// Token: 0x04000033 RID: 51
	public int innNum;
}

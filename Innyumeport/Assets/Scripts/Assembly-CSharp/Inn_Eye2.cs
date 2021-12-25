using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class Inn_Eye2 : MonoBehaviour
{
	// Token: 0x06000032 RID: 50 RVA: 0x00003BA8 File Offset: 0x00001DA8
	private void Start()
	{
		this.innyume = GameObject.Find("innyume" + this.innNum);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003BD8 File Offset: 0x00001DD8
	private void FixedUpdate()
	{
		base.gameObject.transform.position = this.innyume.transform.position;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003C08 File Offset: 0x00001E08
	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.name == "Player1")
		{
			this.innyume.GetComponent<Innyume>().isDiscover = true;
			this.innyume.GetComponent<Innyume>().isDiscover2 = true;
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003C54 File Offset: 0x00001E54
	private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.name == "Player1")
		{
			this.innyume.GetComponent<Innyume>().isDiscover = false;
		}
	}

	// Token: 0x04000034 RID: 52
	private GameObject innyume;

	// Token: 0x04000035 RID: 53
	public int innNum;
}

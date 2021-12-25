using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class Face_LookAt : MonoBehaviour
{
	// Token: 0x0600001F RID: 31 RVA: 0x000033F8 File Offset: 0x000015F8
	private void Start()
	{
		this.camOBJ = GameObject.Find("Main Camera");
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000340C File Offset: 0x0000160C
	private void Update()
	{
		base.gameObject.transform.rotation = Quaternion.Euler(-this.camOBJ.transform.eulerAngles.x, 180f + this.camOBJ.transform.eulerAngles.y, -this.camOBJ.transform.eulerAngles.z);
	}

	// Token: 0x04000022 RID: 34
	private GameObject camOBJ;
}

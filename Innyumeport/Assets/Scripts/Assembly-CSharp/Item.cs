using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class Item : MonoBehaviour
{
	// Token: 0x06000044 RID: 68 RVA: 0x00004D20 File Offset: 0x00002F20
	private void Start()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004D24 File Offset: 0x00002F24
	private void FixedUpdate()
	{
		base.gameObject.transform.eulerAngles += new Vector3(0f, 5f, 0f);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004D60 File Offset: 0x00002F60
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player1")
		{
			GameObject.Find("GameController").GetComponent<GameController>().getItem[this.itemNum] = true;
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000043 RID: 67
	public int itemNum = 1;
}

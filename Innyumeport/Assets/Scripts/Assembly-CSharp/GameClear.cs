using System;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class GameClear : MonoBehaviour
{
	// Token: 0x06000022 RID: 34 RVA: 0x00003488 File Offset: 0x00001688
	private void Start()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000348C File Offset: 0x0000168C
	private void Update()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00003490 File Offset: 0x00001690
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player1")
		{
			GameObject.Find("Black").GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 1f);
			Application.LoadLevel("GameClear");
		}
	}
}

using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class EventSkip : MonoBehaviour
{
	// Token: 0x06000008 RID: 8 RVA: 0x00002B48 File Offset: 0x00000D48
	private void Start()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002B4C File Offset: 0x00000D4C
	private void Update()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002B50 File Offset: 0x00000D50
	private void OnMouseDown()
	{
		GameObject.Find("EventController").GetComponent<EventController1>().state = 3;
	}
}

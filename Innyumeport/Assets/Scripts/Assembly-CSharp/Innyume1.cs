using System;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class Innyume1 : MonoBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x00004C2C File Offset: 0x00002E2C
	private void Start()
	{
		this.agent = base.GetComponent<UnityEngine.AI.NavMeshAgent>();
		this.player = GameObject.Find("Player1");
		this.frame = 0;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00004C54 File Offset: 0x00002E54
	private void FixedUpdate()
	{
		this.agent.SetDestination(this.player.transform.position);
		this.frame++;
		if (this.frame >= 1800)
		{
			this.agent.speed = 40f;
		}
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004CAC File Offset: 0x00002EAC
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Player1")
		{
			GameObject.Find("Black").GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 1f);
			Application.LoadLevel("GameOver");
		}
	}

	// Token: 0x04000040 RID: 64
	private GameObject player;

	// Token: 0x04000041 RID: 65
	private UnityEngine.AI.NavMeshAgent agent;

	// Token: 0x04000042 RID: 66
	private int frame;
}

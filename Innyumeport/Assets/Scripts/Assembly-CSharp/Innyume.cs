using System;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class Innyume : MonoBehaviour
{
	// Token: 0x06000037 RID: 55 RVA: 0x00003CA4 File Offset: 0x00001EA4
	private void Start()
	{
		this.agent = base.GetComponent<UnityEngine.AI.NavMeshAgent>();
		for (int i = 1; i < 77; i++)
		{
			this.AIPos[i] = GameObject.Find("AI" + i);
		}
		this.player = GameObject.Find("Player1");
		this.frame = 0;
		this.isDiscover = false;
		this.isDiscover2 = false;
		this.beforePos = 1;
		this.NearTarget();
		GameObject gameObject = UnityEngine.Object.Instantiate(this.eyePrefab, base.gameObject.transform.position, Quaternion.identity) as GameObject;
		gameObject.name = "InnyumeEye" + base.gameObject.name.Remove(0, 7);
		gameObject.GetComponent<Inn_Eye2>().innNum = int.Parse(base.gameObject.name.Remove(0, 7));
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003D8C File Offset: 0x00001F8C
	private void FixedUpdate()
	{
		this.frame++;
		for (int i = 1; i < this.AIPos.Length; i++)
		{
			this.IsAIPosSuc(i);
		}
		Vector3 position = base.gameObject.transform.position;
		Vector3 position2 = this.AIPos[this.aimPos].transform.position;
		if (this.frame == 9)
		{
			base.gameObject.GetComponent<AudioSource>().volume = 1f;
		}
		if (this.frame >= 20)
		{
			this.frame = 10;
		}
		if (this.isDiscover)
		{
			position2 = this.player.transform.position;
		}
		this.agent.SetDestination(position2);
		float num = Mathf.Atan2(position.z - position2.z, position.x - position2.x) * 57.29578f;
		base.gameObject.transform.eulerAngles = new Vector3(0f, -num + 90f, 0f);
		if (!this.isDiscover && this.isDiscover2)
		{
			this.NearTarget();
			this.isDiscover2 = false;
		}
		if (this.isDiscover && !this.isDiscover2)
		{
			this.isDiscover = true;
			this.isDiscover2 = true;
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003EE8 File Offset: 0x000020E8
	private void NearTarget()
	{
		float[] array = new float[77];
		for (int i = 1; i < 77; i++)
		{
			array[i] = Vector3.Distance(base.gameObject.transform.position, this.AIPos[i].transform.position);
		}
		float num = 1000f;
		int num2 = 1;
		for (int j = 1; j < 77; j++)
		{
			if (array[j] <= num)
			{
				num = array[j];
				num2 = j;
			}
		}
		this.aimPos = num2;
		this.beforePos = 1;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003F7C File Offset: 0x0000217C
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Player1")
		{
			GameObject.Find("Black").GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 1f);
			if (GameObject.Find("innyume0") != null)
			{
				UnityEngine.Object.Destroy(GameObject.Find("innyume0").GetComponent<AudioSource>());
			}
			if (GameObject.Find("innyume1") != null)
			{
				UnityEngine.Object.Destroy(GameObject.Find("innyume1").GetComponent<AudioSource>());
			}
			if (GameObject.Find("innyume2") != null)
			{
				UnityEngine.Object.Destroy(GameObject.Find("innyume2").GetComponent<AudioSource>());
			}
			Application.LoadLevel("GameOver");
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000405C File Offset: 0x0000225C
	private void IsAIPosSuc(int _num)
	{
		if (Vector3.Distance(this.AIPos[_num].transform.position, base.gameObject.transform.position) >= 6f)
		{
			return;
		}
		if (this.AIPos[_num].name == "AI" + this.beforePos)
		{
			return;
		}
		if (this.isDiscover)
		{
			return;
		}
		if (this.AIPos[_num].tag == "AIRoute")
		{
			switch (this.aimPos)
			{
				case 1:
					this.aimPos = this.Randomize(6, 2, 12);
					this.beforePos = 1;
					break;
				case 2:
					this.aimPos = this.Randomize(1, 7, 3);
					this.beforePos = 2;
					break;
				case 3:
					this.aimPos = this.Randomize(2, 13, 9);
					this.beforePos = 3;
					break;
				case 4:
					this.aimPos = this.Randomize(13, 5, 8);
					this.beforePos = 4;
					break;
				case 5:
					this.aimPos = this.Randomize(4, 6, 28);
					this.beforePos = 5;
					break;
				case 6:
					this.aimPos = this.Randomize(1, 5);
					this.beforePos = 6;
					break;
				case 7:
					this.aimPos = this.Randomize(2, 8);
					this.beforePos = 7;
					break;
				case 8:
					this.aimPos = this.Randomize(4, 7);
					this.beforePos = 8;
					break;
				case 9:
					this.aimPos = this.Randomize(3, 10, 19);
					this.beforePos = 9;
					break;
				case 10:
					this.aimPos = this.Randomize(9, 11);
					this.beforePos = 10;
					break;
				case 11:
					this.aimPos = this.Randomize(10, 12, 67);
					this.beforePos = 11;
					break;
				case 12:
					this.aimPos = this.Randomize(1, 11);
					this.beforePos = 12;
					break;
				case 13:
					this.aimPos = this.Randomize(4, 3, 14);
					this.beforePos = 13;
					break;
				case 14:
					this.aimPos = this.Randomize(13, 15, 16);
					this.beforePos = 14;
					break;
				case 15:
					this.aimPos = this.Randomize(19, 14, 16);
					this.beforePos = 15;
					break;
				case 16:
					this.aimPos = this.Randomize(14, 15, 17);
					this.beforePos = 16;
					break;
				case 17:
					this.aimPos = this.Randomize(16, 18, 20);
					this.beforePos = 17;
					break;
				case 18:
					this.aimPos = this.Randomize(17, 19);
					this.beforePos = 18;
					break;
				case 19:
					this.aimPos = this.Randomize(9, 15, 18);
					this.beforePos = 19;
					break;
				case 20:
					this.aimPos = this.Randomize(17, 21, 22, 23);
					this.beforePos = 20;
					break;
				case 21:
					this.aimPos = this.Randomize(20, 22, 26);
					this.beforePos = 21;
					break;
				case 22:
					this.aimPos = this.Randomize(21, 23, 25);
					this.beforePos = 22;
					break;
				case 23:
					this.aimPos = this.Randomize(22, 24);
					this.beforePos = 23;
					break;
				case 24:
					this.aimPos = this.Randomize(23, 25, 27);
					this.beforePos = 25;
					break;
				case 25:
					this.aimPos = this.Randomize(22, 24, 26);
					this.beforePos = 24;
					break;
				case 26:
					this.aimPos = this.Randomize(21, 25);
					this.beforePos = 26;
					break;
				case 27:
					this.aimPos = this.Randomize(24, 25, 26, 63);
					this.beforePos = 27;
					break;
				case 28:
					this.aimPos = this.Randomize(5, 29, 32);
					this.beforePos = 28;
					break;
				case 29:
					this.aimPos = this.Randomize(28, 30, 33);
					this.beforePos = 29;
					break;
				case 30:
					this.aimPos = this.Randomize(29, 31);
					this.beforePos = 30;
					break;
				case 31:
					this.aimPos = this.Randomize(30, 32);
					this.beforePos = 31;
					break;
				case 32:
					this.aimPos = this.Randomize(31, 33);
					this.beforePos = 32;
					break;
				case 33:
					this.aimPos = this.Randomize(28, 29, 32, 34);
					this.beforePos = 33;
					break;
				case 34:
					this.aimPos = this.Randomize(33, 35, 42);
					this.beforePos = 34;
					break;
				case 35:
					this.aimPos = this.Randomize(34, 36, 41);
					this.beforePos = 35;
					break;
				case 36:
					this.aimPos = this.Randomize(35, 37, 40);
					this.beforePos = 36;
					break;
				case 37:
					this.aimPos = this.Randomize(36, 38, 39);
					this.beforePos = 37;
					break;
				case 38:
					this.aimPos = this.Randomize(37, 53);
					this.beforePos = 38;
					break;
				case 39:
					this.aimPos = this.Randomize(37, 40);
					this.beforePos = 39;
					break;
				case 40:
					this.aimPos = this.Randomize(36, 39, 41, 45);
					this.beforePos = 40;
					break;
				case 41:
					this.aimPos = this.Randomize(35, 40, 42, 44);
					this.beforePos = 41;
					break;
				case 42:
					this.aimPos = this.Randomize(34, 41, 43);
					this.beforePos = 42;
					break;
				case 43:
					this.aimPos = this.Randomize(42, 44, 52);
					this.beforePos = 43;
					break;
				case 44:
					this.aimPos = this.Randomize(41, 43, 45, 51);
					this.beforePos = 44;
					break;
				case 45:
					this.aimPos = this.Randomize(40, 44, 46, 50);
					this.beforePos = 45;
					break;
				case 46:
					this.aimPos = this.Randomize(45, 47, 49);
					this.beforePos = 46;
					break;
				case 47:
					this.aimPos = this.Randomize(46, 48, 59);
					this.beforePos = 47;
					break;
				case 48:
					this.aimPos = this.Randomize(47, 49);
					this.beforePos = 48;
					break;
				case 49:
					this.aimPos = this.Randomize(46, 48, 50);
					this.beforePos = 49;
					break;
				case 50:
					this.aimPos = this.Randomize(45, 49, 51);
					this.beforePos = 50;
					break;
				case 51:
					this.aimPos = this.Randomize(44, 50, 52);
					this.beforePos = 51;
					break;
				case 52:
					this.aimPos = this.Randomize(43, 51);
					this.beforePos = 52;
					break;
				case 53:
					this.aimPos = this.Randomize(38, 54);
					this.beforePos = 53;
					break;
				case 54:
					this.aimPos = this.Randomize(53, 55);
					this.beforePos = 54;
					break;
				case 55:
					this.aimPos = this.Randomize(54, 56);
					this.beforePos = 55;
					break;
				case 56:
					this.aimPos = this.Randomize(55, 57, 58);
					this.beforePos = 56;
					break;
				case 57:
					this.aimPos = this.Randomize(56, 58);
					this.beforePos = 57;
					break;
				case 58:
					this.aimPos = this.Randomize(56, 57);
					this.beforePos = 58;
					break;
				case 59:
					this.aimPos = this.Randomize(47, 60);
					this.beforePos = 59;
					break;
				case 60:
					this.aimPos = this.Randomize(59, 61);
					this.beforePos = 60;
					break;
				case 61:
					this.aimPos = this.Randomize(60, 62);
					this.beforePos = 61;
					break;
				case 62:
					this.aimPos = this.Randomize(61, 63);
					this.beforePos = 62;
					break;
				case 63:
					this.aimPos = this.Randomize(27, 62, 64);
					this.beforePos = 63;
					break;
				case 64:
					this.aimPos = this.Randomize(63, 65);
					this.beforePos = 64;
					break;
				case 65:
					this.aimPos = this.Randomize(64, 66);
					this.beforePos = 65;
					break;
				case 66:
					this.aimPos = this.Randomize(65, 67);
					this.beforePos = 66;
					break;
				case 67:
					this.aimPos = this.Randomize(11, 66, 68);
					this.beforePos = 67;
					break;
				case 68:
					this.aimPos = this.Randomize(67, 69);
					this.beforePos = 68;
					break;
				case 69:
					this.aimPos = this.Randomize(68, 70);
					this.beforePos = 69;
					break;
				case 70:
					this.aimPos = this.Randomize(69, 71);
					this.beforePos = 70;
					break;
				case 71:
					this.aimPos = this.Randomize(70, 72);
					this.beforePos = 71;
					break;
				case 72:
					this.aimPos = this.Randomize(71, 73);
					this.beforePos = 72;
					break;
				case 73:
					this.aimPos = this.Randomize(72, 74, 76);
					this.beforePos = 73;
					break;
				case 74:
					this.aimPos = this.Randomize(73, 75);
					this.beforePos = 74;
					break;
				case 75:
					this.aimPos = this.Randomize(74, 76);
					this.beforePos = 75;
					break;
				case 76:
					this.aimPos = this.Randomize(73, 75);
					this.beforePos = 76;
					break;
			}
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00004B14 File Offset: 0x00002D14
	private int Randomize(int a, int b)
	{
		if (a == this.beforePos)
		{
			return b;
		}
		if (b == this.beforePos)
		{
			return a;
		}
		return a;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00004B34 File Offset: 0x00002D34
	private int Randomize(int a, int b, int c)
	{
		int num = UnityEngine.Random.Range(0, 2);
		if (a == this.beforePos)
		{
			if (num == 0)
			{
				return b;
			}
			return c;
		}
		else if (b == this.beforePos)
		{
			if (num == 0)
			{
				return a;
			}
			return c;
		}
		else
		{
			if (c != this.beforePos)
			{
				return a;
			}
			if (num == 0)
			{
				return a;
			}
			return b;
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004B8C File Offset: 0x00002D8C
	private int Randomize(int a, int b, int c, int d)
	{
		int num = UnityEngine.Random.Range(0, 3);
		if (a == this.beforePos)
		{
			if (num == 0)
			{
				return b;
			}
			if (num == 1)
			{
				return c;
			}
			return d;
		}
		else if (b == this.beforePos)
		{
			if (num == 0)
			{
				return a;
			}
			if (num == 1)
			{
				return c;
			}
			return d;
		}
		else if (c == this.beforePos)
		{
			if (num == 0)
			{
				return a;
			}
			if (num == 1)
			{
				return b;
			}
			return d;
		}
		else
		{
			if (d != this.beforePos)
			{
				return a;
			}
			if (num == 0)
			{
				return a;
			}
			if (num == 1)
			{
				return b;
			}
			return c;
		}
	}

	// Token: 0x04000036 RID: 54
	public bool isDiscover;

	// Token: 0x04000037 RID: 55
	public bool isDiscover2;

	// Token: 0x04000038 RID: 56
	private int frame;

	// Token: 0x04000039 RID: 57
	public int beforePos;

	// Token: 0x0400003A RID: 58
	public int aimPos;

	// Token: 0x0400003B RID: 59
	private GameObject[] AIPos = new GameObject[77];

	// Token: 0x0400003C RID: 60
	private GameObject player;

	// Token: 0x0400003D RID: 61
	public GameObject eye;

	// Token: 0x0400003E RID: 62
	private UnityEngine.AI.NavMeshAgent agent;

	// Token: 0x0400003F RID: 63
	public GameObject eyePrefab;
}

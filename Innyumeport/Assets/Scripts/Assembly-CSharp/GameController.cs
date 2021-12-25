using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class GameController : MonoBehaviour
{
	// Token: 0x06000026 RID: 38 RVA: 0x00003538 File Offset: 0x00001738
	private void Start()
	{
		this.wallOBJ[0] = GameObject.Find("Wall");
		this.wallOBJ[1] = GameObject.Find("Wall_Collision");
		for (int i = 0; i < 5; i++)
		{
			this.frame[i] = 0;
		}
		this.isAdd_Ga = false;
		this.isAdd_Ri = false;
		this.isAdd_All = false;
		Cursor.visible = false;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000035A0 File Offset: 0x000017A0
	private void FixedUpdate()
	{
		float num = -6f;
		int i = 0;
		while (i < 5)
		{
			if (this.getItem[i])
			{
				this.frame[i]++;
				if (this.frame[i] == 1)
				{
					UnityEngine.Object.Instantiate(this.getItemPrefab[i], new Vector3(num, 4f, 10f), Quaternion.Euler(270f, 180f, 0f));
				}
				if (this.frame[i] >= 10000)
				{
					this.frame[i] = 10;
				}
			}
			i++;
			num += 3f;
		}
		if (this.getItem[4] && !this.isAdd_Ga)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(this.innyumePrefab, new Vector3(-145f, 20f, -80f), Quaternion.identity) as GameObject;
			gameObject.name = "innyume1";
			this.isAdd_Ga = true;
		}
		if (this.getItem[0] && !this.isAdd_Ri)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(this.innyumePrefab, new Vector3(105f, 20f, -80f), Quaternion.identity) as GameObject;
			gameObject2.name = "innyume2";
			this.isAdd_Ri = true;
		}
		if (this.getItem[0] && this.getItem[1] && this.getItem[2] && this.getItem[3] && this.getItem[4])
		{
			if (!this.isAdd_All)
			{
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(85f, 20f, -80f), Quaternion.identity);
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(-65f, 0f, -135f), Quaternion.identity);
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(85f, 40f, -15f), Quaternion.identity);
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(35f, 40f, -85f), Quaternion.identity);
				UnityEngine.Object.Instantiate(this.zetInnyumePrefab, new Vector3(-95f, 20f, -25f), Quaternion.identity);
				UnityEngine.Object.Destroy(GameObject.Find("innyume0"));
				UnityEngine.Object.Destroy(GameObject.Find("InnyumeEye0"));
				UnityEngine.Object.Destroy(GameObject.Find("innyume1"));
				UnityEngine.Object.Destroy(GameObject.Find("InnyumeEye1"));
				UnityEngine.Object.Destroy(GameObject.Find("innyume2"));
				UnityEngine.Object.Destroy(GameObject.Find("InnyumeEye2"));
				this.isAdd_All = true;
			}
			for (int j = 0; j < 5; j++)
			{
				GameObject gameObject3 = GameObject.Find("Item_" + (j + 1) + "(Clone)");
				gameObject3.GetComponent<Renderer>().material = this.colorMAT;
				UnityEngine.Object.Destroy(gameObject3.GetComponent<Light>());
			}
			UnityEngine.Object.Destroy(this.wallOBJ[0]);
			UnityEngine.Object.Destroy(this.wallOBJ[1]);
		}
	}

	// Token: 0x04000023 RID: 35
	public bool[] getItem = new bool[5];

	// Token: 0x04000024 RID: 36
	public GameObject[] getItemPrefab = new GameObject[5];

	// Token: 0x04000025 RID: 37
	private int[] frame = new int[5];

	// Token: 0x04000026 RID: 38
	public GameObject innEventPrefab;

	// Token: 0x04000027 RID: 39
	public GameObject innyumePrefab;

	// Token: 0x04000028 RID: 40
	public GameObject zetInnyumePrefab;

	// Token: 0x04000029 RID: 41
	private bool isAdd_Ga;

	// Token: 0x0400002A RID: 42
	private bool isAdd_Ri;

	// Token: 0x0400002B RID: 43
	private bool isAdd_All;

	// Token: 0x0400002C RID: 44
	private GameObject[] wallOBJ = new GameObject[2];

	// Token: 0x0400002D RID: 45
	public Material colorMAT;
}

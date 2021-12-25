using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class Player1 : MonoBehaviour
{
	// Token: 0x06000048 RID: 72 RVA: 0x00004DB8 File Offset: 0x00002FB8
	private void Start()
	{
		this.camAngle = Vector3.zero;
		this.camOBJ = GameObject.Find("Main Camera");
		this.frame = 100;
		this.location = 0;
		Physics.gravity = new Vector3(0f, -98.100006f, 0f);
		this.camAngle = new Vector3(0f, 180f, 0f);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004E24 File Offset: 0x00003024
	private void FixedUpdate()
	{
		this.CharaMove();
		this.CamRot();
		this.frame--;
		if (this.frame > 0)
		{
			GameObject.Find("Black").GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, (float)this.frame / 100f);
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00004E94 File Offset: 0x00003094
	private void CharaMove()
	{
		Vector3 localEulerAngles = this.camOBJ.transform.localEulerAngles;
		Vector3 vector = new Vector3(Mathf.Cos((localEulerAngles.y - 270f) * 0.017453292f) * -1f, 0f, Mathf.Sin((localEulerAngles.y - 270f) * 0.017453292f));
		float num = 0.3f;
		float num2 = Input.GetAxis("Vertical") * num;
		if (num2 != 0f)
		{
			base.gameObject.GetComponent<Rigidbody>().transform.position += new Vector3(vector.x * num2, 0f, vector.z * num2);
		}
		float num3 = Input.GetAxis("Horizontal") * num;
		if (num3 != 0f)
		{
			base.gameObject.GetComponent<Rigidbody>().transform.position += new Vector3(vector.z * num3, 0f, -vector.x * num3);
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00004FA8 File Offset: 0x000031A8
	private void CamRot()
	{
		float axis = Input.GetAxis("Mouse X");
		float axis2 = Input.GetAxis("Mouse Y");
		float num = -3f;
		this.camAngle += new Vector3(axis2 * num, -axis * num, 0f);
		this.camOBJ.transform.rotation = Quaternion.Euler(this.camAngle);
		if (this.camOBJ.transform.localEulerAngles.x > 60f && this.camOBJ.transform.localEulerAngles.x <= 180f)
		{
			this.camOBJ.transform.localEulerAngles = new Vector3(60f, this.camAngle.y, 0f);
			this.camAngle = new Vector3(60f, this.camAngle.y, this.camAngle.z);
		}
		if (this.camOBJ.transform.localEulerAngles.x >= 180f && this.camOBJ.transform.localEulerAngles.x < 300f)
		{
			this.camOBJ.transform.localEulerAngles = new Vector3(300f, this.camAngle.y, 0f);
			this.camAngle = new Vector3(300f, this.camAngle.y, this.camAngle.z);
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000513C File Offset: 0x0000333C
	private void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "1F_Right")
		{
			this.location = 1;
		}
		if (col.gameObject.tag == "1F_Left")
		{
			this.location = 2;
		}
		if (col.gameObject.tag == "2F_Right")
		{
			this.location = 3;
		}
		if (col.gameObject.tag == "2F_Left")
		{
			this.location = 4;
		}
		if (col.gameObject.tag == "3F")
		{
			this.location = 5;
		}
		if (col.gameObject.tag == "EmerSteps")
		{
			this.location = 6;
		}
	}

	// Token: 0x04000044 RID: 68
	private Vector3 camAngle;

	// Token: 0x04000045 RID: 69
	private GameObject camOBJ;

	// Token: 0x04000046 RID: 70
	public int location;

	// Token: 0x04000047 RID: 71
	public int frame;
}

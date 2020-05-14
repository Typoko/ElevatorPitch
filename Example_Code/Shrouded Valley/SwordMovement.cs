using UnityEngine;
using System.Collections;

public class SwordMovement : MonoBehaviour {

	public GameObject playerChar;
	public Vector3 playerPos;
	public Transform playerTrf;
	public Transform thisTrf;
	public ParticleSystem thisParticle;
	public bool hasCharge;
	public float chargeTime;
	public bool wepRaised;
	public GameObject slamEffect;

	// Use this for initialization
	void Start () {
		playerTrf = playerChar.transform;
		thisTrf = this.transform;
		hasCharge = false;
		wepRaised = false;
		chargeTime = 0f;

		Transform[] allTrf = this.GetComponentsInChildren<Transform>();
		foreach (Transform trf in allTrf)
			if (trf.gameObject.name == "ChargeParticle")
				thisParticle = trf.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {

		//playerPos = playerChar.transform.position;

		Vector3 inputDirection = Vector3.zero;
		inputDirection.x = Input.GetAxis("RightX");
		inputDirection.z -= Input.GetAxis("RightY");
		inputDirection.y = CalculateYPos(inputDirection.x, inputDirection.z);

		PositionWeapon(inputDirection);

		IsWepCharging();

		if(hasCharge && !thisParticle.isPlaying)
			thisParticle.Play();
		else
			if(!hasCharge && thisParticle.isPlaying) 
				thisParticle.Stop();

	}

	public void IsWepCharging()
	{
		float inputSum = Mathf.Sqrt(Mathf.Pow(Input.GetAxis("RightX"),2f) + Mathf.Pow(Input.GetAxis("RightY"),2f));
		//print(inputSum);
		if(!wepRaised)
		{
			if(!hasCharge)
			{
				if(inputSum > 0.95f)
					chargeTime += Time.deltaTime;
				else
					chargeTime = 0;
				
				if(chargeTime > 1)
				{
					hasCharge = true;
				}

			}
			else
			{
				if(inputSum < 0.8f)
					wepRaised = true;
			}
		}
		else
		{
			chargeTime -= Time.deltaTime;

			if(inputSum > 0.95f)	
			{
				//print("SLAM!");
				Vector3 slamPos = Vector3.zero;
				slamPos.x = this.transform.position.x + 0.6f * (this.transform.position.x - playerChar.transform.position.x);
				slamPos.y = this.transform.position.y;
				slamPos.z = this.transform.position.z + 0.6f * (this.transform.position.z - playerChar.transform.position.z);

				Instantiate(slamEffect,slamPos,this.transform.rotation);
				wepRaised = false;
				hasCharge = false;
				chargeTime = 0;
			}

			if(chargeTime<0)
			{
				wepRaised = false;
				hasCharge = false;
				chargeTime = 0;
			}
		}
	}

	public void PositionWeapon(Vector3 wepDir)
	{
		thisTrf.position = playerChar.transform.position + wepDir*2;
		//thisTrf.rotation = RotateSword(playerPos,inputDirection);
		thisTrf.rotation = Quaternion.FromToRotation(new Vector3(0,1,0),wepDir);
	}

	public float CalculateYPos(float xPos, float zPos)
	{
		float yPos = 1.5f;

		float tempPos;
		float tempPos2;


		tempPos = Mathf.Sqrt(Mathf.Pow(xPos,2f) + Mathf.Pow(zPos,2f));
		//print(tempPos.ToString());
		if(tempPos>1) tempPos = 1;
		//print(tempPos.ToString());
		tempPos2 = Mathf.Sqrt(Mathf.Pow(1f,2f) - Mathf.Pow(tempPos,2f));

		yPos = tempPos2;
			
		/*print("xPos: " + xPos.ToString());
		print("yPos: " + yPos.ToString());
		print("zPos: " + zPos.ToString());*/


		return yPos;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Enemy")
		{
			EnemyScript eScript = other.GetComponent<EnemyScript>();

			eScript.TakeDamage(5);
			eScript.KnockBack(thisTrf.position, 500);
			eScript.KnockBack(playerTrf.position, 900);
		}
	}


	/*public Quaternion RotateSword(Vector3 sPos, Vector3 ePos)
	{
		Quaternion rsQuaternion;

		Vector3 v3Direction = ePos-sPos;
		rsQuaternion = Quaternion.FromToRotation(

		return rsQuaternion;
	}*/

}



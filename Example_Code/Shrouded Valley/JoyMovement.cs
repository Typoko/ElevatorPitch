using UnityEngine;
using System.Collections;

public class JoyMovement : MonoBehaviour {

	public Rigidbody thisRB;
	public int speedMultiplier;
	public bool isJumping = false;
	public bool isFalling = false;
	public bool doubleJump = false;
	public float jumpGauge = 0;
	public bool releasedJump = true;

	public GameObject weaponGO;

	public int playerHealth;
	public HealthBarScript thisHealth;

	// Use this for initialization
	void Start () {
		thisRB = this.GetComponent<Rigidbody>();
		playerHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 inputDirection = new Vector3(0,0,0);
		if(!(thisRB.velocity.x > 10 && Input.GetAxis("LeftX") > 0f) && !(thisRB.velocity.x < -10 && Input.GetAxis("LeftX") < 0f))// && Input.GetAxisRaw("LeftY") < 0f))
			inputDirection.x = Input.GetAxis("LeftX");
		if(!(thisRB.velocity.z > 10 && Input.GetAxis("LeftY") < 0f) && !(thisRB.velocity.z < -10 && Input.GetAxis("LeftY") > 0f))// && Input.GetAxisRaw("LeftY") < 0f))
			inputDirection.z -= Input.GetAxis("LeftY");
		if(inputDirection.magnitude>0.2f)
			thisRB.AddForce(inputDirection*speedMultiplier);
		//print(inputDirection.magnitude);
		//print("update1 " + Input.GetAxis("RightX").ToString() + Input.GetAxis("RightY").ToString());
		//print(Input.GetButton("pJump").ToString() + thisRB.velocity.y.ToString());
		if(Input.GetButton("pJump") == true && !isFalling)// && thisRB.position.y < 1.3f)
		{
			isJumping = true;
			releasedJump = false;
			if (thisRB.velocity.y < 0.2)
				thisRB.AddForce(new Vector3(0,7,0),ForceMode.Impulse);
			
			thisRB.velocity += Vector3.up * 200 * Time.deltaTime;
			//thisRB.AddForce(new Vector3(0,10,0),ForceMode.Impulse);
			jumpGauge +=Time.deltaTime;
		}

		if(Input.GetButton("pRespawn"))
			this.transform.position = new Vector3(0f,2f,0f);

		if(Input.GetButton("pJump") == false && !releasedJump)
			releasedJump = true;
					
		if(((Input.GetButton("pJump") == false && isJumping) ||( jumpGauge > 0.2f && isJumping))&& !isFalling)
		{
			isFalling = true;
			//print("lähtee putoomaan");
		}

		if(Input.GetButton("pJump") == false && isJumping && !doubleJump)
		{
			//print("Lupa!" + doubleJump.ToString());
			doubleJump = true;
		}


		/*if(thisRB.velocity.y < -13f && doubleJump)
		{
			print("tiputus nopeus dj pois");
			print(thisRB.velocity.y);
			doubleJump = false;
		}*/

		if(Input.GetButton("pJump") == true && isFalling && doubleJump)
		{
			//print("Double jumperu!");
			//thisRB.AddForce(new Vector3(0,10,0),ForceMode.Impulse);
			thisRB.velocity = new Vector3 (thisRB.velocity.x, 20f,thisRB.velocity.z);
			doubleJump = false;
			isJumping = false;
			releasedJump = false;
		}

		if(thisRB.velocity.y == 0 && releasedJump && isFalling)
		{
			isJumping = false;
			isFalling = false;
			doubleJump = false;
			//releasedJump = true;
			jumpGauge = 0;
		}
		//print("IsJumping " + isJumping.ToString() + "|| IsFalling " + isFalling.ToString());

		if(thisRB.velocity.y<0f || (isFalling && thisRB.velocity.y<0.2f))// && thisRB.velocity.y > -11f)
		{
			if(thisRB.velocity.y > -11f)
				thisRB.velocity += Vector3.up * Physics.gravity.y * 25f * Time.deltaTime;
			else
				thisRB.velocity += Vector3.up * Physics.gravity.y * 18f * Time.deltaTime;
			//print(thisRB.velocity.y.ToString());
		}
	}

	public void TakeDamage(int iDamage)
	{
		playerHealth -=iDamage;
		thisHealth.ChangeHealth((float)playerHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "eWeapon")
		{
			TakeDamage(5);
			//Transform otherTRF = other.GetComponent<Transform>();
			//SwordMovement otherSM = other.GetComponent<SwordMovement>();

			Vector3 knockBackW = new Vector3(thisRB.position.x - other.transform.position.x,0.1f,thisRB.position.z - other.transform.position.z);
			knockBackW.Normalize();

			Vector3 knockBackP = new Vector3(thisRB.position.x - other.transform.position.x,0.1f,thisRB.position.z - other.transform.position.z);
			knockBackP.Normalize();

			thisRB.AddForce(knockBackW*500);
			thisRB.AddForce(knockBackP*900);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.transform.tag == "Enemy")
			TakeDamage(5);

	}

	public void Die()
	{
		print("Player has died!");
		//Destroy(weaponGO);
		//Destroy(this.gameObject);
	}
}


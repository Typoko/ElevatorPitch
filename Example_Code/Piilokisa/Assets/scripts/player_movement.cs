using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

    public static float max_player_speed = 0.06f;
    public static bool bl_canMove = true;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 0, -7);
	}
	
	// Update is called once per frame
	void Update () {
        //Time.deltaTimen use removed from the calculation as it didn't seem to respond correctly to changes in max_player_speed
        //Might have been an issue with scripts not uploading on Unity

        //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * max_player_speed);
        //transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * max_player_speed);
        if (bl_canMove)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * max_player_speed);
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * max_player_speed);
        }
    }
    
    // parempi?
    // void FixedUpdate() {}
        
   

}

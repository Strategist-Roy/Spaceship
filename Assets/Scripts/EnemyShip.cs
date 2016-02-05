using UnityEngine;
using System.Collections;

public class EnemyShip : MonoBehaviour {

	private GameObject missile;
	private Rigidbody erb;
	void Start () {
		transform.position = new Vector3 (Random.Range (9F, 40F), 10, Random.Range (-20F, 20F));   //Position the ship at the range defined
		transform.Rotate(new Vector3 (Random.Range(0F, 90F), Random.Range(0F, 90F), Random.Range(0F, 90F)));   //Set Random Angles
		gameObject.AddComponent<Rigidbody> ();     //Add Rigidbody Component
		erb = GetComponent<Rigidbody> ();     //Access rigidbody attached to this object
		erb.useGravity = false;        //Disable Gravity
		erb.velocity = Vector3.right * -10;    //Set Velocity to be approaching the player
	}
	void Update () {
		if (transform.position.x <= -44F) {     //Destroy Ship if it crosses the screen
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter (Collision col) {      //On Collision with Missiles Destroy
		if (col.gameObject.name == "Missile") {
			Destroy (gameObject);
		}
	}		
}

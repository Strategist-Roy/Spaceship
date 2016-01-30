using UnityEngine;
using System.Collections;

public class EnemyShip : MonoBehaviour {

	private Rigidbody erb;
	void Start () {
		transform.position = new Vector3 (Random.Range (9F, 40F), 10, Random.Range (12.4F, -12.4F));   //Position the ship at the range defined
		gameObject.AddComponent<Rigidbody> ();     //Add Rigidbody Component
		erb = GetComponent<Rigidbody> ();     //Access rigidbody attached to this object
		erb.useGravity = false;        //Disable Gravity
		erb.velocity = Vector3.right * -20;    //Set Velocity to be approaching the player
	}
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {      //On Collision with Missiles Destroy
		if (col.gameObject.name == "Missile") {
			Destroy (gameObject);
		}
	}
}

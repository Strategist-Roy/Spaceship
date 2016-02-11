using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	private Rigidbody rb;
	void Start () {
		transform.position = new Vector3 (Random.Range (9F, 40F), 10, Random.Range (-7F, 12F));   //Position the ship at the range defined
		transform.Rotate(new Vector3 (Random.Range(0F, 90F), Random.Range(0F, 90F), Random.Range(0F, 90F)));   //Set Random Angles
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;   //Set Gravity to null
		rb.velocity = Vector3.right * -10;   //Set velocity of Asteroids
	}
	
	void Update () {
		if (transform.position.x <= -44F) {     //Destroy Asteroid if it crosses the screen
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter (Collision col) {      //On Collision with Missiles Destroy
		if (col.gameObject.name == "Missile") {
			Destroy (gameObject);
		}
	}		
}

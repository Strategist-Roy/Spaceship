using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

	void Start () {
		transform.position = GameObject.Find ("Gun").transform.position;       //Sets launch point of missile as that of the Gun
		transform.eulerAngles = new Vector3 (0, 0, -90);   //Aligns the missile;
		//gameObject.AddComponent<Rigidbody> ();     //Adds Rigidbody component;
		//Rigidbody mr = GetComponent<Rigidbody> ();  //Recieves Rigidbody attached to Missile
		//mr.useGravity = false;   //Disables Gravity
		//mr.velocity = Vector3.right * 10;   //Sets Velocity of magnitude 80 units
		//CapsuleCollider cc = GetComponent<CapsuleCollider> ();
		//cc.isTrigger = true;
		//transform.Translate(Vector3.right * 10 * Time.deltaTime);
	}

	void Update () {
		transform.Translate(Vector3.up * 80 * Time.deltaTime);
		if (transform.position.x >= 48F) {    //If missile exits the screen, destroy it automatically
			Destroy (gameObject);
		}
	}
}
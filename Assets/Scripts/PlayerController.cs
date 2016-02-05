using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour
{
	public float speed;    //speed of translation
	private float x;    //Input parameters for Spaceship movement
	private float y;         
	private GunController gun;
	void Start () {
		gun = transform.Find ("Gun").GetComponent<GunController> ();     //Recieve Script Object
	}

	void Update () {
		x = Input.GetAxis ("Horizontal");  //Recieve Inputs
		y = Input.GetAxis ("Vertical");    //Recieve Inputs
		transform.Translate (x * speed * Time.deltaTime, 0, y * speed * Time.deltaTime);  //Translates
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -43.19F, -38F), 10, Mathf.Clamp (transform.position.z, -7F, 12F));    //Prevents Ship from exiting screen by clamping the position
		if (Input.GetKeyDown(KeyCode.Space)) {   //Fires the missiles by accessing Fire method of GunController
			gun.Fire ();
		}
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.name == "Asteroid") {    //Destroy Player Ship if Enemy Ship collides
			Destroy (gameObject);
		}
	}
}
using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour
{
	public float speed;
	private float x;
	private float y;
	private GunController gun;
	void Start () {
		gun = transform.GetChild (5).GetComponent<GunController> ();     //Recieve Script Object
	}

	void Update () {
		x = Input.GetAxis ("Horizontal");  //Recieve Inputs
		y = Input.GetAxis ("Vertical");    //Recieve Inputs
		transform.Translate (x * speed * Time.deltaTime, 0, y * speed * Time.deltaTime);  //Translates
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -37.6F, -9.5F), 10, Mathf.Clamp (transform.position.z, -12.5F, 12.5F));    //Prevents Ship from exiting screen by clamping the position
		if (Input.GetKeyDown(KeyCode.Space)) {   //Fires the missiles by accessing Fire method of GunController
			gun.Fire ();
		}
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.name == "EnemyShip") {    //Destroy Player Ship if Enemy Ship collides
			Destroy (gameObject);
		}
	}
}
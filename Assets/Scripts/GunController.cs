using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public GameObject missile;
	public void Fire () {
		//missile = GameObject.CreatePrimitive (PrimitiveType.Capsule);     //Returns Missile Object with Capsule Collider
		GameObject m = Instantiate(missile, transform.position, new Quaternion(0, 0, -1, 1)) as GameObject;
		m.name = "Missile";  //Names the gameobject as Missile
		m.AddComponent<Missile> ();  //Attach Missile Script to each missile
	}
}
		
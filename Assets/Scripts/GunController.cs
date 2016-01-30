using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	private GameObject missile;
	public void Fire () {
		missile = GameObject.CreatePrimitive (PrimitiveType.Capsule);     //Returns Missile Object with Capsule Collider
		missile.name = "Missile";   //Names the gameobject as Missile
		missile.AddComponent<Missile> ();  //Attach Missile Script to each missile
	}
}
		
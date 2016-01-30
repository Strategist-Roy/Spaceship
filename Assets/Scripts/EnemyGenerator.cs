using UnityEngine;
using System.Collections;

public class EnemyGenerator: MonoBehaviour {
	
	void Start () {
		InvokeRepeating ("Generate", 0F, 2F);    //Call Generate to create EnemyShips at interval of 2s 
	}

	public void Generate () {
		GameObject enemy = GameObject.CreatePrimitive (PrimitiveType.Cube);    //Create Enemy Ship
		enemy.name = "EnemyShip";    //Name it
		enemy.AddComponent<EnemyShip> ();   //Add the Enemy Ship script to govern it's dynamics
		Random.seed = (int) System.DateTime.Now.Ticks;   //Provide New Seed to Random function
	}
}

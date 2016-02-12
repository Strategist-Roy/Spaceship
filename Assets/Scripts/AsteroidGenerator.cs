using UnityEngine;
using System.Collections;

public class AsteroidGenerator: MonoBehaviour {

	private int conc;
	public GameObject rock;
	void Start () {
		InvokeRepeating ("Generate", 0F, 0.7F);    //Call Generate to create EnemyShips at interval of 0.7s 
	}

	public void Generate () {
		Random.seed = (int) System.DateTime.Now.Ticks;
		conc = Random.Range (1, 5);
		while (conc != 0) {
			conc--;
			GameObject asteroid = Instantiate (rock) as GameObject;
			asteroid.name = "Asteroid";
			asteroid.AddComponent<Asteroid> ();
			asteroid.AddComponent<Rigidbody> ();
			/*GameObject enemy = GameObject.CreatePrimitive (PrimitiveType.Cube);    //Create Enemy Ship
			enemy.name = "EnemyShip";    //Name it
			enemy.AddComponent<EnemyShip> ();   //Add the Enemy Ship script to govern it's dynamics*/
			Random.seed = (int) System.DateTime.Now.Ticks;   //Provide New Seed to Random function
		}
	}
}

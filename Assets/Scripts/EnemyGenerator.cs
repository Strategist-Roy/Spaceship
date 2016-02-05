using UnityEngine;
using System.Collections;

public class EnemyGenerator: MonoBehaviour {

	private int no_enemies;
	public GameObject rock;
	void Start () {
		InvokeRepeating ("Generate", 0F, 0.7F);    //Call Generate to create EnemyShips at interval of 2s 
	}

	public void Generate () {
		Random.seed = (int) System.DateTime.Now.Ticks;
		no_enemies = Random.Range (5, 15);
		while (no_enemies != 0) {
			no_enemies--;
			GameObject asteroid = Instantiate (rock) as GameObject;
			asteroid.name = "Asteroid";
			asteroid.AddComponent<EnemyShip> ();
			/*GameObject enemy = GameObject.CreatePrimitive (PrimitiveType.Cube);    //Create Enemy Ship
			enemy.name = "EnemyShip";    //Name it
			enemy.AddComponent<EnemyShip> ();   //Add the Enemy Ship script to govern it's dynamics*/
			Random.seed = (int) System.DateTime.Now.Ticks;   //Provide New Seed to Random function
		}
	}
}

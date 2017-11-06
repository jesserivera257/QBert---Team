using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JR_Respawn : MonoBehaviour {

	//public Transform enemy;
	public Transform player;
	public Transform respawnPosition;
	//public Transform enemySpawnPosition;


	void start ()
	{
		player.transform.position = respawnPosition.transform.position;
	}


	void OnTriggerEnter(Collider other)
	{
		player.transform.position = respawnPosition.transform.position;
		//enemy.transform.position = enemySpawnPosition.transform.position;
	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //El punto de spawn se suscribe en la lista.
        SpawnManager.GetInstance().NewSpawnPoint(gameObject);
	}
}

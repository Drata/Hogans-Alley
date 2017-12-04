using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] prefabs;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnPerson());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnPerson() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(4f, 10f));
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
        }
    }
}

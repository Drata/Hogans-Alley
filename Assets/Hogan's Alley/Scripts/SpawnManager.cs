using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    private static SpawnManager instance;

    public GameObject[] prefabs;
    private List<GameObject> spawnPoints = new List<GameObject>();

    //Singleton
    public static SpawnManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnPerson());
	}

    //Observer
    public void NewSpawnPoint(GameObject spawnPoint)
    {
        spawnPoints.Add(spawnPoint);
        Debug.Log("Spawnpoint added.");
    }

    IEnumerator SpawnPerson() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(4f, 6f));
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnPoints[Random.Range(0, spawnPoints.Count)].transform);
        }
    }
}

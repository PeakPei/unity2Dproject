using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = .5f;
    public float spawnMax = .6f;


	// Use this for initialization
	void Start () {
        Spawn();
	}

    void FixedUpdate()
    {

    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnDistance = 25f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < 5)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 position =  new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
        position.Normalize();
        position = position * spawnDistance + player.transform.position;
        Instantiate(enemy, position, Quaternion.identity, gameObject.transform);
    }
}

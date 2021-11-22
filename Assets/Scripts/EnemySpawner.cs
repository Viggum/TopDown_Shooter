using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] EnemyArray;
    private GameObject Enemy;
    private bool Spawning = false;
    private int x = 15, y = 0, z = 21;
    public float SpawnSpeed;
   

    // Start is called before the first frame update
    void Start()
    {
        Spawning = true;
    }

    // Update is called once per frame
    void Update()
    {
        Enemy = EnemyArray[Random.Range(0, EnemyArray.Length)];

        if (Spawning == true && Enemy != null)
        {
            Instantiate(Enemy, new Vector3(Random.Range(-x, x), y, z), Enemy.transform.rotation);
            Spawning = false;
            StartCoroutine("SpawnTime");
        }
    }

    IEnumerator SpawnTime()
    {
        yield return new WaitForSeconds(5/SpawnSpeed);
        Spawning = true;
    }
}

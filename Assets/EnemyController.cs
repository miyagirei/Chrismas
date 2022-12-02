using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]GameObject enemyPrefabs;
    static public int enemyCount;

    [SerializeField] GameObject startSpawn;
    [SerializeField] GameObject endSpawn;

    private void Update()
    {
        if(enemyCount < 5)
        {
            float x = Random.Range(startSpawn.transform.position.x, endSpawn.transform.position.x);
            float z = Random.Range(startSpawn.transform.position.z, endSpawn.transform.position.z);

            Instantiate(enemyPrefabs, new Vector3(x, startSpawn.transform.position.y, z), Quaternion.identity);
            enemyCount++;
        }
    }
}

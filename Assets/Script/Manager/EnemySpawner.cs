using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // public GameObject enemySmallPrefabs;
    // public GameObject enemyMedPrefabs;
    // public GameObject enemyBigPrefabs;

    public ObjectSpawnRate[] enemies;
    public float spawnDelay;

    private List<GameObject> enemyList;
    // Start is called before the first frame update
    void Start()
    {
        enemyList = new List<GameObject>();

        StartCoroutine(spawner());
    }

    private IEnumerator spawner()
    {
        while (true)
        {
            if (GameManager.GetInstance().isPlaying)
            {
                Spawn();
                yield return new WaitForSeconds(spawnDelay);
            }
            else
            {
                yield return null;
            }
        }
    }

    public void Spawn()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Random.Range(-6f, 6f);
        enemyList.Add(Instantiate(getEnemy(), newPosition, transform.rotation));
    }

    public void clearEnemies()
    {
        foreach (GameObject go in enemyList)
        {
            Destroy(go);
        }
        enemyList.Clear();
    }

    private GameObject getEnemy()
    {
        int limit = 0;

        foreach (ObjectSpawnRate osr in enemies)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach (ObjectSpawnRate osr in enemies)
        {
            if (random < osr.rate)
            {
                return osr.prefab;
            }
            else
            {
                random -= osr.rate;
            }
        }

        return null;
    }
}

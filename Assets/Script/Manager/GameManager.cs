using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public GameObject playerPrefabs;
    public GameObject activePlayer;
    public bool isPlaying = false;
    public UnityAction OnGameOverAction;

    public ScriptableInt life;
    public ScriptableInt coin;
    public EnemySpawner enemy;
    public List<GameObject> items;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        items = new List<GameObject>();
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    private void spawnPlayer()
    {
        activePlayer = Instantiate(playerPrefabs);
    }

    public Vector3 getPlayerPosition()
    {

        if (activePlayer != null)
        {
            return activePlayer.transform.position;
        }
        return Vector3.zero;
    }

    public void startGame()
    {
        isPlaying = true;
        spawnPlayer();
    }

    public void pauseGame()
    {
        isPlaying = false;
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        isPlaying = true;
        Time.timeScale = 1;
    }
    internal void gameOver()
    {
        isPlaying = false;
        OnGameOverAction?.Invoke();
    }

    internal void retry()
    {
        life.Reset();
        coin.Reset();
        enemy.clearEnemies();
        ObjectPool.GetInstance().deactivateObject();
        ClearItems();
    }

    internal void getItem(GameObject gameObject)
    {
        items.Add(gameObject);
    }
    public void AddItem(GameObject gameObject)
    {
        items.Add(gameObject);
    }

    public void ClearItems()
    {
        foreach (GameObject go in items)
        {
            Destroy(go);
        }
        items.Clear();
    }
}

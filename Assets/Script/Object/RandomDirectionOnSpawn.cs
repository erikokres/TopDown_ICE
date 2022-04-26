using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Movable))]
public class RandomDirectionOnSpawn : MonoBehaviour
{
    private Movable movable;

    private void Awake()
    {
        movable = GetComponent<Movable>();
    }
    void Start()
    {
        movable.setDirection(randomDirection(), randomDirection());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private float randomDirection()
    {
        return Random.Range(-1f, 1);
    }
}

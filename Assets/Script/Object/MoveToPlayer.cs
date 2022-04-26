using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]
public class MoveToPlayer : MonoBehaviour
{

    private Movable movable;

    private void Awake()
    {
        movable = GetComponent<Movable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        movable.setDirection(getDirection());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 getDirection()
    {
        Vector3 dir;
        dir = GameManager.GetInstance().getPlayerPosition() - transform.position;
        dir = dir.normalized;


        return dir;
    }
}

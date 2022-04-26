using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]

public class MoveForward : MonoBehaviour
{
    private Movable movable;

    private void Awake()
    {
        movable = GetComponent<Movable>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        movable.setDirection(transform.up);
    }
}

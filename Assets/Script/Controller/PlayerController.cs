using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]

public class PlayerController : MonoBehaviour
{

    public InputHandler inputHandler;
    private Movable movable;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Awake()
    {
        movable = GetComponent<Movable>();
    }

    private void OnSetDirection(Vector2 direction)
    {
        //Debug.Log("Testing" + direction);
        movable.setDirection(direction);
    }

    private void OnEnable()
    {
        inputHandler.OnMoveAction += OnSetDirection;
    }

    private void OnDisable()
    {
        inputHandler.OnMoveAction -= OnSetDirection;
    }
}

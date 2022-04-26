using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]

public class MovementBorder : MonoBehaviour
{
    public Rect border;

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
        if (isXOutBorder())
        {
            movable.setXdirection(0f);
        }

        if (isYOutBorder())
        {
            movable.setYdirection(0f);
        }
    }

    private bool isXOutBorder()
    {
        return movable.getNextPosition().x < border.xMin || movable.getNextPosition().x > border.xMax;
    }

    private bool isYOutBorder()
    {
        return movable.getNextPosition().y < border.yMin || movable.getNextPosition().y > border.yMax;
    }
}

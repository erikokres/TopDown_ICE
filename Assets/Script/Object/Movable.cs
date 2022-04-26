using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    private Vector3 direction;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updatePosition();
    }

    private void updatePosition()
    {
        transform.position = getNextPosition();
    }

    public Vector3 getNextPosition()
    {
        return transform.position + newPosition();
    }

    public Vector3 newPosition()
    {
        return direction * Time.deltaTime * speed;
    }

    internal void setXdirection(float v)
    {
        direction.x = v;
    }

    internal void setYdirection(float v)
    {
        direction.y = v;
    }

    public void setDirection(Vector3 value)
    {
        direction = value;
    }

    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }

    internal void setDirection(float x, float y)
    {
        direction.x = x;
        direction.y = y;
    }
}

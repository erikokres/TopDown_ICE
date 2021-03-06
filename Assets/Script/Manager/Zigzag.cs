using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zigzag : MonoBehaviour
{

    public float zigspeed;
    public Transform pos1;
    public Transform pos2;
    bool turnback;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= pos1.position.x)
        {
            turnback = true;
        }
        if (transform.position.x <= pos2.position.x)
        {
            turnback = false;
        }
        if (turnback)
        {
            transform.position = Vector2.MoveTowards(transform.position, pos2.position, zigspeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pos1.position, zigspeed * Time.deltaTime);
        }
    }
}

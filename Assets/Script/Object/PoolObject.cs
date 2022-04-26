using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PoolObjectType
{
    BULLET, BOLT, EXPLOTION
}
public class PoolObject : MonoBehaviour
{

    public PoolObjectType type;
    // Start is called before the first frame update
    void Start()
    {
        deactive();
    }

    public void activate(Vector3 position, Quaternion rotation)
    {
        gameObject.SetActive(true);

        transform.position = position;
        transform.rotation = rotation;
    }

    public void deactive()
    {
        gameObject.SetActive(false);
    }

    internal bool isActive()
    {
        return gameObject.activeInHierarchy;
    }
}

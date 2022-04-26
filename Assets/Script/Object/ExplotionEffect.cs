using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showExplotion()
    {
        ObjectPool.GetInstance().requestObject(PoolObjectType.EXPLOTION).activate(transform.position, Quaternion.identity);
    }
}

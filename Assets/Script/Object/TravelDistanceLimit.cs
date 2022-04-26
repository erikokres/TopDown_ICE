using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]

public class TravelDistanceLimit : MonoBehaviour
{

    public float maxTravelDistance;
    [SerializeField] private float travelDistance;
    private Movable movable;
    private PoolObject poolObject;

    private void Awake()
    {
        movable = GetComponent<Movable>();
        poolObject = GetComponent<PoolObject>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (travelDistance >= maxTravelDistance)
        {
            if (poolObject != null)
            {
                poolObject.deactive();

            }
            else
            {
                Destroy(gameObject);
            }
        }

        travelDistance += movable.newPosition().magnitude;
    }

    private void OnEnable()
    {
        travelDistance = 0;
    }
}

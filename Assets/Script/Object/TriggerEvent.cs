using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(CircleCollider2D))]

[System.Serializable]
public class myEvent : UnityEvent<GameObject>
{
}
public class TriggerEvent : MonoBehaviour
{
    public string targetTag;
    public UnityEvent OnTrigger;
    [SerializeField] public myEvent onTiggerWithGameObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == targetTag)
        {
            OnTrigger?.Invoke();
            onTiggerWithGameObject?.Invoke(other.gameObject);
        }
    }
}

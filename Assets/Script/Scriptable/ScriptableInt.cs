using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " New ScriptableInt", menuName = "Scriptable/Integer", order = 0)]
public class ScriptableInt : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool resetOnEnable;

    private void OnEnable()
    {
        if (resetOnEnable)
        {
            Reset();
        }
    }

    internal void Reset()
    {
        value = defaultValue;
    }
}


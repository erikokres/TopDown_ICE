using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Life))]
public class LifeEditor : Editor
{

    private Life life;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        life = (Life)target;

        life.useScriptable = EditorGUILayout.Toggle("Use Scriptabe?", life.useScriptable);

        if (life.useScriptable)
        {
            life.lifeScriptable = (ScriptableInt)EditorGUILayout.ObjectField("Life", life.lifeScriptable, typeof(ScriptableInt), true);
            life.maxLifeScriptable = (ScriptableInt)EditorGUILayout.ObjectField("Max Life", life.maxLifeScriptable, typeof(ScriptableInt), true);
        }
        else
        {
            life.life = EditorGUILayout.IntField("Life", life.life);
            life.maxLife = EditorGUILayout.IntField("Max Life", life.maxLife);
        }
    }
}

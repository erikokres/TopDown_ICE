using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FireRateModivire : MonoBehaviour
{
    public float modivire = 0.2f;

    private List<Weapon> weapons;

    private void Awake()
    {
        weapons = GetComponentsInChildren<Weapon>().ToList<Weapon>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // foreach (Weapon w in weapons)
        // {
        //     w.addFireRateModifier(modivire);
        // }
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        foreach (Weapon w in weapons)
        {
            w.removeFireRateModifier(modivire);
        }
    }

    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<FireRateModivire>();
        go.GetComponent<WeaponSetController>().weaponUpgradeCheck();
    }


}

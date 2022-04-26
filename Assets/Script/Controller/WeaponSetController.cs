using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetController : MonoBehaviour
{

    public GameObject[] weaponSet;
    // Start is called before the first frame update
    void Start()
    {
        deactivateAllWeapon();
        activateWeaponSet(1);

        weaponUpgradeCheck();
    }

    private void deactivateAllWeapon()
    {
        foreach (GameObject go in weaponSet)
        {
            go.SetActive(false);
        }
    }

    public void activateWeaponSet(int updateLevel)
    {
        for (int i = 0; i < weaponSet.Length; i++)
        {
            if (i == updateLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }
    }

    public void weaponUpgradeCheck()
    {
        int updateLevel = GetComponents<WeaponUpgrade>().Length;
        Debug.Log(updateLevel);

        if (updateLevel >= weaponSet.Length)
        {
            updateLevel = weaponSet.Length - 1;
        }

        activateWeaponSet(updateLevel);

        fireRateUpdate();
    }

    private void fireRateUpdate()
    {
        foreach (Weapon w in GetComponentsInChildren<Weapon>())
        {
            w.clearModifier();

            foreach (FireRateModivire f in GetComponents<FireRateModivire>())
            {
                w.addFireRateModifier(f.modivire);
            }
        }
    }
}

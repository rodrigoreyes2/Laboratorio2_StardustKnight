using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour, IWeapon
{
    public void atacar()
    {
        Debug.Log("Has atacado");
    }

    // Start is called before the first frame update
    void Start()
    {
        atacar();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : MonoBehaviour, IPotion
{
    public void curar()
    {
        Debug.Log("Te has curado");
    }

    // Start is called before the first frame update
    void Start()
    {
        curar();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour, IArmor
{
    public void defender()
    {
        Debug.Log("Te has defendido");
    }

    // Start is called before the first frame update
    void Start()
    {
        defender();
    }

}

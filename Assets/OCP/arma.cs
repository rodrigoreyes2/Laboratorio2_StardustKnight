using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    // Clase base Weapon
    public class Weapon
    {
        public virtual void Fire()
        {
            Debug.Log("disparando un arma...");
        }
    }

}

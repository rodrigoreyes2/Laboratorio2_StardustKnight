using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static arma;

public class pistola : MonoBehaviour
{
    public class Gun : Weapon
    {
        public override void Fire()
        {
            base.Fire(); // Llamada al método de la clase base
            Debug.Log("disparando la pistola!");
            // Lógica específica de la pistola
        }

        public void QuickReload()
        {
            Debug.Log("Recarga rapida...");
            // Lógica de recarga específica de la pistola
        }
    }


}








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
            base.Fire(); // Llamada al m�todo de la clase base
            Debug.Log("disparando la pistola!");
            // L�gica espec�fica de la pistola
        }

        public void QuickReload()
        {
            Debug.Log("Recarga rapida...");
            // L�gica de recarga espec�fica de la pistola
        }
    }


}








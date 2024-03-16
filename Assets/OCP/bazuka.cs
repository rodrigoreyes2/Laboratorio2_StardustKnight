using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static arma;

public class bazuka : MonoBehaviour
{
    public class RocketLauncher : Weapon
    {
        public override void Fire()
        {
            base.Fire(); // Llamada al m�todo de la clase base
            Debug.Log("disparando bazuka!");
            // L�gica espec�fica del lanzacohetes
        }

        public void LockTarget()
        {
            Debug.Log("apuntando objetivo...");
            // L�gica de bloqueo de objetivo espec�fica del lanzacohetes
        }
    }
}

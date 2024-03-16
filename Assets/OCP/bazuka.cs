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
            base.Fire(); // Llamada al método de la clase base
            Debug.Log("disparando bazuka!");
            // Lógica específica del lanzacohetes
        }

        public void LockTarget()
        {
            Debug.Log("apuntando objetivo...");
            // Lógica de bloqueo de objetivo específica del lanzacohetes
        }
    }
}

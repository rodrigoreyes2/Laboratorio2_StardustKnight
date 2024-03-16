using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static arma;
using static bazuka;
using static pistola;

public class disparar : MonoBehaviour
{
    public Weapon currentWeapon;

    void Start()
    {
        // Ejemplo de uso con una pistola
        currentWeapon = new Gun();
        currentWeapon.Fire(); // Llama al método Fire de la clase Gun
        ((Gun)currentWeapon).QuickReload(); // Llama al método Reload específico de Gun
        Debug.Log("------------------");

        // Ejemplo de uso con un lanzacohetes
        currentWeapon = new RocketLauncher();
        currentWeapon.Fire(); // Llama al método Fire de la clase RocketLauncher
        ((RocketLauncher)currentWeapon).LockTarget(); // Llama al método LockTarget específico de RocketLauncher
        Debug.Log("------------------");
    }
}


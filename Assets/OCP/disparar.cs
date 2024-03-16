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
        currentWeapon.Fire(); // Llama al m�todo Fire de la clase Gun
        ((Gun)currentWeapon).QuickReload(); // Llama al m�todo Reload espec�fico de Gun
        Debug.Log("------------------");

        // Ejemplo de uso con un lanzacohetes
        currentWeapon = new RocketLauncher();
        currentWeapon.Fire(); // Llama al m�todo Fire de la clase RocketLauncher
        ((RocketLauncher)currentWeapon).LockTarget(); // Llama al m�todo LockTarget espec�fico de RocketLauncher
        Debug.Log("------------------");
    }
}


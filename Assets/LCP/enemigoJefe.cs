using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enemigo;

public class BossEnemy : Enemy
{
    public override void Move()
    {
        base.Move(); // Llamada al m�todo de la clase base
        Debug.Log("Moving as a boss enemy...");
        // L�gica espec�fica del movimiento del jefe enemigo
    }

    public override void Attack()
    {
        base.Attack(); // Llamada al m�todo de la clase base
        Debug.Log("Attacking as a boss enemy...");
        // L�gica espec�fica del ataque del jefe enemigo
    }
}
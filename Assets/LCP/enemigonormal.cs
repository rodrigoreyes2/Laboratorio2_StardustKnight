using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enemigo;

public class NormalEnemy : Enemy
{
    public override void Move()
    {
        base.Move(); // Llamada al m�todo de la clase base
        Debug.Log("Moving as a normal enemy...");
        // L�gica espec�fica del movimiento del enemigo normal
    }

    public override void Attack()
    {
        base.Attack(); // Llamada al m�todo de la clase base
        Debug.Log("Attacking as a normal enemy...");
        // L�gica espec�fica del ataque del enemigo normal
    }
}
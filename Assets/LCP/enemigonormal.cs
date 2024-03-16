using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enemigo;

public class NormalEnemy : Enemy
{
    public override void Move()
    {
        base.Move(); // Llamada al método de la clase base
        Debug.Log("Moving as a normal enemy...");
        // Lógica específica del movimiento del enemigo normal
    }

    public override void Attack()
    {
        base.Attack(); // Llamada al método de la clase base
        Debug.Log("Attacking as a normal enemy...");
        // Lógica específica del ataque del enemigo normal
    }
}
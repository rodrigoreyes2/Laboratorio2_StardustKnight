using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public class Enemy
    {
        public virtual void Move()
        {
            Debug.Log("Moving as a generic enemy...");
        }

        public virtual void Attack()
        {
            Debug.Log("Attacking as a generic enemy...");
        }
    }
}
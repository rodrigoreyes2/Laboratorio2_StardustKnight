using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enemigo;
public class spawner : MonoBehaviour
{

    public class EnemyGenerator : MonoBehaviour
    {
        public Enemy[] enemigo; // Prefabs de enemigos

        public GameObject variablePrefab;
        void Start()
        {
            Instantiate(variablePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }


    }


}


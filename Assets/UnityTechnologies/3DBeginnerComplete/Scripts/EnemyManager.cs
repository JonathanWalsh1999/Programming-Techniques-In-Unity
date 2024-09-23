using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    Enemy1 enemy1;

    EnemyFactory enemyFactory = new EnemyFactory();

    // Start is called before the first frame update
    void Start()
    {
        enemy1 = enemyFactory.CreateEnemy("Enemy");

        if (enemy1 != null)
        {
            enemy1.Attack();
        }
        else
        {
            Debug.Log("Can't run Attack method because enemy1 is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

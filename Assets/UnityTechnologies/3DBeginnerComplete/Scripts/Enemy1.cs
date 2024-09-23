using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy1 : MonoBehaviour
{
    public abstract void Attack();

}

public class BossEnemy : Enemy1
{
    public override void Attack()
    {
        Debug.Log("Boss Enemy attack");
    }
}

public class RegularEnemy : Enemy1
{
    public override void Attack()
    {
        Debug.Log("Regular Enemy attack");
    }
}

public class EnemyFactory
{
    public Enemy1 CreateEnemy(string enemyType)
    {
        if(enemyType == "BossEnemy")
        {
            return new BossEnemy();
        }
        else if (enemyType == "RegularEnemy")
        {
            return new RegularEnemy();
        }
        return null;
    }
}





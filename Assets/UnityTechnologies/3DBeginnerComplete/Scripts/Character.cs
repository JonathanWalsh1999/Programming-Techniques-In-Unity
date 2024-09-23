using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class (Still derives from MonoBehaviour so that it can be used in Unity)
public abstract class Character : MonoBehaviour
{
    [SerializeField]
    public int health;

    [SerializeField]
    private float speed;

    public virtual void Move()
    {
        //Default implementation
        Debug.Log("Default");
    }

}


//Derived Class 1
public class Player : Character
{
    public override void Move()
    {
        //Implementation to override base class
        Debug.Log("Player Move");
    }
}


//Derived Class 2
public class Enemy : Character
{
    public override void Move()
    {
        //Implementation to override base class
        Debug.Log("Enemy move");
    }
}

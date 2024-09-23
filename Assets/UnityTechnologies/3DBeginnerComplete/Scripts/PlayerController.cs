using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 5.0f;

    [SerializeField]
    private HealthSystem m_healthSystemComponent;

    [SerializeField]
    private CharacterStats characterStats;

    private Rigidbody m_rb;
    private Vector3 m_playerForce;


    private void Awake()
    {
        Debug.Log("Awake is called");
        m_rb = GetComponent<Rigidbody>();

    }


    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start is called");

        //StartCoroutine(DisplayMessages());

        Debug.Log(characterStats.attackPower);
        //**Inheritance example**
        // Add the Player component to the GameObject
        Character playerComponent = gameObject.AddComponent<Player>();
        

        // Now playerObject has an instance of the Player class and can use the Move method
        //playerComponent.Move();
        //**
    }
    
    // Update is called once per frame
    private void Update()
    {
        StartCoroutine(DisplayMessages());

        HandleMovement();
  
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        m_healthAmount--;
    //        Debug.Log(m_healthAmount);
    //    }
    //}



    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        m_playerForce = new Vector3(moveX, 0, moveZ);
    }

    private void MovePlayer()
    {
        m_rb.velocity = m_playerForce * m_speed;
    }

    // Handles movement input (runs in Update)
    public void IncreaseSpeed(float increaseSpeedBy)
    {
        m_speed += increaseSpeedBy;
    }

    public void IncreaseSpeed(int increaseSpeedBy)
    {

        m_speed += increaseSpeedBy;
    }

    IEnumerator DisplayMessages()
    {
        Debug.Log("Initial message");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Message after 5 seconds");
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum EGameState { Idle, EndOfGame }

    private EGameState state;

    private static GameManager instance;



    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        state = EGameState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMessage()
    {
        Debug.Log("Event triggered: You have entered the zone");
    }

}

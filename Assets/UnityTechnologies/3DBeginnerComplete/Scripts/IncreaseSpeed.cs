using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    [SerializeField]
    private PlayerController m_PlayerController;

    // Start is called before the first frame update
    void Start()
    {
        m_PlayerController.IncreaseSpeed(2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZoneTrigger : MonoBehaviour
{
    public UnityEvent OnPlayerEnterZone;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnPlayerEnterZone?.Invoke();
        }
    }


}

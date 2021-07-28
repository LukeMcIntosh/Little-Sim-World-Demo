using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProximityEvent : MonoBehaviour
{
    public UnityEvent onTrigger = new UnityEvent();
    public string detectionLayerName;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer(detectionLayerName))
        {
            Debug.Log("Trigger");
            onTrigger.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(detectionLayerName))
        {
            Debug.Log("Trigger");
            onTrigger.Invoke();
        }
    }


}

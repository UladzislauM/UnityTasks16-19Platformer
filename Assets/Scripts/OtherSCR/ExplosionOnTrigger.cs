using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject trigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody)
        {
            trigger.GetComponent<PointEffector2D>().enabled = true;
            Debug.Log("yeee");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody)
        {
            trigger.GetComponent<PointEffector2D>().enabled = false;
            Debug.Log("nooo");
        }
    }
}

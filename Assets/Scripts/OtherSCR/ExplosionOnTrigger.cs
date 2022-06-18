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
            gameObject.GetComponent<PointEffector2D>().Set;
        }
    }
}

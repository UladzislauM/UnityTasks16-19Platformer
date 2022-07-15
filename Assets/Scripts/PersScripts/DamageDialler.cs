using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDialler : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageble"))
        {
            
            if (!collision.GetComponent<Health>().isAlive)
            {
                Destroy(collision.gameObject);
            }
            collision.gameObject.GetComponent<Health>().TakeDemage(damage);
        }

        Destroy(gameObject);
    }

}

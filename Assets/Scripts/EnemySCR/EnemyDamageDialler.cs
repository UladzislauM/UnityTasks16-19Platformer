using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageDialler : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private GameManager gameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageble"))
        {

            if (!collision.GetComponent<Health>().isAlive)
            {
                gameManager.GameOver();
            }
            collision.gameObject.GetComponent<Health>().TakeDemage(damage);
        }

    }

}

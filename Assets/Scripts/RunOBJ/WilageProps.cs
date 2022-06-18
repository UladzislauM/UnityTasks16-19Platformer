using UnityEngine;

public class WilageProps : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}

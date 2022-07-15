using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePoint;


    public void Shoot(float direction)
    {
        GameObject curretBullet = Instantiate(bullet, firePoint.position, Quaternion.identity);
        Rigidbody2D curretBulletVelosity = curretBullet.GetComponent<Rigidbody2D>();

        if (direction >= 0)
        {
            curretBulletVelosity.velocity = new Vector2(fireSpeed * 1, curretBulletVelosity.velocity.y);
        }
        else
        {
            curretBulletVelosity.velocity = new Vector2(fireSpeed * -1, curretBulletVelosity.velocity.y);
        }
    }
}

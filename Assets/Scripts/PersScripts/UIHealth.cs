using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private GameObject healthHeart1;
    [SerializeField] private GameObject health1;
    [SerializeField] private GameObject healthHeart2;
    [SerializeField] private GameObject health2;
    [SerializeField] private GameObject healthHeart3;
    [SerializeField] private GameObject health3;

    private Health health;


    private void Awake()
    {
        health = GetComponent<Health>();
    }

    private void FixedUpdate()
    {
        ChangedHealth(health.curretHealth);
    }

    public void ChangedHealth(float healhtPerCent)
    {
        switch (healhtPerCent)
        {
            case >= 95:
                health1.SetActive(true);
                healthHeart3.SetActive(true);
                health3.SetActive(true);
                healthHeart2.SetActive(true);
                health2.SetActive(true);
                healthHeart1.SetActive(true);
                break;
            case >= 85:
                health1.SetActive(false);
                break;
            case >= 70:
                healthHeart1.SetActive(false);
                health1.SetActive(false);
                break;
            case >= 50:
                health2.SetActive(false);
                healthHeart1.SetActive(false);
                health1.SetActive(false);
                break;
            case >= 40:
                healthHeart2.SetActive(false);
                health2.SetActive(false);
                healthHeart1.SetActive(false);
                health1.SetActive(false);
                break;
            case >= 25:
                health3.SetActive(false);
                healthHeart2.SetActive(false);
                health2.SetActive(false);
                healthHeart1.SetActive(false);
                health1.SetActive(false);
                break;
            case >= 0:
                healthHeart3.SetActive(false);
                health3.SetActive(false);
                healthHeart2.SetActive(false);
                health2.SetActive(false);
                healthHeart1.SetActive(false);
                health1.SetActive(false);
                break;

        }
    }
}

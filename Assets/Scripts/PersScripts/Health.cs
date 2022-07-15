using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float _curretHealth;
    private bool _isAlive;

    public float curretHealth { get { return _curretHealth; } set { _curretHealth = value; } }
    public bool isAlive { get { return this._isAlive; } set { this._isAlive = value; } }

    private void Awake()
    {
        _curretHealth = maxHealth;
        _isAlive = true;
    }

    public void TakeDemage (float damage)
    {
        _curretHealth -= damage;
        CheckIsAlive();
    }


    private void CheckIsAlive()
    {
        if (_curretHealth > 0)
        {
            _isAlive = true;
        }
        else
        {
            _isAlive = false;
        }
    }

    public void Reset()
    {
        _curretHealth = maxHealth;
        _isAlive = true;
    }
}

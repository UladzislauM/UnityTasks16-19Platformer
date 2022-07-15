using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _dieScrieen;
    [SerializeField] private GameObject pers;

    public void GameOver()
    {
        _dieScrieen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reset()
    {
        _dieScrieen.SetActive(false);
        Time.timeScale = 1;
        pers.GetComponent<Health>().Reset();

    }
}

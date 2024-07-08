using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Start()
    {
        PlayerController.OnGameOver += GameOver;
    }

    public void GameOver()
    {
        print("Player Die and GameOver");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 델리게이트 선언
    public delegate void PlayerFunction();
    // 이벤트 선언
    public static event PlayerFunction OnGameOver;

    void Start()
    {
        OnGameOver();
    }
}

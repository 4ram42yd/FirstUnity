using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 90;
    void Start()
    {
        hp = hp - 100;
        if (hp < 0)
        {
            print("게임 오버!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 100;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;
            if (hp <= 0)
            {
                print("게임 오버!");
            }
            else if(hp <= 40)
            {
                print("현재 체력은 : " + hp + " 입니다.");
                print("비상!!!");
            }
            else if( hp <= 60)
            {
                print("현재 체력은 : " + hp + " 입니다.");
                print("조심하세요!!");
            }
            else
            {
                print("현재 체력은 : " + hp + " 입니다.");
            }
        }    
    }
}

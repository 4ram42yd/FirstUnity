using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int thisYear;
    float pi;
    // Start is called before the first frame update
    void Start()
    {
        thisYear = 2024;
        print("이번 연도는 : " + thisYear + " 입니다.");

        pi = 3.14f;
        print("파이 값은 " + pi + " 입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

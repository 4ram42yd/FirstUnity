using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelegageExample : MonoBehaviour
{

    // 델리게이트 정의
    public delegate void Notify(string message);

    // 이벤트를 위한 델리게이트 인스턴스
    public Notify OnNotify;

    void Start()
    {
        // 여러 메서드를 델리게이트에 할당
        OnNotify += DisplayMessage;
        OnNotify += AnotherMessage;

        OnNotify -= AnotherMessage;
        // 델리게이트 호출
        if (OnNotify != null)
        {
            OnNotify("Game Started!");
        }
    }

    void DisplayMessage(string message)
    {
        Debug.Log("DisplayMessage: " + message);
    }

    void AnotherMessage(string message)
    {
        Debug.Log("AnotherMessage: " + message);
    }

}

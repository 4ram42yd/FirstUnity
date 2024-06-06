using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelegageExample : MonoBehaviour
{

    public Button myButton;

    void Start()
    {
        // 버튼의 클릭 이벤트에 델리게이트 할당
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("Button Clicked!");
    }
}

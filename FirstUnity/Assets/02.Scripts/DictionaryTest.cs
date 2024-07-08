using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    // 아이템을 관리할 Dictionary
    private Dictionary<string, int> items = new Dictionary<string, int>();

    void Start()
    {
        // 아이템 추가
        AddItem("Potion", 5);
        AddItem("Elixir", 2);

        // 아이템 사용
        UseItem("Potion");

        // 아이템 목록 출력
        PrintInventory();
    }

    void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += quantity;
        }
        else
        {
            items.Add(itemName, quantity);
        }
        Debug.Log("Added " + quantity + " " + itemName + "(s) to inventory.");
    }

    void UseItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]--;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
            Debug.Log("Used one " + itemName + ".");
        }
        else
        {
            Debug.Log("Item " + itemName + " not found in inventory.");
        }
    }

    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("Item: " + item.Key + ", Quantity: " + item.Value);
        }
    }
}

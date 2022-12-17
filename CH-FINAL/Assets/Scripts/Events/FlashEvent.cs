using UnityEngine;
using System;

public class FlashEvent : MonoBehaviour
{
    public static event Action Flashing;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Flashing?.Invoke();
            Debug.Log("Flashbang!");
        }
    }
}

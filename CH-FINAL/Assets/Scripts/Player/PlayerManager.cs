using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP;
    public static bool dead;

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(dead)
        {
            Debug.Log("La Quedutti!");
        }
    }

    public void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        if(playerHP <= 0)
        {
            dead = true;
        }
    }
}

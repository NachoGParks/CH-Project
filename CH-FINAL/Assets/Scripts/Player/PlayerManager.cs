using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP = 100;
    public static bool dead;
    public GameObject Player;

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
            Destroy(Player);
        }
    }

    public static void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        Debug.Log("Player HP= " + playerHP);

        if(playerHP <= 0)
        {
            dead = true;
            Debug.Log("La Quedutti!");
        }
    }
}

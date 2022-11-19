using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static float playerHP = 100f;
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

    public static void TakeDamage(float damageAmount)
    {
        playerHP -= damageAmount;
        Debug.Log("Player HP= " + playerHP);

        if(playerHP <= 0f)
        {
            dead = true;
            Debug.Log("La Quedutti!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour

{   //VARIABLES

    //Stats
    public GameObject player;
    public float playerHP = 100f;
    public bool playerDead = false;

    //Ataque
    public float playerDamage = 30f;

    //Defensa
    public EnemyManager enemyManager; 


    public void playerDies()
    {
        if(playerHP <= 0f)
        {
            playerDead = true;
            Debug.Log("La Quedutti!");
        }
    }





    void Start()
    {
        playerDead = false;        
    }

    void Update()
    {        
        if(playerDead)
        {            
            Destroy(player);
        }
    }
}

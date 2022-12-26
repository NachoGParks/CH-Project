using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour

{   //VARIABLES

    //Stats
    public GameObject player;
    public float playerHP = 100f;
    public bool playerDead = false;
    public int TagsFound;

    //Ataque
    public float playerDamage = 30f;

    //Defensa
    public EnemyManager enemyManager; 


    public void playerDies()
    {
        if(playerHP <= 0f)
        {
            playerDead = true;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }





    void Start()
    {
        playerDead = false;        
    }

    void Update()
    {        
        playerDies();
        if (TagsFound == 6)
        {
            SceneManager.LoadScene("Victory", LoadSceneMode.Single);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List1 : MonoBehaviour
{
    Queue listaDeItems = new Queue();

    // Start is called before the first frame update
    void Start()
    {
        listaDeItems.Enqueue("Pistol");
        listaDeItems.Enqueue("Shotgun");
        listaDeItems.Enqueue("Rifle");
        listaDeItems.Enqueue("Medkit");
        listaDeItems.Enqueue("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            Debug.Log("Cantidad de Items:" + listaDeItems.Count);
        }
    }
}

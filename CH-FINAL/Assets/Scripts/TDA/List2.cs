using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List2 : MonoBehaviour
{
    public List<string> lista = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            lista.Add("Coin");
            Debug.Log("$" + lista.Count);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            lista.RemoveAt(3);
        }
    }
}

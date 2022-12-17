using UnityEngine;

public class EnemyName : MonoBehaviour
{
    public string nombre = "Norman";
    

    // Start is called before the first frame update
    void Start()
    {
        EnemyID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void EnemyID()
    {
        Debug.Log(nombre);
    }
}

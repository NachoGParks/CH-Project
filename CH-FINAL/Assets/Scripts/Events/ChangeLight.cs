using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    public Light lt;
    float timeToShoot = 3f;
	float timeToShootLeft;

    void Start()
    {
        lt = GetComponent<Light>();
        FlashEvent.Flashing += CambiarLight;                 
    }

    void Update()
    {

    }

    void CambiarLight()
    {
        ResetTimer();
        lt.intensity = 6;
        Debug.Log("Mas intensidad");

        //quiero que tras un tiempo vuelva al valor inicial, pero cuando invoco el evento, me saltea el temporizador
        //le sube la intensidad y la devuelve al mismo tiempo:

        Temporizador();
        lt.intensity = 3;
        Debug.Log("Menos intensidad");
    }
    void Temporizador()
	{        
        timeToShootLeft -= Time.deltaTime;        
        ResetTimer();
    }	

    void ResetTimer()
	{
		timeToShootLeft = timeToShoot;
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("MenuTest", LoadSceneMode.Single);
    }
}

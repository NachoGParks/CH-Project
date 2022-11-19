using UnityEngine;
using UnityEngine.UI;
public class InGameHUD : MonoBehaviour
{
    #region public variables
    public Text KillCount;
    [SerializeField]
    public static int dead_Zombies = 0;

    [Header("HealthBar")]
    public Image healthBar;
    public float playerHP;
    public float MaxHP = 100f;

    #endregion


    void Update()
    {
        KillCount.text = "ENEMIES KILLED = " + dead_Zombies.ToString();;
        playerHP = PlayerManager.playerHP;

        healthBar.fillAmount = playerHP / MaxHP;
    }


}

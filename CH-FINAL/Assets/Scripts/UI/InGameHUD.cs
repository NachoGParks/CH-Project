using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InGameHUD : MonoBehaviour
{
    #region public variables
    public Text KillCount;
    public Text FoundTags;
    [SerializeField]
    public static int dead_Zombies = 0;

    [Header("HealthBar")]
    public Image healthBar;
    public float HUDplayerHP;
    public float MaxHP = 100f;

    #endregion
    public PlayerManager playerManager;

    void Update()
    {
        KillCount.text = "ENEMIES KILLED = " + dead_Zombies.ToString();;
        HUDplayerHP = playerManager.playerHP;

        healthBar.fillAmount = HUDplayerHP / MaxHP;

        FoundTags.text = "FOUND TAGS = " + playerManager.TagsFound.ToString() + " of 6"; ;

        
    }


}

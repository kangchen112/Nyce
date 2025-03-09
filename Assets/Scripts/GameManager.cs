using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerStats playerStats;

    private void Start()
    {
        if (playerStats == null)
        {
            Debug.LogError("PlayerStats reference is missing!");
            return;
        }

        playerStats.TakeDamage(10);
        playerStats.AddScore(100);
    }
}

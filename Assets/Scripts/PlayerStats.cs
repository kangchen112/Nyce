using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int health = 100;
    private int score = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    public int GetHealth()
    {
        return health;
    }
}

using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    public string player;
    public int health;

    public abstract void Attack(); // Abstract method must be implemented by child classes

    public void Move()
    {
        Debug.Log(player + " is moving.");
    }
}

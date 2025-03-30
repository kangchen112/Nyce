using UnityEngine;

public class PlayerCharacter : BaseCharacter
{
    public override void Attack()
    {
        Debug.Log(Player + " attacks with a sword!");
    }
}

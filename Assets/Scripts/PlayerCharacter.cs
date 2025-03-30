using UnityEngine;

public class PlayerCharacter : BaseCharacter
{
    public override void Attack()
    {
        Debug.Log(player + " attacks with a sword!");
    }
}

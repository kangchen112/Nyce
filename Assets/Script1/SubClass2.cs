using UnityEngine;
public class SubClass2 : BaseClass
{
    public override void ShowMessage()
    {
        base.ShowMessage();
        Debug.Log("SubClass2: This method overrides but also calls base.");
    }
}

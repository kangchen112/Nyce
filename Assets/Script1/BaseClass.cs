using UnityEngine;

public class BaseClass : MonoBehaviour
{
    public virtual void ShowMessage()
    {
        Debug.Log("BaseClass: This is the base class message.");
    }
}

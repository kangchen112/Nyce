using UnityEngine;

public class InterfaceImplementor1 : MonoBehaviour, IMyInterface
{
    public void DoSomething()
    {
        Debug.Log("InterfaceImplementor1: Doing something...");
    }
}

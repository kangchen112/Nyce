using UnityEngine;

public class InterfaceImplementor2 : MonoBehaviour, IMyInterface
{
    public void DoSomething()
    {
        Debug.Log("InterfaceImplementor2: Doing something differently...");
    }
}

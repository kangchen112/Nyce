using UnityEngine;

public class PolymorphismManager : MonoBehaviour
{
    void Start()
    {
        BaseClass baseObj = new BaseClass();
        BaseClass sub1 = new SubClass1();
        BaseClass sub2 = new SubClass2();

        baseObj.ShowMessage();
        sub1.ShowMessage();
        sub2.ShowMessage();

        IMyInterface obj1 = new InterfaceImplementor1();
        IMyInterface obj2 = new InterfaceImplementor2();

        obj1.DoSomething();
        obj2.DoSomething();
    }
}

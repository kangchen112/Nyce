using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        GameObject[] Targets = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject Target in Targets)
        {
            Target.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
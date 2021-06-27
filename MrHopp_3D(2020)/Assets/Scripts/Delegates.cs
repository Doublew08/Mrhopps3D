using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void Example();
    public static Example example;
    // Start is called before the first frame update
    void Start()
    {
        example += myFunction;
        example += myOtherFunction;
    }

    // Update is called once per frame
    void Update()
    {
        example?.Invoke();
    }
    
    void myFunction()
    {
        //Debug.Log("This is annoying");
    }
    void myOtherFunction()
    {
        //Debug.Log("More Annoying");
    }
}

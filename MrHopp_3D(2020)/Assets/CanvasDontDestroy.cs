using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDontDestroy : MonoBehaviour
{
    public static CanvasDontDestroy instance;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    void Awake()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

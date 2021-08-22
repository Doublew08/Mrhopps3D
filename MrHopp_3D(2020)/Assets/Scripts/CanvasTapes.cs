using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTapes : MonoBehaviour
{
    public static CanvasTapes instance;
    public Text TextTapes;
    public int TapesCollected;
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
        TextTapes.text = TapesCollected.ToString() + "/6";
    }
}

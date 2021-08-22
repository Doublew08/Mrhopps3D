using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTapes : MonoBehaviour
{
    public static CanvasTapes instance;
    public Text TextTapes;
    public static int TapesCollected = 0;
    public Text Task;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EndTask");
        TapesCollected++;
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
        TextTapes.text = (TapesCollected-1).ToString() + "/6";
    }
    IEnumerator EndTask()
    {
        yield return new WaitForSeconds(4);
        Destroy(Task);
        yield break;
    }
}

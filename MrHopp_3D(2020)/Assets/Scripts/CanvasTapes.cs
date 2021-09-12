using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTapes : MonoBehaviour
{
    public static CanvasTapes instance;
    public Text TextTapes;
    public static int TapesCollected;
    public int TapesCollectedInspector = 0;
    public Text Task;
   public GameManager gameManager;
    public GameObject KeyTask;
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
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (TextTapes)
        {
            TextTapes.text = (gameManager.destroyCassetteNumber).ToString() + "/6";
        }
            TapesCollected = TapesCollectedInspector;
        if(gameManager.destroyCassetteNumber == 6)
        {
            StartCoroutine("KeyTaskF");
        }
    }
    IEnumerator EndTask()
    {
        yield return new WaitForSeconds(4);
        Destroy(Task);
        yield break;
    }
    IEnumerator KeyTaskF()
    {
        Destroy(TextTapes);
        Instantiate(KeyTask,GameObject.FindGameObjectWithTag("CanvasTapes").transform);
        yield return new WaitForSeconds(3);
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        Destroy(gameObject);
        yield break;

    }
}

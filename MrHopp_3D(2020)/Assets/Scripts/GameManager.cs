using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool ToBeDestroyedDrawing;
    public int TextToBeCleared;
    public int ScreenToBeCleared;
    public GameObject Warningscreen;
    public int EnterP1st = 0;
    public GameObject help;
    public GameObject Task;
    GameObject helpsign;
    GameObject TaskSign;
    public bool startco = true;
    public bool startco2 = true;
    public bool canend1;
    public bool destroy_eyes;
    //Collision ToyCol;
    public Scene PrevScene;
    public int PrevSceneint;
    public int currentSceneint;
    public Scene currentScene;

    private void Start()
    {
        /*OnMessageReceived test = WriteMessage;
        test();*/



    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneLoaded += OnSceneLoaded1;
        SceneManager.sceneLoaded += OnSceneLoadedToy;

    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded1;
        SceneManager.sceneLoaded -= OnSceneLoadedToy;

        SceneManager.sceneLoaded -= OnSceneLoaded;

    }
    void OnSceneLoaded1(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {

            TextToBeCleared++;
        }
        /*if(scene.buildIndex == 1 && EnterP1st == 2)
        {

            bedending bed = GameObject.FindGameObjectWithTag("Bed").GetComponent<bedending>();
            bed.bedendcan = true;
        }*/


    }
    void OnSceneLoadedToy(Scene scene, LoadSceneMode mode)
    {



    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 9)
        {
            EnterP1st++;
            ToBeDestroyedDrawing = true;
            Debug.Log("Destroyed Object");
            Destroy(GameObject.FindGameObjectWithTag("Drawing"));
            
        }
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
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneint = currentScene.buildIndex;
        if(currentSceneint == 2 && PrevSceneint == 1)
        {
            GameObject PlayerC = GameObject.FindGameObjectWithTag("PlayerCollector");
           // GameObject player = PlayerC.FindChild("Player1");
            
        }
        //  Warningscreen = Toyfirstscreen.instance.screenwarn;
       if(EnterP1st == 1)
        {
            destroy_eyes = true;
            func();
            EnterP1st ++;
        }
        if (!startco)
        {
            StartCoroutine(myco());
        }
        else
        {
            StopCoroutine(myco());
        }
        if (!startco2)
        {
            StartCoroutine(myco2());
        }
        else
        {
            StopCoroutine(myco2());
        }


    }
    private void FixedUpdate()
    {
        //LOL IT DO BE FEEL WEIRD SOMETIMES

    }
    void func()
    {
      helpsign = (GameObject)Instantiate(help, GameObject.FindGameObjectWithTag("Canvas").transform);
      TaskSign = (GameObject)Instantiate(Task, GameObject.FindGameObjectWithTag("Canvas").transform);
        TaskSign.SetActive(false);
        startco = false;
    }
    IEnumerator myco()
    {
        PlayerMovement player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        player.canmove = false;
        yield return new WaitForSeconds(4);
        helpsign.SetActive(false);
        player.canmove = true;
        startco = true;
        startco2 = false;

    }
    IEnumerator myco2()
    {
        TaskSign.SetActive(true);
        yield return new WaitForSeconds(4);
        TaskSign.SetActive(false);
        canend1 = true; 
        startco2 = true;
    }
}
    

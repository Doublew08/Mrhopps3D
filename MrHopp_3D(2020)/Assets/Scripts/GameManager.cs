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
    string PlayerController;
    public bool RabbitExists;
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

        if (GameObject.FindGameObjectWithTag("Rabbit"))
        {
            GameObject rab = GameObject.FindGameObjectWithTag("Rabbit");
            if (RabbitExists)
            {

                rab.SetActive(true);

            }
            else
            {
                rab.SetActive(false);
            }
        }
       
      

        //  Warningscreen = Toyfirstscreen.instance.screenwarn;
        if (EnterP1st == 1)
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
        if (GameObject.Find(PlayerController) != null)
        {

        }
        
        AdjustPlayerSpawn(2, 1, "PlayerCollector", 0);
        AdjustPlayerSpawn(2, 8, "PlayerCollector", 1);
        AdjustPlayerSpawn(2, 2, "PlayerCollector", 2);
        AdjustPlayerSpawn(2, 3, "PlayerCollector", 2);
        AdjustPlayerSpawn(3, 2, "PlayerCollector2", 0);
        AdjustPlayerSpawn(3, 9, "PlayerCollector2", 1);
        AdjustPlayerSpawn(3, 3, "PlayerCollector2", 2);
        AdjustPlayerSpawn(4, 3, "PlayerCollector3", 0);
        AdjustPlayerSpawn(4, 4, "PlayerCollector3", 1);
        AdjustPlayerSpawn(5, 4, "PlayerCollector4", 0);
        AdjustPlayerSpawn(5, 5, "PlayerCollector4", 1);
        AdjustPlayerSpawn(6, 5, "PlayerCollector5", 0);
        AdjustPlayerSpawn(6, 7, "PlayerCollector5", 1);




    }
    public void AdjustPlayerSpawn(int currentSint,int PrevSint,string PlayerController,int activator)
    {
        if (currentSceneint == currentSint && PrevSceneint == PrevSint)
        {
            PlayerActivator playerActivator = GameObject.Find(PlayerController).GetComponent<PlayerActivator>();
            playerActivator.Activate[activator] = true;

        }
        else
        {
            if (GameObject.Find(PlayerController) != null)
            {
                PlayerActivator playerActivator = GameObject.Find(PlayerController).GetComponent<PlayerActivator>();
                playerActivator.Activate[activator] = false;
            }
        }
    }
    private void FixedUpdate()
    {
        /*
        Bool ActivateP1;
        Bool ActivateP2;
        Bool ActivateP2;
         void callbool(Int ActivatePnum){
         Activate{ActivatePnum} = true 
        }
        */
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
        if (helpsign)
        {
            helpsign.SetActive(false);
        }
        player.canmove = true;
        startco = true;
        startco2 = false;

    }
    IEnumerator myco2()
    {
        if (TaskSign)
        {
            TaskSign.SetActive(true);
        }
        yield return new WaitForSeconds(4);
        if (TaskSign)
        {
            TaskSign.SetActive(false);
        }
        canend1 = true;
        RabbitExists = true;
        startco2 = true;
    }
}
    

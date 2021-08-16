using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayExitingScene : MonoBehaviour
{
    public GameObject Image;
    public GameObject Mumsign;
    public GameObject Mumtext;
    public GameObject MumtaskSign;
    public GameObject Mumtasktext;
    float beg_door;
    float End_door;
    public bool OpenLocker;
    public bool MumScene2 = true;

    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.x - (transform.localScale.x / 2);
        End_door = transform.position.x + (transform.localScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        if (!MumScene2)
        {
            StartCoroutine("MomScene2");
        }
        else
        {
            StopCoroutine("MomScene2");
        }
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            if (beg_door < Player.position.x && Player.position.x < End_door)
            {
                Image.SetActive(true);
                if (gameManager.MomScene == false && Input.GetKeyDown(KeyCode.E))
                {
                    if (!gameManager.MomScene)
                    {
                        StartCoroutine("MomScene");
                    }
                    else
                    {
                        StopCoroutine("MomScene");
                    }
                    



                    OpenLocker = true;
                }
            }
            else
            {
                Image.SetActive(false);
            }
        }
    }
    IEnumerator MomScene()
    {
        instager();
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        //do click sound
        //do cry sound
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        if (Player)
        {
            Player.GetComponent<PlayerMovement>().canmove = false;
        }
        yield return new WaitForSeconds(2.5f);
        gameManager.MomScene = true;
        Mumsign.SetActive(false);
        MumScene2 = false;
        


    }
    IEnumerator MomScene2()
    {
        MumtaskSign.SetActive(true);
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        if (Player)
        {
            Player.GetComponent<PlayerMovement>().canmove = true;
        }
        yield return new WaitForSeconds(4f);
        MumtaskSign.SetActive(false);
        MumScene2 = true;
    }
    void DO(bool doing, string enumerator)
    {
        if (!doing)
        {
            StartCoroutine(enumerator);
        }
        else
        {
            StopCoroutine(enumerator);
        }
    }
    void instager()
    {
        Mumsign = (GameObject)Instantiate(Mumtext, GameObject.FindGameObjectWithTag("Canvas").transform);
        MumtaskSign = (GameObject)Instantiate(Mumtasktext, GameObject.FindGameObjectWithTag("Canvas").transform);
        MumtaskSign.SetActive(false);
        
    }
}
/*void func()
    {
      helpsign = (GameObject)Instantiate(help, GameObject.FindGameObjectWithTag("Canvas").transform);
      TaskSign = (GameObject)Instantiate(Task, GameObject.FindGameObjectWithTag("Canvas").transform);
        TaskSign.SetActive(false);
        startco = false;
    }*/

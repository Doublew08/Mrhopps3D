using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MayExitToKitcher : MonoBehaviour
{
    public GameObject Image;
    public int Room_num;
    float beg_door;
    float End_door;

    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.x - (transform.localScale.x / 2);
        End_door = transform.position.x + (transform.localScale.x / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Transform Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            OpenLocker openLocker = GameObject.Find("tv_table_2 (1)").GetComponent<OpenLocker>();
            if (beg_door < Player.position.x && Player.position.x < End_door)
            {
                Image.SetActive(true);
                if (Input.GetKey(KeyCode.E)&&gameManager.HaveKey)
                {
                    Destroy(GameObject.Find("Canvas(Key)(Clone)"));
                    gameManager.PrevScene = SceneManager.GetActiveScene();
                    gameManager.PrevSceneint = gameManager.PrevScene.buildIndex;
                    SceneManager.LoadSceneAsync(Room_num);
                }
            }
            else
            {
                Image.SetActive(false);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MayExitforRoom2 : MonoBehaviour
{
    public GameObject Image;
    public int Room_num;
    float beg_door;
    float End_door;
    // Start is called before the first frame update
    void Start()
    {
        beg_door = transform.position.z - (transform.localScale.z / 2);
        End_door = transform.position.z + (transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");

        if (GameObject.FindGameObjectWithTag("Player"))
        {

            if (beg_door < Player.transform.position.z)
            {
                if (Player.transform.position.z < End_door)
                {
                    Image.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                        gameManager.PrevScene = SceneManager.GetActiveScene();
                        gameManager.PrevSceneint = gameManager.PrevScene.buildIndex;
                        SceneManager.LoadSceneAsync(Room_num);
                    }
                }
            }

            else
            {
                Image.SetActive(false);
            }
        }
    }
}
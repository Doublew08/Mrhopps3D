using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneInRoom : MonoBehaviour
{
    PlayerMovement Player;

    public GameObject Panel;
    private int Cs;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();


    }

    // Update is called once per frame
    void Update()
    {
        //define the ray
        RaycastHit Ray;
        //make if the ray hit the (Something)
        if (Physics.Raycast(transform.position, -transform.up, out Ray, Mathf.Infinity))
        {
            //make sure if the ray hit the player
            if (Ray.collider.tag == "Player")
            {
                //Start the coroutine 
                Debug.Log("I catch you");
                //The photo of the Rabbit Will Appear
                Panel.SetActive(true);
                StartCoroutine(RabbitCatchThePlayer());

            }

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, -transform.up * 1000);
    }
    //The scene will load again if (ROOM)
    IEnumerator RabbitCatchThePlayer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);


    }

}

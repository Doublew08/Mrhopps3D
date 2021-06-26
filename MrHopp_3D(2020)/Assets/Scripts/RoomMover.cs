using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomMover : MonoBehaviour
{
    public int Room2bemoved2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameManager.PrevScene = SceneManager.GetActiveScene();
        gameManager.PrevSceneint = gameManager.PrevScene.buildIndex;
        SceneManager.LoadSceneAsync(Room2bemoved2);
    }

}

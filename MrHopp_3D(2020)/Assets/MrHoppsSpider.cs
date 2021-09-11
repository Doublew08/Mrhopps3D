using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MrHoppsSpider : MonoBehaviour
{
    public GameObject Player;
    NavMeshAgent agent;
    public GameManager gameManager;
   public  Vector3 oldpos;
    // Start is called before the first frame update
    void Start()
    {
        oldpos = this.transform.position;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        agent = GetComponent<NavMeshAgent>();
        if (gameManager.destroyCassetteNumber != 5 || !gameManager.lastime)
        {
            
                gameObject.SetActive(false);
            
        }
        if(gameManager.destroyCassetteNumber == 5 && gameManager.lastime)
        {
            gameManager.lastime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position);
        /*if(transform.position != oldpos)
        {
            gameManager.lastime = false;
        }*/
    }
}

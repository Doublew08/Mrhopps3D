using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MrHoppsSpider : MonoBehaviour
{
    public GameObject Player;
    NavMeshAgent agent;
    private Animator Rabbit;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Rabbit = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position);
        

    }
}

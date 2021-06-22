using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRabbitMove : MonoBehaviour
{
    //Private Values
    private Animator RabbitAnimator;
    private PlayerMovement Player;
    private RabbitPlace1 place1;
    private NavMeshAgent nav;
    

    //public values
    public float StopDistance = 3f;
    public bool IsMove = false;
    public float speed;
    public float lookRadius = 10f;
   

    private void Awake()
    {
        Player = FindObjectOfType<PlayerMovement>();
        nav = GetComponent<NavMeshAgent>();
        RabbitAnimator = GetComponent<Animator>();
        place1 = FindObjectOfType<RabbitPlace1>();
    }
     IEnumerator Start()
     {
        yield return new WaitForSeconds(1);
        IsMove = true;   
     }
    private void Update()
    {
        if (!IsMove)
            return;
        Move();
    }
    public void Move()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) <= lookRadius)
        {           
            nav.SetDestination(place1.transform.position);
            RabbitAnimator.SetFloat("Walk", 0.2f);
            lookRadius = 150f;

        }
        else 
        {
            nav.SetDestination(transform.position);
            RabbitAnimator.SetFloat("Walk", 0.0f);
            lookRadius = 121f;
        }

        if (Vector3.Distance(transform.position, place1.transform.position) <= StopDistance)
        {
            nav.SetDestination(transform.position);
            RabbitAnimator.SetFloat("Walk", 0.0f);

        }


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}

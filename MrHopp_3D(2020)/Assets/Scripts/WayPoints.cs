using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    //Private Variables
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f; 
    private int lastWaypointIndex;
    private Animator RabbitAnimator;
    private float rotationSpeed = 2.0f;
    
    
    



    //Public Variables
    public List<Transform> waypoints = new List<Transform>();
    public  float movementSpeed = 15.0f;
    public float LookR=121;
    public bool CanMove =false;

    void Start()
    {
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoint = waypoints[targetWaypointIndex];
        RabbitAnimator = GetComponent<Animator>();
       
       
    }


    void Update()
    {


        /*if (CanMove==true)
       // {*/
            float movementStep = movementSpeed * Time.deltaTime;
            float rotationStep = rotationSpeed * Time.deltaTime;

            Vector3 directionToTarget = targetWaypoint.position - transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);

            Debug.DrawRay(transform.position, transform.forward * 50f, Color.green, 0f);
            Debug.DrawRay(transform.position, directionToTarget, Color.red, 0f);

            float distance = Vector3.Distance(transform.position, targetWaypoint.position);
            CheckDistanceToWaypoint(distance);

            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
            RabbitAnimator.SetFloat("Walk", 0.2f);
        //}                          
    }


   
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            targetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }

    

    void UpdateTargetWaypoint()
    {
        if (targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;
        }

        targetWaypoint = waypoints[targetWaypointIndex];
    }

}

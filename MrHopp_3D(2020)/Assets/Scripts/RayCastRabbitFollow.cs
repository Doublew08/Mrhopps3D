using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastRabbitFollow : MonoBehaviour
{
    private WayPoints way;
    // Start is called before the first frame update
    void Start()
    {
        way = FindObjectOfType<WayPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit ray;
        if (Physics.Raycast(transform.position, -transform.up, out ray, Mathf.Infinity))
        {
            if (ray.collider.tag == "Player")
            {
                Debug.Log("Shit");
                way.movementSpeed = 30f;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -transform.up * 1000);
    }
    IEnumerator DecreseTheSpeed()
    {
        yield return new WaitForSeconds(5);
        way.movementSpeed = 20f;
    }
}

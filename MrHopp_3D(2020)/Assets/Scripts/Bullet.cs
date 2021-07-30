using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody Clone;
    public Rigidbody BulletPrefab;
    private float NextBullet;
    public float FireRate;
    public Transform SpawnPoint;
    public float BulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > NextBullet)
            {
                NextBullet = Time.time + FireRate;
                Clone = Instantiate(BulletPrefab, transform.position, transform.rotation);
                Clone.velocity = transform.TransformDirection(-Vector3.up * BulletSpeed);
                Destroy(Clone.gameObject, 3);
            }
            Debug.Log("Shooting");
            
            
        }
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     GameObject bullet;
    public GameObject BulletPrefab;
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
                NextBullet = FireRate + Time.time;

                bullet = Instantiate(BulletPrefab, SpawnPoint.position, Quaternion.identity);
                bullet.gameObject.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
            }
            Debug.Log("Shooting");
            StartCoroutine(destroy());
            
        }
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(3);
        Destroy(bullet);
    }
}

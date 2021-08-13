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
    public int Ammo;
    private int MaxAmmo = 20;
    public bool IsFiring;
    public Animator PlayerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        Ammo = MaxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Ammo > 0 && !IsFiring)
        {
            if (Time.time > NextBullet)
            {
                PlayerAnimator.SetBool("Shoot", true);
                Debug.Log("Shooting");
                NextBullet = Time.time + FireRate;
                Clone = Instantiate(BulletPrefab, transform.position, transform.rotation);
                Clone.velocity = transform.TransformDirection(-Vector3.up * BulletSpeed);
                Destroy(Clone.gameObject, 3);
                IsFiring = true;
                Ammo--;
                IsFiring = false;
                if (Ammo == 0)
                {
                    Debug.Log("You Cant Shoot Now ");
                }
            }

        }
        else
        {
            PlayerAnimator.SetBool("Shoot", false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            StartCoroutine(Reload());
        }
        
    }
    IEnumerator Reload()
    {
        PlayerAnimator.SetBool("Reload", true);
        yield return new WaitForSeconds(4);
        PlayerAnimator.SetBool("Reload", false);
        Ammo = MaxAmmo;
    }
}

   


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //private 
    private int MaxAmmo = 10;
    private float NextBullet;
    Rigidbody Clone;
    private AudioSource Audio;
    private WraponReload reload;

    //public
    public Rigidbody BulletPrefab;
    public Transform SpawnPoint;
    public float BulletSpeed;
    public int Ammo;
    public bool IsFiring;
    public Animator PlayerAnimator;
    public float FireRate;
    public ParticleSystem muzzleflash;


    // Start is called before the first frame update
    void Start()
    {
        Ammo = MaxAmmo;
        Audio = GetComponent<AudioSource>();
        reload = FindObjectOfType<WraponReload>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if the user press the button of fire1 (AND) the ammo is more than 0 (AND) IsFiring=false 
        if (Input.GetButton("Fire1") && Ammo > 0 && !IsFiring)
        {
            //this if statement to make player shoot single single
            if (Time.time > NextBullet)
            {
                //Run the audio 
                Audio.Play();
                //Run the Animtion of shoot
                PlayerAnimator.SetBool("Shoot", true);
                Debug.Log("Shooting");
                NextBullet = Time.time + FireRate;
                //MAke clone of the Bullet Prefab
                Clone = Instantiate(BulletPrefab, transform.position, transform.rotation);
                //Put the direction for the bullet and speed
                Clone.velocity = transform.TransformDirection(-Vector3.up * BulletSpeed);
                //Destroy the bullet after 3 sec
                Destroy(Clone.gameObject, 3);
                //make isfiring true
                IsFiring = true;
                muzzleflash.Play();
                    
                Ammo--;
                //make isfiring false
                IsFiring = false;
                //check if the ammo = 0
                if (Ammo == 0)
                {
                    Debug.Log("You Cant Shoot Now ");
                }
            }

        }
        //make sure if the user didnt press the fire1 button (OR) the ammo=0 (OR) isFiring=false
        else
        {
            //Dont  Run the Animation of shoot
            PlayerAnimator.SetBool("Shoot", false);
        }
        //make sure if ammo -0
        if (Ammo == 0)
        {
            //make sure if user pree R 
            if (Input.GetKey(KeyCode.R))
            {
                //Start the coroutine
                StartCoroutine(Reload());
                reload.Reload();
            }
            Debug.Log("You Cant Shoot Now ");
        }
        
        
    }
    //this method to make the player reload after the ammo = 0
    IEnumerator Reload()
    {
        //Run the animation of realod
        PlayerAnimator.SetBool("Reload", true);
        //wait 4 sec
        yield return new WaitForSeconds(4);
        //disable the animation of realod
        PlayerAnimator.SetBool("Reload", false);
        //make the ammo is equal maxammo
        Ammo = MaxAmmo;
    }
}

   


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Animator PlayerAnimator;
    public int FireRate;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerAnimator.SetBool("Shoot", true);
        }
        else
        {
            PlayerAnimator.SetBool("Shoot", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public bool canmove = true;
    public float speed = 40f;
    public float jump = 50;
    public float gravity = 100f;


    float hor;
    float ver;
    CharacterController controller;
    Vector3 movedire = Vector3.zero;
    Vector3 jumpdire = Vector3.zero;
    StaminaScript PlayerStamina;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        PlayerStamina = GetComponent<StaminaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            move();
        }

    }

    void move()
    {
        if (controller.isGrounded)
        {
            movedire = new Vector3(Input.GetAxis("Horizontal"), .0f, Input.GetAxis("Vertical"));
            movedire = movedire * speed;
            movedire = transform.TransformDirection(movedire);
            if (Input.GetButton("Jump"))
            {
                movedire.y = jump;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
            PlayerStamina.DecreaseInStamina(0.5f);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 6f;
            PlayerStamina.DecreaseInStamina(0.0f);
        }

        movedire.y = movedire.y - gravity * Time.deltaTime;
        controller.Move(movedire * Time.deltaTime);
    }
}

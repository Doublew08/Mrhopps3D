using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    
    public bool canmove = true ;
    public float speed = 40f;
    public float jump = 50f;
    public float gravity = 300f;
    public GameObject Player;

    float hor;
    float ver;
    CharacterController controller;
    Vector3 movedire = Vector3.zero;
    Vector3 jumpdire = Vector3.zero;
    StaminaScript PlayerStamina;
    Vector3 PlayerPos;
    public bool IsMoving=true;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        PlayerStamina = GetComponent<StaminaScript>();
        PlayerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            move();
        }
        if (PlayerStamina.Stamina < 100f)
        {
            if (transform.position != PlayerPos)
            {
                Debug.Log("Player has moved");

            }
            else
            {
                PlayerStamina.IncreaseTheStamina();
                Debug.Log("Player has not moved");
            }
           
        }
        PlayerPos = transform.position;

    }

    void move()
    {
        //make sure if player on the ground
        if (controller.isGrounded)
        {
           
                //put the axises(horizontal and vertical in movedir vector)
                movedire = new Vector3(Input.GetAxis("Horizontal"), .0f, Input.GetAxis("Vertical"));
                //put speed to movedir and direction
                movedire = movedire * speed;
                movedire = transform.TransformDirection(movedire);
                //check if user press jump button
                if (Input.GetButton("Jump"))
                {
                    //make the player jump
                    movedire.y = jump;
                }
            }
            //Check if the User press LeftShift
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //Increse the Speed and the stamina will decrease
                speed = 70f;
                PlayerStamina.DecreaseInStamina(0.5f);
            }
            //Check if the player dont press LeftShift
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                //Decrease the speed and the stamina will not be decreased
                speed = 40f;
                PlayerStamina.DecreaseInStamina(0.0f);
            }
            //The gravity will decrease jump speed until the player be on the ground
            movedire.y = movedire.y - gravity * Time.deltaTime;
            //make the player move
            controller.Move(movedire * Time.deltaTime);
              
    }
    
}

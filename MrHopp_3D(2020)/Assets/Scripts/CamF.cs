
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamF : MonoBehaviour
{
   

    public Transform Player;
    float MouseX;
    float MouseY;
    public float MouseSensevetity = 6f;
    public float MaxDegreeForCamera = 90f;
    public float MinDegreeForCamera = -90f;
    public float Rotation;

    // Start is called before the first frame update
    void Start()
    {
       

        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();
        PlayerMovement2 playerMovement2 = Player.GetComponent<PlayerMovement2>();

        if (playerMovement.canmove ||playerMovement2.canmove)
        {
            RotateCam();
        }

       

    }
    void RotateCam()
    {
        MouseX = Input.GetAxis("Mouse X") * MouseSensevetity;
        MouseY = Input.GetAxis("Mouse Y") * MouseSensevetity;
        Rotation -= MouseY;
        Rotation = Mathf.Clamp(Rotation, MinDegreeForCamera, MaxDegreeForCamera);
        transform.localRotation = Quaternion.Euler(Rotation, 0, 0);
        Player.Rotate(Vector3.up * MouseX * MouseSensevetity);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    public float MouseSensitivityX = 250f;
    public float MouseSensitivityY = 250f;
    public float walkSpeed;
    public float jumpForce;
    public Rigidbody m_Rigidbody;
    bool grounded;
    Transform cameraT;
    float verticalLookRotation;
    Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    public LayerMask groundedMask;
    // Start is called before the first frame update
    void Start()
    {
        cameraT = Camera.main.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        Vector3 targetMoveAmount = moveDir * walkSpeed;
        moveAmount = Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothMoveVelocity, .15f); 
        
    }
    void FixedUpdate()
    {
        m_Rigidbody.MovePosition(m_Rigidbody.position +transform.TransformDirection(moveAmount) * Time.fixedDeltaTime)  ;
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.fixedDeltaTime*MouseSensitivityX);
        verticalLookRotation += Input.GetAxis("Mouse Y")*Time.fixedDeltaTime* MouseSensitivityY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -45, 45);
        cameraT.localEulerAngles = (Vector3.left * verticalLookRotation);
        if (Input.GetButtonDown("Fire1"))
        {
            if (grounded) {
                m_Rigidbody.AddForce(transform.up * jumpForce);
        }
        }
        grounded = false;
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit , 1 + .1f , groundedMask))
        {
            grounded = true;
        }

    }
}

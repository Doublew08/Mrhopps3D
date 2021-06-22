using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class Movement : MonoBehaviour
{
    public float rotVal;
    public GameObject camera;
    
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        Vector3 moveValues = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(moveValues);
        transform.rotation = Quaternion.Euler (transform.rotation.x , camera.transform.rotation.y * rotVal, camera.transform.rotation.z);
        
    
    }
}
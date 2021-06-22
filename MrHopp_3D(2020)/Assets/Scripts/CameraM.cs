using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraM : MonoBehaviour
{
    public float SensitivityHor = 9f;
    public float SensitivityVer = 9f;
    public float minimumVer = -45f;
    public float maximumVer = 45;
    private float _rotationX = 0;
    public enum RotationsAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationsAxes axes = RotationsAxes.MouseXandY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationsAxes.MouseX)
        {
            //horizontal rotation goes here
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityHor, 0);
        }
        else if (axes == RotationsAxes.MouseY)
        {
            //Vertical rotation goes here 
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVer, maximumVer);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityHor, 0);
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVer, maximumVer);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}

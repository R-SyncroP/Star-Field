using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotat : MonoBehaviour
{
    float MaxSpeed = 20;
    public float Speed = 0;
    float Acceleration = 10;
    float Deceleration = 30;


    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam.cullingMask = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if ((Input.GetKey("a")) && (Speed < MaxSpeed))
        {
            Speed = Speed - Acceleration * Time.deltaTime;
        }
        else if ((Input.GetKey("d")) && (Speed > -MaxSpeed))
        {
            Speed = Speed + Acceleration * Time.deltaTime;
        }
        else
        {
            if (Speed > Deceleration * Time.deltaTime)
            {
                Speed = Speed - Deceleration * Time.deltaTime;
            }
            else if (Speed < -Deceleration * Time.deltaTime)
            {
                Speed = Speed + Deceleration * Time.deltaTime;
            }
            else
            {
                Speed = 0;
            }
        }
        pos.x = transform.position.x + Speed * Time.deltaTime;
        transform.position = pos;



        float pitch = Input.GetAxis("Mouse Y") * -200f * Time.deltaTime;
        float yaw = Input.GetAxis("Mouse X") * 210f * Time.deltaTime;

        cam.transform.Rotate(pitch, 0, 0, Space.Self);
        cam.transform.Rotate(0, yaw, 0, Space.World);
    }
}

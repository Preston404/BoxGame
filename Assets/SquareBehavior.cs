using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBehavior : MonoBehaviour
{
    float movement_speed = 0.02f;
    float rotation_speed = 0.45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //update the position
        if (Input.GetKey("up"))
        {
            transform.position = transform.position + new Vector3(0, 1 * movement_speed);
        }
        else if (Input.GetKey("down"))
        {
            transform.position = transform.position + new Vector3(0, -1 * movement_speed);
        }
        if (Input.GetKey("right"))
        {
            transform.position = transform.position + new Vector3(1 * movement_speed, 0);
        }
        else if (Input.GetKey("left"))
        {
            transform.position = transform.position + new Vector3(-1*movement_speed, 0);
        }

        // Update rotation
        if (Input.GetKey("a"))
        {
            Quaternion target = Quaternion.Euler(0, 0, 90); // Tilt around x,y,z
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotation_speed);
        }
        else if (Input.GetKey("d"))
        {
            Quaternion target = Quaternion.Euler(0, 0, -90); // Tilt around x,y,z
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotation_speed);
        }
    }
}

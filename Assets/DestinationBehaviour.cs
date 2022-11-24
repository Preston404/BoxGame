using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationBehaviour : MonoBehaviour
{
	GameObject the_circle;
	float min_distance = 0.4f;
	int frame_count = 0;
	int frames_to_wait = 120; // Time to wait after the circle enters the box.
	
    // Start is called before the first frame update
    void Start()
    {
        the_circle = GameObject.Find("Circle");
    }

    // Update is called once per frame
    void Update()
    {
		
		// Was the circle already detected inside the box?
		if(frame_count > 0)
		{
			frame_count += 1;
		}
		// Did the circle just enter the box?
		else if(
			Math.Abs(the_circle.transform.position.y - transform.position.y) < min_distance &&
			Math.Abs(the_circle.transform.position.x - transform.position.x) < min_distance
		)
		{
			frame_count = 1;
		}
		
		if(frame_count > frames_to_wait)
		{
			SceneManager.LoadScene("play_scene", LoadSceneMode.Single);
		}
    }
}

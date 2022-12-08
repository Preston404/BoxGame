using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class DestinationBehaviour : MonoBehaviour
{
	GameObject the_circle;
	GameObject the_arrow;
	float min_distance = 0.4f;
	int frame_count = 0;
	int frames_to_wait = 120; // Time to wait after the circle enters the box.
	
	int max_position_x = 10;
	int max_position_y = 2;
	int min_position_x = 2;
	int min_position_y = 0;
	
	float arrow_offset_x = 0.0f;
	float arrow_offset_y = 1.5f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        the_circle = GameObject.Find("Circle");
		the_arrow = GameObject.Find("Arrow");
		
		// Generate random x position
		int x_position = Random.Range(min_position_x, max_position_x+1);
		if (Random.Range(-100,100) < 0)
		{
			x_position *= -1;
		}
		transform.position = new Vector3(x_position, 0, 0);
		
		the_arrow.transform.position = transform.position;
		if(x_position < 0)
		{
			 the_arrow.transform.position = the_arrow.transform.position - new Vector3(arrow_offset_x,0,0);
		}
		else
		{
			the_arrow.transform.position = the_arrow.transform.position + new Vector3(arrow_offset_x,0,0);
		}
		
		// Generate random y position
		int y_position = Random.Range(min_position_y, max_position_y+1);
		if (Random.Range(-100,100) < 0)
		{
			y_position *= -1;
		}
		transform.position = transform.position + new Vector3(0,y_position,0);
		
		the_arrow.transform.position = the_arrow.transform.position + new Vector3(0, y_position + arrow_offset_y, 0);
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

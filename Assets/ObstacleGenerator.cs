using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
	int number_of_obstacles = 0;
	int starting_y_position = 4;
	
	public GameObject obstacle_prefab;
	
    // Start is called before the first frame update
    void Start()
    {
        obstacle_prefab = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(number_of_obstacles < 1)
		{
			Vector3 position = new Vector3(
				starting_y_position,
				Random.Range(-10,10), 
				0
			);

			GameObject new_obstacle = Instantiate(
				obstacle_prefab,
				position,
				Quaternion.identity,
				gameObject.transform
			);
			number_of_obstacles += 1;
		}
    }
}

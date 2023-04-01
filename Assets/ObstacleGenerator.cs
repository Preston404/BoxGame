using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
	bool first_time = true;
	int starting_y_position = 5;
	
	public GameObject obstacle_prefab;
	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(first_time || Random.Range(0.0f, 600.0f) < 9)
		{
			Vector3 position = new Vector3(
				Random.Range(-14,14),
				starting_y_position,
				0
			);

			GameObject new_obstacle = Instantiate(
				obstacle_prefab,
				position,
				Quaternion.identity,
				gameObject.transform
			);
			first_time = false;
		}
    }
}

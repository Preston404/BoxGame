using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CircleBehaviour : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
		// Are we off the bottom of the screen?
        if(transform.position.y < -5)
		{
			SceneManager.LoadScene("failure_scene", LoadSceneMode.Single);
		}
    }
}

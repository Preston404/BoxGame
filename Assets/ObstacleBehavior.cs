using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
	float movement_speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("failure_scene", LoadSceneMode.Single);
    }
}

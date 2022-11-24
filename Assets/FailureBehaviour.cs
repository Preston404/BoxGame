using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FailureBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene("play_scene", LoadSceneMode.Single);
		}
		if (Input.GetKeyDown("backspace"))
		{
			SceneManager.LoadScene("menu_scene", LoadSceneMode.Single);
		}
    }
}

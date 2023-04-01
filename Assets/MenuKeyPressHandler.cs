using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuKeyPressHandler : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
		// The user may also select a game mode based on the game mode number.
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene("play_scene", LoadSceneMode.Single);
        }
        else if (Input.GetKey("2"))
        {
            SceneManager.LoadScene("survival_scene", LoadSceneMode.Single);
        }
    }
}

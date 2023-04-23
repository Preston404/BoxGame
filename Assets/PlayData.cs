using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayData : MonoBehaviour
{
    public static PlayData Instance; 

	// Number of times the user has gotten the ball into the box
    public int success_count = 0;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

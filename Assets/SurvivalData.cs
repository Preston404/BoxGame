using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalData : MonoBehaviour
{
    public static SurvivalData Instance; 

    public int survival_seconds = 0;
    
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

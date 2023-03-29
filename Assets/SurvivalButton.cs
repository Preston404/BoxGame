using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalButton : MonoBehaviour
{
	public Button the_button;

    // Start is called before the first frame update
    void Start()
    {
        the_button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
   public void TaskOnClick(){
	  SceneManager.LoadScene("survival_scene", LoadSceneMode.Single);
   }
}

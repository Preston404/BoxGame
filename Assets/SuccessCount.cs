using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessCount : MonoBehaviour
{
	GameObject the_desination;
	string text_mesh_string;
	int move_count = 0;
	TextMesh the_text_mesh;
	
    // Start is called before the first frame update
    void Start()
    {
        the_desination = GameObject.Find("Destination");
		the_text_mesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
		
		if(PlayData.Instance != null)
		{
			text_mesh_string = PlayData.Instance.success_count.ToString();
			the_text_mesh.text = text_mesh_string;
			move_count += 1;
		}
		transform.position = the_desination.transform.position;
    }
}

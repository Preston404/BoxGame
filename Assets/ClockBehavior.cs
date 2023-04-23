using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockBehavior : MonoBehaviour
{
	float seconds_since_start = 0;

	public Text the_text_box;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		seconds_since_start += Time.deltaTime;

		if(((int) seconds_since_start) != SurvivalData.Instance.survival_seconds)
		{
			SurvivalData.Instance.survival_seconds = (int) seconds_since_start;
			the_text_box.text = get_time_string((int) seconds_since_start);
		}
        
    }
	
	public string get_time_string(int survival_seconds)
	{
		string minutes = (((int)survival_seconds) / 60).ToString().PadLeft(2,'0');
		string seconds = (((int)survival_seconds) % 60).ToString().PadLeft(2,'0');

		return string.Format("{0}:{1}", minutes, seconds);
	}
}

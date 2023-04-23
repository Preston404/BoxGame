using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailureText : MonoBehaviour
{
	public Text the_failure_text;
	
    // Start is called before the first frame update
    void Start()
    {
		string failure_message = "Failure\nPress enter to continue.";
		if(PlayData.Instance != null && PlayData.Instance.success_count != -1)
		{
			string play_message = string.Format("\nScore: {0}", PlayData.Instance.success_count);
			failure_message += play_message;
			PlayData.Instance.success_count = -1;
		}
		if(SurvivalData.Instance != null && SurvivalData.Instance.survival_seconds != -1)
		{
			string time_string = get_time_string(SurvivalData.Instance.survival_seconds);
			string survival_message = string.Format("\nTime: {0}", time_string);
			failure_message += survival_message;
			SurvivalData.Instance.survival_seconds = -1;
		}
        the_failure_text.text = failure_message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public string get_time_string(int survival_seconds)
	{
		string minutes = (((int)survival_seconds) / 60).ToString().PadLeft(2,'0');
		string seconds = (((int)survival_seconds) % 60).ToString().PadLeft(2,'0');

		return string.Format("{0}:{1}", minutes, seconds);
	}
}

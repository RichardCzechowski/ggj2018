using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioOnClick : MonoBehaviour {
	private Button btn;

	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick ()
	{
		gameObject.GetComponent<AudioSource>().Play();
	}
}

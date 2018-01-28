using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLink : MonoBehaviour {
	private Button btn;
	private PointTracker pointTracker;

	public string[] urls;

	private string url;

	// Awake, not Start because we reset points to 0 on Start
	void Awake () {
		pointTracker = GameObject.Find("PlayerManager").GetComponent<PointTracker>();
		url = urls[pointTracker.points];

		Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick ()
	{
        Application.OpenURL(url);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

public class ActionButton : MonoBehaviour {

	private Button thisButton;

	public VideoPlayer vp;

	public GameObject dropdownLose;

	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick () {
		gameObject.GetComponent<AudioSource>().Play();
		vp.Stop();
		dropdownLose.SetActive(true);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTimer : MonoBehaviour {

	private VideoPlayer vp;
    private VideoClip vc;
    private RectTransform rectTransform;

    private float initialWidth;


	// Use this for initialization
	void Start () {
		vp = GameObject.Find("Video Player").GetComponent<VideoPlayer> ();
		vc = vp.clip;
    	rectTransform = GetComponent<RectTransform>();
    	initialWidth = rectTransform.offsetMax.x;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (vp.isPlaying && vc.length > vp.time) {
			rectTransform.offsetMax = new Vector2 (initialWidth * (float)((vc.length - vp.time) / vc.length), rectTransform.offsetMax.y);
		}
	}
}

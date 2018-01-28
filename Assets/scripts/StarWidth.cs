using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWidth : MonoBehaviour {

    /// Reference to the rect transform component.
    private RectTransform rectTransform;

	private PointTracker pointTracker;

	// Use this for initialization
	void Start () {
    	rectTransform = GetComponent<RectTransform>();
		pointTracker = GameObject.Find("PlayerManager").GetComponent<PointTracker>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (pointTracker.points == 1 && rectTransform.offsetMax.x < -118) {
			UpdateStarWidth ();
		} else if (pointTracker.points == 2 && rectTransform.offsetMax.x < 48) {
			UpdateStarWidth ();
		} else if (pointTracker.points == 3 && rectTransform.offsetMax.x < 220) {
			UpdateStarWidth ();
		}
	}

	void UpdateStarWidth(){
		rectTransform.offsetMax = new Vector2 (rectTransform.offsetMax.x + 6f, rectTransform.offsetMax.y);
	}
}

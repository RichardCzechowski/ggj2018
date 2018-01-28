using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultPicker : MonoBehaviour {

	public Image myImage;
    public Sprite[] spriteList;
	private PointTracker pointTracker;

    void Start()
    {
        myImage = GetComponent<Image>();
		pointTracker = GameObject.Find("PlayerManager").GetComponent<PointTracker>();
        myImage.sprite = spriteList[pointTracker.points];
        // Reset the points for restart
        pointTracker.points = 0;
    }
}

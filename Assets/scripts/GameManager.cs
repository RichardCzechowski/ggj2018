using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// This script won't work without a VideoPlayer present,
// so let's ask Unity to enforce that relationship for us.
[RequireComponent (typeof(VideoPlayer))]

public class GameManager : MonoBehaviour
{
	private VideoPlayer vp;

	public GameObject dropdownWin;

		void Start ()
	{
		vp = gameObject.GetComponent<VideoPlayer> ();
		vp.loopPointReached += EndReached;
	}

	void EndReached (UnityEngine.Video.VideoPlayer vp)
	{
		dropdownWin.SetActive(true);
	}
}

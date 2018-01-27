using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// This script won't work without a VideoPlayer present,
// so let's ask Unity to enforce that relationship for us.
[RequireComponent (typeof(VideoPlayer))]

public class GameManager : MonoBehaviour
{
	// Don't create/size the Array in Start() - that makes an empty
	// array, discarding the clips you assigned in the Inspector.
	public VideoClip[] vids = new VideoClip[3];

	private int level = 0;

	private VideoPlayer vp;

	void Start ()
	{
		vp = gameObject.GetComponent<VideoPlayer> ();
//		PlayVideo(level);
	}

	// Call this method when it's time to play a particular video.
	// Pass a number from 0 to 25 inclusive to choose which video.
	public void PlayVideo (int id)
	{
		// To be safe, let's bounds-check the ID 
		// and throw a descriptive error to catch bugs.
		if (id < 0 || id >= vids.Length) {
			Debug.LogErrorFormat (
				"Cannot play video #{0}. The array contains {1} video(s)",
				id, vids.Length);
			return;
		}

		// If we get here, we know the ID is safe.
		// So we assign the (id+1)th entry of the vids array as our clip.
		vp.clip = vids [id];

		vp.loopPointReached += EndReached;

		vp.Play ();
	}
	void EndReached (UnityEngine.Video.VideoPlayer vp)
	{
		level++;
		if (level >= vids.Length) {
			return;
		}
		PlayVideo(level);
	}
}

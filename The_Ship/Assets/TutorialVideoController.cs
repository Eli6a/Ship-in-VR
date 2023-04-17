using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TutorialVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip[] videoClips;
    int currentClip = 0;

    public void NextClip()
    {
        videoPlayer.Stop();
        if (currentClip+1 >= videoClips.Length)
        {
            currentClip = 0;
        }
        else
        {
            currentClip++;
        }
        videoPlayer.clip = videoClips[currentClip];
        videoPlayer.Play();
    }
}

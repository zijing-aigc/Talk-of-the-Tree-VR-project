using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    private VideoPlayer videoPlayer; // VideoPlayer 
    private GameObject rootObject; // storage Root 

    private void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = false; // donot play in the beginng
            videoPlayer.loopPointReached += OnVideoFinished; // finish
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mesh")) // check tag
        {
            videoPlayer = other.GetComponentInChildren<VideoPlayer>(); // get VideoPlayer
            rootObject = other.transform.parent.Find("root")?.gameObject; // get root 

            if (videoPlayer != null)
            {
                videoPlayer.Play(); // play videos
            }

            if (rootObject != null)
            {
                rootObject.SetActive(false); // root disappear
            }
        }
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        vp.gameObject.SetActive(false); // videoe disappear when finish
    }
}
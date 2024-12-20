using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playVideo : MonoBehaviour
{
    public GameObject videoPlayer;

    public void VideoStart()
    {
        videoPlayer.SetActive(true);
    }
}
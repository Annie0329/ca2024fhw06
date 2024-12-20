using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

//Attach this script to a GameObject

[ExecuteInEditMode]
[RequireComponent(typeof(VideoPlayer))]
public class PlayOnEditor : MonoBehaviour
{
    [Range(0f,1f)]public float CurrSeek = 0;
    [HideInInspector]
    public float LastSeek = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CurrSeek = GetSeek();
        LastSeek = CurrSeek;
    }

    public void PlayVideo()
    {
        GetComponent<VideoPlayer>().Play();
    }
    
    public void PauseVideo()
    {
        GetComponent<VideoPlayer>().Pause();
    }
    
    public void RestartVideo()
    {
        GetComponent<VideoPlayer>().Stop();
        GetComponent<VideoPlayer>().Play();
    }

    public void SeekVideo(float normalized)
    {
        var real = GetComponent<VideoPlayer>().frameCount * normalized;
        GetComponent<VideoPlayer>().frame = Convert.ToInt64(real);
    }
    
    public float GetSeek()
    {
        var real = (float)GetComponent<VideoPlayer>().frame / (float)GetComponent<VideoPlayer>().frameCount;
        if (real < 0) return 0; //video not ready

        return real;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayTrigger : MonoBehaviour
{
   

    public VideoClip videoClip;
    private bool playstatus = true;

    //public GameObject screen;

    void Start()
    {
        //var videoPlayer = screen.AddComponent<VideoPlayer>();   // videoPlayeコンポーネントの追加

        //videoPlayer.source = VideoSource.VideoClip; // 動画ソースの設定
        //videoPlayer.clip = videoClip;

        //videoPlayer.isLooping = true;   // ループの設定
    }

    public void VPControl()
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        if (!videoPlayer.isPlaying) // ボタンを押した時の処理
            videoPlayer.Play(); // 動画を再生する。
        else
            videoPlayer.Pause();    // 動画を一時停止する。
    }

    void OnTriggerEnter(Collider other)
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        Debug.Log("walk！");
        videoPlayer.Play(); // 動画を再生する。
        //playstatus = false;
    }

    void OnTriggerExit(Collider other)
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        Debug.Log("通り抜け終えた");
        videoPlayer.Pause();    // 動画を一時停止する。
        //playstatus = true;
    }

    void Update()
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("A key or mouse click has been detected");
            videoPlayer.Play(); // 動画を再生する。
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            videoPlayer.Pause();    // 動画を一時停止する。
        }
    }
}

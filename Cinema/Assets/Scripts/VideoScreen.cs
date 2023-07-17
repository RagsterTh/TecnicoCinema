using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScreen : MonoBehaviour
{
    public VideoClip[] videos;
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Interaction()
    {
        if (StarterAssets.StarterAssetsInputs.hasRemote)
        {
            videoPlayer.clip = videos[0];
        }
    }
}

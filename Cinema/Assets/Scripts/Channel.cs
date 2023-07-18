using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Channel : MonoBehaviour
{
    VideoScreen screen;
    public int videoID;
    // Start is called before the first frame update
    void Awake()
    {
        screen = GetComponentInParent<VideoScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Interaction()
    {
        screen.ChoiceVideo(videoID);
    }
}

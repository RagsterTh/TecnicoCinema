using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScreen : MonoBehaviour
{
    public VideoClip[] videos;
    public Material screenOff, screenOn;
    public GameObject choiceVideoMenu;

    MeshRenderer meshR;
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        meshR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Interaction(bool remoteActive)
    {
        if (remoteActive)
        {
            if (videoPlayer.clip)
            {
                videoPlayer.clip = null;
            }
            meshR.material = screenOn;
            choiceVideoMenu.SetActive(!choiceVideoMenu.activeSelf);
        }
    }
    public void ChoiceVideo(int id)
    {
        videoPlayer.clip = videos[id];
        choiceVideoMenu.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    public GameObject remoteController;
    public static bool hasController;
    Transform cam;
    RaycastHit hit;
    Image lastChannel;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit);
        if (remoteController.activeSelf && hit.collider.CompareTag("Channel"))
        {
            if (lastChannel)
            {
                lastChannel.color = Color.white;
            }
            lastChannel = hit.collider.GetComponent<Image>();
            lastChannel.color = Color.blue;
        }
    }
    public void Interaction()
    {
            hit.collider.SendMessage("Interaction", remoteController.activeSelf, SendMessageOptions.DontRequireReceiver);
            if (hit.collider.CompareTag("Controller"))
            {
                remoteController.SetActive(true);
            }
    }
}

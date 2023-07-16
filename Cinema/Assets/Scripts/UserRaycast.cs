using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserRaycast : MonoBehaviour
{
    public float distanceInteraction = 5;
    Transform cam;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
            RayCastInteraction();
    }
    void RayCastInteraction()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distanceInteraction))
        {
            hit.collider.SendMessage("Interaction", SendMessageOptions.DontRequireReceiver);
            /*
                if (lastObjSelection != null)
                {
                    lastObjSelection.GetComponent<Outline>().DeselectObj();
                }
                lastObjSelection = hit.collider.gameObject;
                hit.collider.GetComponent<Outline>().SelectObj();
                if (Input.GetButtonDown("Fire1"))
                {
                    hit.collider.SendMessage("Interaction", SendMessageOptions.DontRequireReceiver);
                }
            }

        }
        else
        {
            if (lastObjSelection != null)
            {
                lastObjSelection.GetComponent<Outline>().DeselectObj();
            }
            */
        }
    }
}

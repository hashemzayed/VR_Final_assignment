using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CubeLogic : MonoBehaviour
{
    private XRGrabInteractable grab;
    private Vector3 startPos;
    private bool isLocked = false;

    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
        startPos = transform.position;
    }

    public void LockToPosition(Vector3 position)
    {
        grab.enabled = false;
        isLocked = true;
        transform.position = position;
        transform.rotation = Quaternion.identity;
    }

    public void Reject()
    {
        if (!isLocked)
        {
            transform.position = startPos;
            transform.rotation = Quaternion.identity;
            // Optional: Add a buzz sound
        }
    }

    public bool IsLocked()
    {
        return isLocked;
    }
}


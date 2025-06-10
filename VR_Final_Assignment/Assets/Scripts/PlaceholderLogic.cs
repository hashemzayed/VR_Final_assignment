using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderLogic : MonoBehaviour
{
    public string acceptedTag; // Set this in Inspector, e.g., "RedCube"

    private void OnTriggerEnter(Collider other)
    {
        CubeLogic cube = other.GetComponent<CubeLogic>();
        if (cube != null && !cube.IsLocked())
        {
            if (other.CompareTag(acceptedTag))
            {
                cube.LockToPosition(transform.position);
                FindObjectOfType<PuzzleManager>().CubePlacedCorrectly();
            }
            else
            {
                cube.Reject();
            }
        }
    }
}

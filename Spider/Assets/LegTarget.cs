using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegTarget : MonoBehaviour
{
    Ray rayDown;
    GameObject legGroundTarget;
    // GameObject spider;
    LayerMask mask;

    private void Start()
    {
        legGroundTarget = transform.Find("LegGroundTarget").gameObject;
        // spider = transform.parent.parent.parent.parent.gameObject; // Spider

        mask = ~(1 << 8);
    }

    void Update()
    {
        rayDown = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        if(Physics.Raycast(rayDown, out hit, 3f, mask))
        {
            legGroundTarget.transform.position = hit.point;
        }
    }
}

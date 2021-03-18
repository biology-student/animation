using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{

    public Transform leftFootTarget;
    private Vector3 initLeftFootPos;
    private Vector3 lastLeftFootPos;

    private GameObject legGroundTarget;
    private GameObject targetDistance;
    private LineRenderer lineRenderer;


    void Start()
    {
        initLeftFootPos = leftFootTarget.localPosition;
        lastLeftFootPos = leftFootTarget.position;

        legGroundTarget = transform.Find("Model/BodyPivot/Body/LegTargetRaycast/LegGroundTarget").gameObject;
        targetDistance = transform.Find("Model/BodyPivot/UpLegPivot/LegPivot/FootPivot/TargetDistance").gameObject;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    
    void Update()
    {
        leftFootTarget.position = lastLeftFootPos;
        lastLeftFootPos = leftFootTarget.position;

        var positions = new Vector3[]
        {
            legGroundTarget.transform.position,
            targetDistance.transform.position
        };

        lineRenderer.SetPositions(positions);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{

    public Transform leftFootTarget;
    private Vector3 initLeftFootPos;
    private Vector3 lastLeftFootPos;
    public Transform rightFootTarget;
    private Vector3 initRightFootPos;
    private Vector3 lastRightFootPos;

    private GameObject leftGroundTarget;
    private GameObject leftTargetDistance;
    private GameObject rightGroundTarget;
    private GameObject rightTargetDistance;

    public float maxDistance = 1f;
    private float leftDistance;
    private float rightDistance;

    void Start()
    {
        initLeftFootPos = leftFootTarget.localPosition;
        lastLeftFootPos = leftFootTarget.position;
        initRightFootPos = rightFootTarget.localPosition;
        lastRightFootPos = rightFootTarget.position;

        leftGroundTarget = transform.Find("Model/BodyPivot/Body/L-LegTargetRaycast/LegGroundTarget").gameObject;
        leftTargetDistance = transform.Find("Model/BodyPivot/L-UpLegPivot/LegPivot/FootPivot/TargetDistance").gameObject;
        rightGroundTarget = transform.Find("Model/BodyPivot/Body/R-LegTargetRaycast/LegGroundTarget").gameObject;
        rightTargetDistance = transform.Find("Model/BodyPivot/R-UpLegPivot/LegPivot/FootPivot/TargetDistance").gameObject;

    }

    
    void Update()
    {
        leftFootTarget.position = lastLeftFootPos;
        lastLeftFootPos = leftFootTarget.position;
        rightFootTarget.position = lastRightFootPos;
        lastRightFootPos = rightFootTarget.position;
        Vector3 leftGroundTargetPos = leftGroundTarget.transform.position;
        Vector3 leftTargetDistancePos = leftTargetDistance.transform.position;
        Vector3 rightGroundTargetPos = rightGroundTarget.transform.position;
        Vector3 rightTargetDistancePos = rightTargetDistance.transform.position;


        leftDistance = (leftGroundTargetPos - leftTargetDistancePos).magnitude;
        rightDistance = (rightGroundTargetPos - rightTargetDistancePos).magnitude;
        if (leftDistance >= maxDistance)
        {
            leftFootTarget.position = leftGroundTargetPos + new Vector3(0, 1f, 0);
            lastLeftFootPos = leftFootTarget.position;
        }
        if (rightDistance >= maxDistance)
        {
            rightFootTarget.position = rightGroundTargetPos + new Vector3(0, 1f, 0);
            lastRightFootPos = rightFootTarget.position;
        }
    }
}

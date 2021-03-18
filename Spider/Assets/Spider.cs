using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{

    public Transform leftFootTarget;
    private Vector3 initLeftFootPos;
    private Vector3 lastLeftFootPos;
    
    
    void Start()
    {
        initLeftFootPos = leftFootTarget.localPosition;
        lastLeftFootPos = leftFootTarget.position;
    }

    
    void Update()
    {
        leftFootTarget.position = lastLeftFootPos;
        lastLeftFootPos = leftFootTarget.position;
    }
}

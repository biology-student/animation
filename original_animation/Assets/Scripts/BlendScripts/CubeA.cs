using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeA : MonoBehaviour
{

    public Vector3 positionChange;
    public float limit;

    private int check;
    private float minLimit;

    // Start is called before the first frame update
    void Start()
    {
        check = 0;
        minLimit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 0)
        {
            transform.localPosition += positionChange;
        }
        else
        {
            transform.localPosition -= positionChange;
        }
        if (transform.localPosition.x >= limit || transform.localPosition.y >= limit || transform.localPosition.z >= limit)
        {
            check = 1;
        }
        else if(transform.localPosition.x <= minLimit && transform.localPosition.y <= minLimit && transform.localPosition.z <= minLimit)
        {
            check = 0;
        }
    }
}

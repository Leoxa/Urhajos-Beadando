using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraskovetes : MonoBehaviour
{

    public Transform target;

    private Vector3 velocity = Vector3.zero;

    public float smoothTime = .15f;

    public bool yMinEnable = false;
    public float yMinValue = 0;

    public bool yMaxEnable = false;
    public float yMaxValue = 0;

    public bool xMinEnable = false;
    public float xMinValue = 0;

    public bool xMaxEnable = false;
    public float xMaxValue = 0;

    public void Update()
    {
        Vector3 targetPos = target.position;

            if (yMinEnable && yMaxEnable)
            {
                targetPos.y = Mathf.Clamp(target.position.y, yMaxValue, yMaxValue);
            }else if (yMinEnable)
            {
                targetPos.y = Mathf.Clamp(target.position.y, yMinValue, target.position.y);
            }
            else if (yMaxEnable)
            {
                targetPos.y = Mathf.Clamp(target.position.y, target.position.y, yMaxValue);
            }


            if (xMinEnable && xMaxEnable)
            {
                targetPos.x = Mathf.Clamp(target.position.x, xMaxValue, xMaxValue);
            }
            else if (xMinEnable)
            {
                targetPos.x = Mathf.Clamp(target.position.x, xMinValue, target.position.x);
            }
            else if (xMaxEnable)
            {
                targetPos.x = Mathf.Clamp(target.position.x, target.position.x, yMaxValue);
            }

        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}

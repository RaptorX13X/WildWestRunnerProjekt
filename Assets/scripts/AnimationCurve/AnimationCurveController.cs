using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveController : MonoBehaviour
{
    public float speed;
    public Vector3 startPoint;
    public Vector3 endPoint;
    public float currentTime;
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        endPoint = Vector3.Scale(startPoint, new Vector3(-1,1,1));
   
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime * speed;
        transform.position = Vector3.LerpUnclamped(startPoint, endPoint, curve.Evaluate(currentTime));

        if (currentTime > 1)
            currentTime = 0;
    }
}

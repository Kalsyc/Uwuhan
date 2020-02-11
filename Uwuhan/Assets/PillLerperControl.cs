using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillLerperControl : MonoBehaviour
{

    public Transform startPos, endPos;
    public bool isRepeatable = false;
    public float speed = 1.0f;
    public float period;
    
    float startTime, totalDistance;

    IEnumerator Start()
    {
        startTime = Time.time;
        totalDistance = Vector3.Distance(startPos.position, endPos.position);
        while(isRepeatable)
        {
            yield return RepeatLerp(startPos.position, endPos.position, period);
            yield return RepeatLerp(endPos.position, startPos.position, period);
        }
    }

    void Update()
    {
        if (!isRepeatable)
        {
            float currentDuration = (Time.time - startTime) * speed;
            float journeyFraction = currentDuration / totalDistance;
            this.transform.position = Vector3.Lerp(startPos.position, endPos.position, journeyFraction);
        }
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            this.transform.position = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
}

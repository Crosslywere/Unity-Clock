using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hourPivot;
    
    [SerializeField]
    Transform minutePivot;
    
    [SerializeField]
    Transform secondPivot;

    private const float hourAngle = -30.0f, minuteAngle = -6.0f, secondAngle = -6.0f;

    void Update()
    {
        var time = DateTime.Now;
        float seconds = time.Second;
        float minutes = time.Minute + (float)(seconds / 60.0f);
        float hours = time.Hour + (float)(minutes / 60.0f);
        hourPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hourAngle * hours);
        minutePivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minuteAngle * minutes);
        secondPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondAngle * seconds);
    }
}

using System;
using UnityEngine;

public class WorldCalender : MonoBehaviour
{
    DateTime StartDateTime;
    DateTime CurrentDateTime;

    float StartTime;

    void Start()
    {
        StartDateTime = new DateTime(1, 1, 1, 0, 0, 0);
        StartTime = Time.time;
    }


    void FixedUpdate()
    {
        CurrentDateTime = StartDateTime + System.TimeSpan.FromSeconds((Time.time - StartTime) * 60);
        DebugCalender();
    }

    void DebugCalender(){
        Debug.Log ("Year:" + CurrentDateTime.Year+", Month:" + CurrentDateTime.Month+", Day:" + CurrentDateTime.Day+", Hour:" + CurrentDateTime.Hour+", Minute:"+CurrentDateTime.Minute);
    }
}

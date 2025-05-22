using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float time;
    public float fullDayLength;
    public float startTime = 0.4f;
    private float timeRate;
    public Vector3 noon; // vector 90 0 0

    [Header("Sun")]
    public Light sun;
    public AnimationCurve sunIntensity; //조명 강도
    public Gradient sunColor;

    [Header("Moon")]
    public Light moon;
    public AnimationCurve moonIntensity; //조명 강도
    public Gradient moonColor;

    [Header("Other Lighting")]
    public AnimationCurve lightingIntensityMultiplier;
    public AnimationCurve reflectionIntensityMultiplier; //반사


    void Start()
    {
        timeRate = 1.0f / fullDayLength;
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

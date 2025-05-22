using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public float passiveValue; //시간에 따라 변화
    public Image uiBar;



    void Start()
    {
        curValue = startValue;
    }

    
    void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }

    public void Add(float amount)
    {
        curValue = Mathf.Min(curValue + amount, maxValue);
    }

    public void Subtract(float amount)
    {
        curValue = Mathf.Max(curValue - amount, 0.0f);
    }

    public float GetPercentage()
    {
        return curValue / maxValue;
    }

    //float GetPercentage()
    //{
    //    return curValue / maxValue;
    //}

    //public void Add(float value)
    //{
    //    curValue += Mathf.Min(curValue + value, maxValue);
    //}

    //public void Subtract(float value)
    //{
    //    curValue -= Mathf.Max(curValue - value, 0);
    //}
}

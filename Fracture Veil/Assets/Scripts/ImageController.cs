﻿using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    //public GameAction imageAction;
    private Image imageComponent;
    public FloatData data;
    private void Start ()
    {
        imageComponent = GetComponent<Image>();
        data.resetValue(100f);
    }

    
    public void UpdateImageHandler()
    {
        Debug.Log("Got");
        imageComponent.fillAmount = data.value;
    }
	
	
    public void UpdateImageComponent(float amount)
    {
        imageComponent.fillAmount += amount;
    }
	
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
        Debug.Log(dataObj.value);
    }
}
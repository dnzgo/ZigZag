using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    [SerializeField] private Material material;

    [SerializeField] private Color[] colors;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;

    private int colorIndex = 0;

    private void Update()
    {
        ColorChangeTime();
        SmoothColorChange();
    }

    private void ColorChangeTime()
    {
        if (currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        colorIndex++;
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SmoothColorChange()
    {
        material.color = Color.Lerp(material.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        material.color = colors[1];
    }

}


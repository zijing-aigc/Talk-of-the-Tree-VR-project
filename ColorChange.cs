using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    //color
    public Material material;
    public Color[] colors;
    private int currentColorIndex = 0;
    private int targetColorIndex = 1;
    private float targetPoint;
    public float time;
    private float colorChangeDelay = 72f;//62s
    private bool canChangeColor = false;// whether coukd change

    //Start is called before the first frame update
    void Start()
    {
        Invoke("EnableColorChange", colorChangeDelay);
    }
    void EnableColorChange()
    {
        canChangeColor = true;
    }


    //Update is called once per frame
    void Update()
    {
        if (canChangeColor)
        {
            Transition();
        }


        void Transition()
        {

            targetPoint += Time.deltaTime / time;
            material.color = Color.Lerp(colors[currentColorIndex], colors[targetColorIndex], targetPoint);
            //if (targetPoint >= 1f)
            //{
            //    targetPoint = 0f;
            //    currentColorIndex = targetColorIndex;
            //    targetColorIndex++;
                //if (targetColorIndex == colors.Length)
                //    targetColorIndex = 0;

            }
        }

    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arealightscontrol : MonoBehaviour
{
    [SerializeField] Light areaLight;
    [SerializeField] Material LightBallsOn;
    [SerializeField] Material LightBallsOff;
    [SerializeField] Renderer shade;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // when use presses I
        //1. enabke light
        // 2. change material to on
        if (Input.GetKeyDown(KeyCode.K))
        {
            areaLight.enabled = true;
            shade.material = LightBallsOn;
        }

        //when user presses O
        //1. disable light
        //2. change material to off
        if (Input.GetKeyDown(KeyCode.L))
        {
            areaLight.enabled = false;
            shade.material = LightBallsOff;
        }
    }
}

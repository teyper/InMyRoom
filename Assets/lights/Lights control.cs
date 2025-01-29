using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightscontrol : MonoBehaviour
{

    [SerializeField] Light bulb;
    [SerializeField] Material LightOn;
    [SerializeField] Material LightOff;
    [SerializeField] Renderer Shade;
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
        if (Input.GetKeyDown(KeyCode.I))
        {
            bulb.enabled = true;
            Shade.material = LightOn;
        }

        //when user presses O
        //1. disable light
        //2. change material to off
        if (Input.GetKeyDown(KeyCode.O))
        {
            bulb.enabled = false;
            Shade.material = LightOff;
        }
    }
}

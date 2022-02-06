using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class BallLightController : MonoBehaviour
{
    public Light2D ballLight;

    private void OnTriggerEnter(Collider other) 
    {
        ballLight.intensity = 1f;
    }
    
}

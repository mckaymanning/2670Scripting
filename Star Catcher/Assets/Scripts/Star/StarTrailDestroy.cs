using UnityEngine;
using System.Collections;

public class StarTrailDestroy : MonoBehaviour
{
    public ParticleSystem trailSystem;
    

    void OnTriggerEnter()
    {
        trailSystem.Stop();
    }
}

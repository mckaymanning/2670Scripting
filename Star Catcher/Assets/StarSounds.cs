using UnityEngine;
using System.Collections;

public class StarSounds : MonoBehaviour {

    public AudioSource StarSource;

    public AudioClip StarCollect;

    public float volLowRange = .5f;
    public float volHighRange = 1.0f;


    void OnTriggerEnter()
    {
        float vol = volHighRange;
        StarSource.PlayOneShot(StarCollect, vol);

    }
}

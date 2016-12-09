using UnityEngine;
using System.Collections;

public class WolfSounds : MonoBehaviour {

    public AudioSource WolfSource;
    public AudioClip Impact;
    public float volLowRange = .5f;
    public float volHighRange = 1.0f;

    void OnTriggerEnter()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        WolfSource.PlayOneShot(Impact, vol);
    }
}

using UnityEngine;
using System.Collections;

public class ButtonClickSound : MonoBehaviour {

    public AudioSource ButtonSound;
    public AudioClip ButtonClick;
    public float volLowRange = .5f;
    public float volHighRange = 1.0f;


    void OnMouseDown ()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        ButtonSound.PlayOneShot(ButtonClick, vol);
    }
}

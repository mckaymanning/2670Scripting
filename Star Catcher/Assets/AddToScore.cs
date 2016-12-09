using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AddToScore : MonoBehaviour {

    //static public int count;
    public Text countText;
    public ParticleSystem starcollect;

    public AudioSource StarSource;

    public AudioClip StarPop;

    public float volLowRange = .5f;
    public float volHighRange = 1.0f;


	// Use this for initialization
	void Start () {
		staticVars.count = 0;
        staticVars.yourScore = 0;
        //count = 0;
        SetCountText();
    }
	
    void OnTriggerEnter()
    {
        float vol = volHighRange;
        StarSource.PlayOneShot(StarPop, vol);
        starcollect.Play();
        staticVars.count = staticVars.count + 1;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Stars  " + staticVars.count.ToString();
    }

    void Update()
    {
        staticVars.yourScore = staticVars.count;
    }
}

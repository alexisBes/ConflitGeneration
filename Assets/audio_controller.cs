using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_controller : MonoBehaviour
{
    public AudioSource source;
    public GameObject source1;
    public GameObject source2;
    public GameObject source3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (source1.GetComponent<AudioSource>().isPlaying || source2.GetComponent<AudioSource>().isPlaying || source3.GetComponent<AudioSource>().isPlaying)
        {
            if (source.isPlaying)
            {
                source.Stop();
            }
        }
        else if (!source.isPlaying)
        {
            source.Play();
        }
    }
}

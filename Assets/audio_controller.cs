using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_controller : MonoBehaviour
{
    public AudioSource Sharksource;
    public GameObject BGsource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sharksource.isPlaying)
        {
            if (BGsource.GetComponent<AudioSource>().isPlaying)
            {
                BGsource.GetComponent<AudioSource>().Stop();
            }
        }
        else if (!BGsource.GetComponent<AudioSource>().isPlaying)
        {
            BGsource.GetComponent<AudioSource>().Play();
        }
    }
}

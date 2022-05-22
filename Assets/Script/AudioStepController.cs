using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStepController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool IsMoving = false;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x != 0)
        {
            IsMoving = true;
        }
        else
        {
            IsMoving = false;
        }

        if (IsMoving)
        {
            if (!audio.isPlaying)
                audio.Play();
        }
        else
        {
            audio.Stop();
        }
    }
}

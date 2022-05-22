using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyController : MonoBehaviour
{
    public float moovementSpped = 1;
    public Animator animator;
    public GameObject trap;
    public GameObject mgameObject;

    private bool IsMoving = false;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moovementSpped;
        if(movement != 0)
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
    
    void OnTriggerEnter2D(Collider2D hit) {
        Destroy(trap);
        Destroy(mgameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bartman : MonoBehaviour
{
    public int speedx = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speedx, 0, 0) * Time.deltaTime;
        transform.Translate(movement);
    }
}
 
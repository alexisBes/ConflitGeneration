using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenealogicTree : MonoBehaviour
{
    LineRenderer line;
    public GameObject parent;

    // Start is called before the first frame update
    void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        line.positionCount = 2;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, parent.transform.position);

    }
}

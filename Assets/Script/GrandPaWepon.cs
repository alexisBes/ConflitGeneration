using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandPaWepon : MonoBehaviour
{
    LineRenderer line;

    public LayerMask caneMask;
    private float maxRange = 10f;
    private float caneSpeed = 20f;
    private bool isHooked = false;
    private bool touched = false;

    Vector2 target;

    private void Start() {
        line = GetComponent<LineRenderer>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && !isHooked) {
            StartCane();
        }
        if (touched) {
           DefaultCane();
        }
    }

    private void StartCane() {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxRange, caneMask);

        if (hit.collider != null) {
            isHooked = true;
            target = hit.point;
            line.enabled = true;
            line.positionCount = 2;
            StartCoroutine(CreateCane());
        }
    }

    private void DefaultCane() {
        line.SetPosition(0, transform.position);
        touched = false;
        isHooked = false;
        line.enabled = false;
    }

    IEnumerator CreateCane() {
        float t = 0;
        float time = 10;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position); 
        Vector2 p;

        while (t < time) {
            t += caneSpeed * Time.deltaTime;
            p = Vector2.Lerp(transform.position, target, t / time);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, p);
            yield return null;
        }
   
        line.SetPosition(1, target);
        touched = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ballPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {    
            Shoot();
        }
        
    }

    void Shoot() {
        Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
    }
}

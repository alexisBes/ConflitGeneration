using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;
public class SwitchCharacter : MonoBehaviour
{
    public GameObject dady;
    public GameObject baby;
    public GameObject grandpa;

    public enum State {
        Dady,
        Grandpa,
        Baby
    }
    private int switchAvatar = 1;
    // Start is called before the first frame update
    void Start()
    {
        dady.gameObject.SetActive(true);
        baby.gameObject.SetActive(false);
        grandpa.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)) {
            SwitchCharac();
        }
    }

    void SwitchCharac() {
        float t = 0;
        float time = 10;
        while (t < time) {
            t += Time.deltaTime;
            switch(switchAvatar) {
            case 1:
                switchAvatar = 2;
                dady.gameObject.SetActive(true);
                baby.gameObject.SetActive(false);
                grandpa.gameObject.SetActive(false);
                break;
            case 2:
                switchAvatar = 3;
                dady.gameObject.SetActive(false);
                baby.gameObject.SetActive(true);
                grandpa.gameObject.SetActive(false);
                break;
            case 3:
                switchAvatar = 1;
                dady.gameObject.SetActive(false);
                baby.gameObject.SetActive(false);
                grandpa.gameObject.SetActive(true);
                break;
        }
        }
    }
}

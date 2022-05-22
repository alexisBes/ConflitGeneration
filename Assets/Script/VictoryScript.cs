using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour
{
    public Transform G�n�alogicalDote;
    public GameObject victoryUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector3 position = G�n�alogicalDote.transform.position;
            position.x += 1;
            Transform test = Instantiate(G�n�alogicalDote, position, Quaternion.identity, G�n�alogicalDote.parent);
            victoryUI.SetActive(true);
        }
    }
}

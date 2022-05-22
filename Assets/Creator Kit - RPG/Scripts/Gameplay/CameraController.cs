using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPGM.Gameplay
{
    /// <summary>
    /// A simple camera follower class. It saves the offset from the
    ///  focus position when started, and preserves that offset when following the focus.
    /// </summary>
    public class CameraController : MonoBehaviour
    {
        //public Transform focus;
        public float smoothTime = 2;

        Vector3 offset;

        public GameObject dady;
        public GameObject baby;
        public GameObject grandpa;
        
        public Transform t_dady;
        public Transform t_baby;
        public Transform t_grandpa;
        
        public GameObject dadyController;
        public GameObject grandpaController;
        public static int switchAvatar = 3;

        void Start() {
            dady.gameObject.SetActive(false);
            baby.gameObject.SetActive(true);
            grandpa.gameObject.SetActive(false);
            dadyController.gameObject.SetActive(false);
            grandpaController.gameObject.SetActive(false);
        }

        void Awake()
        {   
            if (switchAvatar == 1)
                offset = t_grandpa.position - transform.position;
            else if (switchAvatar == 2)
                offset = t_dady.position - transform.position;
            else if (switchAvatar == 3)
                offset = t_baby.position - transform.position;
        }

        void Update()
        {
            //if (Input.GetKey(KeyCode.S)) {
            //    SwitchCharac();
            //}/*
            if (switchAvatar == 1)
                transform.position = Vector3.Lerp(transform.position, t_grandpa.position - offset, Time.deltaTime * smoothTime);
            else if (switchAvatar == 2)
                transform.position = Vector3.Lerp(transform.position, t_dady.position - offset, Time.deltaTime * smoothTime);
            else if (switchAvatar == 3)
                transform.position = Vector3.Lerp(transform.position, t_baby.position - offset, Time.deltaTime * smoothTime);
            //    */
        }

        public void SwitchCharac() {
            float t = 0;
            float time = 10;
            //while (t < time) {
            //    t += Time.deltaTime;
                switch(switchAvatar) {
                    case 1:
                        dady.gameObject.SetActive(true);
                        baby.gameObject.SetActive(false);
                        grandpa.gameObject.SetActive(false);
                        grandpaController.gameObject.SetActive(false);
                        dadyController.gameObject.SetActive(true);
                        switchAvatar = 2;
             //           transform.position = Vector3.Lerp(transform.position, t_dady.position - offset, Time.deltaTime * smoothTime);
                        break;
                    case 2:
                        dady.gameObject.SetActive(false);
                        baby.gameObject.SetActive(true);
                        grandpa.gameObject.SetActive(false);
                        switchAvatar = 3;
               //         transform.position = Vector3.Lerp(transform.position, t_baby.position - offset, Time.deltaTime * smoothTime);
                        break;
                    case 3:
                        dady.gameObject.SetActive(false);
                        baby.gameObject.SetActive(false);
                        grandpa.gameObject.SetActive(true);
                        grandpaController.gameObject.SetActive(true);
                        dadyController.gameObject.SetActive(false);
                        switchAvatar = 1;
                        //transform.position = Vector3.Lerp(transform.position, t_grandpa.position - offset, Time.deltaTime * smoothTime);
                        break;
                }
            //}
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    /*
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                float turnX = Input.GetAxis("Mouse X");
                float turnY = Input.GetAxis("Mouse Y");
                Vector3 vecX = Camera.main.transform.up * 30.0f * -turnX;
                Vector3 vecY = Camera.main.transform.right * 30.0f * turnY;

                Rigidbody rigidBody = GetComponent<Rigidbody>();
                rigidBody.AddTorque(vecX);
                rigidBody.AddTorque(vecY);
            }
        }
    */

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            float turnX = Input.GetAxis("Mouse X");
            float turnY = Input.GetAxis("Mouse Y");
            Vector3 vecX = Camera.main.transform.up * 30.0f * -turnX;
            Vector3 vecY = Camera.main.transform.right * 30.0f * turnY;

            Rigidbody rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddTorque(vecX);
            rigidBody.AddTorque(vecY);
        }
    }

}

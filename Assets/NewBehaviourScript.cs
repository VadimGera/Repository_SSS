using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * 1f);
    }





}

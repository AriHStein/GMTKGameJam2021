using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Rigidbody body;
    
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
    {
        body.AddForce(force, mode);
    }
}

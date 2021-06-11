using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Bumper : MonoBehaviour
{
    [SerializeField]
    private float cooldown = 1f;

    [SerializeField]
    private float bumpForce;

    private float lastBumpTime;

    private void OnCollisionEnter(Collision collision)
    {
        if(Time.time - lastBumpTime < cooldown ||
            collision.collider == null)
        {
            return;
        }
        
        Ball other = collision.collider.GetComponent<Ball>();
        if(other == null)
        {
            return;
        }

        lastBumpTime = Time.time;
        other.AddForce(bumpForce * collision.GetContact(0).normal, ForceMode.Impulse);
    }
}

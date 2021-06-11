using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Flipper : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 360f)]
    private float rotationAmount = 30f;
    
    [SerializeField]
    [Min(0f)]
    private float rotationSpeed = 180f;

    [SerializeField][Range(-1, 1)]
    private int rotateDirection = 1;
    private Quaternion neutralQuat;
    private Quaternion activatedQuat;
    private Quaternion targetQuat;

    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        neutralQuat = targetQuat = transform.rotation;
        activatedQuat = neutralQuat * Quaternion.Euler(0, rotationAmount * rotateDirection, 0);
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        body.MoveRotation(Quaternion.RotateTowards(transform.rotation, targetQuat, rotationSpeed * Time.fixedDeltaTime));
    }

    public void OnFlipInput(InputAction.CallbackContext context) 
    {
        if(context.started)
        {
            OnFlipStarted();
        }
        else if(context.canceled)
        {
            OnFlipStopped();
        }
    }

    private void OnFlipStarted()
    {
        targetQuat = activatedQuat;
    }

    private void OnFlipStopped()
    {
        targetQuat = neutralQuat;
    }

}

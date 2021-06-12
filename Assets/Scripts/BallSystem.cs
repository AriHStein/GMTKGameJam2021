using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSystem : MonoBehaviour
{
    [SerializeField]
    private Ball ball1;

    [SerializeField]
    private Ball ball2;

    [SerializeField]
    private int chainLength;

    [SerializeField]
    private GameObject chainPrefab;

    public event System.Action BallDestroyed;

    public void DestroyBall()
    {
        BallDestroyed?.Invoke();
        Destroy(gameObject);
    }

    public void FireBalls(Vector3 force)
    {
        ball1.AddForce(force, ForceMode.Impulse);
        ball2.AddForce(force, ForceMode.Impulse);
    }
}


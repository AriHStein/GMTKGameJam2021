using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PlayArea : MonoBehaviour
{
    [SerializeField]
    private GameObject gate;

    [SerializeField]
    private BallSpawner spawner;

    [SerializeField]
    private int numBalls = 2;
    private int ballCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        OpenGate();
        spawner.BallSpawned += OnBallSpawned;
    }

    private void OnBallSpawned(BallSystem ball)
    {
        OpenGate();
    }

    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball != null)
        {
            ballCount++;
            if (ballCount >= numBalls)
            {
                Invoke(nameof(CloseGate), 0.5f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball != null)
        {
            ballCount--;
        }
    }

    private void OpenGate()
    {
        gate.gameObject.SetActive(false);
    }

    private void CloseGate()
    {
        gate.gameObject.SetActive(true);
    }
}

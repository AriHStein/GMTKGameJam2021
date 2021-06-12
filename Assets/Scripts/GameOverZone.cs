using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GameOverZone : MonoBehaviour
{
    [SerializeField]
    private BallSpawner spawner;

    [SerializeField]
    private int numBalls = 2;
    private int ballCount = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();
        if(ball != null)
        {
            ballCount++;
            if(ballCount >= numBalls)
            {
                ball.transform.parent.GetComponent<BallSystem>().DestroyBall();
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
}

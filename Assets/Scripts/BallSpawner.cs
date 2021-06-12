using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private BallSystem ballPrefab;

    private BallSystem currentBall;

    [SerializeField]
    private float launchForce = 20f;

    private bool canFire = true;

    public event System.Action<BallSystem> BallSpawned;

    private void Start()
    {
        SpawnBall();
    }

    public void FireBall()
    {
        if(!canFire || currentBall == null)
        {
            return;
        }
        
        currentBall.FireBalls(Vector3.back * launchForce);
        canFire = false;
    }

    private void OnBallDestroyed()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        canFire = true;
        currentBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        currentBall.BallDestroyed += OnBallDestroyed;
        BallSpawned?.Invoke(currentBall);
    }

    
}

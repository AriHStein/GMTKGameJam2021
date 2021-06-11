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
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 ballOffset = ball2.transform.position - ball1.transform.position;
        Vector3 linkOffset = ballOffset / chainLength;

        Vector3 nextPos = ball1.transform.position + linkOffset;
        Rigidbody nextTarget = ball1.GetComponent<Rigidbody>();
        for(int i = 0; i < chainLength; i++)
        {
            GameObject link = Instantiate(chainPrefab, nextPos, Quaternion.identity);
            link.transform.SetParent(transform);
            link.GetComponent<Joint>().connectedBody = nextTarget;
            nextTarget = link.GetComponent<Rigidbody>();
            nextPos += linkOffset;
        }

        ball2.GetComponent<Joint>().connectedBody = nextTarget;
    }
}


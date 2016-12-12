using UnityEngine;
using System.Collections;

public class SpiderChase : MonoBehaviour
{

    public LayerMask detectionLayer;
    private Transform myTransform;
    private NavMeshAgent myNavMeshAgent;
    private Collider[] hitColliders;
    private float checkRate = 1.0f;
    private float nextCheck;
    public float detectionRadius = 50;
    public float speed;

    // Use this for initialization
    void Start()
    {
        SetInitialReferences();
        myNavMeshAgent.speed = Random.Range(10.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfPlayerInRange();
    }

    void SetInitialReferences()
    {
        myTransform = transform;
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void CheckIfPlayerInRange()
    {
        if (Time.time > nextCheck && myNavMeshAgent.enabled == true)
        {
            nextCheck = Time.time + checkRate;
            hitColliders = Physics.OverlapSphere(myTransform.position, detectionRadius, detectionLayer);

            if (hitColliders.Length > 0)
            {
                myNavMeshAgent.SetDestination(hitColliders[0].transform.position);
            }
        }
    }

}

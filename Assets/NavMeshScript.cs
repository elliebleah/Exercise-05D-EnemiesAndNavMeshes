using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject target; // The target object to move towards
    private NavMeshAgent agent; // Reference to the NavMeshAgent component

    void Start()
    {
        target = GameObject.Find("Dest");
        agent = GetComponent<NavMeshAgent>(); // Get reference to NavMeshAgent component
        if (target == null)
        {
            Debug.LogError("Target object is not assigned!");
            enabled = false; // Disable the script if target is not assigned
        }
    }

    void Update()
    {
        if (agent.enabled) // Ensure NavMeshAgent is enabled
        {
            MoveToTarget();
            Debug.Log("Target Position: " + target.transform.position);
        }
    }

    void MoveToTarget()
    {
        agent.SetDestination(target.transform.position); // Set the destination of the NavMeshAgent to the target's position
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolMovement : MonoBehaviour
{

    public List<Transform> patrolPoints;
    int patrolIndex = 0;
    public float moveSpeed = 3;



    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = patrolPoints[patrolIndex].position;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * moveSpeed);
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f) {
            patrolIndex++;
            if(patrolIndex >= patrolPoints.Count) {
                patrolIndex = 0;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMover : MonoBehaviour
{
private Transform[] pathPoints;
    private int currentPointIndex = 0;
    private float moveSpeed;

    public void SetPath(Transform[] points, float speed)
    {
        pathPoints = points;
        moveSpeed = speed;
        StartCoroutine(MoveAlongPath());
    }

    private IEnumerator MoveAlongPath()
    {
        while (currentPointIndex < pathPoints.Length)
        {
            Transform targetPoint = pathPoints[currentPointIndex];
            while (Vector3.Distance(transform.position, targetPoint.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);
                yield return null;
            }
            currentPointIndex++;
        }
    }
}

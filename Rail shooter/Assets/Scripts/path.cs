using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UIElements;

public class path : MonoBehaviour
{
    [SerializeField] private float distance;
    public PathCreator pathCreator;
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        distance += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distance);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distance);
    }
}

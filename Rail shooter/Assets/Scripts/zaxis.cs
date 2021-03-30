using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaxis : MonoBehaviour
{

    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,speed*Time.deltaTime + transform.localPosition.z);
    }
}

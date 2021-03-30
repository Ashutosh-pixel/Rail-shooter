using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float Speed;
    
    [Header("Clamp&screen")]
    [SerializeField] private float xmin;
    [SerializeField] private float xmax;
    [SerializeField] private float ymin;
    [SerializeField] private float ymax;
    private float horizontal;
    private float vertical;
    [Header("Angles")]
    [SerializeField] private float xangle;
    [SerializeField] private float yangle;
    // Update is called once per frame
    void Update()
    {
        XandYMovement();
        Rotation();
        
    }

    private void XandYMovement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        float xdis = horizontal * Speed * Time.deltaTime + transform.localPosition.x;
        float ydis = vertical * Speed * Time.deltaTime + transform.localPosition.y;
        float xclamp = Mathf.Clamp(xdis, xmin, xmax);
        float yclamp = Mathf.Clamp(ydis,ymin,ymax);
        transform.localPosition = new Vector3(xclamp, yclamp, transform.localPosition.z);
    }

    void Rotation()
    {
        float xrotation = horizontal * xangle;
        float yrotation = vertical * yangle;
        transform.localRotation =  Quaternion.Euler(yrotation,180,xrotation);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoominout : MonoBehaviour
{
    [SerializeField] private float boost;

    [SerializeField] private bool boostconditon = true;
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,-20.33f);
        float camboost = Input.GetAxis("Space");
        float cameraboost = camboost * Time.deltaTime * boost;
        transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,cameraboost+transform.localPosition.z);
    }
}

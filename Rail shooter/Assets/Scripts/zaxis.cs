using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaxis : MonoBehaviour
{

    [SerializeField] private float normalSpeed;
    [SerializeField] private float boostSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,normalSpeed*Time.deltaTime + transform.localPosition.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            normalSpeed = 800;
            Invoke("Delay",6f);
        }
         float boost   = Input.GetAxis("Space");
         float camspeed = boost*Time.deltaTime*boostSpeed;
         transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y,camspeed+transform.localPosition.z);
    }

    void Delay()
    {
        normalSpeed = 500;
    }
}

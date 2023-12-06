using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follow;
    public Vector2 min, max;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float PosX = follow.transform.position.x;
        float PosY = follow.transform.position.y;

        transform.position = new Vector3(
            Mathf.Clamp(PosX, min.x, max.x),
            Mathf.Clamp(PosY, min.y, max.y),
            transform.position.z);
    }
}

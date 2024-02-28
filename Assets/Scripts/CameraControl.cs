using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed;

    private void FixedUpdate()
    {
        if (target == null) return;

        Vector3 finalPosition = target.position;
        finalPosition.z = -10;
        transform.position = Vector3.Lerp(transform.position, finalPosition, speed * Time.deltaTime);
        //Hacemos zoom con la camara
        Camera.main.orthographicSize = 5;
    }
}

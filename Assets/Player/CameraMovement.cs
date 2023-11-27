using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        cameraPosition.x = gameObject.transform.position.x;
        cameraPosition.y = gameObject.transform.position.y;
        Camera.main.gameObject.transform.position = cameraPosition;

        
    }
}

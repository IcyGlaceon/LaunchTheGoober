using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchSystem : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject launchObject;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform launchTransform;
    [SerializeField] private Transform cannonTransform;

    private Vector3 velocity;

    [SerializeField] private float xpower = 1000;
    [SerializeField] private float ypower = 800;
    private bool fired = false;

    private GameObject goob;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 ScreenPos = Camera.main.WorldToScreenPoint(mousePos);

        // look at
        transform.LookAt(mousePos);

        var angle = Mathf.Atan2(ScreenPos.y, ScreenPos.x) * Mathf.Rad2Deg;
        cannonTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        velocity = mousePos - launchTransform.position;

        if (Input.GetMouseButtonDown(0))
        {
            if (!fired)
            {                
                goob = Instantiate(player, launchObject.transform.position, launchObject.transform.rotation);

                rb = goob.GetComponent<Rigidbody2D>();

                rb.AddForce(velocity);

                //goob.transform.SetParent(Camera.main.transform);
                fired = true;
            }

            while (fired)
            {
                Console.WriteLine(goob.transform);
                //Camera.main.transform.parent = goob.transform;
            }
        }
    }
}

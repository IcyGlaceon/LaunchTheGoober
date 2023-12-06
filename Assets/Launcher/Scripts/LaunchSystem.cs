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

    Vector3 velocity;

    [SerializeField]float launchPower = 1;

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

        if (Input.GetMouseButtonUp(0))
        {
            if (!fired)
            {
                /*var goob = Instantiate(player, launchTransform.position, launchTransform.rotation);
                goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * ypower);
                goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * xpower);*/

                launchTransform.RotateAround(cannonTransform.position, new Vector3(0, 0, 1), angle);

                goob = Instantiate(player, launchObject.transform.localPosition, launchObject.transform.rotation);

                rb = goob.GetComponent<Rigidbody2D>();

                rb.AddForce(velocity * launchPower);

                fired = true;
            }
        }
    }
}

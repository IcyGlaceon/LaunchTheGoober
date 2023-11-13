using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchSystem : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform launchTransform;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float launchPower = 16f;

    [SerializeField] private float xpower = 2;
    [SerializeField] private float ypower = 2;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var goob = Instantiate(player, launchTransform.position, launchTransform.rotation);
            goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * ypower);
            goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * xpower);
        }
    }
}

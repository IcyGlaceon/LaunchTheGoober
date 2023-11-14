using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchSystem : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject launchObject;

    [SerializeField] private Rigidbody2D rb;


    [SerializeField] private float xpower = 1000;
    [SerializeField] private float ypower = 800;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            //print(launchTransform.position);
        if (Input.GetMouseButtonDown(0))
        {            
            var goob = Instantiate(player, launchObject.transform.position, launchObject.transform.rotation);

            goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * ypower);
            goob.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * xpower);
        }
    }
}

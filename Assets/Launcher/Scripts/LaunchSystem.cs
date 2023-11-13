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
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector2(launchPower * XPower, launchPower * YPower));
        }*/
    }

    public void Launcher(float angle)
    {
        if (Input.GetMouseButtonDown(0))
        {
            var goob = Instantiate(player, launchTransform.position, launchTransform.rotation);

            rb.AddForce(Vector2.up * ypower);
            rb.AddForce(Vector2.right * xpower);
        }
    }
}

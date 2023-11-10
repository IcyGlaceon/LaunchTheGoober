using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchSystem : MonoBehaviour
{
    [SerializeField] private GameObject playerLaunch;
    [SerializeField] private Transform launchTransform;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float launchPower = 16f;

    [SerializeField] private float XPower = 2;
    [SerializeField] private float YPower = 2;


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
            Instantiate(playerLaunch, launchTransform);
            rb.AddForce(new Vector2(angle * XPower, angle * YPower));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpwaners : MonoBehaviour
{
    public GameObject fan;
    public GameObject booster;
    public GameObject UpAndRightBooster;
    
    public Transform fanSpawner;
    public Transform boosterSpawner;
    public Transform UpAndRightBoosterSpawner;

    private GameObject newFan;
    private GameObject newBooster;
    private GameObject newUpAndRightBooster;


    private bool doesFanExist = false;
    private bool doesBoosterExist = false;
    private bool doesUpBoosterExist = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(!doesFanExist)
        {
            newFan = Instantiate(fan);
            newFan.transform.position = fanSpawner.position;
            doesFanExist= true;
        }
        if(newFan.transform.position.x < gameObject.transform.position.x)
        {
            Destroy(newFan);
            doesFanExist= false;
        }

        if (!doesBoosterExist)
        {
            newBooster = Instantiate(booster);
            newBooster.transform.position = boosterSpawner.position;
            doesBoosterExist = true;
        }
        if (newBooster.transform.position.x < gameObject.transform.position.x)
        {
            Destroy(newBooster);
            doesBoosterExist = false;
        }

        if (!doesUpBoosterExist)
        {
            newUpAndRightBooster = Instantiate(UpAndRightBooster);
            newUpAndRightBooster.transform.position = UpAndRightBoosterSpawner.position;
            doesUpBoosterExist = true;
        }
        if (newUpAndRightBooster.transform.position.x < gameObject.transform.position.x)
        {
            Destroy(newUpAndRightBooster);
            doesUpBoosterExist = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Grounded")
        {
            doesBoosterExist= true;
            doesFanExist = true;
            doesUpBoosterExist = true; 
        }
    }
}

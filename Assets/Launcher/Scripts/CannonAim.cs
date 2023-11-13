using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAim : MonoBehaviour
{
    [SerializeField] private Transform cannonTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 ScreenPos = Camera.main.WorldToScreenPoint(mousePos);

        mousePos.x -= ScreenPos.x;
        mousePos.y -= ScreenPos.y;

        var angle = Mathf.Atan2(ScreenPos.y, ScreenPos.x) * Mathf.Rad2Deg;
        cannonTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}

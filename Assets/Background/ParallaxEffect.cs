using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private float _startingPos;
    [SerializeField] private float _lengthOfSprite;
    [SerializeField] private float AmountOfParallax;
    [SerializeField] Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        _startingPos = transform.position.x;
        _lengthOfSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Positon = MainCamera.transform.position;
        float Temp = Positon.x * (1 - AmountOfParallax);
        float Distance = Positon.x * AmountOfParallax;

        Vector3 NewPosition = new Vector3(_startingPos + Distance, transform.position.y, transform.position.z);

        transform.position = NewPosition;

        if (Temp > _startingPos + (_lengthOfSprite / 2))
        {
            _startingPos += _lengthOfSprite;
        }
        else if (Temp < _startingPos - (_lengthOfSprite / 2))
        {
            _startingPos -= _lengthOfSprite;
        }
    }
}

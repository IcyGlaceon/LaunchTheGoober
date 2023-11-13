using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    public PowerUpObject power;
    [SerializeField] private Rigidbody2D player;
    
    Vector2 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            velocity.x = power.horizontalAcceloration;
            velocity.y = power.verticleAcceloration;

            player.velocity += velocity * power.speed;
        }
    }
}

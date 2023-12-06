using UnityEngine;

public class Player : MonoBehaviour
{
    //Hi Carter <3
    //No </3

    // Upgrades
    public int GooberHits = Upgrades.GooberHits;
    public int Durability = Upgrades.Durability;
    public static Rigidbody2D rb;

	private float ScoreMultiplier = Upgrades.ScoreMultiplier;

    //LaunchSystem launchSys;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Spikes;

    // Dabloons
    public static int Dabloons = 0;

    public Vector2 StartPOS = Vector2.zero;
    public Vector2 EndPOS = Vector2.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //rb.position = StartPOS;
    }

    public void AddDabloons ()
    {
        int score = (int)CalculateScore();

        Dabloons += score; /* !!!THIS NEEDS TO BE CHANGED!!! */
    }

    public float CalculateScore ()
    {
        rb.position = EndPOS;
        float score = (EndPOS.x - StartPOS.x) * ScoreMultiplier; /* !!!THIS NEEDS TO BE CHANGED!!! */
        return score;
	}

    Vector2 negativeXForce = new Vector2(-1, 0);

    void Update()
    {
        //checks if the player is below y of 0
        if (player.gameObject.transform.up.y <= new Vector3(0,0,0).y && rb.velocity.x > 0)
        {
            rb.AddForce(negativeXForce);
        }

        if(rb.velocity.x == 0)
        {
            rb.velocity.Set(0, 0);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Spikes")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}

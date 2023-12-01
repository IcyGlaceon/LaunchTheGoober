using UnityEngine;

public class Player : MonoBehaviour
{
    //Hi Carter <3

    // Upgrades
    public int GooberHits = Upgrades.GooberHits;
    public int Durability = Upgrades.Durability;
    public static Rigidbody2D rb;

	private float ScoreMultiplier = Upgrades.ScoreMultiplier;
    

    // Dabloons
    public static int Dabloons = 0;

    public Vector2 StartPOS = Vector2.zero;
    public Vector2 EndPOS = Vector2.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.position = StartPOS;
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


}

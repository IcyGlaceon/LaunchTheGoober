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
    public int Dabloons = 0;

    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    public void AddDabloons ()
    {
        int score = (int)CalculateScore();

        Dabloons += score; /* !!!THIS NEEDS TO BE CHANGED!!! */
    }

    public float CalculateScore ()
    {
        float score = 0 * ScoreMultiplier; /* !!!THIS NEEDS TO BE CHANGED!!! */
        return score;
	}


}

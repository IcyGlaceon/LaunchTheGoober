using UnityEngine;

public class Player : MonoBehaviour
{
    // Upgrades
    public int GooberHits = Upgrades.GooberHits;
    public int Durability = Upgrades.Durability;
	private float ScoreMultiplier = Upgrades.ScoreMultiplier;

    // Dabloons
    public int Dabloons = 0;

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

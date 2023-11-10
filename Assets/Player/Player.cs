using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Upgrades
    public int GooberHits = 1;
    public int Durability = 1;
	public float ScoreMultiplier = 1;

    // Dabloons
    public int Dabloons = 0;

    public void AddDabloons ()
    {
        Dabloons += 0; /* !!!THIS NEEDS TO BE CHANGED!!! */
    }

    public void CalculateScore ()
    {
        float score = 0 * ScoreMultiplier; /* !!!THIS NEEDS TO BE CHANGED!!! */
	}


}

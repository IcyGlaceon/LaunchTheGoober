using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public static int GooberHits = 1;
	public static float CannonPower = 1;
	public static int Durability = 1;
	public static float PowerUpFrequency = 1;
	public static float ScoreMultiplier = 1;

    public void GooberHitsBuy ()
    {
        if (Player.Dabloons >= 100)
        {
            Player.Dabloons -= 100;
		    GooberHits += 1;
        }
    }

    public void CannonPowerBuy ()
    {
        if (Player.Dabloons >= 100)
        {
			Player.Dabloons -= 100;
			CannonPower += 0.5f;
		}
    }

    public void DurabilityBuy ()
    {
        if (Player.Dabloons >= 100)
        {
			Player.Dabloons -= 100;
			Durability += 1;
		}
    }

    public void PowerUpFrequencyBuy ()
    {
        if (Player.Dabloons >= 50)
        {
			Player.Dabloons -= 50;
			PowerUpFrequency += 0.2f;
		}
    }

    public void ScoreMultiplierBuy()
    {
        if (Player.Dabloons >= 300)
        {
			Player.Dabloons -= 300;
			ScoreMultiplier += 0.1f;
		}
    }

}

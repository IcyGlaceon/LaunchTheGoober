using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public int GooberHits = 1;
    public float CannonPower = 1;
    public int Durability = 1;
    public float PowerUpFrequency = 1;
    public float ScoreMultiplier = 1;

    public void GooberHitsBuy ()
    {
        GooberHits += 1;
    }

    public void CannonPowerBuy ()
    {
        CannonPower += 0.5f;
    }

    public void DurabilityBuy ()
    {
        Durability += 1;
    }

    public void PowerUpFrequencyBuy ()
    {
        PowerUpFrequency += 0.2f;
    }

    public void ScoreMultiplierBuy()
    {
        ScoreMultiplier += 0.1f;
    }

}

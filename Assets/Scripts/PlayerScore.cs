using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    private List<int> coins = new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 50)
        {
            Debug.Log("Je hebt gewonnen!");
        }
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            AddCoin(10);
        }
    }

    void AddCoin(int coinValue)
    {
        coins.Add(coinValue);
        score += coinValue;
        Debug.Log("Jij munt score:" + score);
    }
}

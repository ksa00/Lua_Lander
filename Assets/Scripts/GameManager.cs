using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int score;
    private float time;
   
    private void Awake() 
    {
        Instance = this; 
    }
    private void Start()
    {
        Lander.Instance.OnCoinPickUp += Lander_OnCoinPickUp;
        Lander.Instance.OnLanded += Instance_OnLanded;

    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    private void Instance_OnLanded(object sender, Lander.OnLandedEventArgs e)
    {
        AddScore(e.score);
    }

    private void Lander_OnCoinPickUp(object sender, System.EventArgs e)
    {
        AddScore(500);
    }

    public void AddScore(int addScoreAmount)
    {
        score += addScoreAmount;
    }
    public int GetScore()
    {
        return score;
    }
    public float GetTime()
    {
        return time;
    }
}

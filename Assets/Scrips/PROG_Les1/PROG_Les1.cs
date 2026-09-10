using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

class PROG_Les1 : MonoBehaviour
{
    public string names = "Samantha";
    public int score = 100;
    public bool alive = false;
    public int hp = 100;
    public string[] enemyNames;
    public int[] scores;
    public Player[] players;
    private void Start()
    {
        Debug.Log("Opdracht 1.1:");
        Debug.Log("name: " + names);
        Debug.Log("score: " + score);
        Debug.Log("alivenes: " + alive);

        Attack();

        Welcome(names);

        Debug.Log("Opdracht 1.4:");
        Debug.Log(Intmax(score, hp));

        Debug.Log("Opdracht 1.5:");
        Debug.Log(Damage(10, 5));

        Arrays();

        ArraysScore();

        DisplayPlayers();

        Displayed(players);

        Lists();
    }
    private void Attack()
    {
        Debug.Log("Opdracht 1.2:");
        hp -= 35;
        Debug.Log("hp left: " + hp);

        hp -= 80;
        if (hp > 0)
            alive = true;
        else
            alive = false;

        Debug.Log("Aliveness: " + alive);
    }

    private void Welcome(string name)
    {
        Debug.Log("Opdracht 1.3:");
        Debug.Log("Welcome " + name + "!");
    }
    private int Intmax(int a, int b)
    {
        if (a > b)
        {
            return a;
        } else
        {
            return b;
        }
    }
    private int Damage(int incoming, int defence)
    {
        int result = incoming - defence;

        return result > 0 ? result : 0;
    }
    private void Arrays()
    {
        Debug.Log("Opdracht 1.6:");
        for (int i = 0; i < enemyNames.Length; i++)
        {
            Debug.Log("Enemy name: " + enemyNames[i]);
        }
    }
    private void ArraysScore()
    {
        Debug.Log("Opdracht 1.7:");
        int highest = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > highest)
                highest = scores[i];
        }
        Debug.Log("Highest score: " + highest);
    }
    private void DisplayPlayers()
    {
        Debug.Log("Opdracht 1.8:");
        for (int i = 0; i < 2; i++)
        {
            Player pl = new();
            pl.name = "player" + i;
            pl.hp = 100 + i;
            pl.score = 12 + i;
            Debug.Log(pl.name + ", " + pl.hp + ", " + pl.score);
            pl.Display();
        }
    }
    private void Displayed(Player[] pla)
    {
        foreach (var player in pla)
        {
            Debug.Log("My name is " + player.name + ", my hp is " + player.hp + " and my score is " + player.score);
        }
    }
    private void Lists()
    {
        List<string> names = new();
        
        for (int i = 0;i < 5;i++)
        {
            names.Add("name" + i);
        }
        names.Remove("name2");

        Debug.Log("Total names: " + names.Count);

        foreach (string  name in names)
        {
            Debug.Log(name);
        }
    }
}
[System.Serializable]
public class Player
{
    public string name;
    public int hp;
    public int score;
    public void Display()
    {
        Debug.Log("My name is " + name + ", my hp is " + hp + " and my score is " + score);
    }
}
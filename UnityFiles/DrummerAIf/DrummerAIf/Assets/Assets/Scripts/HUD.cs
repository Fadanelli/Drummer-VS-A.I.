using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{

    //Instance of class HUD
    public static HUD instance;
    //3 Images of life, 3 on and 3 off
    [SerializeField] // For access it to Unity
    private Image Life1;
    [SerializeField]
    private Image Life2;
    [SerializeField]
    private Image Life3;
    [SerializeField] // For access it to Unity
    private Image Lifeoff1;
    [SerializeField]
    private Image Lifeoff2;
    [SerializeField]
    private Image Lifeoff3;
    //3 Images of Defense, 3 on and 3 off
    [SerializeField] 
    private Image Defense1;
    [SerializeField]
    private Image Defense2;
    [SerializeField]
    private Image Defense3;
    [SerializeField] 
    private Image Defenseoff1;
    [SerializeField]
    private Image Defenseoff2;
    [SerializeField]
    private Image Defenseoff3;
    //One TextMeshProUGUI for Score in the match
    [SerializeField]
    private TextMeshProUGUI txtScore;

    private void Awake()
    {
        instance = this;
    }
    //Recuperamos el estado anterior
    private void Start()
    {
        int defenses = PlayerPrefs.GetInt("NDefense", 0);
        int lifes = PlayerPrefs.GetInt("NLifes", 3);
        int scores= PlayerPrefs.GetInt("Score", 0);


        LifePlayer.instance.life = lifes;
        UpdateLifes();

        LifePlayer.instance.defense = defenses;
        UpdateDefense();

        LifePlayer.instance.score = scores;
        UpdateScore();
    }

    public void UpdateLifes()
    {
        int vidas = LifePlayer.instance.life;
        if (vidas == 1)
        {
            Life1.enabled = true;
            Lifeoff1.enabled = false;

            Life2.enabled = false;
            Lifeoff2.enabled = true;

            Life3.enabled = false;
            Lifeoff3.enabled = true;

        }
        else if (vidas == 2)
        {
            Life1.enabled = true;
            Lifeoff1.enabled = false;

            Life2.enabled = true;
            Lifeoff2.enabled = false;

            Life3.enabled = false;
            Lifeoff3.enabled = true;
        }
        else if (vidas == 3)
        {
            Life1.enabled = true;
            Lifeoff1.enabled = false;

            Life2.enabled = true;
            Lifeoff2.enabled = false;

            Life3.enabled = true;
            Lifeoff3.enabled = false;
        }
    }
    public void UpdateDefense()
    {
        int defense = LifePlayer.instance.defense;
        if (defense == 1)
        {
            Defense1.enabled = true;
            Defenseoff1.enabled = false;

            Defense2.enabled = false;
            Defenseoff2.enabled = true;

            Defense3.enabled = false;
            Defenseoff3.enabled = true;

        }
        else if (defense == 2)
        {
            Defense1.enabled = true;
            Defenseoff1.enabled = false;

            Defense2.enabled = true;
            Defenseoff2.enabled = false;

            Defense3.enabled = false;
            Defenseoff3.enabled = true;
        }
        else if (defense == 3)
        {
            Defense1.enabled = true;
            Defenseoff1.enabled = false;

            Defense2.enabled = true;
            Defenseoff2.enabled = false;

            Defense3.enabled = true;
            Defenseoff3.enabled = false;
        }
    }
    internal void UpdateScore()
    {
        int score = LifePlayer.instance.score;
        txtScore.text = score.ToString();
    }
}

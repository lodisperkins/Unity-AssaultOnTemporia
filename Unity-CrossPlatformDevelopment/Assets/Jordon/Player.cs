using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Intvariable value;

    public Intvariable level;
    public Intvariable health;

    public Text healthtext;
    public Text leveltext;

    public void GetHealth()
    {

    }

    public void LoseHealth()
    {

    }

    public void GetLevel()
    {

    }

    public void LoseLevel()
    {

    }


    public void Start()
    {
        health.Val = 40;
        level.Val = 3; 
    }

    public void SavePlayer()
    {
        Savebehaviour.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = Savebehaviour.LoadPlayer();
        level.Val = data.level;
        health.Val = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

    #region UI Methods

    public void ChangeLevel(int amount)
    {
        level.Val += amount;
    }

    public void ChangeHealth(int amount)
    {
        health.Val += amount;
    }
    #endregion

    private void Update()
    {
        healthtext.text = healthtext.name + " is:" + health.Val.ToString();
        leveltext.text = leveltext.name + " is:" + level.Val.ToString();
    }
}

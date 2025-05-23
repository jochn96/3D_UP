using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerCondition condition;

    public Sprite euqminatImage;
    public GameObject axe;
    public SpriteRenderer SpriteRenderer;
    

    public ItemData itemData;
    public Action addItem;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();


    }

    public void Oninteract()
    {
        
        axe .SetActive(true);
        controller.moveSpeed = 10;
        SpriteRenderer.sprite = euqminatImage;
    }
}

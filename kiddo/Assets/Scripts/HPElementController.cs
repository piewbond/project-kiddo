using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HPElementController : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite fullHPSprite;
    [SerializeField] Sprite halfHPSprite;
    [SerializeField] int HPValue = 0;


    public void SetHP(int value)
    {
        if (value <= 0)
        {
            spriteRenderer.sprite = null; // Hide the sprite if value is 0 or less
        }
        else if (value == 1)
        {
            spriteRenderer.sprite = halfHPSprite; // Set to half HP sprite
        }
        else
        {
            spriteRenderer.sprite = fullHPSprite; // Set to full HP sprite
        }
    }
}

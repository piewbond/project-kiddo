using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichBoxController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite fullHpSprite;
    [SerializeField] private Sprite halfSprite;
    [SerializeField] private Sprite lowfHpSprite;


    public void UpdateSpriteState(HpState hpState)
    {
        switch (hpState)
        {
            case HpState.Full:
                spriteRenderer.sprite = fullHpSprite;
                break;
            case HpState.Half:
                spriteRenderer.sprite = halfSprite;
                break;
            case HpState.Low:
                spriteRenderer.sprite = lowfHpSprite;
                break;
        }
    }

}
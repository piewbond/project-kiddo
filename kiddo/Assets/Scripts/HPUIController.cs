using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUIController : MonoBehaviour
{
    [SerializeField] SandwichBoxController sandwichBoxController;
    [SerializeField] HPElementController[] hpElements;

    public void UpdateHealthUI(int health)
    {
        // Update the sandwich box state based on health
        if (health <= (int)HpState.Low)
        {
            sandwichBoxController.UpdateSpriteState(HpState.Low);
        }
        else if (health <= (int)HpState.Half)
        {
            sandwichBoxController.UpdateSpriteState(HpState.Half);
        }
        else
        {
            sandwichBoxController.UpdateSpriteState(HpState.Full);
        }

        for (int i = 0; i < hpElements.Length; i++)
        {
            if (health - i * 2 <= 0)
            {
                hpElements[i].SetHP(0); // Hide the sprite if value is 0 or less
            }
            else if (health - i * 2 == 1)
            {
                hpElements[i].SetHP(1); // Set to half HP sprite
            }
            else
            {
                hpElements[i].SetHP(2); // Set to full HP sprite
            }
        }
    }

}

public enum HpState
{
    Low = 3,
    Half = 10,
    Full = 16
}

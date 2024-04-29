using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class BurningRecipeSO : ScriptableObject
{
    [SerializeField] private KitchenObjectSO input;
    [SerializeField] private KitchenObjectSO output;
    [SerializeField] private float burningTimerMax;

    public KitchenObjectSO GetBurningRecipeSOInput()
    {
        return input;
    }

    public KitchenObjectSO GetBurningRecipeSOOutput()
    {
        return output;
    }

    public float GetBurningTimerMax()
    {
        return burningTimerMax;
    }
}

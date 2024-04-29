using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class FryingRecipeSO : ScriptableObject
{
    [SerializeField] private KitchenObjectSO input;
    [SerializeField] private KitchenObjectSO output;
    [SerializeField] private float fryingTimerMax;

    public KitchenObjectSO GetFryingRecipeSOInput()
    {
        return input;
    }

    public KitchenObjectSO GetFryingRecipeSoOutput()
    {
        return output;
    }

    public float GetFryingTimerMax()
    {
        return fryingTimerMax;
    }
}

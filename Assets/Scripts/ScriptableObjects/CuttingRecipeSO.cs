using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class CuttingRecipeSO : ScriptableObject
{
    [SerializeField] private KitchenObjectSO input;
    [SerializeField] private KitchenObjectSO output;
    [SerializeField] private int cuttingProgressMax;

    public KitchenObjectSO GetCuttingRecipeSOInput()
    {
        return input;
    }

    public KitchenObjectSO GetCuttingRecipeSoOutput()
    {
        return output;
    }

    public int GetCuttingProgressMax()
    {
        return cuttingProgressMax;
    }
}

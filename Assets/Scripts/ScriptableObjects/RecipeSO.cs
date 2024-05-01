using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class RecipeSO : ScriptableObject
{
    [SerializeField] private List<KitchenObjectSO> kitchenObjectSOList;
    [SerializeField] private string recipeName;

    public List<KitchenObjectSO> GetKitchenObjectSOList()
    {
        return kitchenObjectSOList;
    }

    public string GetRecipeName()
    {
        return recipeName;
    }
}

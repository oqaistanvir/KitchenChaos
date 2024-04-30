using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{

    [SerializeField] private List<KitchenObjectSO> validKitchenObjectList;
    private List<KitchenObjectSO> kitchenObjectSOList;
    private void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }
    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        if (!validKitchenObjectList.Contains(kitchenObjectSO))
        {
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectSO))
        {
            //Plate already contains the ingredient
            return false;
        }
        else
        {
            //New Ingredient
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }
}

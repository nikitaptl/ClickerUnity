using System;
using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ResourceBank _resourceBank = new ResourceBank();
    public ResourceBank ResourceBank => _resourceBank;

    private void Awake()
    {
        _resourceBank.ChangeResource(GameResource.Humans, 10);
        _resourceBank.ChangeResource(GameResource.Food, 5);
        _resourceBank.ChangeResource(GameResource.Wood, 5);
    }
}

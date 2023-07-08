using Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour, IName
{
    private string _id;

    public string ID => _id;

    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

}

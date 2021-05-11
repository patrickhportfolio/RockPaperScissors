using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Player : ScriptableObject
{
    public string Username;

    public bool IsActive = true;

    public bool IsComputer;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Keys> keys;
    public void AddKey(Keys key)
    {
        keys.Add(key);
    }
    public bool HasKey(Keys keys)
    {
        foreach (Keys key in this.keys)
        {
            if (keys == key)
            {
                return true;
            }
        }
        return false;
    }
    public enum Keys
    {
        Blue,
        Purple,
        Pink,
        Green,
        Vinous,
        Secret
    }
}

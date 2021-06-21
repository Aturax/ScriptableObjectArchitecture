using System.Collections.Generic;
using UnityEngine;

public class ListGenericVariable<T> : ScriptableObject
{

    public List<T> genericList = null;

    public event System.Action OnAddItem = () => { };
    public event System.Action OnRemoveItem = () => { };

    public void Add(T genericVariable)
    {
        if (genericList == null)
        {
            genericList =  new List<T>();
        }
        genericList.Add(genericVariable);
        OnAddItem();

    }

    public void Remove(T genericVariable)
    {
        genericList.Remove(genericVariable);
        OnRemoveItem();
    }

}

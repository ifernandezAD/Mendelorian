using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collector : MonoBehaviour
{
    [SerializeField] List<Collectible> _gatherables;
    [SerializeField] UnityEvent OnCompleteEvent;

    List<Collectible> _collectiblesRemaning;

    private void OnEnable()
    {
        _collectiblesRemaning = new List<Collectible>(_gatherables);

        foreach (var collectible in _collectiblesRemaning)
            collectible.OnPickup += HandlePickup;
    }

    private void HandlePickup(Collectible collectible)
    {
        _collectiblesRemaning.Remove(collectible);

        if (_collectiblesRemaning.Count == 0)
            OnCompleteEvent.Invoke();
    }
}

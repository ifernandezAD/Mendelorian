using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceSingleton : MonoBehaviour
{
    #region Singleton

    public static ReferenceSingleton instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}

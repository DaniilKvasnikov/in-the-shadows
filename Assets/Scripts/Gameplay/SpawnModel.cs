using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnModel : MonoBehaviour
{
    [SerializeField] private AllShadowModels _models;
    [SerializeField] private Transform parent;

    private void Start()
    {
        GameObject obj = Instantiate(_models.models[0], parent.position, Quaternion.identity, parent);
    }
}

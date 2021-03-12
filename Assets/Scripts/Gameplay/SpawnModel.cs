using System;
using UnityEngine;

namespace Gameplay
{
    public class SpawnModel : MonoBehaviour
    {
        [SerializeField] private AllShadowModels models;
        [SerializeField] private Transform parent;

        private GameObject obj;
        private void Start()
        {
            obj = Instantiate(models.models[0], parent.position, Quaternion.identity, parent);
        }
    }
}

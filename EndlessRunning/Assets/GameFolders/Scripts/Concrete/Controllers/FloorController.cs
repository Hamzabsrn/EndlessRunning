using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class FloorController : MonoBehaviour
    {
        [Range(0,1)] [SerializeField] float _moveSpeed = 5f;

        Material _material;


        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }
        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * Time.deltaTime * _moveSpeed;
        }
    }


}
using Mover;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _maxLifeTime = 10f;

        VerticalMover _mover;
        float _currrentLifeTime = 0f;

        public float MoveSpeed => _moveSpeed;
        private void Awake()
        {
            _mover = new VerticalMover(this);
        }
        private void Update()
        {
            _currrentLifeTime += Time.deltaTime;

            if (_currrentLifeTime > _maxLifeTime)
            {
                _currrentLifeTime = 0f;
                KillYourSelf();
            }
        }
        private void FixedUpdate()
        {
            _mover.FixedTick();
        }
        private void KillYourSelf()
        {
            Destroy(this.gameObject);
        }
    }


}
﻿using UnityEngine;

namespace Characters.Ai
{
    [RequireComponent(typeof(Attributes.Attributes))]
    public class AiMovement : Movement
    {
        [SerializeField]
        private string _targetTag;

        private GameObject _target;

        void FixedUpdate () {
            _target = Util.Util.ClosestGameObjectWithTag(gameObject, _targetTag);

            Vector3 force = (_target.transform.position - transform.position).normalized;

            Rb2D.velocity = new Vector2(force.x, force.y) * GetComponent<Attributes.Attributes>().Speed;
        }
    }
}

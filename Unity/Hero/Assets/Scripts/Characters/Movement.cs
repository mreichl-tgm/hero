﻿using UnityEngine;

namespace Character
{
    [RequireComponent (typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        protected Rigidbody2D Rb2D;

        void Awake() {
            Rb2D = GetComponent<Rigidbody2D>();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animals {

    [RequireComponent(typeof(Rigidbody))]
    public abstract class Animal : MonoBehaviour {

        [field: SerializeField]
        protected Vector3 StartPosition { get; private set; }

        [field: SerializeField]
        protected Vector3 TargetPosition { get; private set; }

        protected Rigidbody animalRigidBody;
        
        [SerializeField]
        bool isMoving = false;


        void Awake() {
            animalRigidBody = GetComponent<Rigidbody>();
            StartPosition = transform.position;
        }

        public virtual void SetDestination(Vector3 destination) {
            TargetPosition = destination;
        }

        public abstract void Move();
    }

}

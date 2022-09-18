using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animals {
    public class Rabbit : Animal {

        [SerializeField]
        private float impulse = 10;

        public override void Move() {
            StartCoroutine(HopMove(animalRigidBody));
        }
        
        IEnumerator HopMove(Rigidbody rb) {
            while (true) {
                rb.AddForce((Vector3.right + Vector3.up).normalized * impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}

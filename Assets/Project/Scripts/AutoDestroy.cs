using Lean.Pool;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {
    public float DestroyThreshold;
    
    private Car _car;
    
    private void Awake() {
        _car = FindObjectOfType<Car>();
    }
    
    private void Update() {
        if (transform.position.x - _car.transform.position.x < DestroyThreshold) {
            LeanPool.Despawn(gameObject);
        }
    }
}